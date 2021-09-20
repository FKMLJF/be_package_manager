using Microsoft.EntityFrameworkCore.Migrations;

namespace PackageManagerAPI.Migrations
{
    public partial class FixType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ProductQuantityUnit",
                table: "Products",
                type: "nvarchar(50)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)");

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "OrderId", "ProductName", "ProductPrice", "ProductQuantity", "ProductQuantityUnit" },
                values: new object[] { 1, null, "23423", 1000.0, 1, "Db" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1);

            migrationBuilder.AlterColumn<string>(
                name: "ProductQuantityUnit",
                table: "Products",
                type: "nvarchar(50)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldNullable: true);
        }
    }
}
