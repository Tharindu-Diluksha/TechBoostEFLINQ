using Microsoft.EntityFrameworkCore.Migrations;

namespace TechBoostEFLINQ.Migrations
{
    public partial class RenameBlobUrl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "BlobUrl",
                table: "Blogs",
                newName: "Link");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Link",
                table: "Blogs",
                newName: "BlobUrl");
        }
    }
}
