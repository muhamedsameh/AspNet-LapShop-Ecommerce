using LapShop.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Bl.Config
{
    public class TbCashTransacionConfiguration : IEntityTypeConfiguration<TbCashTransacion>
    {
        public void Configure(EntityTypeBuilder<TbCashTransacion> builder)
        {
            builder.HasKey(e => e.CashTransactionId);

            builder.ToTable("TbCashTransacion");

            builder.Property(e => e.CashDate).HasColumnType("datetime");
            builder.Property(e => e.CashValue).HasColumnType("decimal(8, 2)");
        }
    }
}
