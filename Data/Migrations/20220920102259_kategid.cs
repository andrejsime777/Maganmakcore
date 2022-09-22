using Microsoft.EntityFrameworkCore.Migrations;

namespace Maganmakcore.Data.Migrations
{
    public partial class kategid : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Proizvodi_kategorija_Proizvodi_kategorija_proizvodiKategorijaId",
                table: "Proizvodi");

            migrationBuilder.AlterColumn<int>(
                name: "kategorija_proizvodiKategorijaId",
                table: "Proizvodi",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Proizvodi_kategorija_Proizvodi_kategorija_proizvodiKategorijaId",
                table: "Proizvodi",
                column: "kategorija_proizvodiKategorijaId",
                principalTable: "kategorija_Proizvodi",
                principalColumn: "KategorijaId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Proizvodi_kategorija_Proizvodi_kategorija_proizvodiKategorijaId",
                table: "Proizvodi");

            migrationBuilder.AlterColumn<int>(
                name: "kategorija_proizvodiKategorijaId",
                table: "Proizvodi",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Proizvodi_kategorija_Proizvodi_kategorija_proizvodiKategorijaId",
                table: "Proizvodi",
                column: "kategorija_proizvodiKategorijaId",
                principalTable: "kategorija_Proizvodi",
                principalColumn: "KategorijaId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
