using Microsoft.EntityFrameworkCore.Migrations;

namespace Maganmakcore.Data.Migrations
{
    public partial class programmadded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "kategorija_Programi",
                columns: table => new
                {
                    KategorijaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KategorijaIme = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_kategorija_Programi", x => x.KategorijaId);
                });

            migrationBuilder.CreateTable(
                name: "Programi",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ime = table.Column<string>(nullable: true),
                    pdf_link = table.Column<string>(nullable: true),
                    kategorija_programiKategorijaId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Programi", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Programi_kategorija_Programi_kategorija_programiKategorijaId",
                        column: x => x.kategorija_programiKategorijaId,
                        principalTable: "kategorija_Programi",
                        principalColumn: "KategorijaId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Programi_kategorija_programiKategorijaId",
                table: "Programi",
                column: "kategorija_programiKategorijaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Programi");

            migrationBuilder.DropTable(
                name: "kategorija_Programi");
        }
    }
}
