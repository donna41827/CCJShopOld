using Microsoft.EntityFrameworkCore.Migrations;

namespace CCJShop.Migrations.Product
{
    public partial class AddClotheData3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "SizeMemo",
                table: "ProductSize",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ColorName",
                table: "ProductColor",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "ProductColor",
                keyColumn: "ProductColorId",
                keyValue: 1,
                column: "ColorName",
                value: "白");

            migrationBuilder.UpdateData(
                table: "ProductColor",
                keyColumn: "ProductColorId",
                keyValue: 2,
                column: "ColorName",
                value: "黑");

            migrationBuilder.UpdateData(
                table: "ProductColor",
                keyColumn: "ProductColorId",
                keyValue: 3,
                column: "ColorName",
                value: "杏");

            migrationBuilder.UpdateData(
                table: "ProductColor",
                keyColumn: "ProductColorId",
                keyValue: 4,
                column: "ColorName",
                value: "藍");

            migrationBuilder.UpdateData(
                table: "ProductColor",
                keyColumn: "ProductColorId",
                keyValue: 5,
                column: "ColorName",
                value: "白");

            migrationBuilder.UpdateData(
                table: "ProductColor",
                keyColumn: "ProductColorId",
                keyValue: 6,
                column: "ColorName",
                value: "黑");

            migrationBuilder.UpdateData(
                table: "ProductColor",
                keyColumn: "ProductColorId",
                keyValue: 7,
                column: "ColorName",
                value: "藍");

            migrationBuilder.UpdateData(
                table: "ProductColor",
                keyColumn: "ProductColorId",
                keyValue: 8,
                column: "ColorName",
                value: "杏");

            migrationBuilder.UpdateData(
                table: "ProductColor",
                keyColumn: "ProductColorId",
                keyValue: 9,
                column: "ColorName",
                value: "綠");

            migrationBuilder.UpdateData(
                table: "ProductSize",
                keyColumn: "ProductSizeId",
                keyValue: 1,
                column: "SizeMemo",
                value: "腰圍58 裙長77");

            migrationBuilder.UpdateData(
                table: "ProductSize",
                keyColumn: "ProductSizeId",
                keyValue: 2,
                column: "SizeMemo",
                value: "腰圍60 裙長78");

            migrationBuilder.UpdateData(
                table: "ProductSize",
                keyColumn: "ProductSizeId",
                keyValue: 3,
                column: "SizeMemo",
                value: "腰圍63 裙長79");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SizeMemo",
                table: "ProductSize");

            migrationBuilder.DropColumn(
                name: "ColorName",
                table: "ProductColor");
        }
    }
}
