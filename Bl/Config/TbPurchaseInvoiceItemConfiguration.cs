using LapShop.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Bl.Config
{
    public class TbPurchaseInvoiceItemConfiguration : IEntityTypeConfiguration<TbPurchaseInvoiceItem>
    {
        public void Configure(EntityTypeBuilder<TbPurchaseInvoiceItem> builder)
        {
            builder.HasKey(e => e.InvoiceItemId);

            builder.Property(e => e.InvoiceItemId).ValueGeneratedNever();
            builder.Property(e => e.InvoicePrice).HasColumnType("decimal(8, 4)");
            builder.Property(e => e.Qty).HasDefaultValue(1.0);

            builder.HasOne(d => d.Invoice).WithMany(p => p.TbPurchaseInvoiceItems)
                .HasForeignKey(d => d.InvoiceId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TbPurchaseInvoiceItems_TbPurchaseInvoices");

            builder.HasOne(d => d.Item).WithMany(p => p.TbPurchaseInvoiceItems)
                .HasForeignKey(d => d.ItemId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TbPurchaseInvoiceItems_TbItems");
        }
    }
}
