﻿// <auto-generated />
using System;
using L_L.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace L_L.Data.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("L_L.Data.Entities.Blog", b =>
                {
                    b.Property<int>("BlogId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("BlogId"));

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.Property<string>("content")
                        .HasColumnType("text");

                    b.Property<string>("description")
                        .HasColumnType("text");

                    b.Property<string>("status")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("thumbnail")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("title")
                        .HasColumnType("text");

                    b.HasKey("BlogId");

                    b.HasIndex("UserId");

                    b.ToTable("Blog");
                });

            modelBuilder.Entity("L_L.Data.Entities.BlogRating", b =>
                {
                    b.Property<int>("BlogRatingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("BlogRatingId"));

                    b.Property<int>("BlogId")
                        .HasColumnType("integer");

                    b.Property<int>("Rating")
                        .HasColumnType("integer");

                    b.Property<int>("TotalRating")
                        .HasColumnType("integer");

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("BlogRatingId");

                    b.HasIndex("BlogId");

                    b.HasIndex("UserId");

                    b.ToTable("BlogRating");
                });

            modelBuilder.Entity("L_L.Data.Entities.DeliveryInfo", b =>
                {
                    b.Property<int>("DeliveryInfoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("DeliveryInfoId"));

                    b.Property<DateTime?>("DeliveryDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("DeliveryLocaTion")
                        .HasColumnType("text");

                    b.Property<DateTime?>("ExpectedDeliveryDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime?>("ExpectedRecieveDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("LatDelivery")
                        .HasColumnType("text");

                    b.Property<string>("LatPickUp")
                        .HasColumnType("text");

                    b.Property<string>("LongDelivery")
                        .HasColumnType("text");

                    b.Property<string>("LongPickUp")
                        .HasColumnType("text");

                    b.Property<DateTime?>("OrderDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("PickUpLocation")
                        .HasColumnType("text");

                    b.Property<string>("ReceiverName")
                        .HasColumnType("text");

                    b.Property<string>("ReceiverPhone")
                        .HasColumnType("text");

                    b.Property<DateTime?>("RecieveDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("SenderName")
                        .HasColumnType("text");

                    b.Property<string>("SenderPhone")
                        .HasColumnType("text");

                    b.HasKey("DeliveryInfoId");

                    b.ToTable("DeliveryInfo");
                });

            modelBuilder.Entity("L_L.Data.Entities.Hub", b =>
                {
                    b.Property<int>("HubId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("HubId"));

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("RecipientId")
                        .HasColumnType("integer");

                    b.Property<int>("SenderId")
                        .HasColumnType("integer");

                    b.HasKey("HubId");

                    b.HasIndex("RecipientId");

                    b.HasIndex("SenderId");

                    b.ToTable("Hub");
                });

            modelBuilder.Entity("L_L.Data.Entities.IdentityCard", b =>
                {
                    b.Property<int>("IdentityCardId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("IdentityCardId"));

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.Property<string>("address")
                        .HasColumnType("text");

                    b.Property<string>("address_entities")
                        .HasColumnType("text");

                    b.Property<DateTime?>("dob")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime?>("doe")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("features")
                        .HasColumnType("text");

                    b.Property<string>("home")
                        .HasColumnType("text");

                    b.Property<string>("id")
                        .HasColumnType("text");

                    b.Property<string>("imageBack")
                        .HasColumnType("text");

                    b.Property<string>("imageFront")
                        .HasColumnType("text");

                    b.Property<DateTime?>("issue_date")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("name")
                        .HasColumnType("text");

                    b.Property<string>("nationality")
                        .HasColumnType("text");

                    b.Property<string>("sex")
                        .HasColumnType("text");

                    b.Property<string>("type")
                        .HasColumnType("text");

                    b.Property<string>("type_new")
                        .HasColumnType("text");

                    b.HasKey("IdentityCardId");

                    b.HasIndex("UserId");

                    b.ToTable("IdentityCard");
                });

            modelBuilder.Entity("L_L.Data.Entities.LicenseDriver", b =>
                {
                    b.Property<int>("LicenseDriverId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("LicenseDriverId"));

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.Property<string>("address")
                        .HasColumnType("text");

                    b.Property<string>("classLicense")
                        .HasColumnType("text");

                    b.Property<DateTime?>("date")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime?>("dob")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime?>("doe")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("id")
                        .HasColumnType("text");

                    b.Property<string>("imageBack")
                        .HasColumnType("text");

                    b.Property<string>("imageFront")
                        .HasColumnType("text");

                    b.Property<string>("name")
                        .HasColumnType("text");

                    b.Property<string>("nation")
                        .HasColumnType("text");

                    b.Property<string>("place_issue")
                        .HasColumnType("text");

                    b.Property<string>("type")
                        .HasColumnType("text");

                    b.HasKey("LicenseDriverId");

                    b.HasIndex("UserId");

                    b.ToTable("LicenseDriver");
                });

            modelBuilder.Entity("L_L.Data.Entities.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("OrderId"));

                    b.Property<int?>("DriverId")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("EndDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Notes")
                        .HasColumnType("text");

                    b.Property<int>("OrderCode")
                        .HasColumnType("integer");

                    b.Property<int?>("OrderCount")
                        .HasColumnType("integer");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<decimal?>("TotalAmount")
                        .IsRequired()
                        .HasColumnType("numeric");

                    b.HasKey("OrderId");

                    b.HasIndex("DriverId");

                    b.ToTable("Order");
                });

            modelBuilder.Entity("L_L.Data.Entities.OrderDetails", b =>
                {
                    b.Property<int>("OrderDetailId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("OrderDetailId"));

                    b.Property<int?>("DeliveryInfoId")
                        .HasColumnType("integer");

                    b.Property<decimal>("Distance")
                        .HasColumnType("numeric");

                    b.Property<DateTime?>("EndDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int?>("OrderDetailCode")
                        .HasColumnType("integer");

                    b.Property<int?>("OrderId")
                        .HasColumnType("integer");

                    b.Property<string>("PaymentMethod")
                        .HasColumnType("text");

                    b.Property<int?>("ProductId")
                        .HasColumnType("integer");

                    b.Property<int?>("SenderId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<decimal>("TotalPrice")
                        .HasColumnType("numeric");

                    b.Property<int?>("TruckId")
                        .HasColumnType("integer");

                    b.Property<int?>("VehicleTypeId")
                        .HasColumnType("integer");

                    b.Property<string>("reference")
                        .HasColumnType("text");

                    b.Property<string>("transactionDateTime")
                        .HasColumnType("text");

                    b.HasKey("OrderDetailId");

                    b.HasIndex("DeliveryInfoId");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.HasIndex("SenderId");

                    b.HasIndex("TruckId");

                    b.ToTable("OrderDetails");
                });

            modelBuilder.Entity("L_L.Data.Entities.OrderTracking", b =>
                {
                    b.Property<int>("OrderTrackingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("OrderTrackingId"));

                    b.Property<string>("ConfirmImage")
                        .HasColumnType("text");

                    b.Property<DateTime?>("DeliveryConfirmedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<bool>("IsDelivered")
                        .HasColumnType("boolean");

                    b.Property<string>("Location")
                        .HasColumnType("text");

                    b.Property<int>("OrderId")
                        .HasColumnType("integer");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("OrderTrackingId");

                    b.HasIndex("OrderId");

                    b.ToTable("OrderTracking");
                });

            modelBuilder.Entity("L_L.Data.Entities.PackageType", b =>
                {
                    b.Property<int>("PackageTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("PackageTypeId"));

                    b.Property<decimal>("HeightMax")
                        .HasColumnType("decimal(19, 2)");

                    b.Property<decimal>("HeightMin")
                        .HasColumnType("decimal(19, 2)");

                    b.Property<decimal>("LengthMax")
                        .HasColumnType("decimal(19, 2)");

                    b.Property<decimal>("LengthMin")
                        .HasColumnType("decimal(19, 2)");

                    b.Property<int>("VehicleRangeMax")
                        .HasColumnType("integer");

                    b.Property<int>("VehicleRangeMin")
                        .HasColumnType("integer");

                    b.Property<decimal>("WeightLimit")
                        .HasColumnType("decimal(19, 2)");

                    b.Property<decimal>("WidthMax")
                        .HasColumnType("decimal(19, 2)");

                    b.Property<decimal>("WidthMin")
                        .HasColumnType("decimal(19, 2)");

                    b.HasKey("PackageTypeId");

                    b.ToTable("PackageType");
                });

            modelBuilder.Entity("L_L.Data.Entities.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("ProductId"));

                    b.Property<string>("Image")
                        .HasColumnType("text");

                    b.Property<string>("ProductDescription")
                        .HasColumnType("text");

                    b.Property<string>("ProductName")
                        .HasColumnType("text");

                    b.Property<int?>("Quantity")
                        .HasColumnType("integer");

                    b.Property<int?>("SenderId")
                        .HasColumnType("integer");

                    b.Property<string>("TotalDismension")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("TypeProduct")
                        .HasColumnType("text");

                    b.Property<string>("Weight")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("ProductId");

                    b.ToTable("Product");
                });

            modelBuilder.Entity("L_L.Data.Entities.ServiceCost", b =>
                {
                    b.Property<int>("ServiceCostId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("ServiceCostId"));

                    b.Property<string>("Amount")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("OrderDetailId")
                        .HasColumnType("integer");

                    b.Property<int>("VehicleTypeId")
                        .HasColumnType("integer");

                    b.HasKey("ServiceCostId");

                    b.HasIndex("OrderDetailId");

                    b.ToTable("ServiceCost");
                });

            modelBuilder.Entity("L_L.Data.Entities.ShippingRate", b =>
                {
                    b.Property<int>("RateId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("RateId"));

                    b.Property<int>("DistanceFrom")
                        .HasColumnType("integer");

                    b.Property<int?>("DistanceTo")
                        .HasColumnType("integer");

                    b.Property<decimal>("RatePerKM")
                        .HasColumnType("decimal(19, 2)");

                    b.Property<int>("VehicleTypeId")
                        .HasColumnType("integer");

                    b.HasKey("RateId");

                    b.HasIndex("VehicleTypeId");

                    b.ToTable("ShippingRate");
                });

            modelBuilder.Entity("L_L.Data.Entities.Transaction", b =>
                {
                    b.Property<int>("TransactionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("TransactionId"));

                    b.Property<int>("AdminId")
                        .HasColumnType("integer");

                    b.Property<decimal?>("Amount")
                        .HasColumnType("numeric");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<int>("DriverId")
                        .HasColumnType("integer");

                    b.Property<string>("Note")
                        .HasColumnType("text");

                    b.HasKey("TransactionId");

                    b.HasIndex("AdminId");

                    b.HasIndex("DriverId");

                    b.ToTable("Transaction");
                });

            modelBuilder.Entity("L_L.Data.Entities.Truck", b =>
                {
                    b.Property<int>("TruckId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("TruckId"));

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<decimal>("DimensionsHeight")
                        .HasColumnType("numeric");

                    b.Property<decimal>("DimensionsLength")
                        .HasColumnType("numeric");

                    b.Property<decimal>("DimensionsWidth")
                        .HasColumnType("numeric");

                    b.Property<string>("EngineNumber")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("FrameNumber")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("LoadCapacity")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Manufacturer")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("PlateCode")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int?>("TotalBill")
                        .HasColumnType("integer");

                    b.Property<string>("TruckName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.Property<string>("VehicleModel")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("VehicleTypeId")
                        .HasColumnType("integer");

                    b.HasKey("TruckId");

                    b.HasIndex("UserId");

                    b.HasIndex("VehicleTypeId");

                    b.ToTable("Truck");
                });

            modelBuilder.Entity("L_L.Data.Entities.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("UserId"));

                    b.Property<string>("AccountBalance")
                        .HasColumnType("text");

                    b.Property<string>("Address")
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.Property<string>("Avatar")
                        .HasColumnType("text");

                    b.Property<string>("Bank")
                        .HasColumnType("text");

                    b.Property<DateTime?>("BirthDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("City")
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<string>("CreateBy")
                        .HasColumnType("text");

                    b.Property<DateTimeOffset?>("CreateDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.Property<string>("FullName")
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<string>("Gender")
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<string>("ModifyBy")
                        .HasColumnType("text");

                    b.Property<DateTimeOffset?>("ModifyDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("OTPCode")
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<string>("PhoneNumber")
                        .HasMaxLength(15)
                        .HasColumnType("character varying(15)");

                    b.Property<string>("QRCode")
                        .HasColumnType("text");

                    b.Property<string>("RefreshToken")
                        .HasColumnType("text");

                    b.Property<int>("RoleID")
                        .HasColumnType("integer");

                    b.Property<string>("STK")
                        .HasColumnType("text");

                    b.Property<string>("Status")
                        .HasColumnType("text");

                    b.Property<string>("TypeLogin")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.HasKey("UserId");

                    b.HasIndex("RoleID");

                    b.ToTable("User");
                });

            modelBuilder.Entity("L_L.Data.Entities.UserRole", b =>
                {
                    b.Property<int>("RoleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("RoleId"));

                    b.Property<string>("RoleName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.HasKey("RoleId");

                    b.ToTable("UserRole");
                });

            modelBuilder.Entity("L_L.Data.Entities.VehiclePackageRelation", b =>
                {
                    b.Property<int>("VehicleTypeId")
                        .HasColumnType("integer");

                    b.Property<int>("PackageTypeId")
                        .HasColumnType("integer");

                    b.Property<int>("RelationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("RelationId"));

                    b.HasKey("VehicleTypeId", "PackageTypeId");

                    b.HasIndex("PackageTypeId");

                    b.ToTable("VehiclePackageRelation", (string)null);
                });

            modelBuilder.Entity("L_L.Data.Entities.VehicleType", b =>
                {
                    b.Property<int>("VehicleTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("VehicleTypeId"));

                    b.Property<decimal>("BaseRate")
                        .HasColumnType("decimal(19, 2)");

                    b.Property<string>("VehicleTypeName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.HasKey("VehicleTypeId");

                    b.ToTable("VehicleType");
                });

            modelBuilder.Entity("L_L.Data.Entities.Blog", b =>
                {
                    b.HasOne("L_L.Data.Entities.User", "UserBlog")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("UserBlog");
                });

            modelBuilder.Entity("L_L.Data.Entities.BlogRating", b =>
                {
                    b.HasOne("L_L.Data.Entities.Blog", "BlogRate")
                        .WithMany()
                        .HasForeignKey("BlogId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("L_L.Data.Entities.User", "UserRate")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BlogRate");

                    b.Navigation("UserRate");
                });

            modelBuilder.Entity("L_L.Data.Entities.Hub", b =>
                {
                    b.HasOne("L_L.Data.Entities.User", "Recipient")
                        .WithMany()
                        .HasForeignKey("RecipientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("L_L.Data.Entities.User", "Sender")
                        .WithMany()
                        .HasForeignKey("SenderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Recipient");

                    b.Navigation("Sender");
                });

            modelBuilder.Entity("L_L.Data.Entities.IdentityCard", b =>
                {
                    b.HasOne("L_L.Data.Entities.User", "UserIdentityCard")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("UserIdentityCard");
                });

            modelBuilder.Entity("L_L.Data.Entities.LicenseDriver", b =>
                {
                    b.HasOne("L_L.Data.Entities.User", "UserLicense")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("UserLicense");
                });

            modelBuilder.Entity("L_L.Data.Entities.Order", b =>
                {
                    b.HasOne("L_L.Data.Entities.User", "OrderDriver")
                        .WithMany()
                        .HasForeignKey("DriverId");

                    b.Navigation("OrderDriver");
                });

            modelBuilder.Entity("L_L.Data.Entities.OrderDetails", b =>
                {
                    b.HasOne("L_L.Data.Entities.DeliveryInfo", "DeliveryInfoDetail")
                        .WithMany()
                        .HasForeignKey("DeliveryInfoId");

                    b.HasOne("L_L.Data.Entities.Order", "OrderInfo")
                        .WithMany()
                        .HasForeignKey("OrderId");

                    b.HasOne("L_L.Data.Entities.Product", "ProductInfo")
                        .WithMany()
                        .HasForeignKey("ProductId");

                    b.HasOne("L_L.Data.Entities.User", "UserOrder")
                        .WithMany()
                        .HasForeignKey("SenderId");

                    b.HasOne("L_L.Data.Entities.Truck", "TruckInfo")
                        .WithMany()
                        .HasForeignKey("TruckId");

                    b.Navigation("DeliveryInfoDetail");

                    b.Navigation("OrderInfo");

                    b.Navigation("ProductInfo");

                    b.Navigation("TruckInfo");

                    b.Navigation("UserOrder");
                });

            modelBuilder.Entity("L_L.Data.Entities.OrderTracking", b =>
                {
                    b.HasOne("L_L.Data.Entities.Order", "OrderInfo")
                        .WithMany()
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("OrderInfo");
                });

            modelBuilder.Entity("L_L.Data.Entities.ServiceCost", b =>
                {
                    b.HasOne("L_L.Data.Entities.OrderDetails", "OrderDetail")
                        .WithMany()
                        .HasForeignKey("OrderDetailId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("OrderDetail");
                });

            modelBuilder.Entity("L_L.Data.Entities.ShippingRate", b =>
                {
                    b.HasOne("L_L.Data.Entities.VehicleType", "VehicleType")
                        .WithMany("ShippingRates")
                        .HasForeignKey("VehicleTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("VehicleType");
                });

            modelBuilder.Entity("L_L.Data.Entities.Transaction", b =>
                {
                    b.HasOne("L_L.Data.Entities.User", "Admin")
                        .WithMany()
                        .HasForeignKey("AdminId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("L_L.Data.Entities.User", "Driver")
                        .WithMany()
                        .HasForeignKey("DriverId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Admin");

                    b.Navigation("Driver");
                });

            modelBuilder.Entity("L_L.Data.Entities.Truck", b =>
                {
                    b.HasOne("L_L.Data.Entities.User", "TruckUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("L_L.Data.Entities.VehicleType", "TruckType")
                        .WithMany()
                        .HasForeignKey("VehicleTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TruckType");

                    b.Navigation("TruckUser");
                });

            modelBuilder.Entity("L_L.Data.Entities.User", b =>
                {
                    b.HasOne("L_L.Data.Entities.UserRole", "UserRole")
                        .WithMany()
                        .HasForeignKey("RoleID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("UserRole");
                });

            modelBuilder.Entity("L_L.Data.Entities.VehiclePackageRelation", b =>
                {
                    b.HasOne("L_L.Data.Entities.PackageType", "PackageType")
                        .WithMany("VehiclePackageRelations")
                        .HasForeignKey("PackageTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_VehiclePackageRelation2");

                    b.HasOne("L_L.Data.Entities.VehicleType", "VehicleType")
                        .WithMany("VehiclePackageRelations")
                        .HasForeignKey("VehicleTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_VehiclePackageRelation1");

                    b.Navigation("PackageType");

                    b.Navigation("VehicleType");
                });

            modelBuilder.Entity("L_L.Data.Entities.PackageType", b =>
                {
                    b.Navigation("VehiclePackageRelations");
                });

            modelBuilder.Entity("L_L.Data.Entities.VehicleType", b =>
                {
                    b.Navigation("ShippingRates");

                    b.Navigation("VehiclePackageRelations");
                });
#pragma warning restore 612, 618
        }
    }
}
