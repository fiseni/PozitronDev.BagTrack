﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace PozitronDev.BagTrack.Infrastructure.Configurations;

public class FlightConfiguration : IEntityTypeConfiguration<Flight>
{
    public void Configure(EntityTypeBuilder<Flight> builder)
    {
        builder.Property(x => x.AirlineIATA).HasMaxLength(10).IsUnicode(false);
        builder.Property(x => x.Number).HasMaxLength(10).IsUnicode(false);
        builder.Property(x => x.ActiveCarousel).HasMaxLength(10).IsUnicode(false);
        builder.Property(x => x.AllocatedCarousel).HasMaxLength(10).IsUnicode(false);
        builder.Property(x => x.Agent).HasMaxLength(20).IsUnicode(false);

        builder.HasIndex(x => new { x.AirlineIATA, x.ActiveCarousel, x.Start, x.Stop });
        builder.HasIndex(x => new { x.AirlineIATA, x.Number, x.OriginDate });
    }
}
