using Microsoft.EntityFrameworkCore.Migrations;

namespace Webcore_demo.Migrations
{
    public partial class requires : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "UserDetails",
                keyColumn: "Id",
                keyValue: 0,
                column: "UserName",
                value: "ank");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "UserDetails",
                keyColumn: "Id",
                keyValue: 0,
                column: "UserName",
                value: "lucky");
        }
    }
}
