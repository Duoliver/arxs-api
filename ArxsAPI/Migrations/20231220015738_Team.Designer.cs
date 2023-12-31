﻿// <auto-generated />
using System;
using ArxsAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace ArxsAPI.Migrations
{
    [DbContext(typeof(ArxsDbContext))]
    [Migration("20231220015738_Team")]
    partial class Team
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.HasPostgresEnum(modelBuilder, "race_type", new[] { "main_race", "sub_pre_qualify", "pre_qualify", "qualify_one", "qualify_two", "bottom_four" });
            NpgsqlModelBuilderExtensions.HasPostgresEnum(modelBuilder, "round_race_driver_status", new[] { "undefined", "disqualified", "classified", "winner", "retired", "classified_retired" });
            NpgsqlModelBuilderExtensions.HasPostgresEnum(modelBuilder, "trophy_round_driver_status", new[] { "undefined", "disqualified", "classified", "winner", "did_not_qualify" });
            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

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

                    b.ToTable("country", (string)null);
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

                    b.HasIndex("PreviousTeamId")
                        .IsUnique();

                    b.ToTable("team", (string)null);
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

            modelBuilder.Entity("ArxsAPI.Models.Country", b =>
                {
                    b.Navigation("Teams");
                });

            modelBuilder.Entity("ArxsAPI.Models.Team", b =>
                {
                    b.Navigation("NextTeam");
                });
#pragma warning restore 612, 618
        }
    }
}
