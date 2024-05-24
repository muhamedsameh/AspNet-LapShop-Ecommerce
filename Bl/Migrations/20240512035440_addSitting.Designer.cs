﻿// <auto-generated />
using System;
using LapShop.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LapShop.Migrations
{
    [DbContext(typeof(LapShopContext))]
    [Migration("20240512035440_addSitting")]
    partial class addSitting
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Domains.TbSittings", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Discription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FacebookLink")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("InstaLink")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LinkedinLink")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Logo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MiddlePanner")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WebsiteName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("XLink")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("YoutubeLink")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TbSittings");
                });

            modelBuilder.Entity("LapShop.Models.TbBusinessInfo", b =>
                {
                    b.Property<int>("BusinessInfoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BusinessInfoId"));

                    b.Property<decimal>("Budget")
                        .HasColumnType("decimal(8, 2)");

                    b.Property<string>("BusinessCardNumber")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int>("CutomerId")
                        .HasColumnType("int");

                    b.Property<string>("OfficePhone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BusinessInfoId");

                    b.HasIndex(new[] { "CutomerId" }, "IX_TbBusinessInfo_CutomerId")
                        .IsUnique();

                    b.ToTable("TbBusinessInfo", (string)null);
                });

            modelBuilder.Entity("LapShop.Models.TbCashTransacion", b =>
                {
                    b.Property<int>("CashTransactionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CashTransactionId"));

                    b.Property<DateTime>("CashDate")
                        .HasColumnType("datetime");

                    b.Property<decimal>("CashValue")
                        .HasColumnType("decimal(8, 2)");

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.HasKey("CashTransactionId");

                    b.ToTable("TbCashTransacion", (string)null);
                });

            modelBuilder.Entity("LapShop.Models.TbCategory", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryId"));

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(max)")
                        .HasDefaultValue("");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("CurrentState")
                        .HasColumnType("int");

                    b.Property<string>("ImageName")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(max)")
                        .HasDefaultValue("");

                    b.Property<bool>("ShowInHomePage")
                        .HasColumnType("bit");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("CategoryId");

                    b.ToTable("TbCategories");
                });

            modelBuilder.Entity("LapShop.Models.TbCustomer", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CustomerId"));

                    b.Property<string>("CustomerName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("CustomerId");

                    b.ToTable("TbCustomers");
                });

            modelBuilder.Entity("LapShop.Models.TbItem", b =>
                {
                    b.Property<int>("ItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ItemId"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(max)")
                        .HasDefaultValue("");

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2020, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified));

                    b.Property<int>("CurrentState")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gpu")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HardDisk")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageName")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("ItemName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int?>("ItemTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.Property<int?>("OsId")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.Property<string>("Processor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("PurchasePrice")
                        .HasColumnType("decimal(8, 2)");

                    b.Property<int?>("RamSize")
                        .HasColumnType("int");

                    b.Property<decimal>("SalesPrice")
                        .HasColumnType("decimal(8, 2)");

                    b.Property<string>("ScreenReslution")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ScreenSize")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Weight")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ItemId");

                    b.HasIndex("CategoryId");

                    b.HasIndex(new[] { "ItemTypeId" }, "IX_TbItems_ItemTypeId");

                    b.HasIndex(new[] { "OsId" }, "IX_TbItems_OsId");

                    b.ToTable("TbItems");
                });

            modelBuilder.Entity("LapShop.Models.TbItemDiscount", b =>
                {
                    b.Property<int>("ItemDiscountId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ItemDiscountId"));

                    b.Property<decimal>("DiscountPercent")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("ItemId")
                        .HasColumnType("int");

                    b.HasKey("ItemDiscountId");

                    b.HasIndex(new[] { "ItemId" }, "IX_TbItemDiscount_ItemId");

                    b.ToTable("TbItemDiscount", (string)null);
                });

            modelBuilder.Entity("LapShop.Models.TbItemImage", b =>
                {
                    b.Property<int>("ImageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ImageId"));

                    b.Property<string>("ImageName")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<int>("ItemId")
                        .HasColumnType("int");

                    b.HasKey("ImageId");

                    b.HasIndex("ItemId");

                    b.ToTable("TbItemImages");
                });

            modelBuilder.Entity("LapShop.Models.TbItemType", b =>
                {
                    b.Property<int>("ItemTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ItemTypeId"));

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("CurrentState")
                        .HasColumnType("int");

                    b.Property<string>("ImageName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ItemTypeName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("ItemTypeId");

                    b.ToTable("TbItemTypes");
                });

            modelBuilder.Entity("LapShop.Models.TbO", b =>
                {
                    b.Property<int>("OsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OsId"));

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("CurrentState")
                        .HasColumnType("int");

                    b.Property<string>("ImageName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OsName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<bool>("ShowInHomePage")
                        .HasColumnType("bit");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("OsId");

                    b.ToTable("TbOs");
                });

            modelBuilder.Entity("LapShop.Models.TbPurchaseInvoice", b =>
                {
                    b.Property<int>("InvoiceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("InvoiceId"));

                    b.Property<DateTime>("InvoiceDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<string>("Notes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SupplierId")
                        .HasColumnType("int");

                    b.HasKey("InvoiceId");

                    b.HasIndex("SupplierId");

                    b.ToTable("TbPurchaseInvoices");
                });

            modelBuilder.Entity("LapShop.Models.TbPurchaseInvoiceItem", b =>
                {
                    b.Property<int>("InvoiceItemId")
                        .HasColumnType("int");

                    b.Property<int>("InvoiceId")
                        .HasColumnType("int");

                    b.Property<decimal>("InvoicePrice")
                        .HasColumnType("decimal(8, 4)");

                    b.Property<int>("ItemId")
                        .HasColumnType("int");

                    b.Property<string>("Notes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Qty")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("float")
                        .HasDefaultValue(1.0);

                    b.HasKey("InvoiceItemId");

                    b.HasIndex("InvoiceId");

                    b.HasIndex("ItemId");

                    b.ToTable("TbPurchaseInvoiceItems");
                });

            modelBuilder.Entity("LapShop.Models.TbSalesInvoice", b =>
                {
                    b.Property<int>("InvoiceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("InvoiceId"));

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(max)")
                        .HasDefaultValue("");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("CurrentState")
                        .HasColumnType("int");

                    b.Property<Guid>("CustomerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DelivryDate")
                        .HasColumnType("datetime");

                    b.Property<int?>("DelivryManId")
                        .HasColumnType("int");

                    b.Property<DateTime>("InvoiceDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<string>("Notes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("InvoiceId");

                    b.ToTable("TbSalesInvoices");
                });

            modelBuilder.Entity("LapShop.Models.TbSalesInvoiceItem", b =>
                {
                    b.Property<int>("InvoiceItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("InvoiceItemId"));

                    b.Property<int>("InvoiceId")
                        .HasColumnType("int");

                    b.Property<decimal>("InvoicePrice")
                        .HasColumnType("decimal(8, 2)");

                    b.Property<int>("ItemId")
                        .HasColumnType("int");

                    b.Property<string>("Notes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Qty")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("float")
                        .HasDefaultValue(1.0);

                    b.HasKey("InvoiceItemId");

                    b.HasIndex("InvoiceId");

                    b.HasIndex("ItemId");

                    b.ToTable("TbSalesInvoiceItems");
                });

            modelBuilder.Entity("LapShop.Models.TbSlider", b =>
                {
                    b.Property<int>("SliderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SliderId"));

                    b.Property<string>("Description")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("ImageName")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Title")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("SliderId");

                    b.ToTable("TbSlider", (string)null);
                });

            modelBuilder.Entity("LapShop.Models.TbSupplier", b =>
                {
                    b.Property<int>("SupplierId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SupplierId"));

                    b.Property<string>("SupplierName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("SupplierId")
                        .HasName("PK_TbSupplier");

                    b.ToTable("TbSuppliers");
                });

            modelBuilder.Entity("LapShop.Models.VwItem", b =>
                {
                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("CurrentState")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gpu")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HardDisk")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageName")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<int>("ItemId")
                        .HasColumnType("int");

                    b.Property<string>("ItemName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int?>("ItemTypeId")
                        .HasColumnType("int");

                    b.Property<string>("ItemTypeName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int?>("OsId")
                        .HasColumnType("int");

                    b.Property<string>("OsName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Processor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("PurchasePrice")
                        .HasColumnType("decimal(8, 2)");

                    b.Property<int?>("RamSize")
                        .HasColumnType("int");

                    b.Property<decimal>("SalesPrice")
                        .HasColumnType("decimal(8, 2)");

                    b.Property<string>("ScreenReslution")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ScreenSize")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Weight")
                        .HasColumnType("nvarchar(max)");

                    b.ToTable((string)null);

                    b.ToView("VwItems", (string)null);
                });

            modelBuilder.Entity("LapShop.Models.VwItemCategories", b =>
                {
                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gpu")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HardDisk")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ItemId")
                        .HasColumnType("int");

                    b.Property<string>("ItemName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ItemTypeId")
                        .HasColumnType("int");

                    b.Property<int?>("OsId")
                        .HasColumnType("int");

                    b.Property<string>("Processor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("PurchasePrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("RamSize")
                        .HasColumnType("int");

                    b.Property<decimal>("SalesPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("ScreenReslution")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ScreenSize")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Weight")
                        .HasColumnType("nvarchar(max)");

                    b.ToTable((string)null);

                    b.ToView("VwItemCategory", (string)null);
                });

            modelBuilder.Entity("LapShop.Models.VwItemsOutOfInvoice", b =>
                {
                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<decimal?>("InvoicePrice")
                        .HasColumnType("decimal(8, 2)");

                    b.Property<string>("ItemName")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<decimal?>("PurchasePrice")
                        .HasColumnType("decimal(8, 2)");

                    b.ToTable((string)null);

                    b.ToView("VwItemsOutOfInvoices", (string)null);
                });

            modelBuilder.Entity("LapShop.Models.VwSalesInvoice", b =>
                {
                    b.Property<Guid>("CustomerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DelivryDate")
                        .HasColumnType("datetime");

                    b.Property<int?>("DelivryManId")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("InvoiceDate")
                        .HasColumnType("datetime");

                    b.Property<int>("InvoiceId")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Notes")
                        .HasColumnType("nvarchar(max)");

                    b.ToTable((string)null);

                    b.ToView("VwSalesInvoices", (string)null);
                });

            modelBuilder.Entity("TbCustomerItem", b =>
                {
                    b.Property<int>("ItemId")
                        .HasColumnType("int");

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.HasKey("ItemId", "CustomerId");

                    b.HasIndex(new[] { "CustomerId" }, "IX_TbCustomerItems_CustomerId");

                    b.ToTable("TbCustomerItems", (string)null);
                });

            modelBuilder.Entity("LapShop.Models.TbBusinessInfo", b =>
                {
                    b.HasOne("LapShop.Models.TbCustomer", "Cutomer")
                        .WithOne("TbBusinessInfo")
                        .HasForeignKey("LapShop.Models.TbBusinessInfo", "CutomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cutomer");
                });

            modelBuilder.Entity("LapShop.Models.TbItem", b =>
                {
                    b.HasOne("LapShop.Models.TbCategory", "Category")
                        .WithMany("TbItems")
                        .HasForeignKey("CategoryId")
                        .IsRequired()
                        .HasConstraintName("FK_TbItems_TbCategories");

                    b.HasOne("LapShop.Models.TbItemType", "ItemType")
                        .WithMany("TbItems")
                        .HasForeignKey("ItemTypeId")
                        .HasConstraintName("FK_TbItems_TbItemTypes");

                    b.HasOne("LapShop.Models.TbO", "Os")
                        .WithMany("TbItems")
                        .HasForeignKey("OsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_TbItems_TbOs");

                    b.Navigation("Category");

                    b.Navigation("ItemType");

                    b.Navigation("Os");
                });

            modelBuilder.Entity("LapShop.Models.TbItemDiscount", b =>
                {
                    b.HasOne("LapShop.Models.TbItem", "Item")
                        .WithMany("TbItemDiscounts")
                        .HasForeignKey("ItemId")
                        .IsRequired()
                        .HasConstraintName("FK_TbItemDiscounts_TbItems");

                    b.Navigation("Item");
                });

            modelBuilder.Entity("LapShop.Models.TbItemImage", b =>
                {
                    b.HasOne("LapShop.Models.TbItem", "Item")
                        .WithMany("TbItemImages")
                        .HasForeignKey("ItemId")
                        .IsRequired()
                        .HasConstraintName("FK_TbItemImages_TbItems");

                    b.Navigation("Item");
                });

            modelBuilder.Entity("LapShop.Models.TbPurchaseInvoice", b =>
                {
                    b.HasOne("LapShop.Models.TbSupplier", "Supplier")
                        .WithMany("TbPurchaseInvoices")
                        .HasForeignKey("SupplierId")
                        .IsRequired()
                        .HasConstraintName("FK_TbPurchaseInvoices_TbSuppliers");

                    b.Navigation("Supplier");
                });

            modelBuilder.Entity("LapShop.Models.TbPurchaseInvoiceItem", b =>
                {
                    b.HasOne("LapShop.Models.TbPurchaseInvoice", "Invoice")
                        .WithMany("TbPurchaseInvoiceItems")
                        .HasForeignKey("InvoiceId")
                        .IsRequired()
                        .HasConstraintName("FK_TbPurchaseInvoiceItems_TbPurchaseInvoices");

                    b.HasOne("LapShop.Models.TbItem", "Item")
                        .WithMany("TbPurchaseInvoiceItems")
                        .HasForeignKey("ItemId")
                        .IsRequired()
                        .HasConstraintName("FK_TbPurchaseInvoiceItems_TbItems");

                    b.Navigation("Invoice");

                    b.Navigation("Item");
                });

            modelBuilder.Entity("LapShop.Models.TbSalesInvoiceItem", b =>
                {
                    b.HasOne("LapShop.Models.TbSalesInvoice", "Invoice")
                        .WithMany("TbSalesInvoiceItems")
                        .HasForeignKey("InvoiceId")
                        .IsRequired()
                        .HasConstraintName("FK_TbSalesInvoiceItems_TbSalesInvoices");

                    b.HasOne("LapShop.Models.TbItem", "Item")
                        .WithMany("TbSalesInvoiceItems")
                        .HasForeignKey("ItemId")
                        .IsRequired()
                        .HasConstraintName("FK_TbSalesInvoiceItems_TbItems");

                    b.Navigation("Invoice");

                    b.Navigation("Item");
                });

            modelBuilder.Entity("TbCustomerItem", b =>
                {
                    b.HasOne("LapShop.Models.TbCustomer", null)
                        .WithMany()
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LapShop.Models.TbItem", null)
                        .WithMany()
                        .HasForeignKey("ItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("LapShop.Models.TbCategory", b =>
                {
                    b.Navigation("TbItems");
                });

            modelBuilder.Entity("LapShop.Models.TbCustomer", b =>
                {
                    b.Navigation("TbBusinessInfo");
                });

            modelBuilder.Entity("LapShop.Models.TbItem", b =>
                {
                    b.Navigation("TbItemDiscounts");

                    b.Navigation("TbItemImages");

                    b.Navigation("TbPurchaseInvoiceItems");

                    b.Navigation("TbSalesInvoiceItems");
                });

            modelBuilder.Entity("LapShop.Models.TbItemType", b =>
                {
                    b.Navigation("TbItems");
                });

            modelBuilder.Entity("LapShop.Models.TbO", b =>
                {
                    b.Navigation("TbItems");
                });

            modelBuilder.Entity("LapShop.Models.TbPurchaseInvoice", b =>
                {
                    b.Navigation("TbPurchaseInvoiceItems");
                });

            modelBuilder.Entity("LapShop.Models.TbSalesInvoice", b =>
                {
                    b.Navigation("TbSalesInvoiceItems");
                });

            modelBuilder.Entity("LapShop.Models.TbSupplier", b =>
                {
                    b.Navigation("TbPurchaseInvoices");
                });
#pragma warning restore 612, 618
        }
    }
}
