﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProductService.API.Context;

#nullable disable

namespace ProductService.API.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20231203005337_AddProductData")]
    partial class AddProductData
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ProductService.API.Models.ColorOption", b =>
                {
                    b.Property<int>("ColorOptionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ColorOptionId"));

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("ColorOptionId");

                    b.HasIndex("ProductId");

                    b.ToTable("ColorOptions");

                    b.HasData(
                        new
                        {
                            ColorOptionId = 1,
                            Color = "green",
                            Image = "https://i.ibb.co/HYLB0HY/product8.png",
                            ProductId = 1,
                            Quantity = 1
                        },
                        new
                        {
                            ColorOptionId = 2,
                            Color = "red",
                            Image = "https://i.ibb.co/q7BzPCd/product9.png",
                            ProductId = 1,
                            Quantity = 1
                        },
                        new
                        {
                            ColorOptionId = 3,
                            Color = "blue",
                            Image = "https://i.ibb.co/Ttnm3Y1/product7.png",
                            ProductId = 1,
                            Quantity = 1
                        },
                        new
                        {
                            ColorOptionId = 4,
                            Color = "green",
                            Image = "https://i.ibb.co/Qdf0vcX/product6.png",
                            ProductId = 2,
                            Quantity = 1
                        },
                        new
                        {
                            ColorOptionId = 5,
                            Color = "red",
                            Image = "https://i.ibb.co/DW63yV8/product10.png",
                            ProductId = 2,
                            Quantity = 1
                        },
                        new
                        {
                            ColorOptionId = 6,
                            Color = "blue",
                            Image = "https://i.ibb.co/Y04d07J/product5.png",
                            ProductId = 2,
                            Quantity = 1
                        },
                        new
                        {
                            ColorOptionId = 7,
                            Color = "green",
                            Image = "https://i.ibb.co/Qdf0vcX/product6.png",
                            ProductId = 3,
                            Quantity = 1
                        },
                        new
                        {
                            ColorOptionId = 8,
                            Color = "red",
                            Image = "https://i.ibb.co/Ttnm3Y1/product7.png",
                            ProductId = 3,
                            Quantity = 1
                        },
                        new
                        {
                            ColorOptionId = 9,
                            Color = "blue",
                            Image = "https://i.ibb.co/HYLB0HY/product8.png",
                            ProductId = 3,
                            Quantity = 1
                        },
                        new
                        {
                            ColorOptionId = 10,
                            Color = "green",
                            Image = "https://i.ibb.co/1r601Rn/product3.png",
                            ProductId = 4,
                            Quantity = 1
                        },
                        new
                        {
                            ColorOptionId = 11,
                            Color = "red",
                            Image = "https://i.ibb.co/q7BzPCd/product9.png",
                            ProductId = 4,
                            Quantity = 1
                        },
                        new
                        {
                            ColorOptionId = 12,
                            Color = "blue",
                            Image = "https://i.ibb.co/Y04d07J/product5.png",
                            ProductId = 4,
                            Quantity = 1
                        },
                        new
                        {
                            ColorOptionId = 13,
                            Color = "green",
                            Image = "https://i.ibb.co/DW63yV8/product10.png",
                            ProductId = 5,
                            Quantity = 1
                        },
                        new
                        {
                            ColorOptionId = 14,
                            Color = "red",
                            Image = "https://i.ibb.co/q7BzPCd/product9.png",
                            ProductId = 5,
                            Quantity = 1
                        },
                        new
                        {
                            ColorOptionId = 15,
                            Color = "blue",
                            Image = "https://i.ibb.co/KKbNbV6/product2.png",
                            ProductId = 5,
                            Quantity = 1
                        },
                        new
                        {
                            ColorOptionId = 16,
                            Color = "green",
                            Image = "https://i.ibb.co/Ttnm3Y1/product7.png",
                            ProductId = 6,
                            Quantity = 1
                        },
                        new
                        {
                            ColorOptionId = 17,
                            Color = "red",
                            Image = "https://i.ibb.co/HYLB0HY/product8.png",
                            ProductId = 6,
                            Quantity = 1
                        },
                        new
                        {
                            ColorOptionId = 18,
                            Color = "blue",
                            Image = "https://i.ibb.co/q7BzPCd/product9.png",
                            ProductId = 6,
                            Quantity = 1
                        },
                        new
                        {
                            ColorOptionId = 19,
                            Color = "green",
                            Image = "https://i.ibb.co/KKbNbV6/product2.png",
                            ProductId = 7,
                            Quantity = 1
                        },
                        new
                        {
                            ColorOptionId = 20,
                            Color = "red",
                            Image = "https://i.ibb.co/HYLB0HY/product8.png",
                            ProductId = 7,
                            Quantity = 1
                        },
                        new
                        {
                            ColorOptionId = 21,
                            Color = "blue",
                            Image = "https://i.ibb.co/txFk7S2/product1.png",
                            ProductId = 7,
                            Quantity = 1
                        },
                        new
                        {
                            ColorOptionId = 22,
                            Color = "green",
                            Image = "https://i.ibb.co/q7BzPCd/product9.png",
                            ProductId = 8,
                            Quantity = 1
                        },
                        new
                        {
                            ColorOptionId = 23,
                            Color = "red",
                            Image = "https://i.ibb.co/HYLB0HY/product8.png",
                            ProductId = 8,
                            Quantity = 1
                        },
                        new
                        {
                            ColorOptionId = 24,
                            Color = "blue",
                            Image = "https://i.ibb.co/DW63yV8/product10.png",
                            ProductId = 8,
                            Quantity = 1
                        },
                        new
                        {
                            ColorOptionId = 25,
                            Color = "green",
                            Image = "https://i.ibb.co/Y04d07J/product5.png",
                            ProductId = 9,
                            Quantity = 1
                        },
                        new
                        {
                            ColorOptionId = 26,
                            Color = "red",
                            Image = "https://i.ibb.co/Qdf0vcX/product6.png",
                            ProductId = 9,
                            Quantity = 1
                        },
                        new
                        {
                            ColorOptionId = 27,
                            Color = "blue",
                            Image = "https://i.ibb.co/Ttnm3Y1/product7.png",
                            ProductId = 9,
                            Quantity = 1
                        },
                        new
                        {
                            ColorOptionId = 28,
                            Color = "green",
                            Image = "https://i.ibb.co/KKbNbV6/product2.png",
                            ProductId = 10,
                            Quantity = 1
                        },
                        new
                        {
                            ColorOptionId = 29,
                            Color = "red",
                            Image = "https://i.ibb.co/1r601Rn/product3.png",
                            ProductId = 10,
                            Quantity = 1
                        },
                        new
                        {
                            ColorOptionId = 30,
                            Color = "blue",
                            Image = "https://i.ibb.co/CJh01hw/product4.png",
                            ProductId = 10,
                            Quantity = 1
                        });
                });

            modelBuilder.Entity("ProductService.API.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductId"));

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("nvarchar(24)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Hover_Img")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Img")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Labels")
                        .IsRequired()
                        .HasColumnType("nvarchar(24)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.HasKey("ProductId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            Category = "Ceket",
                            Description = "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. \r\nThe point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters.",
                            HoverImg = "https://i.ibb.co/DW63yV8/product10.png",
                            Img = "https://i.ibb.co/txFk7S2/product1.png",
                            Labels = "Trending",
                            Name = "Green Dress For Woman",
                            Price = 38.0
                        },
                        new
                        {
                            ProductId = 2,
                            Category = "Fashion",
                            Description = "Vivamus suscipit tortor eget felis porttitor volutpat. Lorem ipsum dolor sit amet, consectetur adipiscing elit.\r\nProin eget tortor risus. Nulla porttitor accumsan tincidunt. Pellentesque in ipsum ProductId orci porta dapibus.",
                            HoverImg = "https://i.ibb.co/q7BzPCd/product9.png",
                            Img = "https://i.ibb.co/KKbNbV6/product2.png",
                            Labels = "Discount45Percent",
                            Name = "T-Shirt For Men",
                            Price = 72.0
                        },
                        new
                        {
                            ProductId = 3,
                            Category = "Fashion",
                            Description = "Praesent sapien massa, convallis a pellentesque nec, egestas non nisi. Vestibulum ante ipsum primis in \r\nfaucibus orci luctus et ultrices posuere cubilia Curae;",
                            HoverImg = "https://i.ibb.co/Ttnm3Y1/product7.png",
                            Img = "https://i.ibb.co/1r601Rn/product3.png",
                            Labels = "Discount50Percent",
                            Name = "V-Neck Dress",
                            Price = 34.0
                        },
                        new
                        {
                            ProductId = 4,
                            Category = "Ayakkabi",
                            Description = "Donec velit neque, auctor sit amet aliquam vel, ullamcorper sit amet ligula. Vestibulum ac diam sit \r\namet quam vehicula elementum sed sit amet dui. Quisque velit nisi, pretium ut lacinia in, elementum ProductId enim.",
                            HoverImg = "https://i.ibb.co/Qdf0vcX/product6.png",
                            Img = "https://i.ibb.co/CJh01hw/product4.png",
                            Labels = "Hot",
                            Name = "Maxi Dress",
                            Price = 43.0
                        },
                        new
                        {
                            ProductId = 5,
                            Category = "Jeans",
                            Description = "Donec sollicitudin molestie malesuada. Lorem ipsum dolor sit amet, consectetur adipiscing elit. \r\nVivamus suscipit tortor eget felis porttitor volutpat. Nulla quis lorem ut libero malesuada feugiat.",
                            HoverImg = "https://i.ibb.co/txFk7S2/product1.png",
                            Img = "https://i.ibb.co/Y04d07J/product5.png",
                            Labels = "Upcoming",
                            Name = "Fit-Flare Dress",
                            Price = 52.0
                        },
                        new
                        {
                            ProductId = 6,
                            Category = "Canta",
                            Description = "Nulla quis lorem ut libero malesuada feugiat. Quisque velit nisi, pretium ut lacinia in, elementum ProductId enim. \r\nCurabitur non nulla sit amet nisl tempus convallis quis ac lectus. Donec sollicitudin molestie malesuada",
                            HoverImg = "https://i.ibb.co/CJh01hw/product4.png",
                            Img = "https://i.ibb.co/Qdf0vcX/product6.png",
                            Labels = "Upcoming",
                            Name = "Midi Dress",
                            Price = 14.0
                        },
                        new
                        {
                            ProductId = 7,
                            Category = "Canta",
                            Description = "Donec rutrum congue leo eget malesuada. Curabitur arcu erat, accumsan ProductId imperdiet et, porttitor at sem. \r\nLorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque velit nisi, pretium ut lacinia in, elementum ProductId enim.",
                            HoverImg = "https://i.ibb.co/1r601Rn/product3.png",
                            Img = "https://i.ibb.co/Ttnm3Y1/product7.png",
                            Labels = "Trending",
                            Name = "Tulip Dress",
                            Price = 41.0
                        },
                        new
                        {
                            ProductId = 8,
                            Category = "Tshirts",
                            Description = "Nulla quis lorem ut libero malesuada feugiat. Donec sollicitudin molestie malesuada.\r\nLorem ipsum dolor sit amet, consectetur adipiscing elit. Donec rutrum congue leo eget malesuada.",
                            HoverImg = "https://i.ibb.co/KKbNbV6/product2.png",
                            Img = "https://i.ibb.co/HYLB0HY/product8.png",
                            Labels = "BestSelling",
                            Name = "Skater Dress",
                            Price = 21.0
                        },
                        new
                        {
                            ProductId = 9,
                            Category = "Ayakkabi",
                            Description = " Curabitur non nulla sit amet nisl tempus convallis quis ac lectus. \r\nCras ultricies ligula sed magna dictum porta. Donec sollicitudin molestie malesuada.",
                            HoverImg = "https://i.ibb.co/txFk7S2/product1.png",
                            Img = "https://i.ibb.co/q7BzPCd/product9.png",
                            Labels = "Popular",
                            Name = "Boho Tops for Girls",
                            Price = 46.0
                        },
                        new
                        {
                            ProductId = 10,
                            Category = "Canta",
                            Description = "Praesent sapien massa, convallis a pellentesque nec, egestas non nisi. Donec\r\nrutrum congue leo eget malesuada. Sed porttitor lectus nibh. Proin eget tortor risus. Curabitur aliquet quam ProductId dui posuere blandit. ",
                            HoverImg = "https://i.ibb.co/1r601Rn/product3.png",
                            Img = "https://i.ibb.co/DW63yV8/product10.png",
                            Labels = "TopChoice",
                            Name = "Skater Dress",
                            Price = 74.0
                        });
                });

            modelBuilder.Entity("ProductService.API.Models.Rating", b =>
                {
                    b.Property<int>("RatingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RatingId"));

                    b.Property<int>("Count")
                        .HasColumnType("int");

                    b.Property<int?>("ProductId")
                        .HasColumnType("int");

                    b.Property<double>("Rate")
                        .HasColumnType("float");

                    b.HasKey("RatingId");

                    b.HasIndex("ProductId")
                        .IsUnique()
                        .HasFilter("[ProductId] IS NOT NULL");

                    b.ToTable("Ratings");

                    b.HasData(
                        new
                        {
                            RatingId = 1,
                            Count = 30,
                            ProductId = 1,
                            Rate = 3.8999999999999999
                        },
                        new
                        {
                            RatingId = 2,
                            Count = 80,
                            ProductId = 2,
                            Rate = 3.2999999999999998
                        },
                        new
                        {
                            RatingId = 3,
                            Count = 156,
                            ProductId = 3,
                            Rate = 4.9000000000000004
                        },
                        new
                        {
                            RatingId = 4,
                            Count = 190,
                            ProductId = 4,
                            Rate = 1.8999999999999999
                        },
                        new
                        {
                            RatingId = 5,
                            Count = 20,
                            ProductId = 5,
                            Rate = 3.6000000000000001
                        },
                        new
                        {
                            RatingId = 6,
                            Count = 120,
                            ProductId = 6,
                            Rate = 3.8999999999999999
                        },
                        new
                        {
                            RatingId = 7,
                            Count = 10,
                            ProductId = 7,
                            Rate = 1.8999999999999999
                        },
                        new
                        {
                            RatingId = 8,
                            Count = 20,
                            ProductId = 8,
                            Rate = 2.8999999999999999
                        },
                        new
                        {
                            RatingId = 9,
                            Count = 120,
                            ProductId = 9,
                            Rate = 3.8999999999999999
                        },
                        new
                        {
                            RatingId = 10,
                            Count = 220,
                            ProductId = 10,
                            Rate = 3.8999999999999999
                        });
                });

            modelBuilder.Entity("ProductService.API.Models.ColorOption", b =>
                {
                    b.HasOne("ProductService.API.Models.Product", "Product")
                        .WithMany("Colors")
                        .HasForeignKey("ProductId");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("ProductService.API.Models.Rating", b =>
                {
                    b.HasOne("ProductService.API.Models.Product", "Product")
                        .WithOne("Rating")
                        .HasForeignKey("ProductService.API.Models.Rating", "ProductId");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("ProductService.API.Models.Product", b =>
                {
                    b.Navigation("Colors");

                    b.Navigation("Rating")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}