﻿// <auto-generated />
using System;
using ArxsAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace ArxsAPI.Migrations
{
    [DbContext(typeof(ArxsDbContext))]
    partial class ArxsDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.HasPostgresEnum(modelBuilder, "race_type", new[] { "main_race", "sub_pre_qualify", "pre_qualify", "qualify_one", "qualify_two", "bottom_four" });
            NpgsqlModelBuilderExtensions.HasPostgresEnum(modelBuilder, "round_race_driver_status", new[] { "undefined", "disqualified", "classified", "winner", "retired", "classified_retired" });
            NpgsqlModelBuilderExtensions.HasPostgresEnum(modelBuilder, "trophy_round_driver_status", new[] { "undefined", "disqualified", "classified", "winner", "did_not_qualify" });
            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("ArxsAPI.Models.Car", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("ManufacturerId")
                        .HasColumnType("integer")
                        .HasColumnName("manufacturer_id");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.Property<int>("Year")
                        .HasColumnType("integer")
                        .HasColumnName("year");

                    b.HasKey("Id");

                    b.HasIndex("ManufacturerId");

                    b.ToTable("car", (string)null);
                });

            modelBuilder.Entity("ArxsAPI.Models.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Adjective")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("adjective");

                    b.Property<string>("Iso3")
                        .IsRequired()
                        .HasMaxLength(3)
                        .HasColumnType("character varying(3)")
                        .HasColumnName("iso_3");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.HasIndex("Iso3")
                        .IsUnique();

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("country", (string)null);
                });

            modelBuilder.Entity("ArxsAPI.Models.Driver", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("CityOfOrigin")
                        .HasColumnType("text")
                        .HasColumnName("city_of_origin");

                    b.Property<int>("CountryOfOriginId")
                        .HasColumnType("integer")
                        .HasColumnName("country_of_origin_id");

                    b.Property<DateOnly?>("DateOfBirth")
                        .HasColumnType("date")
                        .HasColumnName("date_of_birth");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.Property<int>("NationalityId")
                        .HasColumnType("integer")
                        .HasColumnName("nationality_id");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("surname");

                    b.HasKey("Id");

                    b.HasIndex("CountryOfOriginId");

                    b.HasIndex("NationalityId");

                    b.ToTable("driver", (string)null);
                });

            modelBuilder.Entity("ArxsAPI.Models.Manufacturer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("CountryId")
                        .HasColumnType("integer")
                        .HasColumnName("country_id");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("manufacturer", (string)null);
                });

            modelBuilder.Entity("ArxsAPI.Models.Team", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("CountryId")
                        .HasColumnType("integer")
                        .HasColumnName("country_id");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.Property<int?>("PreviousTeamId")
                        .HasColumnType("integer")
                        .HasColumnName("previous_team_id");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.HasIndex("PreviousTeamId")
                        .IsUnique();

                    b.ToTable("team", (string)null);
                });

            modelBuilder.Entity("ArxsAPI.Models.Track", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("City")
                        .HasColumnType("text")
                        .HasColumnName("city");

                    b.Property<int>("CountryId")
                        .HasColumnType("integer")
                        .HasColumnName("country_id");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("track", (string)null);
                });

            modelBuilder.Entity("ArxsAPI.Models.Car", b =>
                {
                    b.HasOne("ArxsAPI.Models.Manufacturer", "Manufacturer")
                        .WithMany("Cars")
                        .HasForeignKey("ManufacturerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Manufacturer");
                });

            modelBuilder.Entity("ArxsAPI.Models.Driver", b =>
                {
                    b.HasOne("ArxsAPI.Models.Country", "CountryOfOrigin")
                        .WithMany("NativeDrivers")
                        .HasForeignKey("CountryOfOriginId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ArxsAPI.Models.Country", "Nationality")
                        .WithMany("NationalDrivers")
                        .HasForeignKey("NationalityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CountryOfOrigin");

                    b.Navigation("Nationality");
                });

            modelBuilder.Entity("ArxsAPI.Models.Manufacturer", b =>
                {
                    b.HasOne("ArxsAPI.Models.Country", "Country")
                        .WithMany("Manufacturers")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Country");
                });

            modelBuilder.Entity("ArxsAPI.Models.Team", b =>
                {
                    b.HasOne("ArxsAPI.Models.Country", "Country")
                        .WithMany("Teams")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ArxsAPI.Models.Team", "PreviousTeam")
                        .WithOne("NextTeam")
                        .HasForeignKey("ArxsAPI.Models.Team", "PreviousTeamId");

                    b.Navigation("Country");

                    b.Navigation("PreviousTeam");
                });

            modelBuilder.Entity("ArxsAPI.Models.Track", b =>
                {
                    b.HasOne("ArxsAPI.Models.Country", "Country")
                        .WithMany("Tracks")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Country");
                });

            modelBuilder.Entity("ArxsAPI.Models.Country", b =>
                {
                    b.Navigation("Manufacturers");

                    b.Navigation("NationalDrivers");

                    b.Navigation("NativeDrivers");

                    b.Navigation("Teams");

                    b.Navigation("Tracks");
                });

            modelBuilder.Entity("ArxsAPI.Models.Manufacturer", b =>
                {
                    b.Navigation("Cars");
                });

            modelBuilder.Entity("ArxsAPI.Models.Team", b =>
                {
                    b.Navigation("NextTeam");
                });
#pragma warning restore 612, 618
        }
    }
}
