using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CCJShop.Migrations.Product
{
    public partial class AddDataProduct2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "ProductImg",
                columns: new[] { "ProductImgId", "CDT", "ImgSrc", "MDT", "ProductColorId", "ProductId" },
                values: new object[,]
                {
                    { 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "~/Image/3.jpg", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 1 },
                    { 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "~/Image/4.jpg", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 1 },
                    { 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "~/Image/5.jpg", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 1 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProductImg",
                keyColumn: "ProductImgId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ProductImg",
                keyColumn: "ProductImgId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ProductImg",
                keyColumn: "ProductImgId",
                keyValue: 5);

            migrationBuilder.UpdateData(
                table: "ProductImg",
                keyColumn: "ProductImgId",
                keyValue: 1,
                column: "ImgSrc",
                value: "https://instagram.ftpe5-1.fna.fbcdn.net/v/t51.2885-15/e35/s1080x1080/174079068_950674635472462_4447592011368211239_n.jpg?tp=1&_nc_ht=instagram.ftpe5-1.fna.fbcdn.net&_nc_cat=110&_nc_ohc=hmylVF-ezWkAX-Sk9pn&edm=AP_V10EBAAAA&ccb=7-4&oh=79e65203173c8f86022353da81649786&oe=60AF244D&_nc_sid=4f375e");

            migrationBuilder.UpdateData(
                table: "ProductImg",
                keyColumn: "ProductImgId",
                keyValue: 2,
                column: "ImgSrc",
                value: "https://instagram.ftpe5-1.fna.fbcdn.net/v/t51.2885-15/e35/s1080x1080/173084051_1409041302766659_8619673499345077503_n.jpg?tp=1&_nc_ht=instagram.ftpe5-1.fna.fbcdn.net&_nc_cat=103&_nc_ohc=XEhZLjPa1wIAX9GpbeC&edm=AP_V10EBAAAA&ccb=7-4&oh=e8bb670a2aa5beda5e5fc0e3f1bf8e1b&oe=60AF0252&_nc_sid=4f375e");
        }
    }
}
