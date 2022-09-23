using Microsoft.EntityFrameworkCore.Migrations;

namespace Maganmakcore.Data.Migrations
{
    public partial class programmadded1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Programi_kategorija_Programi_kategorija_programiKategorijaId",
                table: "Programi");

            migrationBuilder.AlterColumn<int>(
                name: "kategorija_programiKategorijaId",
                table: "Programi",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Programi_kategorija_Programi_kategorija_programiKategorijaId",
                table: "Programi",
                column: "kategorija_programiKategorijaId",
                principalTable: "kategorija_Programi",
                principalColumn: "KategorijaId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Programi_kategorija_Programi_kategorija_programiKategorijaId",
                table: "Programi");

            migrationBuilder.AlterColumn<int>(
                name: "kategorija_programiKategorijaId",
                table: "Programi",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Programi_kategorija_Programi_kategorija_programiKategorijaId",
                table: "Programi",
                column: "kategorija_programiKategorijaId",
                principalTable: "kategorija_Programi",
                principalColumn: "KategorijaId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
