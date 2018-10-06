using Microsoft.EntityFrameworkCore.Migrations;

namespace Lab1.Data.Migrations
{
    public partial class DBForKeys : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Vectors_IdAlt",
                table: "Vectors",
                column: "IdAlt");

            migrationBuilder.CreateIndex(
                name: "IX_Vectors_IdMark",
                table: "Vectors",
                column: "IdMark");

            migrationBuilder.CreateIndex(
                name: "IX_Results_IdAlt",
                table: "Results",
                column: "IdAlt");

            migrationBuilder.CreateIndex(
                name: "IX_Results_IdLPR",
                table: "Results",
                column: "IdLPR");

            migrationBuilder.CreateIndex(
                name: "IX_Marks_IdCrit",
                table: "Marks",
                column: "IdCrit");

            migrationBuilder.AddForeignKey(
                name: "FK_Marks_Criterions_IdCrit",
                table: "Marks",
                column: "IdCrit",
                principalTable: "Criterions",
                principalColumn: "IdCrit",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Results_Alternatives_IdAlt",
                table: "Results",
                column: "IdAlt",
                principalTable: "Alternatives",
                principalColumn: "IdAlt",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Results_LPRs_IdLPR",
                table: "Results",
                column: "IdLPR",
                principalTable: "LPRs",
                principalColumn: "IdLPR",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Vectors_Alternatives_IdAlt",
                table: "Vectors",
                column: "IdAlt",
                principalTable: "Alternatives",
                principalColumn: "IdAlt",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Vectors_Marks_IdMark",
                table: "Vectors",
                column: "IdMark",
                principalTable: "Marks",
                principalColumn: "IdMark",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Marks_Criterions_IdCrit",
                table: "Marks");

            migrationBuilder.DropForeignKey(
                name: "FK_Results_Alternatives_IdAlt",
                table: "Results");

            migrationBuilder.DropForeignKey(
                name: "FK_Results_LPRs_IdLPR",
                table: "Results");

            migrationBuilder.DropForeignKey(
                name: "FK_Vectors_Alternatives_IdAlt",
                table: "Vectors");

            migrationBuilder.DropForeignKey(
                name: "FK_Vectors_Marks_IdMark",
                table: "Vectors");

            migrationBuilder.DropIndex(
                name: "IX_Vectors_IdAlt",
                table: "Vectors");

            migrationBuilder.DropIndex(
                name: "IX_Vectors_IdMark",
                table: "Vectors");

            migrationBuilder.DropIndex(
                name: "IX_Results_IdAlt",
                table: "Results");

            migrationBuilder.DropIndex(
                name: "IX_Results_IdLPR",
                table: "Results");

            migrationBuilder.DropIndex(
                name: "IX_Marks_IdCrit",
                table: "Marks");
        }
    }
}
