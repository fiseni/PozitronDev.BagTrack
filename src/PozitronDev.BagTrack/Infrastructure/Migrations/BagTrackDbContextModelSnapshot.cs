﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PozitronDev.BagTrack.Infrastructure;

#nullable disable

namespace PozitronDev.BagTrack.Infrastructure.Migrations
{
    [DbContext(typeof(BagTrackDbContext))]
    partial class BagTrackDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BlazarTech.QueryableValues.QueryableValuesEntity", b =>
                {
                    b.Property<int>("X")
                        .HasColumnType("int");

                    b.Property<DateTime?>("A")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("A1")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("A2")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("A3")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("A4")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("A5")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("A6")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("A7")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("A8")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("A9")
                        .HasColumnType("datetime2");

                    b.Property<bool?>("B")
                        .HasColumnType("bit");

                    b.Property<bool?>("B1")
                        .HasColumnType("bit");

                    b.Property<bool?>("B2")
                        .HasColumnType("bit");

                    b.Property<bool?>("B3")
                        .HasColumnType("bit");

                    b.Property<bool?>("B4")
                        .HasColumnType("bit");

                    b.Property<bool?>("B5")
                        .HasColumnType("bit");

                    b.Property<bool?>("B6")
                        .HasColumnType("bit");

                    b.Property<bool?>("B7")
                        .HasColumnType("bit");

                    b.Property<bool?>("B8")
                        .HasColumnType("bit");

                    b.Property<bool?>("B9")
                        .HasColumnType("bit");

                    b.Property<string>("C")
                        .HasColumnType("nvarchar(1)");

                    b.Property<string>("C1")
                        .HasColumnType("nvarchar(1)");

                    b.Property<string>("C2")
                        .HasColumnType("nvarchar(1)");

                    b.Property<string>("C3")
                        .HasColumnType("nvarchar(1)");

                    b.Property<string>("C4")
                        .HasColumnType("nvarchar(1)");

                    b.Property<string>("C5")
                        .HasColumnType("nvarchar(1)");

                    b.Property<string>("C6")
                        .HasColumnType("nvarchar(1)");

                    b.Property<string>("C7")
                        .HasColumnType("nvarchar(1)");

                    b.Property<string>("C8")
                        .HasColumnType("nvarchar(1)");

                    b.Property<string>("C9")
                        .HasColumnType("nvarchar(1)");

                    b.Property<double?>("D")
                        .HasColumnType("float");

                    b.Property<double?>("D1")
                        .HasColumnType("float");

                    b.Property<double?>("D2")
                        .HasColumnType("float");

                    b.Property<double?>("D3")
                        .HasColumnType("float");

                    b.Property<double?>("D4")
                        .HasColumnType("float");

                    b.Property<double?>("D5")
                        .HasColumnType("float");

                    b.Property<double?>("D6")
                        .HasColumnType("float");

                    b.Property<double?>("D7")
                        .HasColumnType("float");

                    b.Property<double?>("D8")
                        .HasColumnType("float");

                    b.Property<double?>("D9")
                        .HasColumnType("float");

                    b.Property<DateTimeOffset?>("E")
                        .HasColumnType("datetimeoffset");

                    b.Property<DateTimeOffset?>("E1")
                        .HasColumnType("datetimeoffset");

                    b.Property<DateTimeOffset?>("E2")
                        .HasColumnType("datetimeoffset");

                    b.Property<DateTimeOffset?>("E3")
                        .HasColumnType("datetimeoffset");

                    b.Property<DateTimeOffset?>("E4")
                        .HasColumnType("datetimeoffset");

                    b.Property<DateTimeOffset?>("E5")
                        .HasColumnType("datetimeoffset");

                    b.Property<DateTimeOffset?>("E6")
                        .HasColumnType("datetimeoffset");

                    b.Property<DateTimeOffset?>("E7")
                        .HasColumnType("datetimeoffset");

