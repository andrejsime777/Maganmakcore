using Microsoft.EntityFrameworkCore.Migrations;

namespace Maganmakcore.Data.Migrations
{
    public partial class proizvodadded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "kategorija_Proizvodi",
                columns: table => new
                {
                    KategorijaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KategorijaIme = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_kategorija_Proizvodi", x => x.KategorijaId);
                });

            migrationBuilder.CreateTable(
                name: "Proizvodi",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ime = table.Column<string>(nullable: false),
                    kratok_opis = table.Column<string>(nullable: true),
                    dolg_opis = table.Column<string>(nullable: true),
                    slika = table.Column<string>(nullable: true),
                    prospekt_link = table.Column<string>(nullable: true),
                    upatstvo_link = table.Column<string>(nullable: true),
                    kategorija_proizvodiKategorijaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Proizvodi", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Proizvodi_kategorija_Proizvodi_kategorija_proizvodiKategorijaId",
                        column: x => x.kategorija_proizvodiKategorijaId,
                        principalTable: "kategorija_Proizvodi",
                        principalColumn: "KategorijaId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Proizvodi_kategorija_proizvodiKategorijaId",
                table: "Proizvodi",
                column: "kategorija_proizvodiKategorijaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Proizvodi");

            migrationBuilder.DropTable(
                name: "kategorija_Proizvodi");
        }
    }
}
