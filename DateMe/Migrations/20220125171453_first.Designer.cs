﻿// <auto-generated />
using DateMe.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DateMe.Migrations
{
    [DbContext(typeof(AppContext))]
    [Migration("20220125171453_first")]
    partial class first
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.22");

            modelBuilder.Entity("DateMe.Models.ApplicationResponse", b =>
                {
                    b.Property<int>("MovieId")
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
                        .HasColumnType("TEXT");

                    b.Property<string>("Rating")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Year")
                        .HasColumnType("INTEGER");

                    b.HasKey("MovieId");

                    b.ToTable("responses");

                    b.HasData(
                        new
                        {
                            MovieId = 1,
                            Category = "Action",
                            Director = "Christopher Nolan",
                            Edited = false,
                            Lent = "",
                            Notes = "im batman",
                            Rating = "PG-13",
                            Title = "The Dark Knight",
                            Year = 2008
                        },
                        new
                        {
                            MovieId = 2,
                            Category = "Space",
                            Director = "Christopher Nolan",
                            Edited = false,
                            Lent = "",
                            Notes = "im not batman",
                            Rating = "PG-13",
                            Title = "Interstellar",
                            Year = 2014
                        },
                        new
                        {
                            MovieId = 3,
                            Category = "Drama",
                            Director = "Makoto Shinkai",
                            Edited = false,
                            Lent = "",
                            Notes = "Your Name.",
                            Rating = "PG-13",
                            Title = "kimi no na ha",
                            Year = 2016
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
