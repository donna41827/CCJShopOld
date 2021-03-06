// <auto-generated />
using System;
using CCJShop.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CCJShop.Migrations.Product
{
    [DbContext(typeof(ProductContext))]
    [Migration("20210521082435_AddDataProduct2")]
    partial class AddDataProduct2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.6")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CCJShop.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CDT")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("MDT")
                        .HasColumnType("datetime2");

                    b.Property<string>("Memo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("ProductId");

                    b.ToTable("Product");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            CDT = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            MDT = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Memo = "內搭竹節T真的很好穿！\n忽冷忽熱的時候都可以搭配到 非常親膚\n整套搭配Claire自留\n渲染洋裝多層次穿搭百摺裙 讓整體更有變化\n比較偏一點點日系的搭配法\n洋裝不能調肩帶唷！\n但是材質有彈性 穿起來一樣親膚不刺癢",
                            Name = "個性渲染絲絨連身裙",
                            Price = 560,
                            Status = 1
                        });
                });

            modelBuilder.Entity("CCJShop.Models.ProductColor", b =>
                {
                    b.Property<int>("ProductColorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AddPrice")
                        .HasColumnType("int");

                    b.Property<DateTime>("CDT")
                        .HasColumnType("datetime2");

                    b.Property<string>("ColorCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("MDT")
                        .HasColumnType("datetime2");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.HasKey("ProductColorId");

                    b.ToTable("ProductColor");
                });

            modelBuilder.Entity("CCJShop.Models.ProductImg", b =>
                {
                    b.Property<int>("ProductImgId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CDT")
                        .HasColumnType("datetime2");

                    b.Property<string>("ImgSrc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("MDT")
                        .HasColumnType("datetime2");

                    b.Property<int>("ProductColorId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.HasKey("ProductImgId");

                    b.ToTable("ProductImg");

                    b.HasData(
                        new
                        {
                            ProductImgId = 1,
                            CDT = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ImgSrc = "~/Image/1.jpg",
                            MDT = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ProductColorId = 0,
                            ProductId = 1
                        },
                        new
                        {
                            ProductImgId = 2,
                            CDT = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ImgSrc = "~/Image/2.jpg",
                            MDT = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ProductColorId = 0,
                            ProductId = 1
                        },
                        new
                        {
                            ProductImgId = 3,
                            CDT = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ImgSrc = "~/Image/3.jpg",
                            MDT = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ProductColorId = 0,
                            ProductId = 1
                        },
                        new
                        {
                            ProductImgId = 4,
                            CDT = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ImgSrc = "~/Image/4.jpg",
                            MDT = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ProductColorId = 0,
                            ProductId = 1
                        },
                        new
                        {
                            ProductImgId = 5,
                            CDT = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ImgSrc = "~/Image/5.jpg",
                            MDT = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ProductColorId = 0,
                            ProductId = 1
                        });
                });

            modelBuilder.Entity("CCJShop.Models.ProductSize", b =>
                {
                    b.Property<int>("ProductSizeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AddPrice")
                        .HasColumnType("int");

                    b.Property<DateTime>("CDT")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("MDT")
                        .HasColumnType("datetime2");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<string>("SizeCode")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProductSizeId");

                    b.ToTable("ProductSize");
                });
#pragma warning restore 612, 618
        }
    }
}
