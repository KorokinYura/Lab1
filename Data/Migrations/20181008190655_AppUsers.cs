using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Lab1.Data.Migrations
{
    public partial class AppUsers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Results_LPRs_IdLPR",
                table: "Results");

            migrationBuilder.DropTable(
                name: "LPRs");

            migrationBuilder.DropIndex(
                name: "IX_Results_IdLPR",
                table: "Results");

            migrationBuilder.AddColumn<string>(
                name: "LPRId",
                table: "Results",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LRange",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Results_LPRId",
                table: "Results",
                column: "LPRId");

            migrationBuilder.AddForeignKey(
                name: "FK_Results_AspNetUsers_LPRId",
                table: "Results",
                column: "LPRId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Results_AspNetUsers_LPRId",
                table: "Results");

            migrationBuilder.DropIndex(
                name: "IX_Results_LPRId",
                table: "Results");

            migrationBuilder.DropColumn(
                name: "LPRId",
                table: "Results");

            migrationBuilder.DropColumn(
                name: "LRange",
                table: "AspNetUsers");

            migrationBuilder.CreateTable(
                name: "LPRs",
                columns: table => new
                {
                    IdLPR = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    LName = table.Column<string>(nullable: true),
                    LRange = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LPRs", x => x.IdLPR);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Results_IdLPR",
                table: "Results",
                column: "IdLPR");

            migrationBuilder.AddForeignKey(
                name: "FK_Results_LPRs_IdLPR",
                table: "Results",
                column: "IdLPR",
                principalTable: "LPRs",
                principalColumn: "IdLPR",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
