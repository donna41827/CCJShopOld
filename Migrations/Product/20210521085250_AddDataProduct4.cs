using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CCJShop.Migrations.Product
{
    public partial class AddDataProduct4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "Memo",
                value: "內搭竹節T真的很好穿！<br>忽冷忽熱的時候都可以搭配到 非常親膚<br>整套搭配Claire自留<br>渲染洋裝多層次穿搭百摺裙 讓整體更有變化<br>比較偏一點點日系的搭配法<br>洋裝不能調肩帶唷！<br>但是材質有彈性 穿起來一樣親膚不刺癢");

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ProductId", "CDT", "MDT", "Memo", "Name", "Price", "Status" },
                values: new object[] { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "不規則長裙非常能多層次穿搭<br>黑色最為首選<br>也可以簡單搭個毛衣或是素上衣單品<br>分三個尺寸", "個性不規則工裝長裙", 499, 1 });

            migrationBuilder.InsertData(
                table: "ProductImg",
                columns: new[] { "ProductImgId", "CDT", "ImgSrc", "MDT", "ProductColorId", "ProductId" },
                values: new object[,]
                {
                    { 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "/Image/6.jpg", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 2 },
                    { 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "/Image/7.jpg", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 2 },
                    { 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "/Image/8.jpg", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 2 },
                    { 9, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "/Image/9.jpg", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 2 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ProductImg",
                keyColumn: "ProductImgId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "ProductImg",
                keyColumn: "ProductImgId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "ProductImg",
                keyColumn: "ProductImgId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "ProductImg",
                keyColumn: "ProductImgId",
                keyValue: 9);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "Memo",
                value: "內搭竹節T真的很好穿！\n忽冷忽熱的時候都可以搭配到 非常親膚\n整套搭配Claire自留\n渲染洋裝多層次穿搭百摺裙 讓整體更有變化\n比較偏一點點日系的搭配法\n洋裝不能調肩帶唷！\n但是材質有彈性 穿起來一樣親膚不刺癢");
        }
    }
}
