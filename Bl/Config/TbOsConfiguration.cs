using LapShop.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Bl.Config
{
    public class TbOsConfiguration : IEntityTypeConfiguration<TbO>
    {
        public void Configure(EntityTypeBuilder<TbO> builder)
        {
            builder.HasKey(e => e.OsId);

            builder.Property(e => e.OsName).HasMaxLength(100);
        }
    }
}
