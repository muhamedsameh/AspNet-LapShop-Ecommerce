using LapShop.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Bl.Config
{
    public class TbItemTypeConfiguration : IEntityTypeConfiguration<TbItemType>
    {
        public void Configure(EntityTypeBuilder<TbItemType> builder)
        {
            builder.HasKey(e => e.ItemTypeId);

            builder.Property(e => e.ItemTypeName).HasMaxLength(100);
        }
    }
}
