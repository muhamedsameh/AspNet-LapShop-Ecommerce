using LapShop.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Bl.Config
{
    public class TbSalesInvoiceConfiguration : IEntityTypeConfiguration<TbSalesInvoice>
    {
        public void Configure(EntityTypeBuilder<TbSalesInvoice> builder)
        {
            builder.HasKey(e => e.InvoiceId);

            builder.Property(e => e.CurrentState).HasDefaultValue<int>(1);
            builder.Property(e => e.CreatedBy).HasDefaultValue("");
            builder.Property(e => e.DelivryDate).HasColumnType("datetime");
            builder.Property(e => e.InvoiceDate).HasDefaultValueSql("(getdate())").HasColumnType("datetime");

            builder.Property(e => e.CreatedBy).HasMaxLength(255);
            builder.Property(e => e.UpdatedBy).HasMaxLength(255);
        }
    }
}
