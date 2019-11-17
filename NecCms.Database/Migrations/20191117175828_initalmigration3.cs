using Microsoft.EntityFrameworkCore.Migrations;

namespace NecCms.Database.Migrations
{
    public partial class initalmigration3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Icerikler_FotografGalerisiDosyalar_ResimId",
                table: "Icerikler");

            migrationBuilder.AddForeignKey(
                name: "FK_Icerikler_Dosyalar_ResimId",
                table: "Icerikler",
                column: "ResimId",
                principalTable: "Dosyalar",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Icerikler_Dosyalar_ResimId",
                table: "Icerikler");

            migrationBuilder.AddForeignKey(
                name: "FK_Icerikler_FotografGalerisiDosyalar_ResimId",
                table: "Icerikler",
                column: "ResimId",
                principalTable: "FotografGalerisiDosyalar",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
