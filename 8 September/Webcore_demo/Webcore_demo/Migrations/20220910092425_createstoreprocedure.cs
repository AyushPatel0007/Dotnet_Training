using Microsoft.EntityFrameworkCore.Migrations;

namespace Webcore_demo.Migrations
{
    public partial class createstoreprocedure : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var sp = @"create proc GetData as begin select * from UserDetails end";
            migrationBuilder.Sql(sp);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        { 
        }
    }
}
