using Microsoft.EntityFrameworkCore.Migrations;

namespace Lab1.Data.Migrations
{
    public partial class group6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Vote",
                table: "GroupDecisions");

            migrationBuilder.AddColumn<int>(
                name: "IdAlt",
                table: "GroupDecisions",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Mark",
                table: "GroupDecisions",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IdAlt",
                table: "GroupDecisions");

            migrationBuilder.DropColumn(
                name: "Mark",
                table: "GroupDecisions");

            migrationBuilder.AddColumn<string>(
                name: "Vote",
                table: "GroupDecisions",
                nullable: true);
        }
    }
}
