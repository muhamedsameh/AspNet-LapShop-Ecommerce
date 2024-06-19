using LapShop.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Bl.Config
{
    public class VwItemCategoriesConfiguration : IEntityTypeConfiguration<VwItemCategories>
    {
        public void Configure(EntityTypeBuilder<VwItemCategories> builder)
        {
            builder
                .HasNoKey()
                .ToView("VwItemCategory");
        }
    }

}
