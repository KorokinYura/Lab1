using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Lab1.Data.Migrations
{
    public partial class DBInit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Alternatives",
                columns: table => new
                {
                    IdAlt = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Alternatives", x => x.IdAlt);
                });

            migrationBuilder.CreateTable(
                name: "Criterions",
                columns: table => new
                {
                    IdCrit = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CName = table.Column<string>(nullable: true),
                    CRange = table.Column<int>(nullable: false),
                    CWeight = table.Column<int>(nullable: false),
                    CType = table.Column<string>(nullable: true),
                    OptimType = table.Column<string>(nullable: true),
                    EdIzmer = table.Column<string>(nullable: true),
                    ScaleType = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Criterions", x => x.IdCrit);
                });

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

            migrationBuilder.CreateTable(
                name: "Marks",
                columns: table => new
                {
                    IdMark = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IdCrit = table.Column<int>(nullable: false),
                    MName = table.Column<string>(nullable: true),
                    MRange = table.Column<int>(nullable: false),
                    NumMark = table.Column<int>(nullable: false),
                    NormMark = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Marks", x => x.IdMark);
                });

            migrationBuilder.CreateTable(
                name: "Results",
                columns: table => new
                {
                    IdRes = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IdLPR = table.Column<int>(nullable: false),
                    IdAlt = table.Column<int>(nullable: false),
                    Range = table.Column<int>(nullable: false),
                    AWeight = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Results", x => x.IdRes);
                });

            migrationBuilder.CreateTable(
                name: "Vectors",
                columns: table => new
                {
                    IdVect = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IdAlt = table.Column<int>(nullable: false),
                    IdMark = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vectors", x => x.IdVect);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Alternatives");

            migrationBuilder.DropTable(
                name: "Criterions");

            migrationBuilder.DropTable(
                name: "LPRs");

            migrationBuilder.DropTable(
                name: "Marks");

            migrationBuilder.DropTable(
                name: "Results");

            migrationBuilder.DropTable(
                name: "Vectors");
        }
    }
}
