using LapShop.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Bl.Config
{
    public class TbSalesInvoiceItemConfiguration : IEntityTypeConfiguration<TbSalesInvoiceItem>
    {
        public void Configure(EntityTypeBuilder<TbSalesInvoiceItem> builder)
        {
            builder.HasKey(e => e.InvoiceItemId);

            builder.Property(e => e.InvoicePrice).HasColumnType("decimal(8, 2)");
            builder.Property(e => e.Qty).HasDefaultValue(1.0);

            builder.HasOne(d => d.Invoice).WithMany(p => p.TbSalesInvoiceItems)
                .HasForeignKey(d => d.InvoiceId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TbSalesInvoiceItems_TbSalesInvoices");

            builder.HasOne(d => d.Item).WithMany(p => p.TbSalesInvoiceItems)
                .HasForeignKey(d => d.ItemId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TbSalesInvoiceItems_TbItems");
        }
    }
}
