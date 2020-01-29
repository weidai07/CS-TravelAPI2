﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TravelAPI.Models;

namespace TravelAPI.Solutions.Migrations
{
    [DbContext(typeof(TravelAPIContext))]
    partial class TravelAPIContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("TravelAPI.Models.Review", b =>
                {
                    b.Property<int>("ReviewId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("City");

                    b.Property<string>("Country");

                    b.Property<int>("Rating");

                    b.Property<string>("ReviewDescription");

                    b.HasKey("ReviewId");

                    b.ToTable("Reviews");

                    b.HasData(
                        new
                        {
                            ReviewId = 1,
                            City = "Seattle",
                            Country = "USA",
                            Rating = 10,
                            ReviewDescription = "Awesome"
                        },
                        new
                        {
                            ReviewId = 2,
                            City = "Moscow",
                            Country = "Russia",
                            Rating = 11,
                            ReviewDescription = "Best"
                        },
                        new
                        {
                            ReviewId = 3,
                            City = "Bangkok",
                            Country = "Thailand",
                            Rating = 8,
                            ReviewDescription = "Good"
                        },
                        new
                        {
                            ReviewId = 4,
                            City = "Victoria",
                            Country = "Canada",
                            Rating = 7,
                            ReviewDescription = "Average"
                        },
                        new
                        {
                            ReviewId = 5,
                            City = "Cancun",
                            Country = "Mexico",
                            Rating = 6,
                            ReviewDescription = "Decent"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
