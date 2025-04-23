using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CV11.Migrations
{
    /// <inheritdoc />
    public partial class CV11_02 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_StudentsPredmet",
                table: "StudentsPredmet");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Hodnoceni",
                table: "Hodnoceni");

            migrationBuilder.AlterColumn<string>(
                name: "ZkratkaPredmet",
                table: "StudentsPredmet",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "ZkratkaPredmet",
                table: "Hodnoceni",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StudentsPredmet",
                table: "StudentsPredmet",
                columns: new[] { "IdStudent", "ZkratkaPredmet" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Hodnoceni",
                table: "Hodnoceni",
                columns: new[] { "IdStudent", "ZkratkaPredmet" });

            migrationBuilder.CreateIndex(
                name: "IX_StudentsPredmet_ZkratkaPredmet",
                table: "StudentsPredmet",
                column: "ZkratkaPredmet");

            migrationBuilder.CreateIndex(
                name: "IX_Hodnoceni_ZkratkaPredmet",
                table: "Hodnoceni",
                column: "ZkratkaPredmet");

            migrationBuilder.AddForeignKey(
                name: "FK_Hodnoceni_Predmet_ZkratkaPredmet",
                table: "Hodnoceni",
                column: "ZkratkaPredmet",
                principalTable: "Predmet",
                principalColumn: "Zkratka",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Hodnoceni_Students_IdStudent",
                table: "Hodnoceni",
                column: "IdStudent",
                principalTable: "Students",
                principalColumn: "StudentId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StudentsPredmet_Predmet_ZkratkaPredmet",
                table: "StudentsPredmet",
                column: "ZkratkaPredmet",
                principalTable: "Predmet",
                principalColumn: "Zkratka",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StudentsPredmet_Students_IdStudent",
                table: "StudentsPredmet",
                column: "IdStudent",
                principalTable: "Students",
                principalColumn: "StudentId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Hodnoceni_Predmet_ZkratkaPredmet",
                table: "Hodnoceni");

            migrationBuilder.DropForeignKey(
                name: "FK_Hodnoceni_Students_IdStudent",
                table: "Hodnoceni");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentsPredmet_Predmet_ZkratkaPredmet",
                table: "StudentsPredmet");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentsPredmet_Students_IdStudent",
                table: "StudentsPredmet");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StudentsPredmet",
                table: "StudentsPredmet");

            migrationBuilder.DropIndex(
                name: "IX_StudentsPredmet_ZkratkaPredmet",
                table: "StudentsPredmet");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Hodnoceni",
                table: "Hodnoceni");

            migrationBuilder.DropIndex(
                name: "IX_Hodnoceni_ZkratkaPredmet",
                table: "Hodnoceni");

            migrationBuilder.AlterColumn<string>(
                name: "ZkratkaPredmet",
                table: "StudentsPredmet",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "ZkratkaPredmet",
                table: "Hodnoceni",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StudentsPredmet",
                table: "StudentsPredmet",
                column: "IdStudent");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Hodnoceni",
                table: "Hodnoceni",
                column: "IdStudent");
        }
    }
}
