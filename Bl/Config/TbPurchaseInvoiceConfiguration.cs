using LapShop.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Bl.Config
{
    public class TbPurchaseInvoiceConfiguration : IEntityTypeConfiguration<TbPurchaseInvoice>
    {
        public void Configure(EntityTypeBuilder<TbPurchaseInvoice> builder)
        {
            builder.HasKey(e => e.InvoiceId);

            builder.Property(e => e.InvoiceDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");

            builder.HasOne(d => d.Supplier).WithMany(p => p.TbPurchaseInvoices)
                .HasForeignKey(d => d.SupplierId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TbPurchaseInvoices_TbSuppliers");
        }
    }
}
