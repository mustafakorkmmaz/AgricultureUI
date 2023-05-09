using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Agri.Data.Migrations
{
    public partial class newsres : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "NewsImage",
                table: "Haberler",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NewsImage",
                table: "Haberler");
        }
    }
}
