using Microsoft.EntityFrameworkCore.Migrations;

namespace Webcore_demo.Migrations
{
    public partial class createsp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "UserDetails",
                columns: new[] { "Id", "Email", "Password", "Roles", "UserName" },
                values: new object[] { 2, null, "123", "user", "lucky" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserDetails",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
