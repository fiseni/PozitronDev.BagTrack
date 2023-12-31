﻿using Azure.Identity;
using BlazarTech.QueryableValues;
using Hangfire;
using Hangfire.Console;
using Hangfire.Dashboard;
using Hangfire.Dashboard.BasicAuthorization;
using Hangfire.SqlServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using PozitronDev.BagTrack.Infrastructure.MQ;
using PozitronDev.BagTrack.Infrastructure.MQ.Handlers;
using PozitronDev.BagTrack.Setup.Jobs;
using PozitronDev.BagTrack.Setup.Middleware;
using PozitronDev.CommissionPayment.Infrastructure;
using PozitronDev.Extensions.Automapper;
using PozitronDev.Extensions.Validations;

namespace PozitronDev.BagTrack.Setup;

public static class BagTrackServices
{
    public static void AddBagTrackServices(this WebApplicationBuilder builder)
    {
        builder.Services.AddExtendedMediatR(typeof(BagTrackMarker));
        builder.Services.AddCustomAutoMapper(typeof(BagTrackMarker).Assembly);
        builder.Services.AddCustomFluentValidation(typeof(BagTrackMarker).Assembly, typeof(BagTrackContractsMarker).Assembly);

        builder.Services.AddOptions<BagTrackSettings>()
            .BindConfiguration(BagTrackSettings.SECTION_NAME)
            .ValidateDataAnnotations()
            .ValidateOnStart();

        builder.Services.AddOptions<KeyVaultSettings>()
            .BindConfiguration(KeyVaultSettings.SECTION_NAME)
            .ValidateDataAnnotations()
            .ValidateOnStart();

        builder.Services.AddOptions<JobSettings>()
            .BindConfiguration(JobSettings.SECTION_NAME)
            .ValidateDataAnnotations()
            .ValidateOnStart();

        builder.Services.AddOptions<MQSettings>()
            .BindConfiguration(MQSettings.SECTION_NAME)
            .ValidateDataAnnotations()
            .ValidateOnStart();

        builder.Services.AddSingleton(x => x.GetRequiredService<IOptions<BagTrackSettings>>().Value);
        builder.Services.AddSingleton(x => x.GetRequiredService<IOptions<KeyVaultSettings>>().Value);
        builder.Services.AddSingleton(x => x.GetRequiredService<IOptions<JobSettings>>().Value);
        builder.Services.AddSingleton(x => x.GetRequiredService<IOptions<MQSettings>>().Value);

        var keyVaultSettings = new KeyVaultSettings();
        builder.Configuration.Bind(KeyVaultSettings.SECTION_NAME, keyVaultSettings);

        var bagTrackSettings = new BagTrackSettings();
        builder.Configuration.Bind(BagTrackSettings.SECTION_NAME, bagTrackSettings);

        if (!keyVaultSettings.DisableAzureKeyVault && !string.IsNullOrEmpty(keyVaultSettings.AzureKeyVault))
        {
            builder.Configuration.AddAzureKeyVault(new Uri(keyVaultSettings.AzureKeyVault), new DefaultAzureCredential());
        }

        var connectionString = keyVaultSettings.DisableAzureKeyVault
            ? bagTrackSettings.ConnectionString
            : builder.Configuration.GetValue<string>(bagTrackSettings.ConnectionString);

        builder.Services.AddDbContext<BagTrackDbContext>(options => options.UseSqlServer(connectionString, sqlServerOptions =>
        {
            sqlServerOptions.UseQueryableValues(config => config.Serialization(SqlServerSerialization.Auto));
        }));
        builder.Services.AddScoped<BagTrackDbInitializer>();

        var options = new SqlServerStorageOptions
        {
            PrepareSchemaIfNecessary = false,
            EnableHeavyMigrations = false,
            //QueuePollInterval = TimeSpan.FromSeconds(15),
            //SlidingInvisibilityTimeout = TimeSpan.FromMinutes(5),
        };
        builder.Services.AddHangfire(x => x.UseSqlServerStorage(connectionString, options).UseConsole());
        builder.Services.AddHangfireServer();
        //builder.Services.AddHangfireServer(options =>
        //{
        //    options.WorkerCount = 1;
        //});

        builder.Services.AddScoped(typeof(IReadRepository<>), typeof(ReadRepository<>));
        builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));

        builder.Services.AddSingleton<IMQAdapterService, MQAdapterService>();
        builder.Services.AddSingleton<IMessageHandler, BaggageClaimMessageHandler>();

        builder.Services.AddSingleton<CachedData>();
        builder.Services.AddSingleton<IDataCache, CachedData>(x => x.GetRequiredService<CachedData>());
        builder.Services.AddSingleton<ICacheReloader, CachedData>(x => x.GetRequiredService<CachedData>());
    }

    public static IApplicationBuilder UseHangfire(this WebApplication app)
    {
        var jobSettings = new JobSettings();
        app.Configuration.Bind(JobSettings.SECTION_NAME, jobSettings);

        var options = new DashboardOptions
        {
            DashboardTitle = "Pozitron BagTrack Jobs"
        };

        if (!app.Environment.IsDevelopment()
            && !string.IsNullOrEmpty(jobSettings.DashboardUsername)
            && !string.IsNullOrEmpty(jobSettings.DashboardPassword))
        {
            options.Authorization = new IDashboardAuthorizationFilter[]
            {
                new BasicAuthAuthorizationFilter(
                    new BasicAuthAuthorizationFilterOptions
                    {
                        LoginCaseSensitive = false,
                        Users = new[]
                        {
                            new BasicAuthAuthorizationUser
                            {
                                Login = jobSettings.DashboardUsername,
                                PasswordClear = jobSettings.DashboardPassword
                            }
                        }
                    })
            };
        }

        app.UseHangfireDashboard("/jobs", options);

        GlobalJobFilters.Filters.Add(new AutomaticRetryAttribute { Attempts = 0 });
        GlobalJobFilters.Filters.Add(new ProlongExpirationTimeAttribute());

        RecurringJob.RemoveIfExists("SampleJob");

        RecurringJob.AddOrUpdate<CleanBagsJob>(nameof(CleanBagsJob), job => job.Start(null!, CancellationToken.None), jobSettings.CleanBagsJob);
        RecurringJob.AddOrUpdate<CleanFlightsJob>(nameof(CleanFlightsJob), job => job.Start(null!, CancellationToken.None), jobSettings.CleanFlightsJob);
        RecurringJob.AddOrUpdate<CleanInboxMessagesJob>(nameof(CleanInboxMessagesJob), job => job.Start(null!, CancellationToken.None), jobSettings.CleanInboxMessagesJob);

        return app;

    }
}
