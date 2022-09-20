using Microsoft.EntityFrameworkCore.Migrations;

namespace Webcore_demo.Migrations
{
    public partial class require : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "UserDetails",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.InsertData(
                table: "UserDetails",
                columns: new[] { "Id", "Email", "Password", "Roles", "UserName" },
                values: new object[] { 0, null, "123", "user", "lucky" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserDetails",
                keyColumn: "Id",
                keyValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "UserDetails",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");
        }
    }
}
