﻿// <auto-generated />
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
    [Migration("20210603075108_ModifyProductImgPathAndName")]
    partial class ModifyProductImgPathAndName
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
                            Memo = "內搭竹節T真的很好穿！<br>忽冷忽熱的時候都可以搭配到 非常親膚<br>整套搭配Claire自留<br>渲染洋裝多層次穿搭百摺裙 讓整體更有變化<br>比較偏一點點日系的搭配法<br>洋裝不能調肩帶唷！<br>但是材質有彈性 穿起來一樣親膚不刺癢",
                            Name = "個性渲染絲絨連身裙",
                            Price = 560,
                            Status = 1
                        },
                        new
                        {
                            ProductId = 2,
                            CDT = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            MDT = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Memo = "不規則長裙非常能多層次穿搭<br>黑色最為首選<br>也可以簡單搭個毛衣或是素上衣單品<br>分三個尺寸",
                            Name = "個性不規則工裝長裙",
                            Price = 499,
                            Status = 1
                        },
                        new
                        {
                            ProductId = 3,
                            CDT = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            MDT = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Memo = "熱賣款短款洋裝<br>厚度適中 所以白色不太會透喔！總共黑白兩色<br>而且還有口袋 非常方便～<br>認真很多人包色的款<br>不過闆娘夏天搭淺色衣服裡面幾乎都穿「膚色」內搭",
                            Name = "圓領素面背心含口袋洋裝",
                            Price = 499,
                            Status = 1
                        },
                        new
                        {
                            ProductId = 4,
                            CDT = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            MDT = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Memo = "可甜可鹹的蓁蓁<br>洋裝不是棉麻材質是偏涼爽材質<br>顏色很亮真的超美 可以背心內搭或是穿短袖長袖<br>所以可以一路穿到秋冬",
                            Name = "涼爽款可調肩蛋糕洋裝",
                            Price = 499,
                            Status = 1
                        },
                        new
                        {
                            ProductId = 5,
                            CDT = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            MDT = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Memo = "最愛黑白配 <br>夏天必備的薄透感西裝外套<br>設計假口袋 長度適中 沒有墊肩問題<br>配褲裝或是裙類單品都可以",
                            Name = "薄款同色扣假口袋西裝外套",
                            Price = 550,
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

                    b.Property<string>("ColorName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("MDT")
                        .HasColumnType("datetime2");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.HasKey("ProductColorId");

                    b.HasIndex("ProductId");

                    b.ToTable("ProductColor");

                    b.HasData(
                        new
                        {
                            ProductColorId = 1,
                            AddPrice = 0,
                            CDT = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ColorCode = "#FFFFFF",
                            ColorName = "白",
                            MDT = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ProductId = 3
                        },
                        new
                        {
                            ProductColorId = 2,
                            AddPrice = 0,
                            CDT = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ColorCode = "#000000",
                            ColorName = "黑",
                            MDT = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ProductId = 3
                        },
                        new
                        {
                            ProductColorId = 3,
                            AddPrice = 0,
                            CDT = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ColorCode = "#FFF9CD",
                            ColorName = "杏",
                            MDT = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ProductId = 4
                        },
                        new
                        {
                            ProductColorId = 4,
                            AddPrice = 0,
                            CDT = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ColorCode = "#7697FF",
                            ColorName = "藍",
                            MDT = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ProductId = 4
                        },
                        new
                        {
                            ProductColorId = 5,
                            AddPrice = 0,
                            CDT = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ColorCode = "#FFFFFF",
                            ColorName = "白",
                            MDT = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ProductId = 5
                        },
                        new
                        {
                            ProductColorId = 6,
                            AddPrice = 0,
                            CDT = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ColorCode = "#000000",
                            ColorName = "黑",
                            MDT = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ProductId = 5
                        },
                        new
                        {
                            ProductColorId = 7,
                            AddPrice = 0,
                            CDT = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ColorCode = "#BDCDFF",
                            ColorName = "藍",
                            MDT = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ProductId = 5
                        },
                        new
                        {
                            ProductColorId = 8,
                            AddPrice = 0,
                            CDT = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ColorCode = "#FFFBD1",
                            ColorName = "杏",
                            MDT = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ProductId = 5
                        },
                        new
                        {
                            ProductColorId = 9,
                            AddPrice = 0,
                            CDT = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ColorCode = "#E1FFA5",
                            ColorName = "綠",
                            MDT = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ProductId = 5
                        });
                });

            modelBuilder.Entity("CCJShop.Models.ProductImg", b =>
                {
                    b.Property<int>("ProductImgId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CDT")
                        .HasColumnType("datetime2");

                    b.Property<string>("ImgName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImgPath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("MDT")
                        .HasColumnType("datetime2");

                    b.Property<int>("ProductColorId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.HasKey("ProductImgId");

                    b.HasIndex("ProductId");

                    b.ToTable("ProductImg");

                    b.HasData(
                        new
                        {
                            ProductImgId = 1,
                            CDT = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ImgName = "1.jpg",
                            ImgPath = "/Image/",
                            MDT = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ProductColorId = 0,
                            ProductId = 1
                        },
                        new
                        {
                            ProductImgId = 2,
                            CDT = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ImgName = "2.jpg",
                            ImgPath = "/Image/",
                            MDT = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ProductColorId = 0,
                            ProductId = 1
                        },
                        new
                        {
                            ProductImgId = 3,
                            CDT = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ImgName = "3.jpg",
                            ImgPath = "/Image/",
                            MDT = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ProductColorId = 0,
                            ProductId = 1
                        },
                        new
                        {
                            ProductImgId = 4,
                            CDT = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ImgName = "4.jpg",
                            ImgPath = "/Image/",
                            MDT = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ProductColorId = 0,
                            ProductId = 1
                        },
                        new
                        {
                            ProductImgId = 5,
                            CDT = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ImgName = "5.jpg",
                            ImgPath = "/Image/",
                            MDT = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ProductColorId = 0,
                            ProductId = 1
                        },
                        new
                        {
                            ProductImgId = 6,
                            CDT = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ImgName = "6.jpg",
                            ImgPath = "/Image/",
                            MDT = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ProductColorId = 0,
                            ProductId = 2
                        },
                        new
                        {
                            ProductImgId = 7,
                            CDT = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ImgName = "7.jpg",
                            ImgPath = "/Image/",
                            MDT = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ProductColorId = 0,
                            ProductId = 2
                        },
                        new
                        {
                            ProductImgId = 8,
                            CDT = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ImgName = "8.jpg",
                            ImgPath = "/Image/",
                            MDT = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ProductColorId = 0,
                            ProductId = 2
                        },
                        new
                        {
                            ProductImgId = 9,
                            CDT = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ImgName = "9.jpg",
                            ImgPath = "/Image/",
                            MDT = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ProductColorId = 0,
                            ProductId = 2
                        },
                        new
                        {
                            ProductImgId = 10,
                            CDT = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ImgName = "10.jpg",
                            ImgPath = "/Image/",
                            MDT = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ProductColorId = 0,
                            ProductId = 3
                        },
                        new
                        {
                            ProductImgId = 11,
                            CDT = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ImgName = "11.jpg",
                            ImgPath = "/Image/",
                            MDT = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ProductColorId = 0,
                            ProductId = 3
                        },
                        new
                        {
                            ProductImgId = 12,
                            CDT = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ImgName = "12.jpg",
                            ImgPath = "/Image/",
                            MDT = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ProductColorId = 0,
                            ProductId = 3
                        },
                        new
                        {
                            ProductImgId = 13,
                            CDT = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ImgName = "13.jpg",
                            ImgPath = "/Image/",
                            MDT = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ProductColorId = 0,
                            ProductId = 3
                        },
                        new
                        {
                            ProductImgId = 14,
                            CDT = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ImgName = "14.jpg",
                            ImgPath = "/Image/",
                            MDT = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ProductColorId = 0,
                            ProductId = 4
                        },
                        new
                        {
                            ProductImgId = 15,
                            CDT = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ImgName = "15.jpg",
                            ImgPath = "/Image/",
                            MDT = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ProductColorId = 0,
                            ProductId = 4
                        },
                        new
                        {
                            ProductImgId = 16,
                            CDT = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ImgName = "16.jpg",
                            ImgPath = "/Image/",
                            MDT = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ProductColorId = 0,
                            ProductId = 4
                        },
                        new
                        {
                            ProductImgId = 17,
                            CDT = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ImgName = "17.jpg",
                            ImgPath = "/Image/",
                            MDT = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ProductColorId = 0,
                            ProductId = 4
                        },
                        new
                        {
                            ProductImgId = 18,
                            CDT = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ImgName = "18.jpg",
                            ImgPath = "/Image/",
                            MDT = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ProductColorId = 0,
                            ProductId = 4
                        },
                        new
                        {
                            ProductImgId = 19,
                            CDT = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ImgName = "19.jpg",
                            ImgPath = "/Image/",
                            MDT = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ProductColorId = 0,
                            ProductId = 5
                        },
                        new
                        {
                            ProductImgId = 20,
                            CDT = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ImgName = "20.jpg",
                            ImgPath = "/Image/",
                            MDT = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ProductColorId = 0,
                            ProductId = 5
                        },
                        new
                        {
                            ProductImgId = 21,
                            CDT = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ImgName = "21.jpg",
                            ImgPath = "/Image/",
                            MDT = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ProductColorId = 0,
                            ProductId = 5
                        },
                        new
                        {
                            ProductImgId = 22,
                            CDT = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ImgName = "22.jpg",
                            ImgPath = "/Image/",
                            MDT = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ProductColorId = 0,
                            ProductId = 5
                        },
                        new
                        {
                            ProductImgId = 23,
                            CDT = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ImgName = "23.jpg",
                            ImgPath = "/Image/",
                            MDT = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ProductColorId = 0,
                            ProductId = 5
                        },
                        new
                        {
                            ProductImgId = 24,
                            CDT = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ImgName = "24.jpg",
                            ImgPath = "/Image/",
                            MDT = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ProductColorId = 0,
                            ProductId = 5
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

                    b.Property<string>("SizeMemo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProductSizeId");

                    b.HasIndex("ProductId");

                    b.ToTable("ProductSize");

                    b.HasData(
                        new
                        {
                            ProductSizeId = 1,
                            AddPrice = 0,
                            CDT = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            MDT = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ProductId = 2,
                            SizeCode = "S",
                            SizeMemo = "腰圍58 裙長77"
                        },
                        new
                        {
                            ProductSizeId = 2,
                            AddPrice = 0,
                            CDT = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            MDT = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ProductId = 2,
                            SizeCode = "M",
                            SizeMemo = "腰圍60 裙長78"
                        },
                        new
                        {
                            ProductSizeId = 3,
                            AddPrice = 0,
                            CDT = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            MDT = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ProductId = 2,
                            SizeCode = "L",
                            SizeMemo = "腰圍63 裙長79"
                        });
                });

            modelBuilder.Entity("CCJShop.Models.ProductColor", b =>
                {
                    b.HasOne("CCJShop.Models.Product", "Product")
                        .WithMany("ProductColor")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("CCJShop.Models.ProductImg", b =>
                {
                    b.HasOne("CCJShop.Models.Product", "Product")
                        .WithMany("ProductImg")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("CCJShop.Models.ProductSize", b =>
                {
                    b.HasOne("CCJShop.Models.Product", "Product")
                        .WithMany("ProductSize")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("CCJShop.Models.Product", b =>
                {
                    b.Navigation("ProductColor");

                    b.Navigation("ProductImg");

                    b.Navigation("ProductSize");
                });
#pragma warning restore 612, 618
        }
    }
}
