﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using P05Shop.API.Models;

#nullable disable

namespace P05Shop.API.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("P06Shop.Shared.Shop.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("TotalPrice")
                        .HasColumnType("decimal(8,2)");

                    b.HasKey("Id");

                    b.ToTable("Orders");

                    b.HasData(
                        new
                        {
                            Id = 16,
                            Date = new DateTime(2016, 7, 3, 0, 0, 0, 0, DateTimeKind.Local),
                            TotalPrice = 18.3m
                        },
                        new
                        {
                            Id = 17,
                            Date = new DateTime(2014, 11, 28, 0, 0, 0, 0, DateTimeKind.Local),
                            TotalPrice = 38.01m
                        },
                        new
                        {
                            Id = 18,
                            Date = new DateTime(2014, 2, 20, 0, 0, 0, 0, DateTimeKind.Local),
                            TotalPrice = 36.02m
                        },
                        new
                        {
                            Id = 19,
                            Date = new DateTime(2017, 7, 13, 0, 0, 0, 0, DateTimeKind.Local),
                            TotalPrice = 83.24m
                        },
                        new
                        {
                            Id = 20,
                            Date = new DateTime(2022, 2, 20, 0, 0, 0, 0, DateTimeKind.Local),
                            TotalPrice = 45.66m
                        },
                        new
                        {
                            Id = 21,
                            Date = new DateTime(2018, 9, 17, 0, 0, 0, 0, DateTimeKind.Local),
                            TotalPrice = 62.33m
                        },
                        new
                        {
                            Id = 22,
                            Date = new DateTime(2015, 10, 13, 0, 0, 0, 0, DateTimeKind.Local),
                            TotalPrice = 83.16m
                        },
                        new
                        {
                            Id = 23,
                            Date = new DateTime(2017, 10, 6, 0, 0, 0, 0, DateTimeKind.Local),
                            TotalPrice = 74.16m
                        },
                        new
                        {
                            Id = 24,
                            Date = new DateTime(2019, 4, 24, 0, 0, 0, 0, DateTimeKind.Local),
                            TotalPrice = 90.99m
                        },
                        new
                        {
                            Id = 25,
                            Date = new DateTime(2021, 12, 8, 0, 0, 0, 0, DateTimeKind.Local),
                            TotalPrice = 23.82m
                        },
                        new
                        {
                            Id = 26,
                            Date = new DateTime(2014, 10, 21, 0, 0, 0, 0, DateTimeKind.Local),
                            TotalPrice = 47.76m
                        },
                        new
                        {
                            Id = 27,
                            Date = new DateTime(2017, 5, 6, 0, 0, 0, 0, DateTimeKind.Local),
                            TotalPrice = 46.25m
                        },
                        new
                        {
                            Id = 28,
                            Date = new DateTime(2019, 10, 2, 0, 0, 0, 0, DateTimeKind.Local),
                            TotalPrice = 40.39m
                        },
                        new
                        {
                            Id = 29,
                            Date = new DateTime(2014, 11, 20, 0, 0, 0, 0, DateTimeKind.Local),
                            TotalPrice = 24.51m
                        },
                        new
                        {
                            Id = 30,
                            Date = new DateTime(2020, 12, 7, 0, 0, 0, 0, DateTimeKind.Local),
                            TotalPrice = 52.61m
                        },
                        new
                        {
                            Id = 31,
                            Date = new DateTime(2022, 9, 1, 0, 0, 0, 0, DateTimeKind.Local),
                            TotalPrice = 41.06m
                        },
                        new
                        {
                            Id = 32,
                            Date = new DateTime(2020, 12, 17, 0, 0, 0, 0, DateTimeKind.Local),
                            TotalPrice = 91.08m
                        },
                        new
                        {
                            Id = 33,
                            Date = new DateTime(2020, 3, 2, 0, 0, 0, 0, DateTimeKind.Local),
                            TotalPrice = 32.77m
                        },
                        new
                        {
                            Id = 34,
                            Date = new DateTime(2020, 8, 19, 0, 0, 0, 0, DateTimeKind.Local),
                            TotalPrice = 52.62m
                        },
                        new
                        {
                            Id = 35,
                            Date = new DateTime(2014, 8, 26, 0, 0, 0, 0, DateTimeKind.Local),
                            TotalPrice = 71.72m
                        },
                        new
                        {
                            Id = 36,
                            Date = new DateTime(2018, 9, 1, 0, 0, 0, 0, DateTimeKind.Local),
                            TotalPrice = 23.99m
                        },
                        new
                        {
                            Id = 37,
                            Date = new DateTime(2015, 3, 14, 0, 0, 0, 0, DateTimeKind.Local),
                            TotalPrice = 79.21m
                        },
                        new
                        {
                            Id = 38,
                            Date = new DateTime(2020, 8, 3, 0, 0, 0, 0, DateTimeKind.Local),
                            TotalPrice = 32.33m
                        },
                        new
                        {
                            Id = 39,
                            Date = new DateTime(2022, 8, 15, 0, 0, 0, 0, DateTimeKind.Local),
                            TotalPrice = 58.09m
                        },
                        new
                        {
                            Id = 40,
                            Date = new DateTime(2014, 10, 12, 0, 0, 0, 0, DateTimeKind.Local),
                            TotalPrice = 25.09m
                        },
                        new
                        {
                            Id = 41,
                            Date = new DateTime(2017, 2, 15, 0, 0, 0, 0, DateTimeKind.Local),
                            TotalPrice = 84.05m
                        },
                        new
                        {
                            Id = 42,
                            Date = new DateTime(2014, 8, 15, 0, 0, 0, 0, DateTimeKind.Local),
                            TotalPrice = 67.52m
                        },
                        new
                        {
                            Id = 43,
                            Date = new DateTime(2013, 12, 4, 0, 0, 0, 0, DateTimeKind.Local),
                            TotalPrice = 90.16m
                        },
                        new
                        {
                            Id = 44,
                            Date = new DateTime(2020, 10, 30, 0, 0, 0, 0, DateTimeKind.Local),
                            TotalPrice = 48.66m
                        },
                        new
                        {
                            Id = 45,
                            Date = new DateTime(2019, 5, 24, 0, 0, 0, 0, DateTimeKind.Local),
                            TotalPrice = 60.5m
                        },
                        new
                        {
                            Id = 46,
                            Date = new DateTime(2017, 10, 15, 0, 0, 0, 0, DateTimeKind.Local),
                            TotalPrice = 25.16m
                        },
                        new
                        {
                            Id = 47,
                            Date = new DateTime(2019, 11, 27, 0, 0, 0, 0, DateTimeKind.Local),
                            TotalPrice = 46.95m
                        },
                        new
                        {
                            Id = 48,
                            Date = new DateTime(2022, 12, 24, 0, 0, 0, 0, DateTimeKind.Local),
                            TotalPrice = 36.2m
                        },
                        new
                        {
                            Id = 49,
                            Date = new DateTime(2014, 12, 2, 0, 0, 0, 0, DateTimeKind.Local),
                            TotalPrice = 66.32m
                        },
                        new
                        {
                            Id = 50,
                            Date = new DateTime(2022, 3, 27, 0, 0, 0, 0, DateTimeKind.Local),
                            TotalPrice = 41.25m
                        });
                });

            modelBuilder.Entity("P06Shop.Shared.Shop.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Barcode")
                        .IsRequired()
                        .HasMaxLength(12)
                        .HasColumnType("nvarchar(12)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(8,2)");

                    b.Property<DateTime>("ReleaseDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Barcode = "3",
                            Description = "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design",
                            Price = 712.021981759007m,
                            ReleaseDate = new DateTime(2023, 3, 19, 18, 6, 46, 341, DateTimeKind.Local).AddTicks(8622),
                            Title = "Gorgeous Wooden Chair"
                        },
                        new
                        {
                            Id = 2,
                            Barcode = "7",
                            Description = "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive",
                            Price = 839.010165513032m,
                            ReleaseDate = new DateTime(2023, 9, 29, 14, 45, 19, 978, DateTimeKind.Local).AddTicks(1118),
                            Title = "Handcrafted Steel Shoes"
                        },
                        new
                        {
                            Id = 3,
                            Barcode = "1",
                            Description = "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit",
                            Price = 198.083692779804m,
                            ReleaseDate = new DateTime(2023, 1, 18, 9, 39, 3, 251, DateTimeKind.Local).AddTicks(3138),
                            Title = "Handmade Granite Table"
                        },
                        new
                        {
                            Id = 4,
                            Barcode = "1",
                            Description = "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive",
                            Price = 160.643399712929m,
                            ReleaseDate = new DateTime(2023, 8, 19, 21, 52, 33, 610, DateTimeKind.Local).AddTicks(4521),
                            Title = "Handmade Wooden Table"
                        },
                        new
                        {
                            Id = 5,
                            Barcode = "0",
                            Description = "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles",
                            Price = 359.887736376788m,
                            ReleaseDate = new DateTime(2023, 2, 19, 23, 10, 45, 340, DateTimeKind.Local).AddTicks(702),
                            Title = "Intelligent Steel Salad"
                        },
                        new
                        {
                            Id = 6,
                            Barcode = "8",
                            Description = "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals",
                            Price = 181.360829243139m,
                            ReleaseDate = new DateTime(2023, 9, 3, 10, 58, 18, 449, DateTimeKind.Local).AddTicks(7986),
                            Title = "Handcrafted Rubber Bike"
                        },
                        new
                        {
                            Id = 7,
                            Barcode = "1",
                            Description = "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart",
                            Price = 938.297015022625m,
                            ReleaseDate = new DateTime(2023, 4, 4, 10, 10, 30, 859, DateTimeKind.Local).AddTicks(8036),
                            Title = "Unbranded Steel Car"
                        },
                        new
                        {
                            Id = 8,
                            Barcode = "3",
                            Description = "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients",
                            Price = 223.882037785315m,
                            ReleaseDate = new DateTime(2023, 6, 28, 1, 24, 58, 548, DateTimeKind.Local).AddTicks(261),
                            Title = "Tasty Plastic Cheese"
                        },
                        new
                        {
                            Id = 9,
                            Barcode = "0",
                            Description = "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals",
                            Price = 249.172251003875m,
                            ReleaseDate = new DateTime(2022, 12, 17, 17, 24, 14, 4, DateTimeKind.Local).AddTicks(7787),
                            Title = "Handcrafted Fresh Sausages"
                        },
                        new
                        {
                            Id = 10,
                            Barcode = "1",
                            Description = "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support",
                            Price = 905.322284099796m,
                            ReleaseDate = new DateTime(2023, 10, 9, 9, 6, 23, 466, DateTimeKind.Local).AddTicks(445),
                            Title = "Fantastic Frozen Gloves"
                        },
                        new
                        {
                            Id = 11,
                            Barcode = "3",
                            Description = "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design",
                            Price = 842.480734222792m,
                            ReleaseDate = new DateTime(2023, 8, 8, 2, 20, 27, 607, DateTimeKind.Local).AddTicks(7609),
                            Title = "Generic Steel Ball"
                        },
                        new
                        {
                            Id = 12,
                            Barcode = "1",
                            Description = "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals",
                            Price = 928.928430071533m,
                            ReleaseDate = new DateTime(2023, 8, 16, 6, 52, 24, 381, DateTimeKind.Local).AddTicks(6317),
                            Title = "Ergonomic Rubber Car"
                        },
                        new
                        {
                            Id = 13,
                            Barcode = "6",
                            Description = "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality",
                            Price = 706.948686653259m,
                            ReleaseDate = new DateTime(2023, 7, 16, 12, 5, 53, 301, DateTimeKind.Local).AddTicks(2296),
                            Title = "Generic Steel Pizza"
                        },
                        new
                        {
                            Id = 14,
                            Barcode = "3",
                            Description = "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles",
                            Price = 306.262494314584m,
                            ReleaseDate = new DateTime(2023, 1, 10, 1, 18, 31, 788, DateTimeKind.Local).AddTicks(8607),
                            Title = "Small Metal Sausages"
                        },
                        new
                        {
                            Id = 15,
                            Barcode = "2",
                            Description = "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support",
                            Price = 378.222576259273m,
                            ReleaseDate = new DateTime(2023, 7, 31, 18, 24, 24, 818, DateTimeKind.Local).AddTicks(5857),
                            Title = "Fantastic Soft Pants"
                        },
                        new
                        {
                            Id = 16,
                            Barcode = "6",
                            Description = "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients",
                            Price = 461.718092748764m,
                            ReleaseDate = new DateTime(2022, 11, 18, 10, 19, 13, 285, DateTimeKind.Local).AddTicks(4718),
                            Title = "Gorgeous Frozen Towels"
                        },
                        new
                        {
                            Id = 17,
                            Barcode = "7",
                            Description = "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles",
                            Price = 126.128098112125m,
                            ReleaseDate = new DateTime(2023, 6, 28, 0, 40, 44, 863, DateTimeKind.Local).AddTicks(4206),
                            Title = "Tasty Steel Cheese"
                        },
                        new
                        {
                            Id = 18,
                            Barcode = "8",
                            Description = "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart",
                            Price = 530.970371435383m,
                            ReleaseDate = new DateTime(2023, 6, 25, 2, 23, 26, 222, DateTimeKind.Local).AddTicks(7261),
                            Title = "Gorgeous Granite Cheese"
                        },
                        new
                        {
                            Id = 19,
                            Barcode = "9",
                            Description = "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive",
                            Price = 913.003066283186m,
                            ReleaseDate = new DateTime(2022, 11, 18, 13, 41, 25, 802, DateTimeKind.Local).AddTicks(610),
                            Title = "Sleek Rubber Chicken"
                        },
                        new
                        {
                            Id = 20,
                            Barcode = "5",
                            Description = "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals",
                            Price = 940.814879371698m,
                            ReleaseDate = new DateTime(2023, 4, 11, 15, 12, 10, 284, DateTimeKind.Local).AddTicks(3856),
                            Title = "Intelligent Wooden Salad"
                        },
                        new
                        {
                            Id = 21,
                            Barcode = "4",
                            Description = "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support",
                            Price = 479.41424090062m,
                            ReleaseDate = new DateTime(2023, 6, 20, 2, 35, 4, 472, DateTimeKind.Local).AddTicks(6236),
                            Title = "Handcrafted Wooden Sausages"
                        },
                        new
                        {
                            Id = 22,
                            Barcode = "7",
                            Description = "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit",
                            Price = 320.499838554068m,
                            ReleaseDate = new DateTime(2023, 1, 30, 22, 2, 26, 742, DateTimeKind.Local).AddTicks(4061),
                            Title = "Sleek Granite Car"
                        },
                        new
                        {
                            Id = 23,
                            Barcode = "6",
                            Description = "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J",
                            Price = 478.915239043029m,
                            ReleaseDate = new DateTime(2023, 6, 1, 15, 52, 34, 60, DateTimeKind.Local).AddTicks(7630),
                            Title = "Small Wooden Car"
                        },
                        new
                        {
                            Id = 24,
                            Barcode = "2",
                            Description = "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients",
                            Price = 910.785444308438m,
                            ReleaseDate = new DateTime(2023, 7, 3, 8, 28, 53, 290, DateTimeKind.Local).AddTicks(803),
                            Title = "Sleek Steel Shirt"
                        },
                        new
                        {
                            Id = 25,
                            Barcode = "3",
                            Description = "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016",
                            Price = 802.238750720974m,
                            ReleaseDate = new DateTime(2023, 7, 19, 9, 57, 44, 853, DateTimeKind.Local).AddTicks(7254),
                            Title = "Incredible Frozen Mouse"
                        },
                        new
                        {
                            Id = 26,
                            Barcode = "7",
                            Description = "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J",
                            Price = 150.818741621831m,
                            ReleaseDate = new DateTime(2023, 5, 14, 3, 34, 4, 977, DateTimeKind.Local).AddTicks(2524),
                            Title = "Incredible Wooden Chair"
                        },
                        new
                        {
                            Id = 27,
                            Barcode = "5",
                            Description = "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit",
                            Price = 721.773541800572m,
                            ReleaseDate = new DateTime(2023, 2, 2, 15, 37, 40, 973, DateTimeKind.Local).AddTicks(4099),
                            Title = "Gorgeous Plastic Chips"
                        },
                        new
                        {
                            Id = 28,
                            Barcode = "5",
                            Description = "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit",
                            Price = 688.245783060904m,
                            ReleaseDate = new DateTime(2023, 4, 27, 18, 3, 36, 84, DateTimeKind.Local).AddTicks(9324),
                            Title = "Incredible Fresh Bacon"
                        },
                        new
                        {
                            Id = 29,
                            Barcode = "7",
                            Description = "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support",
                            Price = 553.558320945389m,
                            ReleaseDate = new DateTime(2023, 7, 21, 4, 34, 30, 78, DateTimeKind.Local).AddTicks(694),
                            Title = "Incredible Soft Computer"
                        },
                        new
                        {
                            Id = 30,
                            Barcode = "4",
                            Description = "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016",
                            Price = 663.536718269594m,
                            ReleaseDate = new DateTime(2022, 11, 15, 5, 29, 53, 294, DateTimeKind.Local).AddTicks(2486),
                            Title = "Handcrafted Rubber Bike"
                        },
                        new
                        {
                            Id = 31,
                            Barcode = "2",
                            Description = "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles",
                            Price = 922.479030014704m,
                            ReleaseDate = new DateTime(2023, 10, 11, 3, 55, 42, 491, DateTimeKind.Local).AddTicks(645),
                            Title = "Handcrafted Concrete Tuna"
                        },
                        new
                        {
                            Id = 32,
                            Barcode = "3",
                            Description = "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality",
                            Price = 255.49067058018m,
                            ReleaseDate = new DateTime(2023, 7, 21, 23, 43, 8, 430, DateTimeKind.Local).AddTicks(1080),
                            Title = "Gorgeous Wooden Fish"
                        },
                        new
                        {
                            Id = 33,
                            Barcode = "7",
                            Description = "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016",
                            Price = 955.272407213818m,
                            ReleaseDate = new DateTime(2023, 4, 29, 0, 12, 9, 680, DateTimeKind.Local).AddTicks(6967),
                            Title = "Handcrafted Frozen Keyboard"
                        },
                        new
                        {
                            Id = 34,
                            Barcode = "8",
                            Description = "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive",
                            Price = 151.982358236323m,
                            ReleaseDate = new DateTime(2022, 11, 25, 17, 27, 57, 519, DateTimeKind.Local).AddTicks(4566),
                            Title = "Intelligent Plastic Chair"
                        },
                        new
                        {
                            Id = 35,
                            Barcode = "9",
                            Description = "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit",
                            Price = 434.299358334532m,
                            ReleaseDate = new DateTime(2022, 12, 13, 22, 20, 15, 514, DateTimeKind.Local).AddTicks(4299),
                            Title = "Unbranded Wooden Pizza"
                        },
                        new
                        {
                            Id = 36,
                            Barcode = "4",
                            Description = "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J",
                            Price = 57.7988712865854m,
                            ReleaseDate = new DateTime(2023, 1, 2, 16, 54, 13, 47, DateTimeKind.Local).AddTicks(6103),
                            Title = "Gorgeous Rubber Bacon"
                        },
                        new
                        {
                            Id = 37,
                            Barcode = "7",
                            Description = "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart",
                            Price = 883.980300599234m,
                            ReleaseDate = new DateTime(2023, 3, 31, 8, 27, 26, 443, DateTimeKind.Local).AddTicks(4269),
                            Title = "Handcrafted Rubber Shirt"
                        },
                        new
                        {
                            Id = 38,
                            Barcode = "7",
                            Description = "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support",
                            Price = 822.452619476455m,
                            ReleaseDate = new DateTime(2023, 1, 10, 6, 29, 6, 762, DateTimeKind.Local).AddTicks(5648),
                            Title = "Rustic Granite Shoes"
                        },
                        new
                        {
                            Id = 39,
                            Barcode = "7",
                            Description = "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design",
                            Price = 22.2432652671092m,
                            ReleaseDate = new DateTime(2023, 4, 6, 14, 7, 21, 322, DateTimeKind.Local).AddTicks(801),
                            Title = "Sleek Granite Chair"
                        },
                        new
                        {
                            Id = 40,
                            Barcode = "2",
                            Description = "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive",
                            Price = 158.364214679396m,
                            ReleaseDate = new DateTime(2023, 6, 24, 10, 53, 37, 945, DateTimeKind.Local).AddTicks(8572),
                            Title = "Incredible Rubber Soap"
                        },
                        new
                        {
                            Id = 41,
                            Barcode = "7",
                            Description = "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit",
                            Price = 533.504530191656m,
                            ReleaseDate = new DateTime(2023, 8, 6, 17, 59, 0, 94, DateTimeKind.Local).AddTicks(625),
                            Title = "Awesome Soft Fish"
                        },
                        new
                        {
                            Id = 42,
                            Barcode = "8",
                            Description = "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive",
                            Price = 265.709933652407m,
                            ReleaseDate = new DateTime(2023, 7, 29, 5, 9, 59, 523, DateTimeKind.Local).AddTicks(5990),
                            Title = "Intelligent Cotton Tuna"
                        },
                        new
                        {
                            Id = 43,
                            Barcode = "2",
                            Description = "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J",
                            Price = 294.402654204239m,
                            ReleaseDate = new DateTime(2023, 1, 20, 20, 56, 13, 79, DateTimeKind.Local).AddTicks(4976),
                            Title = "Refined Soft Bike"
                        },
                        new
                        {
                            Id = 44,
                            Barcode = "5",
                            Description = "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals",
                            Price = 741.648888164036m,
                            ReleaseDate = new DateTime(2023, 1, 24, 18, 36, 38, 238, DateTimeKind.Local).AddTicks(2611),
                            Title = "Handmade Cotton Bacon"
                        },
                        new
                        {
                            Id = 45,
                            Barcode = "5",
                            Description = "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit",
                            Price = 825.239833488706m,
                            ReleaseDate = new DateTime(2023, 1, 2, 14, 43, 1, 308, DateTimeKind.Local).AddTicks(4135),
                            Title = "Small Soft Tuna"
                        },
                        new
                        {
                            Id = 46,
                            Barcode = "1",
                            Description = "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality",
                            Price = 305.894089151124m,
                            ReleaseDate = new DateTime(2023, 5, 7, 19, 25, 12, 867, DateTimeKind.Local).AddTicks(7651),
                            Title = "Practical Frozen Computer"
                        },
                        new
                        {
                            Id = 47,
                            Barcode = "4",
                            Description = "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients",
                            Price = 778.911179241683m,
                            ReleaseDate = new DateTime(2023, 1, 10, 14, 24, 47, 170, DateTimeKind.Local).AddTicks(798),
                            Title = "Rustic Wooden Mouse"
                        },
                        new
                        {
                            Id = 48,
                            Barcode = "2",
                            Description = "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart",
                            Price = 318.709401070936m,
                            ReleaseDate = new DateTime(2023, 2, 22, 11, 17, 4, 596, DateTimeKind.Local).AddTicks(441),
                            Title = "Handcrafted Metal Mouse"
                        },
                        new
                        {
                            Id = 49,
                            Barcode = "6",
                            Description = "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients",
                            Price = 463.195345650052m,
                            ReleaseDate = new DateTime(2023, 4, 7, 15, 59, 8, 197, DateTimeKind.Local).AddTicks(9705),
                            Title = "Handcrafted Rubber Salad"
                        },
                        new
                        {
                            Id = 50,
                            Barcode = "6",
                            Description = "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support",
                            Price = 717.609017980569m,
                            ReleaseDate = new DateTime(2023, 8, 25, 5, 8, 7, 377, DateTimeKind.Local).AddTicks(8395),
                            Title = "Incredible Plastic Shoes"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
