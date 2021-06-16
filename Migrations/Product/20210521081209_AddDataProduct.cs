using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CCJShop.Migrations.Product
{
    public partial class AddDataProduct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ProductId", "CDT", "MDT", "Memo", "Name", "Price", "Status" },
                values: new object[] { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "內搭竹節T真的很好穿！\n忽冷忽熱的時候都可以搭配到 非常親膚\n整套搭配Claire自留\n渲染洋裝多層次穿搭百摺裙 讓整體更有變化\n比較偏一點點日系的搭配法\n洋裝不能調肩帶唷！\n但是材質有彈性 穿起來一樣親膚不刺癢", "個性渲染絲絨連身裙", 560, 1 });

            migrationBuilder.InsertData(
                table: "ProductImg",
                columns: new[] { "ProductImgId", "CDT", "ImgSrc", "MDT", "ProductColorId", "ProductId" },
                values: new object[] { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://instagram.ftpe5-1.fna.fbcdn.net/v/t51.2885-15/e35/s1080x1080/174079068_950674635472462_4447592011368211239_n.jpg?tp=1&_nc_ht=instagram.ftpe5-1.fna.fbcdn.net&_nc_cat=110&_nc_ohc=hmylVF-ezWkAX-Sk9pn&edm=AP_V10EBAAAA&ccb=7-4&oh=79e65203173c8f86022353da81649786&oe=60AF244D&_nc_sid=4f375e", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 1 });

            migrationBuilder.InsertData(
                table: "ProductImg",
                columns: new[] { "ProductImgId", "CDT", "ImgSrc", "MDT", "ProductColorId", "ProductId" },
                values: new object[] { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://instagram.ftpe5-1.fna.fbcdn.net/v/t51.2885-15/e35/s1080x1080/173084051_1409041302766659_8619673499345077503_n.jpg?tp=1&_nc_ht=instagram.ftpe5-1.fna.fbcdn.net&_nc_cat=103&_nc_ohc=XEhZLjPa1wIAX9GpbeC&edm=AP_V10EBAAAA&ccb=7-4&oh=e8bb670a2aa5beda5e5fc0e3f1bf8e1b&oe=60AF0252&_nc_sid=4f375e", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ProductImg",
                keyColumn: "ProductImgId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ProductImg",
                keyColumn: "ProductImgId",
                keyValue: 2);
        }
    }
}
