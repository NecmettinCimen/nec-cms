using Microsoft.EntityFrameworkCore.Migrations;

namespace NecCms.Database.Migrations
{
    public partial class initalmigration3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                "FK_Icerikler_FotografGalerisiDosyalar_ResimId",
                "Icerikler");

            migrationBuilder.AddForeignKey(
                "FK_Icerikler_Dosyalar_ResimId",
                "Icerikler",
                "ResimId",
                "Dosyalar",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                "FK_Icerikler_Dosyalar_ResimId",
                "Icerikler");

            migrationBuilder.AddForeignKey(
                "FK_Icerikler_FotografGalerisiDosyalar_ResimId",
                "Icerikler",
                "ResimId",
                "FotografGalerisiDosyalar",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}