﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using URLShortener;

namespace URLShortener.Migrations
{
    [DbContext(typeof(URLDbContext))]
    partial class URLDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.2-rtm-10011");

            modelBuilder.Entity("URLShortener.Models.ClickData", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ClickedCount");

                    b.Property<int?>("urlId");

                    b.HasKey("Id");

                    b.HasIndex("urlId")
                        .IsUnique();

                    b.ToTable("Clicks");
                });

            modelBuilder.Entity("URLShortener.Models.URL", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address");

                    b.Property<string>("ShortAdress");

                    b.HasKey("Id");

                    b.ToTable("URLs");
                });

            modelBuilder.Entity("URLShortener.Models.ClickData", b =>
                {
                    b.HasOne("URLShortener.Models.URL", "url")
                        .WithOne("ClickData")
                        .HasForeignKey("URLShortener.Models.ClickData", "urlId");
                });
#pragma warning restore 612, 618
        }
    }
}
