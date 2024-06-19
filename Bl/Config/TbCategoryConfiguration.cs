using LapShop.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Bl.Config
{
    public class TbCategoryConfiguration : IEntityTypeConfiguration<TbCategory>
    {
        public void Configure(EntityTypeBuilder<TbCategory> builder)
        {
            builder.HasKey(e => e.CategoryId);

            builder.Property(e => e.CategoryName).HasMaxLength(100);
            builder.Property(e => e.CreatedBy).HasDefaultValue("");
            builder.Property(e => e.ImageName).HasDefaultValue("");
        }
    }
}
