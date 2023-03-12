using Microsoft.EntityFrameworkCore.Migrations;

namespace TechBoostEFLINQ.Migrations
{
    public partial class testreanme : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Title",
                table: "Posts",
                newName: "Name");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Posts",
                newName: "Title");
        }
    }
}
