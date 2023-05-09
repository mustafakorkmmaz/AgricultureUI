using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Agri.Data.Migrations
{
    public partial class ad_newss : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "NewsSummary",
                table: "Haberler",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "NewsTopic",
                table: "Haberler",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NewsSummary",
                table: "Haberler");

            migrationBuilder.DropColumn(
                name: "NewsTopic",
                table: "Haberler");
        }
    }
}
