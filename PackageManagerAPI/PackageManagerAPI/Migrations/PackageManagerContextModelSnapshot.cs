﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PackageManagerAPI.Models;

namespace PackageManagerAPI.Migrations
{
    [DbContext(typeof(PackageManagerContext))]
    partial class PackageManagerContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("OrderProduct", b =>
                {
                    b.Property<int>("OrdersOrderId")
                        .HasColumnType("int");

                    b.Property<int>("ProductsProductId")
                        .HasColumnType("int");

                    b.HasKey("OrdersOrderId", "ProductsProductId");

                    b.HasIndex("ProductsProductId");

                    b.ToTable("ProductOrders");
                });

            modelBuilder.Entity("PackageManagerAPI.Models.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("PackageId")
                        .HasColumnType("nvarchar(8)");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("StatusShortHand")
                        .HasColumnType("nvarchar(4)");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("OrderId");

                    b.HasIndex("UserId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("PackageManagerAPI.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ProductName")
                        .HasColumnType("nvarchar(500)");

                    b.Property<double>("ProductPrice")
                        .HasColumnType("float");

                    b.HasKey("ProductId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            ProductName = "Samsung Galaxy S20 FE 128GB 6GB RAM Dual (SM-G780) Mobiltelefon",
                            ProductPrice = 155000.0
                        },
                        new
                        {
                            ProductId = 2,
                            ProductName = "Samsung Galaxy A52 128GB 6GB RAM Dual (A525) Mobiltelefon",
                            ProductPrice = 119900.0
                        },
                        new
                        {
                            ProductId = 3,
                            ProductName = "Samsung Galaxy A52s 5G 128GB 6GB RAM Dual (SM-A528) Mobiltelefon",
                            ProductPrice = 127870.0
                        },
                        new
                        {
                            ProductId = 4,
                            ProductName = "Samsung Galaxy S21 128GB 8GB RAM Dual (G991) Mobiltelefon",
                            ProductPrice = 249000.0
                        },
                        new
                        {
                            ProductId = 5,
                            ProductName = "Samsung Galaxy A72 128GB 6GB RAM Dual (A725) Mobiltelefon",
                            ProductPrice = 135999.0
                        },
                        new
                        {
                            ProductId = 6,
                            ProductName = "Samsung Galaxy A32 128GB 4GB RAM Dual (A325F) Mobiltelefon",
                            ProductPrice = 85730.0
                        },
                        new
                        {
                            ProductId = 7,
                            ProductName = "Samsung Galaxy A12 64GB 4GB RAM Dual (SM-A125) Mobiltelefon",
                            ProductPrice = 53990.0
                        },
                        new
                        {
                            ProductId = 8,
                            ProductName = "Samsung Galaxy S21 Ultra 128GB 12GB RAM Dual (G998) Mobiltelefon",
                            ProductPrice = 338000.0
                        },
                        new
                        {
                            ProductId = 9,
                            ProductName = "Samsung Galaxy A21s 32GB 3GB RAM Dual (A217F) Mobiltelefon",
                            ProductPrice = 49900.0
                        },
                        new
                        {
                            ProductId = 10,
                            ProductName = "Samsung Galaxy A12 128GB 4GB RAM Dual (SM-A125) Mobiltelefon",
                            ProductPrice = 58940.0
                        },
                        new
                        {
                            ProductId = 11,
                            ProductName = "Samsung Galaxy Note20 Ultra 5G 256GB 12GB RAM Dual (SM-N986) Mobiltelefon",
                            ProductPrice = 329000.0
                        },
                        new
                        {
                            ProductId = 12,
                            ProductName = "Samsung Galaxy A32 5G 128GB 4GB RAM Dual (A326) Mobiltelefon",
                            ProductPrice = 91870.0
                        },
                        new
                        {
                            ProductId = 13,
                            ProductName = "Samsung Galaxy A51 128GB 4GB RAM Dual (A515F) Mobiltelefon",
                            ProductPrice = 109990.0
                        },
                        new
                        {
                            ProductId = 14,
                            ProductName = "Samsung Galaxy S10 128GB Dual G973 Mobiltelefon",
                            ProductPrice = 182590.0
                        },
                        new
                        {
                            ProductId = 15,
                            ProductName = "Samsung Galaxy A22 128GB 4GB RAM Dual (A225) Mobiltelefon",
                            ProductPrice = 69890.0
                        },
                        new
                        {
                            ProductId = 16,
                            ProductName = "Samsung Galaxy A71 128GB 6GB RAM Dual (A715F) Mobiltelefon",
                            ProductPrice = 159999.0
                        },
                        new
                        {
                            ProductId = 17,
                            ProductName = "Samsung Galaxy A22 5G 128GB 4GB RAM Dual (A226) Mobiltelefon",
                            ProductPrice = 83980.0
                        },
                        new
                        {
                            ProductId = 18,
                            ProductName = "Samsung Galaxy A52 5G 128GB 6GB RAM Dual (A526) Mobiltelefon",
                            ProductPrice = 139990.0
                        },
                        new
                        {
                            ProductId = 19,
                            ProductName = "Samsung Galaxy S20 128GB 8GB RAM Dual (G980F) Mobiltelefon",
                            ProductPrice = 249900.0
                        },
                        new
                        {
                            ProductId = 20,
                            ProductName = "Samsung Galaxy A40 64GB Dual A405 Mobiltelefon",
                            ProductPrice = 97563.0
                        },
                        new
                        {
                            ProductId = 21,
                            ProductName = "Samsung Galaxy S10e 128GB Dual G970 Mobiltelefon",
                            ProductPrice = 177989.0
                        },
                        new
                        {
                            ProductId = 22,
                            ProductName = "Samsung Galaxy S20+ 128GB 8GB RAM Dual (G985F) Mobiltelefon",
                            ProductPrice = 235800.0
                        },
                        new
                        {
                            ProductId = 23,
                            ProductName = "Samsung Galaxy Note20 256GB 8GB RAM Dual (N980F) Mobiltelefon",
                            ProductPrice = 244990.0
                        },
                        new
                        {
                            ProductId = 24,
                            ProductName = "Samsung Galaxy S21+ 128GB 8GB RAM Dual (G996) Mobiltelefon",
                            ProductPrice = 280000.0
                        },
                        new
                        {
                            ProductId = 25,
                            ProductName = "Samsung Galaxy S10+ 128GB Dual G975 Mobiltelefon",
                            ProductPrice = 208500.0
                        },
                        new
                        {
                            ProductId = 26,
                            ProductName = "Samsung Galaxy S21 Ultra 256GB 12GB RAM Dual (G998) Mobiltelefon",
                            ProductPrice = 359990.0
                        },
                        new
                        {
                            ProductId = 27,
                            ProductName = "Samsung Galaxy S20 FE 5G 128GB 6GB RAM Dual (SM-G781) Mobiltelefon",
                            ProductPrice = 169890.0
                        },
                        new
                        {
                            ProductId = 28,
                            ProductName = "Samsung Galaxy XCover 5 64GB Dual (G525) Mobiltelefon",
                            ProductPrice = 92980.0
                        },
                        new
                        {
                            ProductId = 29,
                            ProductName = "Samsung Galaxy Note10 256GB Dual N970 Mobiltelefon",
                            ProductPrice = 206250.0
                        },
                        new
                        {
                            ProductId = 30,
                            ProductName = "Samsung Galaxy S20 Ultra 5G 128GB 12GB RAM Dual (G988) Mobiltelefon",
                            ProductPrice = 303890.0
                        },
                        new
                        {
                            ProductId = 31,
                            ProductName = "Samsung Galaxy A01 Core 16GB Dual (A013F) Mobiltelefon",
                            ProductPrice = 28790.0
                        },
                        new
                        {
                            ProductId = 32,
                            ProductName = "Samsung Galaxy A50 128GB 4GB RAM Dual A505 Mobiltelefon",
                            ProductPrice = 133443.0
                        },
                        new
                        {
                            ProductId = 33,
                            ProductName = "Samsung Galaxy A21s 128GB 4GB RAM Dual Mobiltelefon",
                            ProductPrice = 78920.0
                        },
                        new
                        {
                            ProductId = 34,
                            ProductName = "Samsung Galaxy A12 32GB 3GB RAM Dual (A125) Mobiltelefon",
                            ProductPrice = 49090.0
                        },
                        new
                        {
                            ProductId = 35,
                            ProductName = "Samsung Galaxy A02 32GB 3GB RAM Dual (A022F) Mobiltelefon",
                            ProductPrice = 38390.0
                        },
                        new
                        {
                            ProductId = 36,
                            ProductName = "Samsung Galaxy Note9 128GB Dual N960 Mobiltelefon",
                            ProductPrice = 139800.0
                        },
                        new
                        {
                            ProductId = 37,
                            ProductName = "Samsung Galaxy S21 256GB 8GB RAM Dual (G991) Mobiltelefon",
                            ProductPrice = 265000.0
                        },
                        new
                        {
                            ProductId = 38,
                            ProductName = "Samsung Galaxy A10 32GB Dual A105 Mobiltelefon",
                            ProductPrice = 49990.0
                        },
                        new
                        {
                            ProductId = 39,
                            ProductName = "Samsung Galaxy A22 5G 64GB 4GB RAM Dual (A226F) Mobiltelefon",
                            ProductPrice = 72000.0
                        },
                        new
                        {
                            ProductId = 40,
                            ProductName = "Samsung Galaxy Z Fold2 5G 256GB 12GB RAM (F916B) Mobiltelefon",
                            ProductPrice = 489990.0
                        },
                        new
                        {
                            ProductId = 41,
                            ProductName = "Samsung Galaxy A02 64GB 3GB RAM Dual (A022F) Mobiltelefon",
                            ProductPrice = 43390.0
                        },
                        new
                        {
                            ProductId = 42,
                            ProductName = "Samsung Galaxy A22 64GB 4GB RAM Dual (A225F) Mobiltelefon",
                            ProductPrice = 66780.0
                        },
                        new
                        {
                            ProductId = 43,
                            ProductName = "Samsung Galaxy Xcover Pro 64GB Dual Mobiltelefon",
                            ProductPrice = 135290.0
                        },
                        new
                        {
                            ProductId = 44,
                            ProductName = "Samsung Galaxy A12 Nacho 128GB 4GB RAM Dual (SM-A127F) Mobiltelefon",
                            ProductPrice = 67560.0
                        },
                        new
                        {
                            ProductId = 45,
                            ProductName = "Samsung Galaxy M11 32GB 3GB RAM Dual (M115) Mobiltelefon",
                            ProductPrice = 45000.0
                        },
                        new
                        {
                            ProductId = 46,
                            ProductName = "Samsung Galaxy S21 Ultra 512GB 16GB RAM Dual (G998) Mobiltelefon",
                            ProductPrice = 460000.0
                        },
                        new
                        {
                            ProductId = 47,
                            ProductName = "Samsung Galaxy Note10+ 256GB Dual N975F Mobiltelefon",
                            ProductPrice = 265000.0
                        },
                        new
                        {
                            ProductId = 48,
                            ProductName = "Samsung Galaxy A02s 32GB Dual (A025F) Mobiltelefon",
                            ProductPrice = 48500.0
                        },
                        new
                        {
                            ProductId = 49,
                            ProductName = "Samsung Galaxy Xcover 4s Dual (G398F) Mobiltelefon",
                            ProductPrice = 73590.0
                        },
                        new
                        {
                            ProductId = 50,
                            ProductName = "Samsung Galaxy A02s 32GB Dual (A025G) Mobiltelefon",
                            ProductPrice = 47000.0
                        },
                        new
                        {
                            ProductId = 51,
                            ProductName = "Samsung Galaxy S20 FE 256GB 8GB RAM Dual (SM-G780) Mobiltelefon",
                            ProductPrice = 195000.0
                        },
                        new
                        {
                            ProductId = 52,
                            ProductName = "Samsung Galaxy M21 64GB 4GB RAM Dual (M215F) Mobiltelefon",
                            ProductPrice = 66990.0
                        },
                        new
                        {
                            ProductId = 53,
                            ProductName = "Samsung Galaxy A32 128GB 6GB RAM Dual (A325F) Mobiltelefon",
                            ProductPrice = 92000.0
                        },
                        new
                        {
                            ProductId = 54,
                            ProductName = "Samsung Galaxy A20s 32GB 3GB RAM Dual (A207F) Mobiltelefon",
                            ProductPrice = 58800.0
                        },
                        new
                        {
                            ProductId = 55,
                            ProductName = "Samsung Galaxy A32 5G 64GB 4GB RAM Dual (A326) Mobiltelefon",
                            ProductPrice = 86690.0
                        },
                        new
                        {
                            ProductId = 56,
                            ProductName = "Samsung Galaxy M12 64GB 4GB RAM Dual (M127) Mobiltelefon",
                            ProductPrice = 57000.0
                        },
                        new
                        {
                            ProductId = 57,
                            ProductName = "Samsung Galaxy A32 128GB 8GB RAM Dual (A325F) Mobiltelefon",
                            ProductPrice = 98000.0
                        },
                        new
                        {
                            ProductId = 58,
                            ProductName = "Samsung Galaxy A42 5G 128GB 4GB RAM Dual (A426B) Mobiltelefon",
                            ProductPrice = 120900.0
                        },
                        new
                        {
                            ProductId = 59,
                            ProductName = "Samsung Galaxy A52 128GB 8GB RAM Dual (A525F) Mobiltelefon",
                            ProductPrice = 130200.0
                        },
                        new
                        {
                            ProductId = 60,
                            ProductName = "Samsung Galaxy Note20 Ultra 256GB 8GB RAM Dual (N985) Mobiltelefon",
                            ProductPrice = 309000.0
                        },
                        new
                        {
                            ProductId = 61,
                            ProductName = "Samsung Galaxy S21+ 256GB 8GB RAM Dual (G996) Mobiltelefon",
                            ProductPrice = 294390.0
                        },
                        new
                        {
                            ProductId = 62,
                            ProductName = "Samsung Galaxy Note10 Lite 128GB 6GB RAM Dual (N770F) Mobiltelefon",
                            ProductPrice = 226300.0
                        },
                        new
                        {
                            ProductId = 63,
                            ProductName = "Samsung Galaxy S10 5G 256GB G977 Mobiltelefon",
                            ProductPrice = 198810.0
                        },
                        new
                        {
                            ProductId = 64,
                            ProductName = "Samsung Galaxy S10+ 512GB Dual G975 Mobiltelefon",
                            ProductPrice = 418190.0
                        },
                        new
                        {
                            ProductId = 65,
                            ProductName = "Samsung Galaxy A52 128GB 4GB RAM Dual (A525F) Mobiltelefon",
                            ProductPrice = 119900.0
                        },
                        new
                        {
                            ProductId = 66,
                            ProductName = "Samsung Galaxy A32 5G 128GB 6GB RAM Dual (A326) Mobiltelefon",
                            ProductPrice = 90899.0
                        },
                        new
                        {
                            ProductId = 67,
                            ProductName = "Samsung Galaxy A72 128GB 4GB RAM Dual Mobiltelefon",
                            ProductPrice = 142900.0
                        },
                        new
                        {
                            ProductId = 68,
                            ProductName = "Samsung Galaxy S20 FE 5G 256GB 8GB RAM Dual (SM-G781) Mobiltelefon",
                            ProductPrice = 217390.0
                        },
                        new
                        {
                            ProductId = 69,
                            ProductName = "Samsung Galaxy A11 32GB 2GB RAM Dual Mobiltelefon",
                            ProductPrice = 43550.0
                        },
                        new
                        {
                            ProductId = 70,
                            ProductName = "Samsung Galaxy S10 Lite 128GB 8GB RAM Dual (G770F) Mobiltelefon",
                            ProductPrice = 176990.0
                        },
                        new
                        {
                            ProductId = 71,
                            ProductName = "Samsung Galaxy A12 Nacho 64GB 4GB RAM Dual (SM-A127F) Mobiltelefon",
                            ProductPrice = 56200.0
                        },
                        new
                        {
                            ProductId = 72,
                            ProductName = "Samsung Galaxy Note20 5G 256GB 8GB RAM Dual (SM-N981) Mobiltelefon",
                            ProductPrice = 256740.0
                        },
                        new
                        {
                            ProductId = 73,
                            ProductName = "Samsung Galaxy A22 128GB 6GB RAM Dual (A225F) Mobiltelefon",
                            ProductPrice = 82000.0
                        },
                        new
                        {
                            ProductId = 74,
                            ProductName = "Samsung Galaxy S10 Lite 128GB 6GB RAM Dual (G770F) Mobiltelefon",
                            ProductPrice = 168890.0
                        },
                        new
                        {
                            ProductId = 75,
                            ProductName = "Samsung Galaxy M12 128GB 4GB RAM Dual (M127F) Mobiltelefon",
                            ProductPrice = 69090.0
                        },
                        new
                        {
                            ProductId = 76,
                            ProductName = "Samsung Galaxy A21s 128GB 3GB RAM Dual Mobiltelefon",
                            ProductPrice = 79990.0
                        },
                        new
                        {
                            ProductId = 77,
                            ProductName = "Samsung Galaxy Xcover 4s (G398F) Mobiltelefon",
                            ProductPrice = 84999.0
                        },
                        new
                        {
                            ProductId = 78,
                            ProductName = "Samsung Galaxy Note10+ 5G 256GB (N976) Mobiltelefon",
                            ProductPrice = 362769.0
                        },
                        new
                        {
                            ProductId = 79,
                            ProductName = "Samsung Galaxy A12 Nacho 32GB 3GB RAM Dual (SM-A127F) Mobiltelefon",
                            ProductPrice = 49990.0
                        },
                        new
                        {
                            ProductId = 80,
                            ProductName = "Samsung Galaxy S20 Ultra 5G 256GB 12GB RAM Dual Mobiltelefon",
                            ProductPrice = 355790.0
                        },
                        new
                        {
                            ProductId = 81,
                            ProductName = "Samsung Galaxy XCover 5 32GB Dual Mobiltelefon",
                            ProductPrice = 100990.0
                        },
                        new
                        {
                            ProductId = 82,
                            ProductName = "Samsung Galaxy Note10+ 512GB Dual (SM-N975) Mobiltelefon",
                            ProductPrice = 402190.0
                        },
                        new
                        {
                            ProductId = 83,
                            ProductName = "Samsung Galaxy A11 32GB 3GB RAM Dual Mobiltelefon",
                            ProductPrice = 48800.0
                        },
                        new
                        {
                            ProductId = 84,
                            ProductName = "Samsung Galaxy A32 128GB 4GB RAM (A325F) Mobiltelefon",
                            ProductPrice = 89900.0
                        },
                        new
                        {
                            ProductId = 85,
                            ProductName = "Samsung Galaxy Note10+ 5G 256GB Dual (N976) Mobiltelefon",
                            ProductPrice = 275000.0
                        },
                        new
                        {
                            ProductId = 86,
                            ProductName = "Samsung Galaxy A52 5G 128GB 4GB RAM Dual (A526) Mobiltelefon",
                            ProductPrice = 159900.0
                        },
                        new
                        {
                            ProductId = 87,
                            ProductName = "Samsung Galaxy S10e 128GB G970 Mobiltelefon",
                            ProductPrice = 217590.0
                        },
                        new
                        {
                            ProductId = 88,
                            ProductName = "Samsung Galaxy S10 5G 256GB Dual (G977) Mobiltelefon",
                            ProductPrice = 209950.0
                        },
                        new
                        {
                            ProductId = 89,
                            ProductName = "Samsung Galaxy A02 32GB 2GB RAM Dual (A022F) Mobiltelefon",
                            ProductPrice = 49900.0
                        },
                        new
                        {
                            ProductId = 90,
                            ProductName = "Samsung Galaxy Xcover Pro 64GB Mobiltelefon",
                            ProductPrice = 180820.0
                        },
                        new
                        {
                            ProductId = 91,
                            ProductName = "Samsung Galaxy A22 5G 128GB Mobiltelefon",
                            ProductPrice = 95900.0
                        },
                        new
                        {
                            ProductId = 92,
                            ProductName = "Samsung Galaxy A02s 32GB Mobiltelefon",
                            ProductPrice = 58595.0
                        },
                        new
                        {
                            ProductId = 93,
                            ProductName = "Samsung Galaxy A22 128GB (A225F) Mobiltelefon",
                            ProductPrice = 79900.0
                        },
                        new
                        {
                            ProductId = 94,
                            ProductName = "Samsung Galaxy A22 128GB 4GB RAM (SM-A225) Mobiltelefon",
                            ProductPrice = 75990.0
                        },
                        new
                        {
                            ProductId = 95,
                            ProductName = "Samsung Galaxy M12 32GB 3GB RAM Dual (M127F) Mobiltelefon",
                            ProductPrice = 63900.0
                        },
                        new
                        {
                            ProductId = 96,
                            ProductName = "Samsung Galaxy A42 5G 128GB 4GB RAM (A426B) Mobiltelefon",
                            ProductPrice = 136360.0
                        },
                        new
                        {
                            ProductId = 97,
                            ProductName = "Samsung Galaxy S20 FE 5G 128GB 8GB RAM Dual (SM-G781) Mobiltelefon",
                            ProductPrice = 192890.0
                        });
                });

            modelBuilder.Entity("PackageManagerAPI.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("OrderProduct", b =>
                {
                    b.HasOne("PackageManagerAPI.Models.Order", null)
                        .WithMany()
                        .HasForeignKey("OrdersOrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PackageManagerAPI.Models.Product", null)
                        .WithMany()
                        .HasForeignKey("ProductsProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PackageManagerAPI.Models.Order", b =>
                {
                    b.HasOne("PackageManagerAPI.Models.User", "User")
                        .WithMany("Orders")
                        .HasForeignKey("UserId");

                    b.Navigation("User");
                });

            modelBuilder.Entity("PackageManagerAPI.Models.User", b =>
                {
                    b.Navigation("Orders");
                });
#pragma warning restore 612, 618
        }
    }
}
