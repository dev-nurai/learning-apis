﻿// <auto-generated />
using System;
using LearningAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LearningAPI.Migrations
{
    [DbContext(typeof(ApplicationdbContext))]
    partial class ApplicationdbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("LearningAPI.Models.Places", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Amenity")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Details")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Occupancy")
                        .HasColumnType("int");

                    b.Property<double>("Rate")
                        .HasColumnType("float");

                    b.Property<int>("Sqft")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Places");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Amenity = "",
                            CreatedDate = new DateTime(2023, 3, 7, 17, 39, 0, 678, DateTimeKind.Local).AddTicks(9179),
                            Details = "Food City of India.",
                            ImageUrl = "https://www.localsamosa.com/wp-content/uploads/2020/06/original_shutterstock_1294137358.jpg",
                            Name = "Delhi",
                            Occupancy = 200,
                            Rate = 100.0,
                            Sqft = 120,
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 2,
                            Amenity = "",
                            CreatedDate = new DateTime(2023, 3, 7, 17, 39, 0, 678, DateTimeKind.Local).AddTicks(9195),
                            Details = "Dream city of India.",
                            ImageUrl = "https://www.burohappold.com/wp-content/uploads/2022/02/Mumbai-skyline_copyright-Adobe-Stock_01.jpg",
                            Name = "Mumbai",
                            Occupancy = 100,
                            Rate = 300.0,
                            Sqft = 200,
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 3,
                            Amenity = "",
                            CreatedDate = new DateTime(2023, 3, 7, 17, 39, 0, 678, DateTimeKind.Local).AddTicks(9197),
                            Details = "Nawab City of India.",
                            ImageUrl = "https://www.uptourism.gov.in/images/shahnafaz.jpg",
                            Name = "Lucknow",
                            Occupancy = 200,
                            Rate = 200.0,
                            Sqft = 120,
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
