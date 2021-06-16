using Microsoft.EntityFrameworkCore.Migrations;

namespace CCJShop.Migrations
{
    public partial class InitParam : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Param",
                columns: table => new
                {
                    ParamId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GroupId = table.Column<int>(type: "int", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Memo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpParamId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Param", x => x.ParamId);
                });

            migrationBuilder.InsertData(
                table: "Param",
                columns: new[] { "ParamId", "Code", "GroupId", "Memo", "Name", "UpParamId" },
                values: new object[,]
                {
                    { 1, "1", 1, "地區", "北部", 0 },
                    { 2, "2", 1, "地區", "中部", 0 },
                    { 3, "3", 1, "地區", "南部", 0 },
                    { 4, "4", 1, "地區", "東部", 0 },
                    { 5, "5", 1, "地區", "外島", 0 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Param");
        }
    }
}
