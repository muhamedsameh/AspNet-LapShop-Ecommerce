using LapShop.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Bl.Config
{
    public class TbCustomerConfiguration : IEntityTypeConfiguration<TbCustomer>
    {
        public void Configure(EntityTypeBuilder<TbCustomer> builder)
        {
            builder.HasKey(e => e.CustomerId);

            builder.Property(e => e.CustomerName).HasMaxLength(100);
        }
    }
}
