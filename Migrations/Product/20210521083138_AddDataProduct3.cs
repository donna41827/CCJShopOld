using Microsoft.EntityFrameworkCore.Migrations;

namespace CCJShop.Migrations.Product
{
    public partial class AddDataProduct3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ProductImg",
                keyColumn: "ProductImgId",
                keyValue: 1,
                column: "ImgSrc",
                value: "/Image/1.jpg");

            migrationBuilder.UpdateData(
                table: "ProductImg",
                keyColumn: "ProductImgId",
                keyValue: 2,
                column: "ImgSrc",
                value: "/Image/2.jpg");

            migrationBuilder.UpdateData(
                table: "ProductImg",
                keyColumn: "ProductImgId",
                keyValue: 3,
                column: "ImgSrc",
                value: "/Image/3.jpg");

            migrationBuilder.UpdateData(
                table: "ProductImg",
                keyColumn: "ProductImgId",
                keyValue: 4,
                column: "ImgSrc",
                value: "/Image/4.jpg");

            migrationBuilder.UpdateData(
                table: "ProductImg",
                keyColumn: "ProductImgId",
                keyValue: 5,
                column: "ImgSrc",
                value: "/Image/5.jpg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ProductImg",
                keyColumn: "ProductImgId",
                keyValue: 1,
                column: "ImgSrc",
                value: "~/Image/1.jpg");

            migrationBuilder.UpdateData(
                table: "ProductImg",
                keyColumn: "ProductImgId",
                keyValue: 2,
                column: "ImgSrc",
                value: "~/Image/2.jpg");

            migrationBuilder.UpdateData(
                table: "ProductImg",
                keyColumn: "ProductImgId",
                keyValue: 3,
                column: "ImgSrc",
                value: "~/Image/3.jpg");

            migrationBuilder.UpdateData(
                table: "ProductImg",
                keyColumn: "ProductImgId",
                keyValue: 4,
                column: "ImgSrc",
                value: "~/Image/4.jpg");

            migrationBuilder.UpdateData(
                table: "ProductImg",
                keyColumn: "ProductImgId",
                keyValue: 5,
                column: "ImgSrc",
                value: "~/Image/5.jpg");
        }
    }
}
