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
                name: "Kategorijos",
                columns: table => new
                {
                    KategorijosId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Kategorija = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kategorijos", x => x.KategorijosId);
                });

            migrationBuilder.CreateTable(
                name: "Skaitytojas",
                columns: table => new
                {
                    PazymejimoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Vardas = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pavarde = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PazymejimoIsdavimoData = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Slaptazodis = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Skaitytojas", x => x.PazymejimoId);
                });

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
                    Kiekis = table.Column<int>(type: "int", nullable: false),
                    KategorijosId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Knyga", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Knyga_Kategorijos_KategorijosId",
                        column: x => x.KategorijosId,
                        principalTable: "Kategorijos",
                        principalColumn: "KategorijosId");
                });

            migrationBuilder.CreateTable(
                name: "KnygaSkaitytojas",
                columns: table => new
                {
                    MegstamiausiosId = table.Column<int>(type: "int", nullable: false),
                    SkaitytojaiPazymejimoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KnygaSkaitytojas", x => new { x.MegstamiausiosId, x.SkaitytojaiPazymejimoId });
                    table.ForeignKey(
                        name: "FK_KnygaSkaitytojas_Knyga_MegstamiausiosId",
                        column: x => x.MegstamiausiosId,
                        principalTable: "Knyga",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_KnygaSkaitytojas_Skaitytojas_SkaitytojaiPazymejimoId",
                        column: x => x.SkaitytojaiPazymejimoId,
                        principalTable: "Skaitytojas",
                        principalColumn: "PazymejimoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Rezervacija",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KnyguKiekis = table.Column<int>(type: "int", nullable: false),
                    KnygaId = table.Column<int>(type: "int", nullable: true),
                    SkaitytojasPazymejimoId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rezervacija", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Rezervacija_Knyga_KnygaId",
                        column: x => x.KnygaId,
                        principalTable: "Knyga",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Rezervacija_Skaitytojas_SkaitytojasPazymejimoId",
                        column: x => x.SkaitytojasPazymejimoId,
                        principalTable: "Skaitytojas",
                        principalColumn: "PazymejimoId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Knyga_KategorijosId",
                table: "Knyga",
                column: "KategorijosId");

            migrationBuilder.CreateIndex(
                name: "IX_KnygaSkaitytojas_SkaitytojaiPazymejimoId",
                table: "KnygaSkaitytojas",
                column: "SkaitytojaiPazymejimoId");

            migrationBuilder.CreateIndex(
                name: "IX_Rezervacija_KnygaId",
                table: "Rezervacija",
                column: "KnygaId");

            migrationBuilder.CreateIndex(
                name: "IX_Rezervacija_SkaitytojasPazymejimoId",
                table: "Rezervacija",
                column: "SkaitytojasPazymejimoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "KnygaSkaitytojas");

            migrationBuilder.DropTable(
                name: "Rezervacija");

            migrationBuilder.DropTable(
                name: "Knyga");

            migrationBuilder.DropTable(
                name: "Skaitytojas");

            migrationBuilder.DropTable(
                name: "Kategorijos");
        }
    }
}
