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
                            Id = 1,
                            Date = new DateTime(2016, 6, 23, 0, 0, 0, 0, DateTimeKind.Local),
                            TotalPrice = 65.91m
                        },
                        new
                        {
                            Id = 2,
                            Date = new DateTime(2014, 11, 18, 0, 0, 0, 0, DateTimeKind.Local),
                            TotalPrice = 53m
                        },
                        new
                        {
                            Id = 3,
                            Date = new DateTime(2014, 2, 10, 0, 0, 0, 0, DateTimeKind.Local),
                            TotalPrice = 99.63m
                        },
                        new
                        {
                            Id = 4,
                            Date = new DateTime(2017, 7, 3, 0, 0, 0, 0, DateTimeKind.Local),
                            TotalPrice = 28.03m
                        },
                        new
                        {
                            Id = 5,
                            Date = new DateTime(2022, 2, 10, 0, 0, 0, 0, DateTimeKind.Local),
                            TotalPrice = 51.25m
                        },
                        new
                        {
                            Id = 6,
                            Date = new DateTime(2018, 9, 7, 0, 0, 0, 0, DateTimeKind.Local),
                            TotalPrice = 64.06m
                        },
                        new
                        {
                            Id = 7,
                            Date = new DateTime(2015, 10, 3, 0, 0, 0, 0, DateTimeKind.Local),
                            TotalPrice = 49.8m
                        },
                        new
                        {
                            Id = 8,
                            Date = new DateTime(2017, 9, 26, 0, 0, 0, 0, DateTimeKind.Local),
                            TotalPrice = 43.21m
                        },
                        new
                        {
                            Id = 9,
                            Date = new DateTime(2019, 4, 14, 0, 0, 0, 0, DateTimeKind.Local),
                            TotalPrice = 17.13m
                        },
                        new
                        {
                            Id = 10,
                            Date = new DateTime(2021, 11, 28, 0, 0, 0, 0, DateTimeKind.Local),
                            TotalPrice = 51.37m
                        });
                });

            modelBuilder.Entity("P06Shop.Shared.Shop.OrderProduct", b =>
                {
                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.HasKey("OrderId", "ProductId");

                    b.HasIndex("ProductId");

                    b.ToTable("OrderProduct");
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
                            ReleaseDate = new DateTime(2023, 3, 9, 16, 23, 48, 176, DateTimeKind.Local).AddTicks(6473),
                            Title = "Gorgeous Wooden Chair"
                        },
                        new
                        {
                            Id = 2,
                            Barcode = "7",
                            Description = "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive",
                            Price = 839.010165513032m,
                            ReleaseDate = new DateTime(2023, 9, 19, 13, 2, 21, 812, DateTimeKind.Local).AddTicks(8851),
                            Title = "Handcrafted Steel Shoes"
                        },
                        new
                        {
                            Id = 3,
                            Barcode = "1",
                            Description = "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit",
                            Price = 198.083692779804m,
                            ReleaseDate = new DateTime(2023, 1, 8, 7, 56, 5, 86, DateTimeKind.Local).AddTicks(870),
                            Title = "Handmade Granite Table"
                        },
                        new
                        {
                            Id = 4,
                            Barcode = "1",
                            Description = "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive",
                            Price = 160.643399712929m,
                            ReleaseDate = new DateTime(2023, 8, 9, 20, 9, 35, 445, DateTimeKind.Local).AddTicks(2322),
                            Title = "Handmade Wooden Table"
                        },
                        new
                        {
                            Id = 5,
                            Barcode = "0",
                            Description = "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles",
                            Price = 359.887736376788m,
                            ReleaseDate = new DateTime(2023, 2, 9, 21, 27, 47, 174, DateTimeKind.Local).AddTicks(8512),
                            Title = "Intelligent Steel Salad"
                        },
                        new
                        {
                            Id = 6,
                            Barcode = "8",
                            Description = "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals",
                            Price = 181.360829243139m,
                            ReleaseDate = new DateTime(2023, 8, 24, 9, 15, 20, 284, DateTimeKind.Local).AddTicks(5799),
                            Title = "Handcrafted Rubber Bike"
                        },
                        new
                        {
                            Id = 7,
                            Barcode = "1",
                            Description = "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart",
                            Price = 938.297015022625m,
                            ReleaseDate = new DateTime(2023, 3, 25, 8, 27, 32, 694, DateTimeKind.Local).AddTicks(5855),
                            Title = "Unbranded Steel Car"
                        },
                        new
                        {
                            Id = 8,
                            Barcode = "3",
                            Description = "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients",
                            Price = 223.882037785315m,
                            ReleaseDate = new DateTime(2023, 6, 17, 23, 42, 0, 382, DateTimeKind.Local).AddTicks(8087),
                            Title = "Tasty Plastic Cheese"
                        },
                        new
                        {
                            Id = 9,
                            Barcode = "0",
                            Description = "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals",
                            Price = 249.172251003875m,
                            ReleaseDate = new DateTime(2022, 12, 7, 15, 41, 15, 839, DateTimeKind.Local).AddTicks(5563),
                            Title = "Handcrafted Fresh Sausages"
                        },
                        new
                        {
                            Id = 10,
                            Barcode = "1",
                            Description = "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support",
                            Price = 905.322284099796m,
                            ReleaseDate = new DateTime(2023, 9, 29, 7, 23, 25, 300, DateTimeKind.Local).AddTicks(8296),
                            Title = "Fantastic Frozen Gloves"
                        },
                        new
                        {
                            Id = 11,
                            Barcode = "3",
                            Description = "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design",
                            Price = 842.480734222792m,
                            ReleaseDate = new DateTime(2023, 7, 29, 0, 37, 29, 442, DateTimeKind.Local).AddTicks(5468),
                            Title = "Generic Steel Ball"
                        },
                        new
                        {
                            Id = 12,
                            Barcode = "1",
                            Description = "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals",
                            Price = 928.928430071533m,
                            ReleaseDate = new DateTime(2023, 8, 6, 5, 9, 26, 216, DateTimeKind.Local).AddTicks(4180),
                            Title = "Ergonomic Rubber Car"
                        },
                        new
                        {
                            Id = 13,
                            Barcode = "6",
                            Description = "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality",
                            Price = 706.948686653259m,
                            ReleaseDate = new DateTime(2023, 7, 6, 10, 22, 55, 136, DateTimeKind.Local).AddTicks(166),
                            Title = "Generic Steel Pizza"
                        },
                        new
                        {
                            Id = 14,
                            Barcode = "3",
                            Description = "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles",
                            Price = 306.262494314584m,
                            ReleaseDate = new DateTime(2022, 12, 30, 23, 35, 33, 623, DateTimeKind.Local).AddTicks(6482),
                            Title = "Small Metal Sausages"
                        },
                        new
                        {
                            Id = 15,
                            Barcode = "2",
                            Description = "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support",
                            Price = 378.222576259273m,
                            ReleaseDate = new DateTime(2023, 7, 21, 16, 41, 26, 653, DateTimeKind.Local).AddTicks(3634),
                            Title = "Fantastic Soft Pants"
                        },
                        new
                        {
                            Id = 16,
                            Barcode = "6",
                            Description = "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients",
                            Price = 461.718092748764m,
                            ReleaseDate = new DateTime(2022, 11, 8, 8, 36, 15, 120, DateTimeKind.Local).AddTicks(2493),
                            Title = "Gorgeous Frozen Towels"
                        },
                        new
                        {
                            Id = 17,
                            Barcode = "7",
                            Description = "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles",
                            Price = 126.128098112125m,
                            ReleaseDate = new DateTime(2023, 6, 17, 22, 57, 46, 698, DateTimeKind.Local).AddTicks(2032),
                            Title = "Tasty Steel Cheese"
                        },
                        new
                        {
                            Id = 18,
                            Barcode = "8",
                            Description = "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart",
                            Price = 530.970371435383m,
                            ReleaseDate = new DateTime(2023, 6, 15, 0, 40, 28, 57, DateTimeKind.Local).AddTicks(5094),
                            Title = "Gorgeous Granite Cheese"
                        },
                        new
                        {
                            Id = 19,
                            Barcode = "9",
                            Description = "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive",
                            Price = 913.003066283186m,
                            ReleaseDate = new DateTime(2022, 11, 8, 11, 58, 27, 636, DateTimeKind.Local).AddTicks(8446),
                            Title = "Sleek Rubber Chicken"
                        },
                        new
                        {
                            Id = 20,
                            Barcode = "5",
                            Description = "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals",
                            Price = 940.814879371698m,
                            ReleaseDate = new DateTime(2023, 4, 1, 13, 29, 12, 119, DateTimeKind.Local).AddTicks(1696),
                            Title = "Intelligent Wooden Salad"
                        },
                        new
                        {
                            Id = 21,
                            Barcode = "4",
                            Description = "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support",
                            Price = 479.41424090062m,
                            ReleaseDate = new DateTime(2023, 6, 10, 0, 52, 6, 307, DateTimeKind.Local).AddTicks(4080),
                            Title = "Handcrafted Wooden Sausages"
                        },
                        new
                        {
                            Id = 22,
                            Barcode = "7",
                            Description = "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit",
                            Price = 320.499838554068m,
                            ReleaseDate = new DateTime(2023, 1, 20, 20, 19, 28, 577, DateTimeKind.Local).AddTicks(1803),
                            Title = "Sleek Granite Car"
                        },
                        new
                        {
                            Id = 23,
                            Barcode = "6",
                            Description = "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J",
                            Price = 478.915239043029m,
                            ReleaseDate = new DateTime(2023, 5, 22, 14, 9, 35, 895, DateTimeKind.Local).AddTicks(5373),
                            Title = "Small Wooden Car"
                        },
                        new
                        {
                            Id = 24,
                            Barcode = "2",
                            Description = "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients",
                            Price = 910.785444308438m,
                            ReleaseDate = new DateTime(2023, 6, 23, 6, 45, 55, 124, DateTimeKind.Local).AddTicks(8597),
                            Title = "Sleek Steel Shirt"
                        },
                        new
                        {
                            Id = 25,
                            Barcode = "3",
                            Description = "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016",
                            Price = 802.238750720974m,
                            ReleaseDate = new DateTime(2023, 7, 9, 8, 14, 46, 688, DateTimeKind.Local).AddTicks(5052),
                            Title = "Incredible Frozen Mouse"
                        },
                        new
                        {
                            Id = 26,
                            Barcode = "7",
                            Description = "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J",
                            Price = 150.818741621831m,
                            ReleaseDate = new DateTime(2023, 5, 4, 1, 51, 6, 812, DateTimeKind.Local).AddTicks(327),
                            Title = "Incredible Wooden Chair"
                        },
                        new
                        {
                            Id = 27,
                            Barcode = "5",
                            Description = "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit",
                            Price = 721.773541800572m,
                            ReleaseDate = new DateTime(2023, 1, 23, 13, 54, 42, 808, DateTimeKind.Local).AddTicks(1906),
                            Title = "Gorgeous Plastic Chips"
                        },
                        new
                        {
                            Id = 28,
                            Barcode = "5",
                            Description = "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit",
                            Price = 688.245783060904m,
                            ReleaseDate = new DateTime(2023, 4, 17, 16, 20, 37, 919, DateTimeKind.Local).AddTicks(7134),
                            Title = "Incredible Fresh Bacon"
                        },
                        new
                        {
                            Id = 29,
                            Barcode = "7",
                            Description = "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support",
                            Price = 553.558320945389m,
                            ReleaseDate = new DateTime(2023, 7, 11, 2, 51, 31, 912, DateTimeKind.Local).AddTicks(8446),
                            Title = "Incredible Soft Computer"
                        },
                        new
                        {
                            Id = 30,
                            Barcode = "4",
                            Description = "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016",
                            Price = 663.536718269594m,
                            ReleaseDate = new DateTime(2022, 11, 5, 3, 46, 55, 129, DateTimeKind.Local).AddTicks(305),
                            Title = "Handcrafted Rubber Bike"
                        },
                        new
                        {
                            Id = 31,
                            Barcode = "2",
                            Description = "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles",
                            Price = 922.479030014704m,
                            ReleaseDate = new DateTime(2023, 10, 1, 2, 12, 44, 325, DateTimeKind.Local).AddTicks(8471),
                            Title = "Handcrafted Concrete Tuna"
                        },
                        new
                        {
                            Id = 32,
                            Barcode = "3",
                            Description = "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality",
                            Price = 255.49067058018m,
                            ReleaseDate = new DateTime(2023, 7, 11, 22, 0, 10, 264, DateTimeKind.Local).AddTicks(8910),
                            Title = "Gorgeous Wooden Fish"
                        },
                        new
                        {
                            Id = 33,
                            Barcode = "7",
                            Description = "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016",
                            Price = 955.272407213818m,
                            ReleaseDate = new DateTime(2023, 4, 18, 22, 29, 11, 515, DateTimeKind.Local).AddTicks(4802),
                            Title = "Handcrafted Frozen Keyboard"
                        },
                        new
                        {
                            Id = 34,
                            Barcode = "8",
                            Description = "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive",
                            Price = 151.982358236323m,
                            ReleaseDate = new DateTime(2022, 11, 15, 15, 44, 59, 354, DateTimeKind.Local).AddTicks(2406),
                            Title = "Intelligent Plastic Chair"
                        },
                        new
                        {
                            Id = 35,
                            Barcode = "9",
                            Description = "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit",
                            Price = 434.299358334532m,
                            ReleaseDate = new DateTime(2022, 12, 3, 20, 37, 17, 349, DateTimeKind.Local).AddTicks(2093),
                            Title = "Unbranded Wooden Pizza"
                        },
                        new
                        {
                            Id = 36,
                            Barcode = "4",
                            Description = "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J",
                            Price = 57.7988712865854m,
                            ReleaseDate = new DateTime(2022, 12, 23, 15, 11, 14, 882, DateTimeKind.Local).AddTicks(3899),
                            Title = "Gorgeous Rubber Bacon"
                        },
                        new
                        {
                            Id = 37,
                            Barcode = "7",
                            Description = "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart",
                            Price = 883.980300599234m,
                            ReleaseDate = new DateTime(2023, 3, 21, 6, 44, 28, 278, DateTimeKind.Local).AddTicks(2116),
                            Title = "Handcrafted Rubber Shirt"
                        },
                        new
                        {
                            Id = 38,
                            Barcode = "7",
                            Description = "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support",
                            Price = 822.452619476455m,
                            ReleaseDate = new DateTime(2022, 12, 31, 4, 46, 8, 597, DateTimeKind.Local).AddTicks(3502),
                            Title = "Rustic Granite Shoes"
                        },
                        new
                        {
                            Id = 39,
                            Barcode = "7",
                            Description = "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design",
                            Price = 22.2432652671092m,
                            ReleaseDate = new DateTime(2023, 3, 27, 12, 24, 23, 156, DateTimeKind.Local).AddTicks(8660),
                            Title = "Sleek Granite Chair"
                        },
                        new
                        {
                            Id = 40,
                            Barcode = "2",
                            Description = "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive",
                            Price = 158.364214679396m,
                            ReleaseDate = new DateTime(2023, 6, 14, 9, 10, 39, 780, DateTimeKind.Local).AddTicks(6434),
                            Title = "Incredible Rubber Soap"
                        },
                        new
                        {
                            Id = 41,
                            Barcode = "7",
                            Description = "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit",
                            Price = 533.504530191656m,
                            ReleaseDate = new DateTime(2023, 7, 27, 16, 16, 1, 928, DateTimeKind.Local).AddTicks(8492),
                            Title = "Awesome Soft Fish"
                        },
                        new
                        {
                            Id = 42,
                            Barcode = "8",
                            Description = "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive",
                            Price = 265.709933652407m,
                            ReleaseDate = new DateTime(2023, 7, 19, 3, 27, 1, 358, DateTimeKind.Local).AddTicks(3812),
                            Title = "Intelligent Cotton Tuna"
                        },
                        new
                        {
                            Id = 43,
                            Barcode = "2",
                            Description = "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J",
                            Price = 294.402654204239m,
                            ReleaseDate = new DateTime(2023, 1, 10, 19, 13, 14, 914, DateTimeKind.Local).AddTicks(2798),
                            Title = "Refined Soft Bike"
                        },
                        new
                        {
                            Id = 44,
                            Barcode = "5",
                            Description = "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals",
                            Price = 741.648888164036m,
                            ReleaseDate = new DateTime(2023, 1, 14, 16, 53, 40, 73, DateTimeKind.Local).AddTicks(531),
                            Title = "Handmade Cotton Bacon"
                        },
                        new
                        {
                            Id = 45,
                            Barcode = "5",
                            Description = "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit",
                            Price = 825.239833488706m,
                            ReleaseDate = new DateTime(2022, 12, 23, 13, 0, 3, 143, DateTimeKind.Local).AddTicks(2063),
                            Title = "Small Soft Tuna"
                        },
                        new
                        {
                            Id = 46,
                            Barcode = "1",
                            Description = "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality",
                            Price = 305.894089151124m,
                            ReleaseDate = new DateTime(2023, 4, 27, 17, 42, 14, 702, DateTimeKind.Local).AddTicks(5581),
                            Title = "Practical Frozen Computer"
                        },
                        new
                        {
                            Id = 47,
                            Barcode = "4",
                            Description = "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients",
                            Price = 778.911179241683m,
                            ReleaseDate = new DateTime(2022, 12, 31, 12, 41, 49, 4, DateTimeKind.Local).AddTicks(8732),
                            Title = "Rustic Wooden Mouse"
                        },
                        new
                        {
                            Id = 48,
                            Barcode = "2",
                            Description = "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart",
                            Price = 318.709401070936m,
                            ReleaseDate = new DateTime(2023, 2, 12, 9, 34, 6, 430, DateTimeKind.Local).AddTicks(8379),
                            Title = "Handcrafted Metal Mouse"
                        },
                        new
                        {
                            Id = 49,
                            Barcode = "6",
                            Description = "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients",
                            Price = 463.195345650052m,
                            ReleaseDate = new DateTime(2023, 3, 28, 14, 16, 10, 32, DateTimeKind.Local).AddTicks(7597),
                            Title = "Handcrafted Rubber Salad"
                        },
                        new
                        {
                            Id = 50,
                            Barcode = "6",
                            Description = "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support",
                            Price = 717.609017980569m,
                            ReleaseDate = new DateTime(2023, 8, 15, 3, 25, 9, 212, DateTimeKind.Local).AddTicks(6352),
                            Title = "Incredible Plastic Shoes"
                        });
                });

            modelBuilder.Entity("P06Shop.Shared.Shop.OrderProduct", b =>
                {
                    b.HasOne("P06Shop.Shared.Shop.Order", "Order")
                        .WithMany("OrderProducts")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("P06Shop.Shared.Shop.Product", "Product")
                        .WithMany("OrderProducts")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("P06Shop.Shared.Shop.Order", b =>
                {
                    b.Navigation("OrderProducts");
                });

            modelBuilder.Entity("P06Shop.Shared.Shop.Product", b =>
                {
                    b.Navigation("OrderProducts");
                });
#pragma warning restore 612, 618
        }
    }
}
