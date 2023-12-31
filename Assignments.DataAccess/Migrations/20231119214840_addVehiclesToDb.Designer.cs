﻿// <auto-generated />
using Assignments.DataAccess.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Assignments.DataAccess.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20231119214840_addVehiclesToDb")]
    partial class addVehiclesToDb
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Assignments.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("DisplayOrder")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DisplayOrder = 1,
                            Name = "All Cars"
                        },
                        new
                        {
                            Id = 2,
                            DisplayOrder = 2,
                            Name = "Audi"
                        },
                        new
                        {
                            Id = 3,
                            DisplayOrder = 3,
                            Name = "Austin"
                        },
                        new
                        {
                            Id = 4,
                            DisplayOrder = 4,
                            Name = "Bajaj"
                        });
                });

            modelBuilder.Entity("Assignments.Models.Vehicle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<double>("AskingPrice")
                        .HasColumnType("float");

                    b.Property<string>("EngineSize")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LicenseNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Make")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Transmission")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Vehicles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AskingPrice = 112000.0,
                            EngineSize = "2000 cc",
                            LicenseNo = "PDJ",
                            Make = "Kia",
                            Model = "Sportage",
                            Transmission = "Automatic",
                            Year = 2015
                        },
                        new
                        {
                            Id = 2,
                            AskingPrice = 132000.0,
                            EngineSize = "V6 3500 cc",
                            LicenseNo = "PDD",
                            Make = "Nissan",
                            Model = "Altima",
                            Transmission = "Automatic",
                            Year = 2014
                        },
                        new
                        {
                            Id = 3,
                            AskingPrice = 225000.0,
                            EngineSize = "2000 cc",
                            LicenseNo = "PDM",
                            Make = "Toyota",
                            Model = "Rav 4",
                            Transmission = "Automatic",
                            Year = 2015
                        },
                        new
                        {
                            Id = 4,
                            AskingPrice = 68000.0,
                            EngineSize = "2500 cc",
                            LicenseNo = "TDB",
                            Make = "Mitsubishi",
                            Model = "L200 Pickup 4x4",
                            Transmission = "Manual, 5 Forward",
                            Year = 2014
                        },
                        new
                        {
                            Id = 5,
                            AskingPrice = 137000.0,
                            EngineSize = "2000 cc",
                            LicenseNo = "PDR",
                            Make = "Nissan",
                            Model = "X-Trail Hybrid",
                            Transmission = "Automatic",
                            Year = 2018
                        },
                        new
                        {
                            Id = 6,
                            AskingPrice = 100000.0,
                            EngineSize = "1500 cc",
                            LicenseNo = "PDP",
                            Make = "Honda",
                            Model = "City (CNG)",
                            Transmission = "Automatic",
                            Year = 2017
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
