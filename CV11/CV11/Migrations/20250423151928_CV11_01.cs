using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CV11.Migrations
{
    /// <inheritdoc />
    public partial class CV11_01 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Hodnoceni",
                columns: table => new
                {
                    IdStudent = table.Column<int>(type: "int", nullable: false),
                    ZkratkaPredmet = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Datum = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Znamka = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hodnoceni", x => x.IdStudent);
                });

            migrationBuilder.CreateTable(
                name: "Predmet",
                columns: table => new
                {
                    Zkratka = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Nazev = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Predmet", x => x.Zkratka);
                });

            migrationBuilder.CreateTable(
                name: "StudentsPredmet",
                columns: table => new
                {
                    IdStudent = table.Column<int>(type: "int", nullable: false),
                    ZkratkaPredmet = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentsPredmet", x => x.IdStudent);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Hodnoceni");

            migrationBuilder.DropTable(
                name: "Predmet");

            migrationBuilder.DropTable(
                name: "StudentsPredmet");
        }
    }
}
