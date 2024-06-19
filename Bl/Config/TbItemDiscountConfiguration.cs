using LapShop.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Bl.Config
{
    public class TbItemDiscountConfiguration : IEntityTypeConfiguration<TbItemDiscount>
    {
        public void Configure(EntityTypeBuilder<TbItemDiscount> builder)
        {
            builder.HasKey(e => e.ItemDiscountId);

            builder.ToTable("TbItemDiscount");

            builder.HasIndex(e => e.ItemId, "IX_TbItemDiscount_ItemId");

            builder.Property(e => e.DiscountPercent).HasColumnType("decimal(18, 2)");

            builder.HasOne(d => d.Item).WithMany(p => p.TbItemDiscounts)
                .HasForeignKey(d => d.ItemId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TbItemDiscounts_TbItems");
        }
    }
}
