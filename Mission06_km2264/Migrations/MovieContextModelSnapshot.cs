﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Mission06_km2264.Models;

namespace Mission06_km2264.Migrations
{
    [DbContext(typeof(MovieContext))]
    partial class MovieContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.32");

            modelBuilder.Entity("Mission06_km2264.Models.EnterMovieResponse", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Director")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("Edited")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Lent")
                        .HasColumnType("TEXT");

                    b.Property<string>("Notes")
                        .HasColumnType("TEXT")
                        .HasMaxLength(25);

                    b.Property<string>("Rating")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<short>("Year")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("responses");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Category = "Drama",
                            Director = "Nobuhiro Doi",
                            Edited = false,
                            Lent = "",
                            Notes = "",
                            Rating = "PG",
                            Title = "Flying Colors",
                            Year = (short)2015
                        },
                        new
                        {
                            Id = 2,
                            Category = "Romance",
                            Director = "Nobuhiro Doi",
                            Edited = false,
                            Lent = "",
                            Notes = "",
                            Rating = "PG-13",
                            Title = "We Made a Beautiful Bouquet",
                            Year = (short)2021
                        },
                        new
                        {
                            Id = 3,
                            Category = "Action",
                            Director = "Testuro Kodama",
                            Edited = false,
                            Lent = "",
                            Notes = "",
                            Rating = "PG",
                            Title = "Dragonball Super: Super Hero",
                            Year = (short)2022
                        });
                });
#pragma warning restore 612, 618
        }
    }
}