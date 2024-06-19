using System;
using Domains;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Bl;
using Bl.Config;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LapShop.Models;

public partial class LapShopContext : IdentityDbContext<ApplicationUser>
{
    public LapShopContext()
    {
    }

    public LapShopContext(DbContextOptions<LapShopContext> options)
        : base(options)
    {
    }

    public virtual DbSet<TbBusinessInfo> TbBusinessInfos { get; set; }

    public virtual DbSet<TbCashTransacion> TbCashTransacions { get; set; }

    public virtual DbSet<TbCategory> TbCategories { get; set; }

    public virtual DbSet<TbCustomer> TbCustomers { get; set; }

    public virtual DbSet<TbItem> TbItems { get; set; }

    public virtual DbSet<TbItemDiscount> TbItemDiscounts { get; set; }

    public virtual DbSet<TbItemImage> TbItemImages { get; set; }

    public virtual DbSet<TbItemType> TbItemTypes { get; set; }

    public virtual DbSet<TbO> TbOs { get; set; }

    public virtual DbSet<TbPages> TbPages { get; set; }

    public virtual DbSet<TbPurchaseInvoice> TbPurchaseInvoices { get; set; }

    public virtual DbSet<TbPurchaseInvoiceItem> TbPurchaseInvoiceItems { get; set; }

    public virtual DbSet<TbSalesInvoice> TbSalesInvoices { get; set; }

    public virtual DbSet<TbSalesInvoiceItem> TbSalesInvoiceItems { get; set; }

    public virtual DbSet<TbSittings> TbSittings { get; set; }

    public virtual DbSet<TbSlider> TbSliders { get; set; }

    public virtual DbSet<TbSupplier> TbSuppliers { get; set; }

    public virtual DbSet<VwItem> VwItems { get; set; }

    public virtual DbSet<VwItemCategories> VwItemCategory { get; set; }   

    public virtual DbSet<VwItemsOutOfInvoice> VwItemsOutOfInvoices { get; set; }

    public virtual DbSet<VwSalesInvoice> VwSalesInvoices { get; set; }
    
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {

        }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // asp.ent identity
        base.OnModelCreating(modelBuilder);
        OnModelCreatingPartial(modelBuilder);



        new TbPagesConfiguration().Configure(modelBuilder.Entity<TbPages>());

        new TbBusinessInfoConfiguration().Configure(modelBuilder.Entity<TbBusinessInfo>());

        new TbCashTransacionConfiguration().Configure(modelBuilder.Entity<TbCashTransacion>());

        new TbCategoryConfiguration().Configure(modelBuilder.Entity<TbCategory>());

        new TbCustomerConfiguration().Configure(modelBuilder.Entity<TbCustomer>());

        new TbItemConfiguration().Configure(modelBuilder.Entity<TbItem>());

        new TbItemDiscountConfiguration().Configure(modelBuilder.Entity<TbItemDiscount>());

        new TbItemImageConfiguration().Configure(modelBuilder.Entity<TbItemImage>());

        new TbItemTypeConfiguration().Configure(modelBuilder.Entity<TbItemType>());

        new TbOsConfiguration().Configure(modelBuilder.Entity<TbO>());

        new TbPurchaseInvoiceConfiguration().Configure(modelBuilder.Entity<TbPurchaseInvoice>());

        new TbPurchaseInvoiceItemConfiguration().Configure(modelBuilder.Entity<TbPurchaseInvoiceItem>());

        new TbSalesInvoiceConfiguration().Configure(modelBuilder.Entity<TbSalesInvoice>());

        new TbSalesInvoiceItemConfiguration().Configure(modelBuilder.Entity<TbSalesInvoiceItem>());

        new VwItemConfiguration().Configure(modelBuilder.Entity<VwItem>());

        new VwItemCategoriesConfiguration().Configure(modelBuilder.Entity<VwItemCategories>());

        new VwItemsOutOfInvoiceConfiguration().Configure(modelBuilder.Entity<VwItemsOutOfInvoice>());

        new VwSalesInvoiceConfiguration().Configure(modelBuilder.Entity<VwSalesInvoice>());

        new TbSittingsConfiguration().Configure(modelBuilder.Entity<TbSittings>());

        new TbSliderConfiguration().Configure(modelBuilder.Entity<TbSlider>());

        new TbSupplierConfiguration().Configure(modelBuilder.Entity<TbSupplier>());


    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
