using Microsoft.EntityFrameworkCore.Migrations;

namespace Lab1.Data.Migrations
{
    public partial class group5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Voted",
                table: "GroupDecisions");

            migrationBuilder.AddColumn<string>(
                name: "Vote",
                table: "GroupDecisions",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Vote",
                table: "GroupDecisions");

            migrationBuilder.AddColumn<bool>(
                name: "Voted",
                table: "GroupDecisions",
                nullable: false,
                defaultValue: false);
        }
    }
}
