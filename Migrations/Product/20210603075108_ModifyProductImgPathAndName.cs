using Microsoft.EntityFrameworkCore.Migrations;

namespace CCJShop.Migrations.Product
{
    public partial class ModifyProductImgPathAndName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ImgSrc",
                table: "ProductImg",
                newName: "ImgPath");

            migrationBuilder.AddColumn<string>(
                name: "ImgName",
                table: "ProductImg",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "ProductImg",
                keyColumn: "ProductImgId",
                keyValue: 1,
                columns: new[] { "ImgName", "ImgPath" },
                values: new object[] { "1.jpg", "/Image/" });

            migrationBuilder.UpdateData(
                table: "ProductImg",
                keyColumn: "ProductImgId",
                keyValue: 2,
                columns: new[] { "ImgName", "ImgPath" },
                values: new object[] { "2.jpg", "/Image/" });

            migrationBuilder.UpdateData(
                table: "ProductImg",
                keyColumn: "ProductImgId",
                keyValue: 3,
                columns: new[] { "ImgName", "ImgPath" },
                values: new object[] { "3.jpg", "/Image/" });

            migrationBuilder.UpdateData(
                table: "ProductImg",
                keyColumn: "ProductImgId",
                keyValue: 4,
                columns: new[] { "ImgName", "ImgPath" },
                values: new object[] { "4.jpg", "/Image/" });

            migrationBuilder.UpdateData(
                table: "ProductImg",
                keyColumn: "ProductImgId",
                keyValue: 5,
                columns: new[] { "ImgName", "ImgPath" },
                values: new object[] { "5.jpg", "/Image/" });

            migrationBuilder.UpdateData(
                table: "ProductImg",
                keyColumn: "ProductImgId",
                keyValue: 6,
                columns: new[] { "ImgName", "ImgPath" },
                values: new object[] { "6.jpg", "/Image/" });

            migrationBuilder.UpdateData(
                table: "ProductImg",
                keyColumn: "ProductImgId",
                keyValue: 7,
                columns: new[] { "ImgName", "ImgPath" },
                values: new object[] { "7.jpg", "/Image/" });

            migrationBuilder.UpdateData(
                table: "ProductImg",
                keyColumn: "ProductImgId",
                keyValue: 8,
                columns: new[] { "ImgName", "ImgPath" },
                values: new object[] { "8.jpg", "/Image/" });

            migrationBuilder.UpdateData(
                table: "ProductImg",
                keyColumn: "ProductImgId",
                keyValue: 9,
                columns: new[] { "ImgName", "ImgPath" },
                values: new object[] { "9.jpg", "/Image/" });

            migrationBuilder.UpdateData(
                table: "ProductImg",
                keyColumn: "ProductImgId",
                keyValue: 10,
                columns: new[] { "ImgName", "ImgPath" },
                values: new object[] { "10.jpg", "/Image/" });

            migrationBuilder.UpdateData(
                table: "ProductImg",
                keyColumn: "ProductImgId",
                keyValue: 11,
                columns: new[] { "ImgName", "ImgPath" },
                values: new object[] { "11.jpg", "/Image/" });

            migrationBuilder.UpdateData(
                table: "ProductImg",
                keyColumn: "ProductImgId",
                keyValue: 12,
                columns: new[] { "ImgName", "ImgPath" },
                values: new object[] { "12.jpg", "/Image/" });

            migrationBuilder.UpdateData(
                table: "ProductImg",
                keyColumn: "ProductImgId",
                keyValue: 13,
                columns: new[] { "ImgName", "ImgPath" },
                values: new object[] { "13.jpg", "/Image/" });

            migrationBuilder.UpdateData(
                table: "ProductImg",
                keyColumn: "ProductImgId",
                keyValue: 14,
                columns: new[] { "ImgName", "ImgPath" },
                values: new object[] { "14.jpg", "/Image/" });

            migrationBuilder.UpdateData(
                table: "ProductImg",
                keyColumn: "ProductImgId",
                keyValue: 15,
                columns: new[] { "ImgName", "ImgPath" },
                values: new object[] { "15.jpg", "/Image/" });

            migrationBuilder.UpdateData(
                table: "ProductImg",
                keyColumn: "ProductImgId",
                keyValue: 16,
                columns: new[] { "ImgName", "ImgPath" },
                values: new object[] { "16.jpg", "/Image/" });

            migrationBuilder.UpdateData(
                table: "ProductImg",
                keyColumn: "ProductImgId",
                keyValue: 17,
                columns: new[] { "ImgName", "ImgPath" },
                values: new object[] { "17.jpg", "/Image/" });

            migrationBuilder.UpdateData(
                table: "ProductImg",
                keyColumn: "ProductImgId",
                keyValue: 18,
                columns: new[] { "ImgName", "ImgPath" },
                values: new object[] { "18.jpg", "/Image/" });

            migrationBuilder.UpdateData(
                table: "ProductImg",
                keyColumn: "ProductImgId",
                keyValue: 19,
                columns: new[] { "ImgName", "ImgPath" },
                values: new object[] { "19.jpg", "/Image/" });

            migrationBuilder.UpdateData(
                table: "ProductImg",
                keyColumn: "ProductImgId",
                keyValue: 20,
                columns: new[] { "ImgName", "ImgPath" },
                values: new object[] { "20.jpg", "/Image/" });

            migrationBuilder.UpdateData(
                table: "ProductImg",
                keyColumn: "ProductImgId",
                keyValue: 21,
                columns: new[] { "ImgName", "ImgPath" },
                values: new object[] { "21.jpg", "/Image/" });

            migrationBuilder.UpdateData(
                table: "ProductImg",
                keyColumn: "ProductImgId",
                keyValue: 22,
                columns: new[] { "ImgName", "ImgPath" },
                values: new object[] { "22.jpg", "/Image/" });

            migrationBuilder.UpdateData(
                table: "ProductImg",
                keyColumn: "ProductImgId",
                keyValue: 23,
                columns: new[] { "ImgName", "ImgPath" },
                values: new object[] { "23.jpg", "/Image/" });

            migrationBuilder.UpdateData(
                table: "ProductImg",
                keyColumn: "ProductImgId",
                keyValue: 24,
                columns: new[] { "ImgName", "ImgPath" },
                values: new object[] { "24.jpg", "/Image/" });

            migrationBuilder.CreateIndex(
                name: "IX_ProductSize_ProductId",
                table: "ProductSize",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductImg_ProductId",
                table: "ProductImg",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductColor_ProductId",
                table: "ProductColor",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductColor_Product_ProductId",
                table: "ProductColor",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductImg_Product_ProductId",
                table: "ProductImg",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductSize_Product_ProductId",
                table: "ProductSize",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductColor_Product_ProductId",
                table: "ProductColor");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductImg_Product_ProductId",
                table: "ProductImg");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductSize_Product_ProductId",
                table: "ProductSize");

            migrationBuilder.DropIndex(
                name: "IX_ProductSize_ProductId",
                table: "ProductSize");

            migrationBuilder.DropIndex(
                name: "IX_ProductImg_ProductId",
                table: "ProductImg");

            migrationBuilder.DropIndex(
                name: "IX_ProductColor_ProductId",
                table: "ProductColor");

            migrationBuilder.DropColumn(
                name: "ImgName",
                table: "ProductImg");

            migrationBuilder.RenameColumn(
                name: "ImgPath",
                table: "ProductImg",
                newName: "ImgSrc");

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

            migrationBuilder.UpdateData(
                table: "ProductImg",
                keyColumn: "ProductImgId",
                keyValue: 6,
                column: "ImgSrc",
                value: "/Image/6.jpg");

            migrationBuilder.UpdateData(
                table: "ProductImg",
                keyColumn: "ProductImgId",
                keyValue: 7,
                column: "ImgSrc",
                value: "/Image/7.jpg");

            migrationBuilder.UpdateData(
                table: "ProductImg",
                keyColumn: "ProductImgId",
                keyValue: 8,
                column: "ImgSrc",
                value: "/Image/8.jpg");

            migrationBuilder.UpdateData(
                table: "ProductImg",
                keyColumn: "ProductImgId",
                keyValue: 9,
                column: "ImgSrc",
                value: "/Image/9.jpg");

            migrationBuilder.UpdateData(
                table: "ProductImg",
                keyColumn: "ProductImgId",
                keyValue: 10,
                column: "ImgSrc",
                value: "/Image/10.jpg");

            migrationBuilder.UpdateData(
                table: "ProductImg",
                keyColumn: "ProductImgId",
                keyValue: 11,
                column: "ImgSrc",
                value: "/Image/11.jpg");

            migrationBuilder.UpdateData(
                table: "ProductImg",
                keyColumn: "ProductImgId",
                keyValue: 12,
                column: "ImgSrc",
                value: "/Image/12.jpg");

            migrationBuilder.UpdateData(
                table: "ProductImg",
                keyColumn: "ProductImgId",
                keyValue: 13,
                column: "ImgSrc",
                value: "/Image/13.jpg");

            migrationBuilder.UpdateData(
                table: "ProductImg",
                keyColumn: "ProductImgId",
                keyValue: 14,
                column: "ImgSrc",
                value: "/Image/14.jpg");

            migrationBuilder.UpdateData(
                table: "ProductImg",
                keyColumn: "ProductImgId",
                keyValue: 15,
                column: "ImgSrc",
                value: "/Image/15.jpg");

            migrationBuilder.UpdateData(
                table: "ProductImg",
                keyColumn: "ProductImgId",
                keyValue: 16,
                column: "ImgSrc",
                value: "/Image/16.jpg");

            migrationBuilder.UpdateData(
                table: "ProductImg",
                keyColumn: "ProductImgId",
                keyValue: 17,
                column: "ImgSrc",
                value: "/Image/17.jpg");

            migrationBuilder.UpdateData(
                table: "ProductImg",
                keyColumn: "ProductImgId",
                keyValue: 18,
                column: "ImgSrc",
                value: "/Image/18.jpg");

            migrationBuilder.UpdateData(
                table: "ProductImg",
                keyColumn: "ProductImgId",
                keyValue: 19,
                column: "ImgSrc",
                value: "/Image/19.jpg");

            migrationBuilder.UpdateData(
                table: "ProductImg",
                keyColumn: "ProductImgId",
                keyValue: 20,
                column: "ImgSrc",
                value: "/Image/20.jpg");

            migrationBuilder.UpdateData(
                table: "ProductImg",
                keyColumn: "ProductImgId",
                keyValue: 21,
                column: "ImgSrc",
                value: "/Image/21.jpg");

            migrationBuilder.UpdateData(
                table: "ProductImg",
                keyColumn: "ProductImgId",
                keyValue: 22,
                column: "ImgSrc",
                value: "/Image/22.jpg");

            migrationBuilder.UpdateData(
                table: "ProductImg",
                keyColumn: "ProductImgId",
                keyValue: 23,
                column: "ImgSrc",
                value: "/Image/23.jpg");

            migrationBuilder.UpdateData(
                table: "ProductImg",
                keyColumn: "ProductImgId",
                keyValue: 24,
                column: "ImgSrc",
                value: "/Image/24.jpg");
        }
    }
}
