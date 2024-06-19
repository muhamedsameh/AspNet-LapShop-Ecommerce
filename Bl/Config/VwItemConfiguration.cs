using LapShop.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Bl.Config
{
    public class VwItemConfiguration : IEntityTypeConfiguration<VwItem>
    {
        public void Configure(EntityTypeBuilder<VwItem> builder)
        {
            builder
                .HasNoKey()
                .ToView("VwItems");

            builder.Property(e => e.CategoryName).HasMaxLength(100);
            builder.Property(e => e.ImageName).HasMaxLength(200);
            builder.Property(e => e.ItemName).HasMaxLength(100);
            builder.Property(e => e.ItemTypeName).HasMaxLength(100);
            builder.Property(e => e.OsName).HasMaxLength(100);
            builder.Property(e => e.PurchasePrice).HasColumnType("decimal(8, 2)");
            builder.Property(e => e.SalesPrice).HasColumnType("decimal(8, 2)");
        }
    }

}
