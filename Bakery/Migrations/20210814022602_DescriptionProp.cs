using Microsoft.EntityFrameworkCore.Migrations;

namespace Bakery.Migrations
{
    public partial class DescriptionProp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Treats",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Flavors",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Treats");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Flavors");
        }
    }
}
