using LapShop.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Bl.Config
{
    public class VwItemsOutOfInvoiceConfiguration : IEntityTypeConfiguration<VwItemsOutOfInvoice>
    {
        public void Configure(EntityTypeBuilder<VwItemsOutOfInvoice> builder)
        {
            builder
                .HasNoKey()
                .ToView("VwItemsOutOfInvoices");

            builder.Property(e => e.CategoryName).HasMaxLength(100);
            builder.Property(e => e.InvoicePrice).HasColumnType("decimal(8, 2)");
            builder.Property(e => e.ItemName).HasMaxLength(100);
            builder.Property(e => e.PurchasePrice).HasColumnType("decimal(8, 2)");
        }
    }

}
