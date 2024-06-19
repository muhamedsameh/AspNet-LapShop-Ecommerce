using LapShop.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Bl.Config
{
    public class VwSalesInvoiceConfiguration : IEntityTypeConfiguration<VwSalesInvoice>
    {
        public void Configure(EntityTypeBuilder<VwSalesInvoice> builder)
        {
            builder
                .HasNoKey()
                .ToView("VwSalesInvoices");

            builder.Property(e => e.DelivryDate).HasColumnType("datetime");
            builder.Property(e => e.InvoiceDate).HasColumnType("datetime");
        }
    }

}
