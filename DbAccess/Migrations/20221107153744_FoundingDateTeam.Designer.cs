﻿// <auto-generated />
using System;
using DbAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DbAccess.Migrations
{
    [DbContext(typeof(AppDBContext))]
    [Migration("20221107153744_FoundingDateTeam")]
    partial class FoundingDateTeam
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DbAccess.Models.Country", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("ID");

                    b.ToTable("Countries");
                });

            modelBuilder.Entity("DbAccess.Models.TeamModel", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Coach")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CountryID")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<DateTime>("FoundingDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("SponsorID")
                        .HasColumnType("int");

                    b.Property<string>("Stadium")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Team")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("TeamVideo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UEFACups")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("CountryID");

                    b.HasIndex("SponsorID");

                    b.ToTable("Teams");
                });

            modelBuilder.Entity("DbAccess.Models.TeamSponsor", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StudioDescription")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("TeamSponsors");
                });

            modelBuilder.Entity("DbAccess.Models.TeamModel", b =>
                {
                    b.HasOne("DbAccess.Models.Country", "Country")
                        .WithMany("Teams")
                        .HasForeignKey("CountryID");

                    b.HasOne("DbAccess.Models.TeamSponsor", "Sponsor")
                        .WithMany("Teams")
                        .HasForeignKey("SponsorID");

                    b.Navigation("Country");

                    b.Navigation("Sponsor");
                });

            modelBuilder.Entity("DbAccess.Models.Country", b =>
                {
                    b.Navigation("Teams");
                });

            modelBuilder.Entity("DbAccess.Models.TeamSponsor", b =>
                {
                    b.Navigation("Teams");
                });
#pragma warning restore 612, 618
        }
    }
}
