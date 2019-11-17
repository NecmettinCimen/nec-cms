using Microsoft.EntityFrameworkCore.Migrations;

namespace NecCms.Database.Migrations
{
    public partial class initalmigration2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FotografGalerisiDosya_Dosyalar_DosyaId",
                table: "FotografGalerisiDosya");

            migrationBuilder.DropForeignKey(
                name: "FK_FotografGalerisiDosya_Kullanicilar_KullaniciId",
                table: "FotografGalerisiDosya");

            migrationBuilder.DropForeignKey(
                name: "FK_FotografGalerisileri_FotografGalerisiDosya_FotografGalerisiDosyaId",
                table: "FotografGalerisileri");

            migrationBuilder.DropForeignKey(
                name: "FK_FotografGalerisileri_Icerikler_IcerikId",
                table: "FotografGalerisileri");

            migrationBuilder.DropForeignKey(
                name: "FK_FotografGalerisileri_Kullanicilar_KullaniciId",
                table: "FotografGalerisileri");

            migrationBuilder.DropForeignKey(
                name: "FK_IcerikKategoriler_Kullanicilar_KullaniciId",
                table: "IcerikKategoriler");

            migrationBuilder.DropForeignKey(
                name: "FK_Icerikler_IcerikKategoriler_IcerikKategoriId",
                table: "Icerikler");

            migrationBuilder.DropPrimaryKey(
                name: "PK_IcerikKategoriler",
                table: "IcerikKategoriler");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FotografGalerisileri",
                table: "FotografGalerisileri");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FotografGalerisiDosya",
                table: "FotografGalerisiDosya");

            migrationBuilder.RenameTable(
                name: "IcerikKategoriler",
                newName: "IcerikKategorileri");

            migrationBuilder.RenameTable(
                name: "FotografGalerisileri",
                newName: "FotografGalerisi");

            migrationBuilder.RenameTable(
                name: "FotografGalerisiDosya",
                newName: "FotografGalerisiDosyalar");

            migrationBuilder.RenameIndex(
                name: "IX_IcerikKategoriler_KullaniciId",
                table: "IcerikKategorileri",
                newName: "IX_IcerikKategorileri_KullaniciId");

            migrationBuilder.RenameIndex(
                name: "IX_FotografGalerisileri_KullaniciId",
                table: "FotografGalerisi",
                newName: "IX_FotografGalerisi_KullaniciId");

            migrationBuilder.RenameIndex(
                name: "IX_FotografGalerisileri_IcerikId",
                table: "FotografGalerisi",
                newName: "IX_FotografGalerisi_IcerikId");

            migrationBuilder.RenameIndex(
                name: "IX_FotografGalerisileri_FotografGalerisiDosyaId",
                table: "FotografGalerisi",
                newName: "IX_FotografGalerisi_FotografGalerisiDosyaId");

            migrationBuilder.RenameIndex(
                name: "IX_FotografGalerisiDosya_KullaniciId",
                table: "FotografGalerisiDosyalar",
                newName: "IX_FotografGalerisiDosyalar_KullaniciId");

            migrationBuilder.RenameIndex(
                name: "IX_FotografGalerisiDosya_DosyaId",
                table: "FotografGalerisiDosyalar",
                newName: "IX_FotografGalerisiDosyalar_DosyaId");

            migrationBuilder.AddColumn<int>(
                name: "ResimId",
                table: "Icerikler",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UstKategoriId",
                table: "IcerikKategorileri",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_IcerikKategorileri",
                table: "IcerikKategorileri",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FotografGalerisi",
                table: "FotografGalerisi",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FotografGalerisiDosyalar",
                table: "FotografGalerisiDosyalar",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Icerikler_ResimId",
                table: "Icerikler",
                column: "ResimId");

            migrationBuilder.CreateIndex(
                name: "IX_IcerikKategorileri_UstKategoriId",
                table: "IcerikKategorileri",
                column: "UstKategoriId");

            migrationBuilder.AddForeignKey(
                name: "FK_FotografGalerisi_FotografGalerisiDosyalar_FotografGalerisiDosyaId",
                table: "FotografGalerisi",
                column: "FotografGalerisiDosyaId",
                principalTable: "FotografGalerisiDosyalar",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_FotografGalerisi_Icerikler_IcerikId",
                table: "FotografGalerisi",
                column: "IcerikId",
                principalTable: "Icerikler",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_FotografGalerisi_Kullanicilar_KullaniciId",
                table: "FotografGalerisi",
                column: "KullaniciId",
                principalTable: "Kullanicilar",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_FotografGalerisiDosyalar_Dosyalar_DosyaId",
                table: "FotografGalerisiDosyalar",
                column: "DosyaId",
                principalTable: "Dosyalar",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_FotografGalerisiDosyalar_Kullanicilar_KullaniciId",
                table: "FotografGalerisiDosyalar",
                column: "KullaniciId",
                principalTable: "Kullanicilar",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_IcerikKategorileri_Kullanicilar_KullaniciId",
                table: "IcerikKategorileri",
                column: "KullaniciId",
                principalTable: "Kullanicilar",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_IcerikKategorileri_IcerikKategorileri_UstKategoriId",
                table: "IcerikKategorileri",
                column: "UstKategoriId",
                principalTable: "IcerikKategorileri",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Icerikler_IcerikKategorileri_IcerikKategoriId",
                table: "Icerikler",
                column: "IcerikKategoriId",
                principalTable: "IcerikKategorileri",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Icerikler_FotografGalerisiDosyalar_ResimId",
                table: "Icerikler",
                column: "ResimId",
                principalTable: "FotografGalerisiDosyalar",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FotografGalerisi_FotografGalerisiDosyalar_FotografGalerisiDosyaId",
                table: "FotografGalerisi");

            migrationBuilder.DropForeignKey(
                name: "FK_FotografGalerisi_Icerikler_IcerikId",
                table: "FotografGalerisi");

            migrationBuilder.DropForeignKey(
                name: "FK_FotografGalerisi_Kullanicilar_KullaniciId",
                table: "FotografGalerisi");

            migrationBuilder.DropForeignKey(
                name: "FK_FotografGalerisiDosyalar_Dosyalar_DosyaId",
                table: "FotografGalerisiDosyalar");

            migrationBuilder.DropForeignKey(
                name: "FK_FotografGalerisiDosyalar_Kullanicilar_KullaniciId",
                table: "FotografGalerisiDosyalar");

            migrationBuilder.DropForeignKey(
                name: "FK_IcerikKategorileri_Kullanicilar_KullaniciId",
                table: "IcerikKategorileri");

            migrationBuilder.DropForeignKey(
                name: "FK_IcerikKategorileri_IcerikKategorileri_UstKategoriId",
                table: "IcerikKategorileri");

            migrationBuilder.DropForeignKey(
                name: "FK_Icerikler_IcerikKategorileri_IcerikKategoriId",
                table: "Icerikler");

            migrationBuilder.DropForeignKey(
                name: "FK_Icerikler_FotografGalerisiDosyalar_ResimId",
                table: "Icerikler");

            migrationBuilder.DropIndex(
                name: "IX_Icerikler_ResimId",
                table: "Icerikler");

            migrationBuilder.DropPrimaryKey(
                name: "PK_IcerikKategorileri",
                table: "IcerikKategorileri");

            migrationBuilder.DropIndex(
                name: "IX_IcerikKategorileri_UstKategoriId",
                table: "IcerikKategorileri");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FotografGalerisiDosyalar",
                table: "FotografGalerisiDosyalar");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FotografGalerisi",
                table: "FotografGalerisi");

            migrationBuilder.DropColumn(
                name: "ResimId",
                table: "Icerikler");

            migrationBuilder.DropColumn(
                name: "UstKategoriId",
                table: "IcerikKategorileri");

            migrationBuilder.RenameTable(
                name: "IcerikKategorileri",
                newName: "IcerikKategoriler");

            migrationBuilder.RenameTable(
                name: "FotografGalerisiDosyalar",
                newName: "FotografGalerisiDosya");

            migrationBuilder.RenameTable(
                name: "FotografGalerisi",
                newName: "FotografGalerisileri");

            migrationBuilder.RenameIndex(
                name: "IX_IcerikKategorileri_KullaniciId",
                table: "IcerikKategoriler",
                newName: "IX_IcerikKategoriler_KullaniciId");

            migrationBuilder.RenameIndex(
                name: "IX_FotografGalerisiDosyalar_KullaniciId",
                table: "FotografGalerisiDosya",
                newName: "IX_FotografGalerisiDosya_KullaniciId");

            migrationBuilder.RenameIndex(
                name: "IX_FotografGalerisiDosyalar_DosyaId",
                table: "FotografGalerisiDosya",
                newName: "IX_FotografGalerisiDosya_DosyaId");

            migrationBuilder.RenameIndex(
                name: "IX_FotografGalerisi_KullaniciId",
                table: "FotografGalerisileri",
                newName: "IX_FotografGalerisileri_KullaniciId");

            migrationBuilder.RenameIndex(
                name: "IX_FotografGalerisi_IcerikId",
                table: "FotografGalerisileri",
                newName: "IX_FotografGalerisileri_IcerikId");

            migrationBuilder.RenameIndex(
                name: "IX_FotografGalerisi_FotografGalerisiDosyaId",
                table: "FotografGalerisileri",
                newName: "IX_FotografGalerisileri_FotografGalerisiDosyaId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_IcerikKategoriler",
                table: "IcerikKategoriler",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FotografGalerisiDosya",
                table: "FotografGalerisiDosya",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FotografGalerisileri",
                table: "FotografGalerisileri",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_FotografGalerisiDosya_Dosyalar_DosyaId",
                table: "FotografGalerisiDosya",
                column: "DosyaId",
                principalTable: "Dosyalar",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_FotografGalerisiDosya_Kullanicilar_KullaniciId",
                table: "FotografGalerisiDosya",
                column: "KullaniciId",
                principalTable: "Kullanicilar",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_FotografGalerisileri_FotografGalerisiDosya_FotografGalerisiDosyaId",
                table: "FotografGalerisileri",
                column: "FotografGalerisiDosyaId",
                principalTable: "FotografGalerisiDosya",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_FotografGalerisileri_Icerikler_IcerikId",
                table: "FotografGalerisileri",
                column: "IcerikId",
                principalTable: "Icerikler",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_FotografGalerisileri_Kullanicilar_KullaniciId",
                table: "FotografGalerisileri",
                column: "KullaniciId",
                principalTable: "Kullanicilar",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_IcerikKategoriler_Kullanicilar_KullaniciId",
                table: "IcerikKategoriler",
                column: "KullaniciId",
                principalTable: "Kullanicilar",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Icerikler_IcerikKategoriler_IcerikKategoriId",
                table: "Icerikler",
                column: "IcerikKategoriId",
                principalTable: "IcerikKategoriler",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
