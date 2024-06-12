using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LapShop.Migrations
{
    /// <inheritdoc />
    public partial class addsittingcolumns : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "TbSittings",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "HomeBackgroundImgName",
                table: "TbSittings",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LastPanner",
                table: "TbSittings",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Location",
                table: "TbSittings",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "phoneNumber",
                table: "TbSittings",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "TbSittings");

            migrationBuilder.DropColumn(
                name: "HomeBackgroundImgName",
                table: "TbSittings");

            migrationBuilder.DropColumn(
                name: "LastPanner",
                table: "TbSittings");

            migrationBuilder.DropColumn(
                name: "Location",
                table: "TbSittings");

            migrationBuilder.DropColumn(
                name: "phoneNumber",
                table: "TbSittings");
        }
    }
}
