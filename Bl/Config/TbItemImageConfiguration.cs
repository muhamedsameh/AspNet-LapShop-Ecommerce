using LapShop.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Bl.Config
{
    public class TbItemImageConfiguration : IEntityTypeConfiguration<TbItemImage>
    {
        public void Configure(EntityTypeBuilder<TbItemImage> builder)
        {
            builder.HasKey(e => e.ImageId);

            builder.Property(e => e.ImageName).HasMaxLength(200);

            builder.HasOne(d => d.Item).WithMany(p => p.TbItemImages)
                .HasForeignKey(d => d.ItemId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TbItemImages_TbItems");
        }
    }
}
