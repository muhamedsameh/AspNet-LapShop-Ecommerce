using LapShop.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Bl.Config
{
    public class TbSupplierConfiguration : IEntityTypeConfiguration<TbSupplier>
    {
        public void Configure(EntityTypeBuilder<TbSupplier> builder)
        {
            builder.HasKey(e => e.SupplierId).HasName("PK_TbSupplier");

            builder.Property(e => e.SupplierName).HasMaxLength(100);
        }
    }
}
