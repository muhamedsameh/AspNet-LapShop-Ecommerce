using Domains;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Bl.Config
{
    public class TbPagesConfiguration : IEntityTypeConfiguration<TbPages>
    {
        public void Configure(EntityTypeBuilder<TbPages> builder)
        {
            builder.ToTable("TbPages");
            builder.HasKey(e => e.PageId);

            builder.Property(e => e.CurrentState).HasDefaultValue<int>(1);
            builder.Property(e => e.CreatedBy).HasDefaultValue("");
            builder.Property(e => e.ImgName).HasDefaultValue("");
            builder.Property(e => e.MetaKeyWord).HasDefaultValue("");
            builder.Property(e => e.MetaDescription).HasDefaultValue("");

            builder.Property(e => e.Title).HasMaxLength(255);
            builder.Property(e => e.MetaKeyWord).HasMaxLength(255);
            builder.Property(e => e.MetaDescription).HasMaxLength(255);
            builder.Property(e => e.ImgName).HasMaxLength(255);
            builder.Property(e => e.CreatedBy).HasMaxLength(255);
            builder.Property(e => e.UpdatedBy).HasMaxLength(255);
        }
    }
}
