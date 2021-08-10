using Microsoft.EntityFrameworkCore.Migrations;

namespace CCJShop.Migrations.Product
{
    public partial class AddImgSeq : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ImgSeq",
                table: "ProductImg",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "ProductImg",
                keyColumn: "ProductImgId",
                keyValue: 1,
                column: "ImgSeq",
                value: 1);

            migrationBuilder.UpdateData(
                table: "ProductImg",
                keyColumn: "ProductImgId",
                keyValue: 2,
                column: "ImgSeq",
                value: 2);

            migrationBuilder.UpdateData(
                table: "ProductImg",
                keyColumn: "ProductImgId",
                keyValue: 3,
                column: "ImgSeq",
                value: 3);

            migrationBuilder.UpdateData(
                table: "ProductImg",
                keyColumn: "ProductImgId",
                keyValue: 4,
                column: "ImgSeq",
                value: 4);

            migrationBuilder.UpdateData(
                table: "ProductImg",
                keyColumn: "ProductImgId",
                keyValue: 5,
                column: "ImgSeq",
                value: 5);

            migrationBuilder.UpdateData(
                table: "ProductImg",
                keyColumn: "ProductImgId",
                keyValue: 6,
                column: "ImgSeq",
                value: 1);

            migrationBuilder.UpdateData(
                table: "ProductImg",
                keyColumn: "ProductImgId",
                keyValue: 7,
                column: "ImgSeq",
                value: 2);

            migrationBuilder.UpdateData(
                table: "ProductImg",
                keyColumn: "ProductImgId",
                keyValue: 8,
                column: "ImgSeq",
                value: 3);

            migrationBuilder.UpdateData(
                table: "ProductImg",
                keyColumn: "ProductImgId",
                keyValue: 9,
                column: "ImgSeq",
                value: 4);

            migrationBuilder.UpdateData(
                table: "ProductImg",
                keyColumn: "ProductImgId",
                keyValue: 10,
                column: "ImgSeq",
                value: 1);

            migrationBuilder.UpdateData(
                table: "ProductImg",
                keyColumn: "ProductImgId",
                keyValue: 11,
                column: "ImgSeq",
                value: 2);

            migrationBuilder.UpdateData(
                table: "ProductImg",
                keyColumn: "ProductImgId",
                keyValue: 12,
                column: "ImgSeq",
                value: 3);

            migrationBuilder.UpdateData(
                table: "ProductImg",
                keyColumn: "ProductImgId",
                keyValue: 13,
                column: "ImgSeq",
                value: 4);

            migrationBuilder.UpdateData(
                table: "ProductImg",
                keyColumn: "ProductImgId",
                keyValue: 14,
                column: "ImgSeq",
                value: 1);

            migrationBuilder.UpdateData(
                table: "ProductImg",
                keyColumn: "ProductImgId",
                keyValue: 15,
                column: "ImgSeq",
                value: 2);

            migrationBuilder.UpdateData(
                table: "ProductImg",
                keyColumn: "ProductImgId",
                keyValue: 16,
                column: "ImgSeq",
                value: 3);

            migrationBuilder.UpdateData(
                table: "ProductImg",
                keyColumn: "ProductImgId",
                keyValue: 17,
                column: "ImgSeq",
                value: 4);

            migrationBuilder.UpdateData(
                table: "ProductImg",
                keyColumn: "ProductImgId",
                keyValue: 18,
                column: "ImgSeq",
                value: 5);

            migrationBuilder.UpdateData(
                table: "ProductImg",
                keyColumn: "ProductImgId",
                keyValue: 19,
                column: "ImgSeq",
                value: 1);

            migrationBuilder.UpdateData(
                table: "ProductImg",
                keyColumn: "ProductImgId",
                keyValue: 20,
                column: "ImgSeq",
                value: 2);

            migrationBuilder.UpdateData(
                table: "ProductImg",
                keyColumn: "ProductImgId",
                keyValue: 21,
                column: "ImgSeq",
                value: 3);

            migrationBuilder.UpdateData(
                table: "ProductImg",
                keyColumn: "ProductImgId",
                keyValue: 22,
                column: "ImgSeq",
                value: 4);

            migrationBuilder.UpdateData(
                table: "ProductImg",
                keyColumn: "ProductImgId",
                keyValue: 23,
                column: "ImgSeq",
                value: 5);

            migrationBuilder.UpdateData(
                table: "ProductImg",
                keyColumn: "ProductImgId",
                keyValue: 24,
                column: "ImgSeq",
                value: 6);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImgSeq",
                table: "ProductImg");
        }
    }
}
