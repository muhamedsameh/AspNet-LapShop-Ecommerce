using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LapShop.Migrations
{
    /// <inheritdoc />
    public partial class addViewItemCategroy : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
                        CREATE VIEW VwItemCategory
                        AS
                        SELECT   dbo.TbItems.ItemId, dbo.TbItems.SalesPrice, dbo.TbItems.CategoryId, dbo.TbItems.Gpu, dbo.TbItems.HardDisk, dbo.TbItems.RamSize, dbo.TbItems.Processor, dbo.TbItems.ItemTypeId, dbo.TbItems.ScreenSize, 
                                    dbo.TbItems.Weight, dbo.TbItems.OsId, dbo.TbItems.ScreenReslution, dbo.TbCategories.CategoryName
                        FROM    dbo.TbItems INNER JOIN
                                    dbo.TbCategories ON dbo.TbItems.CategoryId = dbo.TbCategories.CategoryId");


        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
