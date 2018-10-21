using Microsoft.EntityFrameworkCore.Migrations;

namespace Lab1.Data.Migrations
{
    public partial class ResultReworked : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IdLPR",
                table: "Results");

            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "Results",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserName",
                table: "Results");

            migrationBuilder.AddColumn<int>(
                name: "IdLPR",
                table: "Results",
                nullable: false,
                defaultValue: 0);
        }
    }
}
