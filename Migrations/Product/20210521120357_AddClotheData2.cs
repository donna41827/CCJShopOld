using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CCJShop.Migrations.Product
{
    public partial class AddClotheData2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ProductId", "CDT", "MDT", "Memo", "Name", "Price", "Status" },
                values: new object[] { 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "最愛黑白配 <br>夏天必備的薄透感西裝外套<br>設計假口袋 長度適中 沒有墊肩問題<br>配褲裝或是裙類單品都可以", "薄款同色扣假口袋西裝外套", 550, 1 });

            migrationBuilder.UpdateData(
                table: "ProductColor",
                keyColumn: "ProductColorId",
                keyValue: 1,
                column: "ColorCode",
                value: "#FFFFFF");

            migrationBuilder.InsertData(
                table: "ProductColor",
                columns: new[] { "ProductColorId", "AddPrice", "CDT", "ColorCode", "MDT", "ProductId" },
                values: new object[,]
                {
                    { 5, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "#FFFFFF", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 },
                    { 6, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "#000000", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 },
                    { 7, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "#BDCDFF", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 },
                    { 8, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "#FFFBD1", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 },
                    { 9, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "#E1FFA5", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 }
                });

            migrationBuilder.InsertData(
                table: "ProductImg",
                columns: new[] { "ProductImgId", "CDT", "ImgSrc", "MDT", "ProductColorId", "ProductId" },
                values: new object[,]
                {
                    { 19, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "/Image/19.jpg", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 5 },
                    { 20, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "/Image/20.jpg", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 5 },
                    { 21, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "/Image/21.jpg", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 5 },
                    { 22, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "/Image/22.jpg", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 5 },
                    { 23, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "/Image/23.jpg", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 5 },
                    { 24, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "/Image/24.jpg", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 5 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ProductColor",
                keyColumn: "ProductColorId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ProductColor",
                keyColumn: "ProductColorId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "ProductColor",
                keyColumn: "ProductColorId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "ProductColor",
                keyColumn: "ProductColorId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "ProductColor",
                keyColumn: "ProductColorId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "ProductImg",
                keyColumn: "ProductImgId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "ProductImg",
                keyColumn: "ProductImgId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "ProductImg",
                keyColumn: "ProductImgId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "ProductImg",
                keyColumn: "ProductImgId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "ProductImg",
                keyColumn: "ProductImgId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "ProductImg",
                keyColumn: "ProductImgId",
                keyValue: 24);

            migrationBuilder.UpdateData(
                table: "ProductColor",
                keyColumn: "ProductColorId",
                keyValue: 1,
                column: "ColorCode",
                value: "#ffffff");
        }
    }
}
