using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Knygu_rezervacijos.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Knyga",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                    .Annotation("SqlServer:Identity", "1, 1"),
                    Pavadinimas = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Santrauka = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ISBN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nuotrauka = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PuslapiuSkaicius = table.Column<int>(type: "int", nullable: false),
                    Kiekis = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Knyga", x => x.Id);
                }) ;
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Knyga");
        }
    }
}
