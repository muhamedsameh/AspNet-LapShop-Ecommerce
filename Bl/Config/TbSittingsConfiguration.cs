using Domains;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Bl.Config
{
    public class TbSittingsConfiguration : IEntityTypeConfiguration<TbSittings>
    {
        public void Configure(EntityTypeBuilder<TbSittings> builder)
        {
            builder.ToTable("TbSittings");
            builder.HasKey(e => e.Id);

            builder.Property(e => e.UpdatedBy).HasMaxLength(255);
            builder.Property(e => e.InstaLink).HasMaxLength(255);
            builder.Property(e => e.YoutubeLink).HasMaxLength(255);
            builder.Property(e => e.LinkedinLink).HasMaxLength(255);
            builder.Property(e => e.FacebookLink).HasMaxLength(255);
            builder.Property(e => e.XLink).HasMaxLength(255);
            builder.Property(e => e.Email).HasMaxLength(255);
            builder.Property(e => e.LastPanner).HasMaxLength(255);
            builder.Property(e => e.MiddlePanner).HasMaxLength(255);
            builder.Property(e => e.HomeBackgroundImgName).HasMaxLength(255);
            builder.Property(e => e.Logo).HasMaxLength(255);
        }
    }
}
