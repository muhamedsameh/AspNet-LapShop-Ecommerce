using LapShop.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Bl.Config
{
    public class TbSliderConfiguration : IEntityTypeConfiguration<TbSlider>
    {
        public void Configure(EntityTypeBuilder<TbSlider> builder)
        {
            builder.ToTable("TbSlider");
            builder.HasKey(e => e.SliderId);

            builder.Property(e => e.CurrentState).HasDefaultValue<int>(1);
            builder.Property(e => e.CreatedBy).HasDefaultValue("");

            builder.Property(e => e.Description).HasMaxLength(255);
            builder.Property(e => e.ImageName).HasMaxLength(255);
            builder.Property(e => e.Title).HasMaxLength(255);
        }
    }
}
