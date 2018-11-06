using Microsoft.EntityFrameworkCore.Migrations;

namespace Lab1.Data.Migrations
{
    public partial class absolute1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AbsoluteDecisions_AspNetUsers_UserId",
                table: "AbsoluteDecisions");

            migrationBuilder.DropIndex(
                name: "IX_AbsoluteDecisions_UserId",
                table: "AbsoluteDecisions");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "AbsoluteDecisions",
                newName: "UserName");

            migrationBuilder.AlterColumn<string>(
                name: "UserName",
                table: "AbsoluteDecisions",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UserName",
                table: "AbsoluteDecisions",
                newName: "UserId");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "AbsoluteDecisions",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_AbsoluteDecisions_UserId",
                table: "AbsoluteDecisions",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_AbsoluteDecisions_AspNetUsers_UserId",
                table: "AbsoluteDecisions",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
