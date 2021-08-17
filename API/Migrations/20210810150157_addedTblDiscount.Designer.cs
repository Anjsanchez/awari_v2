﻿// <auto-generated />
using System;
using API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace API.Migrations
{
    [DbContext(typeof(resortDbContext))]
    [Migration("20210810150157_addedTblDiscount")]
    partial class addedTblDiscount
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("API.Models.Customer", b =>
                {
                    b.Property<Guid>("_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("birthday")
                        .HasColumnType("datetime2");

                    b.Property<float>("cardAmount")
                        .HasColumnType("real");

                    b.Property<DateTime>("createdDate")
                        .HasColumnType("datetime2");

                    b.Property<long>("customerid")
                        .HasColumnType("bigint");

                    b.Property<string>("emailAddress")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("firstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("isActive")
                        .HasColumnType("bit");

                    b.Property<string>("lastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<long>("mobile")
                        .HasColumnType("bigint");

                    b.Property<float>("points")
                        .HasColumnType("real");

                    b.Property<Guid>("userId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("createdBy");

                    b.HasKey("_id");

                    b.HasIndex("customerid")
                        .IsUnique();

                    b.HasIndex("userId");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("API.Models.Role", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Rolename")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("API.Models.RoomVariant", b =>
                {
                    b.Property<Guid>("_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("createdDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("isActive")
                        .HasColumnType("bit");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<Guid>("userId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("createdBy");

                    b.HasKey("_id");

                    b.HasIndex("userId");

                    b.ToTable("RoomVariants");
                });

            modelBuilder.Entity("API.Models.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("EmailAddress")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("isActive")
                        .HasColumnType("bit");

                    b.Property<byte>("isExportFlag")
                        .HasColumnType("tinyint");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("API.Models.functionality.Discount", b =>
                {
                    b.Property<Guid>("_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("createdDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("isActive")
                        .HasColumnType("bit");

                    b.Property<bool>("isByPercentage")
                        .HasColumnType("bit");

                    b.Property<bool>("isRequiredApproval")
                        .HasColumnType("bit");

                    b.Property<bool>("isRequiredCustomer")
                        .HasColumnType("bit");

                    b.Property<bool>("isRequiredId")
                        .HasColumnType("bit");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<Guid>("userId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("createdBy");

                    b.Property<int>("value")
                        .HasColumnType("int");

                    b.HasKey("_id");

                    b.HasIndex("userId");

                    b.ToTable("Discounts");
                });

            modelBuilder.Entity("API.Models.functionality.Payment", b =>
                {
                    b.Property<Guid>("_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("createdDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("isActive")
                        .HasColumnType("bit");

                    b.Property<bool>("isNeedRefNumber")
                        .HasColumnType("bit");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<Guid>("userId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("createdBy");

                    b.HasKey("_id");

                    b.HasIndex("userId");

                    b.ToTable("Payments");
                });

            modelBuilder.Entity("API.Models.products.Product", b =>
                {
                    b.Property<Guid>("_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<float>("costPrice")
                        .HasColumnType("real");

                    b.Property<DateTime>("createdDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("isActive")
                        .HasColumnType("bit");

                    b.Property<bool>("isActivityType")
                        .HasColumnType("bit");

                    b.Property<string>("longName")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<int>("numberOfServing")
                        .HasColumnType("int");

                    b.Property<Guid>("productCategoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<float>("sellingPrice")
                        .HasColumnType("real");

                    b.Property<string>("shortName")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<Guid>("userId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("createdBy");

                    b.HasKey("_id");

                    b.HasIndex("productCategoryId");

                    b.HasIndex("userId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("API.Models.products.ProductCategory", b =>
                {
                    b.Property<Guid>("_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("createdDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("isActive")
                        .HasColumnType("bit");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("userId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("createdBy");

                    b.HasKey("_id");

                    b.HasIndex("userId");

                    b.ToTable("ProductCategories");
                });

            modelBuilder.Entity("API.Models.rooms.Room", b =>
                {
                    b.Property<Guid>("_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("RoomVariantId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<float>("costPrice")
                        .HasColumnType("real");

                    b.Property<DateTime>("createdDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("isActive")
                        .HasColumnType("bit");

                    b.Property<bool>("isAllowExtraPax")
                        .HasColumnType("bit");

                    b.Property<bool>("isPerPaxRoomType")
                        .HasColumnType("bit");

                    b.Property<int>("numberOfRooms")
                        .HasColumnType("int");

                    b.Property<string>("roomLongName")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("searchName")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<Guid>("userId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("createdBy");

                    b.HasKey("_id");

                    b.HasIndex("RoomVariantId");

                    b.HasIndex("userId");

                    b.ToTable("Rooms");
                });

            modelBuilder.Entity("API.Models.rooms.RoomPricing", b =>
                {
                    b.Property<Guid>("_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("capacity")
                        .HasColumnType("int");

                    b.Property<DateTime>("createdDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("isActive")
                        .HasColumnType("bit");

                    b.Property<Guid>("roomId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("sellingPrice")
                        .HasColumnType("int");

                    b.Property<Guid>("userId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("createdBy");

                    b.HasKey("_id");

                    b.HasIndex("roomId");

                    b.HasIndex("userId");

                    b.ToTable("RoomPricings");
                });

            modelBuilder.Entity("API.Models.Customer", b =>
                {
                    b.HasOne("API.Models.User", "user")
                        .WithMany()
                        .HasForeignKey("userId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("user");
                });

            modelBuilder.Entity("API.Models.RoomVariant", b =>
                {
                    b.HasOne("API.Models.User", "user")
                        .WithMany()
                        .HasForeignKey("userId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("user");
                });

            modelBuilder.Entity("API.Models.User", b =>
                {
                    b.HasOne("API.Models.Role", "Role")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");
                });

            modelBuilder.Entity("API.Models.functionality.Discount", b =>
                {
                    b.HasOne("API.Models.User", "user")
                        .WithMany()
                        .HasForeignKey("userId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("user");
                });

            modelBuilder.Entity("API.Models.functionality.Payment", b =>
                {
                    b.HasOne("API.Models.User", "user")
                        .WithMany()
                        .HasForeignKey("userId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("user");
                });

            modelBuilder.Entity("API.Models.products.Product", b =>
                {
                    b.HasOne("API.Models.products.ProductCategory", "productCategory")
                        .WithMany()
                        .HasForeignKey("productCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("API.Models.User", "user")
                        .WithMany()
                        .HasForeignKey("userId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("productCategory");

                    b.Navigation("user");
                });

            modelBuilder.Entity("API.Models.products.ProductCategory", b =>
                {
                    b.HasOne("API.Models.User", "user")
                        .WithMany()
                        .HasForeignKey("userId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("user");
                });

            modelBuilder.Entity("API.Models.rooms.Room", b =>
                {
                    b.HasOne("API.Models.RoomVariant", "RoomVariant")
                        .WithMany()
                        .HasForeignKey("RoomVariantId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("API.Models.User", "user")
                        .WithMany()
                        .HasForeignKey("userId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("RoomVariant");

                    b.Navigation("user");
                });

            modelBuilder.Entity("API.Models.rooms.RoomPricing", b =>
                {
                    b.HasOne("API.Models.rooms.Room", "room")
                        .WithMany()
                        .HasForeignKey("roomId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("API.Models.User", "user")
                        .WithMany()
                        .HasForeignKey("userId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("room");

                    b.Navigation("user");
                });
#pragma warning restore 612, 618
        }
    }
}