                    b.Property<DateTimeOffset?>("E8")
                        .HasColumnType("datetimeoffset");

                    b.Property<DateTimeOffset?>("E9")
                        .HasColumnType("datetimeoffset");

                    b.Property<float?>("F")
                        .HasColumnType("real");

                    b.Property<float?>("F1")
                        .HasColumnType("real");

                    b.Property<float?>("F2")
                        .HasColumnType("real");

                    b.Property<float?>("F3")
                        .HasColumnType("real");

                    b.Property<float?>("F4")
                        .HasColumnType("real");

                    b.Property<float?>("F5")
                        .HasColumnType("real");

                    b.Property<float?>("F6")
                        .HasColumnType("real");

                    b.Property<float?>("F7")
                        .HasColumnType("real");

                    b.Property<float?>("F8")
                        .HasColumnType("real");

                    b.Property<float?>("F9")
                        .HasColumnType("real");

                    b.Property<Guid?>("G")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("G1")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("G2")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("G3")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("G4")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("G5")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("G6")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("G7")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("G8")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("G9")
                        .HasColumnType("uniqueidentifier");

                    b.Property<short?>("H")
                        .HasColumnType("smallint");

                    b.Property<short?>("H1")
                        .HasColumnType("smallint");

                    b.Property<short?>("H2")
                        .HasColumnType("smallint");

                    b.Property<short?>("H3")
                        .HasColumnType("smallint");

                    b.Property<short?>("H4")
                        .HasColumnType("smallint");

                    b.Property<short?>("H5")
                        .HasColumnType("smallint");

                    b.Property<short?>("H6")
                        .HasColumnType("smallint");

                    b.Property<short?>("H7")
                        .HasColumnType("smallint");

                    b.Property<short?>("H8")
                        .HasColumnType("smallint");

                    b.Property<short?>("H9")
                        .HasColumnType("smallint");

                    b.Property<int?>("I")
                        .HasColumnType("int");

                    b.Property<int?>("I1")
                        .HasColumnType("int");

                    b.Property<int?>("I2")
                        .HasColumnType("int");

                    b.Property<int?>("I3")
                        .HasColumnType("int");

                    b.Property<int?>("I4")
                        .HasColumnType("int");

                    b.Property<int?>("I5")
                        .HasColumnType("int");

                    b.Property<int?>("I6")
                        .HasColumnType("int");

                    b.Property<int?>("I7")
                        .HasColumnType("int");

                    b.Property<int?>("I8")
                        .HasColumnType("int");

                    b.Property<int?>("I9")
                        .HasColumnType("int");

                    b.Property<long?>("L")
                        .HasColumnType("bigint");

                    b.Property<long?>("L1")
                        .HasColumnType("bigint");

                    b.Property<long?>("L2")
                        .HasColumnType("bigint");

                    b.Property<long?>("L3")
                        .HasColumnType("bigint");

                    b.Property<long?>("L4")
                        .HasColumnType("bigint");

                    b.Property<long?>("L5")
                        .HasColumnType("bigint");

                    b.Property<long?>("L6")
                        .HasColumnType("bigint");

                    b.Property<long?>("L7")
                        .HasColumnType("bigint");

                    b.Property<long?>("L8")
                        .HasColumnType("bigint");

                    b.Property<long?>("L9")
                        .HasColumnType("bigint");

                    b.Property<decimal?>("M")
                        .HasPrecision(18, 6)
                        .HasColumnType("decimal(18,6)");

                    b.Property<decimal?>("M1")
                        .HasPrecision(18, 6)
                        .HasColumnType("decimal(18,6)");

                    b.Property<decimal?>("M2")
                        .HasPrecision(18, 6)
                        .HasColumnType("decimal(18,6)");

                    b.Property<decimal?>("M3")
                        .HasPrecision(18, 6)
                        .HasColumnType("decimal(18,6)");

                    b.Property<decimal?>("M4")
                        .HasPrecision(18, 6)
                        .HasColumnType("decimal(18,6)");

