using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CCJShop.Migrations.Product
{
    public partial class AddClotheData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ProductId", "CDT", "MDT", "Memo", "Name", "Price", "Status" },
                values: new object[,]
                {
                    { 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "熱賣款短款洋裝<br>厚度適中 所以白色不太會透喔！總共黑白兩色<br>而且還有口袋 非常方便～<br>認真很多人包色的款<br>不過闆娘夏天搭淺色衣服裡面幾乎都穿「膚色」內搭", "圓領素面背心含口袋洋裝", 499, 1 },
                    { 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "可甜可鹹的蓁蓁<br>洋裝不是棉麻材質是偏涼爽材質<br>顏色很亮真的超美 可以背心內搭或是穿短袖長袖<br>所以可以一路穿到秋冬", "涼爽款可調肩蛋糕洋裝", 499, 1 }
                });

            migrationBuilder.InsertData(
                table: "ProductColor",
                columns: new[] { "ProductColorId", "AddPrice", "CDT", "ColorCode", "MDT", "ProductId" },
                values: new object[,]
                {
                    { 1, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "#ffffff", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 2, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "#000000", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 3, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "#FFF9CD", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 4, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "#7697FF", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 }
                });

            migrationBuilder.InsertData(
                table: "ProductImg",
                columns: new[] { "ProductImgId", "CDT", "ImgSrc", "MDT", "ProductColorId", "ProductId" },
                values: new object[,]
                {
                    { 18, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "/Image/18.jpg", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 4 },
                    { 17, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "/Image/17.jpg", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 4 },
                    { 16, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "/Image/16.jpg", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 4 },
                    { 15, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "/Image/15.jpg", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 4 },
                    { 12, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "/Image/12.jpg", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 3 },
                    { 13, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "/Image/13.jpg", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 3 },
                    { 11, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "/Image/11.jpg", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 3 },
                    { 10, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "/Image/10.jpg", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 3 },
                    { 14, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "/Image/14.jpg", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 4 }
                });

            migrationBuilder.InsertData(
                table: "ProductSize",
                columns: new[] { "ProductSizeId", "AddPrice", "CDT", "MDT", "ProductId", "SizeCode" },
                values: new object[,]
                {
                    { 2, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "M" },
                    { 1, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "S" },
                    { 3, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "L" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ProductColor",
                keyColumn: "ProductColorId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ProductColor",
                keyColumn: "ProductColorId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ProductColor",
                keyColumn: "ProductColorId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ProductColor",
                keyColumn: "ProductColorId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ProductImg",
                keyColumn: "ProductImgId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "ProductImg",
                keyColumn: "ProductImgId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "ProductImg",
                keyColumn: "ProductImgId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "ProductImg",
                keyColumn: "ProductImgId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "ProductImg",
                keyColumn: "ProductImgId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "ProductImg",
                keyColumn: "ProductImgId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "ProductImg",
                keyColumn: "ProductImgId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "ProductImg",
                keyColumn: "ProductImgId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "ProductImg",
                keyColumn: "ProductImgId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "ProductSize",
                keyColumn: "ProductSizeId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ProductSize",
                keyColumn: "ProductSizeId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ProductSize",
                keyColumn: "ProductSizeId",
                keyValue: 3);
        }
    }
}
