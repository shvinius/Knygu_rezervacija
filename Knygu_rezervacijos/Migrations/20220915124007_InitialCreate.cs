using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Knygu_rezervacijos.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Slaptazodis",
                table: "Skaitytojas",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Slaptazodis",
                table: "Skaitytojas");
        }
    }
}
