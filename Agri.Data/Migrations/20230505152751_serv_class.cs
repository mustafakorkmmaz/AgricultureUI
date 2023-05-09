using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Agri.Data.Migrations
{
    public partial class serv_class : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ServiceClassFirst",
                table: "Servisler",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ServiceClassSec",
                table: "Servisler",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ServiceClassFirst",
                table: "Servisler");

            migrationBuilder.DropColumn(
                name: "ServiceClassSec",
                table: "Servisler");
        }
    }
}