                    b.Property<decimal?>("M5")
                        .HasPrecision(18, 6)
                        .HasColumnType("decimal(18,6)");

                    b.Property<decimal?>("M6")
                        .HasPrecision(18, 6)
                        .HasColumnType("decimal(18,6)");

                    b.Property<decimal?>("M7")
                        .HasPrecision(18, 6)
                        .HasColumnType("decimal(18,6)");

                    b.Property<decimal?>("M8")
                        .HasPrecision(18, 6)
                        .HasColumnType("decimal(18,6)");

                    b.Property<decimal?>("M9")
                        .HasPrecision(18, 6)
                        .HasColumnType("decimal(18,6)");

                    b.Property<string>("S")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("S1")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("S2")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("S3")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("S4")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("S5")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("S6")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("S7")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("S8")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("S9")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<byte?>("Y")
                        .HasColumnType("tinyint");

                    b.Property<byte?>("Y1")
                        .HasColumnType("tinyint");

                    b.Property<byte?>("Y2")
                        .HasColumnType("tinyint");

                    b.Property<byte?>("Y3")
                        .HasColumnType("tinyint");

                    b.Property<byte?>("Y4")
                        .HasColumnType("tinyint");

                    b.Property<byte?>("Y5")
                        .HasColumnType("tinyint");

                    b.Property<byte?>("Y6")
                        .HasColumnType("tinyint");

                    b.Property<byte?>("Y7")
                        .HasColumnType("tinyint");

                    b.Property<byte?>("Y8")
                        .HasColumnType("tinyint");

                    b.Property<byte?>("Y9")
                        .HasColumnType("tinyint");

                    b.HasKey("X");

                    b.ToTable((string)null);

                    b.ToView("QueryableValuesEntity", (string)null);
                });

            modelBuilder.Entity("PozitronDev.BagTrack.Domain.Bags.Airline", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("BagCode")
                        .IsRequired()
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)");

                    b.Property<string>("IATA")
                        .IsRequired()
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)");

                    b.HasKey("Id");

                    b.ToTable("Airline");
                });

            modelBuilder.Entity("PozitronDev.BagTrack.Domain.Bags.Bag", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("AirlineIATA")
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)");

                    b.Property<string>("BagTagId")
                        .IsRequired()
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)");

                    b.Property<string>("Carousel")
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("DeviceId")
                        .IsRequired()
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)");

                    b.Property<string>("Flight")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<bool>("IsResponseNeeded")
                        .HasColumnType("bit");

                    b.Property<string>("JulianDate")
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)");

                    b.HasKey("Id");

                    b.HasIndex("BagTagId");

                    b.HasIndex("Date");

                    b.ToTable("Bag");
                });

            modelBuilder.Entity("PozitronDev.BagTrack.Domain.Bags.Device", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)");

                    b.Property<string>("Carousel")
                        .IsRequired()
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)");

                    b.HasKey("Id");

                    b.ToTable("Device");
                });

            modelBuilder.Entity("PozitronDev.BagTrack.Domain.Bags.Flight", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ActiveCarousel")
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)");

                    b.Property<string>("Agent")
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)");

                    b.Property<string>("AirlineIATA")
                        .IsRequired()
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)");

                    b.Property<string>("AllocatedCarousel")
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)");

                    b.Property<DateTime?>("FirstBag")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("LastBag")
                        .HasColumnType("datetime2");

                    b.Property<string>("Number")
                        .IsRequired()
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)");

                    b.Property<DateTime>("OriginDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("Start")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("Stop")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Flight");
                });

            modelBuilder.Entity("PozitronDev.BagTrack.Domain.Messaging.InboxMessage", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Data")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ProcessedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("InboxMessage");
                });

            modelBuilder.Entity("PozitronDev.BagTrack.Domain.Messaging.OutboxMessage", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Data")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ProcessedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("OutboxMessage");
                });
#pragma warning restore 612, 618
        }
    }
}
