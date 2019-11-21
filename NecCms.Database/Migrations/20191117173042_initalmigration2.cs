using Microsoft.EntityFrameworkCore.Migrations;

namespace NecCms.Database.Migrations
{
    public partial class initalmigration2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                "FK_FotografGalerisiDosya_Dosyalar_DosyaId",
                "FotografGalerisiDosya");

            migrationBuilder.DropForeignKey(
                "FK_FotografGalerisiDosya_Kullanicilar_KullaniciId",
                "FotografGalerisiDosya");

            migrationBuilder.DropForeignKey(
                "FK_FotografGalerisileri_FotografGalerisiDosya_FotografGalerisiDosyaId",
                "FotografGalerisileri");

            migrationBuilder.DropForeignKey(
                "FK_FotografGalerisileri_Icerikler_IcerikId",
                "FotografGalerisileri");

            migrationBuilder.DropForeignKey(
                "FK_FotografGalerisileri_Kullanicilar_KullaniciId",
                "FotografGalerisileri");

            migrationBuilder.DropForeignKey(
                "FK_IcerikKategoriler_Kullanicilar_KullaniciId",
                "IcerikKategoriler");

            migrationBuilder.DropForeignKey(
                "FK_Icerikler_IcerikKategoriler_IcerikKategoriId",
                "Icerikler");

            migrationBuilder.DropPrimaryKey(
                "PK_IcerikKategoriler",
                "IcerikKategoriler");

            migrationBuilder.DropPrimaryKey(
                "PK_FotografGalerisileri",
                "FotografGalerisileri");

            migrationBuilder.DropPrimaryKey(
                "PK_FotografGalerisiDosya",
                "FotografGalerisiDosya");

            migrationBuilder.RenameTable(
                "IcerikKategoriler",
                newName: "IcerikKategorileri");

            migrationBuilder.RenameTable(
                "FotografGalerisileri",
                newName: "FotografGalerisi");

            migrationBuilder.RenameTable(
                "FotografGalerisiDosya",
                newName: "FotografGalerisiDosyalar");

            migrationBuilder.RenameIndex(
                "IX_IcerikKategoriler_KullaniciId",
                table: "IcerikKategorileri",
                newName: "IX_IcerikKategorileri_KullaniciId");

            migrationBuilder.RenameIndex(
                "IX_FotografGalerisileri_KullaniciId",
                table: "FotografGalerisi",
                newName: "IX_FotografGalerisi_KullaniciId");

            migrationBuilder.RenameIndex(
                "IX_FotografGalerisileri_IcerikId",
                table: "FotografGalerisi",
                newName: "IX_FotografGalerisi_IcerikId");

            migrationBuilder.RenameIndex(
                "IX_FotografGalerisileri_FotografGalerisiDosyaId",
                table: "FotografGalerisi",
                newName: "IX_FotografGalerisi_FotografGalerisiDosyaId");

            migrationBuilder.RenameIndex(
                "IX_FotografGalerisiDosya_KullaniciId",
                table: "FotografGalerisiDosyalar",
                newName: "IX_FotografGalerisiDosyalar_KullaniciId");

            migrationBuilder.RenameIndex(
                "IX_FotografGalerisiDosya_DosyaId",
                table: "FotografGalerisiDosyalar",
                newName: "IX_FotografGalerisiDosyalar_DosyaId");

            migrationBuilder.AddColumn<int>(
                "ResimId",
                "Icerikler",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                "UstKategoriId",
                "IcerikKategorileri",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                "PK_IcerikKategorileri",
                "IcerikKategorileri",
                "Id");

            migrationBuilder.AddPrimaryKey(
                "PK_FotografGalerisi",
                "FotografGalerisi",
                "Id");

            migrationBuilder.AddPrimaryKey(
                "PK_FotografGalerisiDosyalar",
                "FotografGalerisiDosyalar",
                "Id");

            migrationBuilder.CreateIndex(
                "IX_Icerikler_ResimId",
                "Icerikler",
                "ResimId");

            migrationBuilder.CreateIndex(
                "IX_IcerikKategorileri_UstKategoriId",
                "IcerikKategorileri",
                "UstKategoriId");

            migrationBuilder.AddForeignKey(
                "FK_FotografGalerisi_FotografGalerisiDosyalar_FotografGalerisiDosyaId",
                "FotografGalerisi",
                "FotografGalerisiDosyaId",
                "FotografGalerisiDosyalar",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                "FK_FotografGalerisi_Icerikler_IcerikId",
                "FotografGalerisi",
                "IcerikId",
                "Icerikler",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                "FK_FotografGalerisi_Kullanicilar_KullaniciId",
                "FotografGalerisi",
                "KullaniciId",
                "Kullanicilar",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                "FK_FotografGalerisiDosyalar_Dosyalar_DosyaId",
                "FotografGalerisiDosyalar",
                "DosyaId",
                "Dosyalar",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                "FK_FotografGalerisiDosyalar_Kullanicilar_KullaniciId",
                "FotografGalerisiDosyalar",
                "KullaniciId",
                "Kullanicilar",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                "FK_IcerikKategorileri_Kullanicilar_KullaniciId",
                "IcerikKategorileri",
                "KullaniciId",
                "Kullanicilar",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                "FK_IcerikKategorileri_IcerikKategorileri_UstKategoriId",
                "IcerikKategorileri",
                "UstKategoriId",
                "IcerikKategorileri",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                "FK_Icerikler_IcerikKategorileri_IcerikKategoriId",
                "Icerikler",
                "IcerikKategoriId",
                "IcerikKategorileri",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                "FK_Icerikler_FotografGalerisiDosyalar_ResimId",
                "Icerikler",
                "ResimId",
                "FotografGalerisiDosyalar",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                "FK_FotografGalerisi_FotografGalerisiDosyalar_FotografGalerisiDosyaId",
                "FotografGalerisi");

            migrationBuilder.DropForeignKey(
                "FK_FotografGalerisi_Icerikler_IcerikId",
                "FotografGalerisi");

            migrationBuilder.DropForeignKey(
                "FK_FotografGalerisi_Kullanicilar_KullaniciId",
                "FotografGalerisi");

            migrationBuilder.DropForeignKey(
                "FK_FotografGalerisiDosyalar_Dosyalar_DosyaId",
                "FotografGalerisiDosyalar");

            migrationBuilder.DropForeignKey(
                "FK_FotografGalerisiDosyalar_Kullanicilar_KullaniciId",
                "FotografGalerisiDosyalar");

            migrationBuilder.DropForeignKey(
                "FK_IcerikKategorileri_Kullanicilar_KullaniciId",
                "IcerikKategorileri");

            migrationBuilder.DropForeignKey(
                "FK_IcerikKategorileri_IcerikKategorileri_UstKategoriId",
                "IcerikKategorileri");

            migrationBuilder.DropForeignKey(
                "FK_Icerikler_IcerikKategorileri_IcerikKategoriId",
                "Icerikler");

            migrationBuilder.DropForeignKey(
                "FK_Icerikler_FotografGalerisiDosyalar_ResimId",
                "Icerikler");

            migrationBuilder.DropIndex(
                "IX_Icerikler_ResimId",
                "Icerikler");

            migrationBuilder.DropPrimaryKey(
                "PK_IcerikKategorileri",
                "IcerikKategorileri");

            migrationBuilder.DropIndex(
                "IX_IcerikKategorileri_UstKategoriId",
                "IcerikKategorileri");

            migrationBuilder.DropPrimaryKey(
                "PK_FotografGalerisiDosyalar",
                "FotografGalerisiDosyalar");

            migrationBuilder.DropPrimaryKey(
                "PK_FotografGalerisi",
                "FotografGalerisi");

            migrationBuilder.DropColumn(
                "ResimId",
                "Icerikler");

            migrationBuilder.DropColumn(
                "UstKategoriId",
                "IcerikKategorileri");

            migrationBuilder.RenameTable(
                "IcerikKategorileri",
                newName: "IcerikKategoriler");

            migrationBuilder.RenameTable(
                "FotografGalerisiDosyalar",
                newName: "FotografGalerisiDosya");

            migrationBuilder.RenameTable(
                "FotografGalerisi",
                newName: "FotografGalerisileri");

            migrationBuilder.RenameIndex(
                "IX_IcerikKategorileri_KullaniciId",
                table: "IcerikKategoriler",
                newName: "IX_IcerikKategoriler_KullaniciId");

            migrationBuilder.RenameIndex(
                "IX_FotografGalerisiDosyalar_KullaniciId",
                table: "FotografGalerisiDosya",
                newName: "IX_FotografGalerisiDosya_KullaniciId");

            migrationBuilder.RenameIndex(
                "IX_FotografGalerisiDosyalar_DosyaId",
                table: "FotografGalerisiDosya",
                newName: "IX_FotografGalerisiDosya_DosyaId");

            migrationBuilder.RenameIndex(
                "IX_FotografGalerisi_KullaniciId",
                table: "FotografGalerisileri",
                newName: "IX_FotografGalerisileri_KullaniciId");

            migrationBuilder.RenameIndex(
                "IX_FotografGalerisi_IcerikId",
                table: "FotografGalerisileri",
                newName: "IX_FotografGalerisileri_IcerikId");

            migrationBuilder.RenameIndex(
                "IX_FotografGalerisi_FotografGalerisiDosyaId",
                table: "FotografGalerisileri",
                newName: "IX_FotografGalerisileri_FotografGalerisiDosyaId");

            migrationBuilder.AddPrimaryKey(
                "PK_IcerikKategoriler",
                "IcerikKategoriler",
                "Id");

            migrationBuilder.AddPrimaryKey(
                "PK_FotografGalerisiDosya",
                "FotografGalerisiDosya",
                "Id");

            migrationBuilder.AddPrimaryKey(
                "PK_FotografGalerisileri",
                "FotografGalerisileri",
                "Id");

            migrationBuilder.AddForeignKey(
                "FK_FotografGalerisiDosya_Dosyalar_DosyaId",
                "FotografGalerisiDosya",
                "DosyaId",
                "Dosyalar",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                "FK_FotografGalerisiDosya_Kullanicilar_KullaniciId",
                "FotografGalerisiDosya",
                "KullaniciId",
                "Kullanicilar",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                "FK_FotografGalerisileri_FotografGalerisiDosya_FotografGalerisiDosyaId",
                "FotografGalerisileri",
                "FotografGalerisiDosyaId",
                "FotografGalerisiDosya",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                "FK_FotografGalerisileri_Icerikler_IcerikId",
                "FotografGalerisileri",
                "IcerikId",
                "Icerikler",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                "FK_FotografGalerisileri_Kullanicilar_KullaniciId",
                "FotografGalerisileri",
                "KullaniciId",
                "Kullanicilar",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                "FK_IcerikKategoriler_Kullanicilar_KullaniciId",
                "IcerikKategoriler",
                "KullaniciId",
                "Kullanicilar",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                "FK_Icerikler_IcerikKategoriler_IcerikKategoriId",
                "Icerikler",
                "IcerikKategoriId",
                "IcerikKategoriler",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}