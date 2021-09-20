using Microsoft.EntityFrameworkCore.Migrations;

namespace PackageManagerAPI.Migrations
{
    public partial class RemoveModelAttributes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProductQuantity",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "ProductQuantityUnit",
                table: "Products");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProductQuantity",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ProductQuantityUnit",
                table: "Products",
                type: "nvarchar(50)",
                nullable: true);
        }
    }
}
