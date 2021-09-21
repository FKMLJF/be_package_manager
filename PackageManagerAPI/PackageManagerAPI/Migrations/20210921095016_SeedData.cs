using Microsoft.EntityFrameworkCore.Migrations;

namespace PackageManagerAPI.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "ProductName", "ProductPrice" },
                values: new object[,]
                {
                    { 1, "Samsung Galaxy S20 FE 128GB 6GB RAM Dual (SM-G780) Mobiltelefon", 155000.0 },
                    { 70, "Samsung Galaxy S10 Lite 128GB 8GB RAM Dual (G770F) Mobiltelefon", 176990.0 },
                    { 69, "Samsung Galaxy A11 32GB 2GB RAM Dual Mobiltelefon", 43550.0 },
                    { 68, "Samsung Galaxy S20 FE 5G 256GB 8GB RAM Dual (SM-G781) Mobiltelefon", 217390.0 },
                    { 67, "Samsung Galaxy A72 128GB 4GB RAM Dual Mobiltelefon", 142900.0 },
                    { 66, "Samsung Galaxy A32 5G 128GB 6GB RAM Dual (A326) Mobiltelefon", 90899.0 },
                    { 65, "Samsung Galaxy A52 128GB 4GB RAM Dual (A525F) Mobiltelefon", 119900.0 },
                    { 64, "Samsung Galaxy S10+ 512GB Dual G975 Mobiltelefon", 418190.0 },
                    { 63, "Samsung Galaxy S10 5G 256GB G977 Mobiltelefon", 198810.0 },
                    { 62, "Samsung Galaxy Note10 Lite 128GB 6GB RAM Dual (N770F) Mobiltelefon", 226300.0 },
                    { 71, "Samsung Galaxy A12 Nacho 64GB 4GB RAM Dual (SM-A127F) Mobiltelefon", 56200.0 },
                    { 61, "Samsung Galaxy S21+ 256GB 8GB RAM Dual (G996) Mobiltelefon", 294390.0 },
                    { 59, "Samsung Galaxy A52 128GB 8GB RAM Dual (A525F) Mobiltelefon", 130200.0 },
                    { 58, "Samsung Galaxy A42 5G 128GB 4GB RAM Dual (A426B) Mobiltelefon", 120900.0 },
                    { 57, "Samsung Galaxy A32 128GB 8GB RAM Dual (A325F) Mobiltelefon", 98000.0 },
                    { 56, "Samsung Galaxy M12 64GB 4GB RAM Dual (M127) Mobiltelefon", 57000.0 },
                    { 55, "Samsung Galaxy A32 5G 64GB 4GB RAM Dual (A326) Mobiltelefon", 86690.0 },
                    { 54, "Samsung Galaxy A20s 32GB 3GB RAM Dual (A207F) Mobiltelefon", 58800.0 },
                    { 53, "Samsung Galaxy A32 128GB 6GB RAM Dual (A325F) Mobiltelefon", 92000.0 },
                    { 52, "Samsung Galaxy M21 64GB 4GB RAM Dual (M215F) Mobiltelefon", 66990.0 },
                    { 51, "Samsung Galaxy S20 FE 256GB 8GB RAM Dual (SM-G780) Mobiltelefon", 195000.0 },
                    { 60, "Samsung Galaxy Note20 Ultra 256GB 8GB RAM Dual (N985) Mobiltelefon", 309000.0 },
                    { 72, "Samsung Galaxy Note20 5G 256GB 8GB RAM Dual (SM-N981) Mobiltelefon", 256740.0 },
                    { 73, "Samsung Galaxy A22 128GB 6GB RAM Dual (A225F) Mobiltelefon", 82000.0 },
                    { 74, "Samsung Galaxy S10 Lite 128GB 6GB RAM Dual (G770F) Mobiltelefon", 168890.0 },
                    { 95, "Samsung Galaxy M12 32GB 3GB RAM Dual (M127F) Mobiltelefon", 63900.0 },
                    { 94, "Samsung Galaxy A22 128GB 4GB RAM (SM-A225) Mobiltelefon", 75990.0 },
                    { 93, "Samsung Galaxy A22 128GB (A225F) Mobiltelefon", 79900.0 },
                    { 92, "Samsung Galaxy A02s 32GB Mobiltelefon", 58595.0 },
                    { 91, "Samsung Galaxy A22 5G 128GB Mobiltelefon", 95900.0 },
                    { 90, "Samsung Galaxy Xcover Pro 64GB Mobiltelefon", 180820.0 },
                    { 89, "Samsung Galaxy A02 32GB 2GB RAM Dual (A022F) Mobiltelefon", 49900.0 },
                    { 88, "Samsung Galaxy S10 5G 256GB Dual (G977) Mobiltelefon", 209950.0 },
                    { 87, "Samsung Galaxy S10e 128GB G970 Mobiltelefon", 217590.0 },
                    { 86, "Samsung Galaxy A52 5G 128GB 4GB RAM Dual (A526) Mobiltelefon", 159900.0 },
                    { 85, "Samsung Galaxy Note10+ 5G 256GB Dual (N976) Mobiltelefon", 275000.0 },
                    { 84, "Samsung Galaxy A32 128GB 4GB RAM (A325F) Mobiltelefon", 89900.0 },
                    { 83, "Samsung Galaxy A11 32GB 3GB RAM Dual Mobiltelefon", 48800.0 },
                    { 82, "Samsung Galaxy Note10+ 512GB Dual (SM-N975) Mobiltelefon", 402190.0 },
                    { 81, "Samsung Galaxy XCover 5 32GB Dual Mobiltelefon", 100990.0 },
                    { 80, "Samsung Galaxy S20 Ultra 5G 256GB 12GB RAM Dual Mobiltelefon", 355790.0 },
                    { 79, "Samsung Galaxy A12 Nacho 32GB 3GB RAM Dual (SM-A127F) Mobiltelefon", 49990.0 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "ProductName", "ProductPrice" },
                values: new object[,]
                {
                    { 78, "Samsung Galaxy Note10+ 5G 256GB (N976) Mobiltelefon", 362769.0 },
                    { 77, "Samsung Galaxy Xcover 4s (G398F) Mobiltelefon", 84999.0 },
                    { 76, "Samsung Galaxy A21s 128GB 3GB RAM Dual Mobiltelefon", 79990.0 },
                    { 75, "Samsung Galaxy M12 128GB 4GB RAM Dual (M127F) Mobiltelefon", 69090.0 },
                    { 50, "Samsung Galaxy A02s 32GB Dual (A025G) Mobiltelefon", 47000.0 },
                    { 96, "Samsung Galaxy A42 5G 128GB 4GB RAM (A426B) Mobiltelefon", 136360.0 },
                    { 49, "Samsung Galaxy Xcover 4s Dual (G398F) Mobiltelefon", 73590.0 },
                    { 47, "Samsung Galaxy Note10+ 256GB Dual N975F Mobiltelefon", 265000.0 },
                    { 21, "Samsung Galaxy S10e 128GB Dual G970 Mobiltelefon", 177989.0 },
                    { 20, "Samsung Galaxy A40 64GB Dual A405 Mobiltelefon", 97563.0 },
                    { 19, "Samsung Galaxy S20 128GB 8GB RAM Dual (G980F) Mobiltelefon", 249900.0 },
                    { 18, "Samsung Galaxy A52 5G 128GB 6GB RAM Dual (A526) Mobiltelefon", 139990.0 },
                    { 17, "Samsung Galaxy A22 5G 128GB 4GB RAM Dual (A226) Mobiltelefon", 83980.0 },
                    { 16, "Samsung Galaxy A71 128GB 6GB RAM Dual (A715F) Mobiltelefon", 159999.0 },
                    { 15, "Samsung Galaxy A22 128GB 4GB RAM Dual (A225) Mobiltelefon", 69890.0 },
                    { 14, "Samsung Galaxy S10 128GB Dual G973 Mobiltelefon", 182590.0 },
                    { 13, "Samsung Galaxy A51 128GB 4GB RAM Dual (A515F) Mobiltelefon", 109990.0 },
                    { 22, "Samsung Galaxy S20+ 128GB 8GB RAM Dual (G985F) Mobiltelefon", 235800.0 },
                    { 12, "Samsung Galaxy A32 5G 128GB 4GB RAM Dual (A326) Mobiltelefon", 91870.0 },
                    { 10, "Samsung Galaxy A12 128GB 4GB RAM Dual (SM-A125) Mobiltelefon", 58940.0 },
                    { 9, "Samsung Galaxy A21s 32GB 3GB RAM Dual (A217F) Mobiltelefon", 49900.0 },
                    { 8, "Samsung Galaxy S21 Ultra 128GB 12GB RAM Dual (G998) Mobiltelefon", 338000.0 },
                    { 7, "Samsung Galaxy A12 64GB 4GB RAM Dual (SM-A125) Mobiltelefon", 53990.0 },
                    { 6, "Samsung Galaxy A32 128GB 4GB RAM Dual (A325F) Mobiltelefon", 85730.0 },
                    { 5, "Samsung Galaxy A72 128GB 6GB RAM Dual (A725) Mobiltelefon", 135999.0 },
                    { 4, "Samsung Galaxy S21 128GB 8GB RAM Dual (G991) Mobiltelefon", 249000.0 },
                    { 3, "Samsung Galaxy A52s 5G 128GB 6GB RAM Dual (SM-A528) Mobiltelefon", 127870.0 },
                    { 2, "Samsung Galaxy A52 128GB 6GB RAM Dual (A525) Mobiltelefon", 119900.0 },
                    { 11, "Samsung Galaxy Note20 Ultra 5G 256GB 12GB RAM Dual (SM-N986) Mobiltelefon", 329000.0 },
                    { 23, "Samsung Galaxy Note20 256GB 8GB RAM Dual (N980F) Mobiltelefon", 244990.0 },
                    { 24, "Samsung Galaxy S21+ 128GB 8GB RAM Dual (G996) Mobiltelefon", 280000.0 },
                    { 25, "Samsung Galaxy S10+ 128GB Dual G975 Mobiltelefon", 208500.0 },
                    { 46, "Samsung Galaxy S21 Ultra 512GB 16GB RAM Dual (G998) Mobiltelefon", 460000.0 },
                    { 45, "Samsung Galaxy M11 32GB 3GB RAM Dual (M115) Mobiltelefon", 45000.0 },
                    { 44, "Samsung Galaxy A12 Nacho 128GB 4GB RAM Dual (SM-A127F) Mobiltelefon", 67560.0 },
                    { 43, "Samsung Galaxy Xcover Pro 64GB Dual Mobiltelefon", 135290.0 },
                    { 42, "Samsung Galaxy A22 64GB 4GB RAM Dual (A225F) Mobiltelefon", 66780.0 },
                    { 41, "Samsung Galaxy A02 64GB 3GB RAM Dual (A022F) Mobiltelefon", 43390.0 },
                    { 40, "Samsung Galaxy Z Fold2 5G 256GB 12GB RAM (F916B) Mobiltelefon", 489990.0 },
                    { 39, "Samsung Galaxy A22 5G 64GB 4GB RAM Dual (A226F) Mobiltelefon", 72000.0 },
                    { 38, "Samsung Galaxy A10 32GB Dual A105 Mobiltelefon", 49990.0 },
                    { 37, "Samsung Galaxy S21 256GB 8GB RAM Dual (G991) Mobiltelefon", 265000.0 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "ProductName", "ProductPrice" },
                values: new object[,]
                {
                    { 36, "Samsung Galaxy Note9 128GB Dual N960 Mobiltelefon", 139800.0 },
                    { 35, "Samsung Galaxy A02 32GB 3GB RAM Dual (A022F) Mobiltelefon", 38390.0 },
                    { 34, "Samsung Galaxy A12 32GB 3GB RAM Dual (A125) Mobiltelefon", 49090.0 },
                    { 33, "Samsung Galaxy A21s 128GB 4GB RAM Dual Mobiltelefon", 78920.0 },
                    { 32, "Samsung Galaxy A50 128GB 4GB RAM Dual A505 Mobiltelefon", 133443.0 },
                    { 31, "Samsung Galaxy A01 Core 16GB Dual (A013F) Mobiltelefon", 28790.0 },
                    { 30, "Samsung Galaxy S20 Ultra 5G 128GB 12GB RAM Dual (G988) Mobiltelefon", 303890.0 },
                    { 29, "Samsung Galaxy Note10 256GB Dual N970 Mobiltelefon", 206250.0 },
                    { 28, "Samsung Galaxy XCover 5 64GB Dual (G525) Mobiltelefon", 92980.0 },
                    { 27, "Samsung Galaxy S20 FE 5G 128GB 6GB RAM Dual (SM-G781) Mobiltelefon", 169890.0 },
                    { 26, "Samsung Galaxy S21 Ultra 256GB 12GB RAM Dual (G998) Mobiltelefon", 359990.0 },
                    { 48, "Samsung Galaxy A02s 32GB Dual (A025F) Mobiltelefon", 48500.0 },
                    { 97, "Samsung Galaxy S20 FE 5G 128GB 8GB RAM Dual (SM-G781) Mobiltelefon", 192890.0 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 97);
        }
    }
}
