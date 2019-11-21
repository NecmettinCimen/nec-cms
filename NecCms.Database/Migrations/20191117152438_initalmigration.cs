using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NecCms.Database.Migrations
{
    public partial class initalmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                "Kullanicilar",
                table => new
                {
                    Id = table.Column<int>()
                        .Annotation("SqlServer:ValueGenerationStrategy",
                            SqlServerValueGenerationStrategy.IdentityColumn),
                    Sil = table.Column<bool>(),
                    Tarih = table.Column<DateTime>(),
                    KullaniciId = table.Column<int>(),
                    AdSoyad = table.Column<string>(maxLength: 25),
                    Telefon = table.Column<string>(maxLength: 15),
                    Eposta = table.Column<string>(maxLength: 50),
                    Parola = table.Column<string>(maxLength: 50),
                    Rol = table.Column<int>()
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kullanicilar", x => x.Id);
                    table.ForeignKey(
                        "FK_Kullanicilar_Kullanicilar_KullaniciId",
                        x => x.KullaniciId,
                        "Kullanicilar",
                        "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                "Dosyalar",
                table => new
                {
                    Id = table.Column<int>()
                        .Annotation("SqlServer:ValueGenerationStrategy",
                            SqlServerValueGenerationStrategy.IdentityColumn),
                    Sil = table.Column<bool>(),
                    Tarih = table.Column<DateTime>(),
                    KullaniciId = table.Column<int>(),
                    Adi = table.Column<string>(maxLength: 200),
                    Yolu = table.Column<string>(maxLength: 250),
                    Boyutu = table.Column<long>(),
                    Tipi = table.Column<string>(maxLength: 20)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dosyalar", x => x.Id);
                    table.ForeignKey(
                        "FK_Dosyalar_Kullanicilar_KullaniciId",
                        x => x.KullaniciId,
                        "Kullanicilar",
                        "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                "IcerikKategoriler",
                table => new
                {
                    Id = table.Column<int>()
                        .Annotation("SqlServer:ValueGenerationStrategy",
                            SqlServerValueGenerationStrategy.IdentityColumn),
                    Sil = table.Column<bool>(),
                    Tarih = table.Column<DateTime>(),
                    KullaniciId = table.Column<int>(),
                    Isim = table.Column<string>(maxLength: 50)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IcerikKategoriler", x => x.Id);
                    table.ForeignKey(
                        "FK_IcerikKategoriler_Kullanicilar_KullaniciId",
                        x => x.KullaniciId,
                        "Kullanicilar",
                        "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                "Uyeler",
                table => new
                {
                    Id = table.Column<int>()
                        .Annotation("SqlServer:ValueGenerationStrategy",
                            SqlServerValueGenerationStrategy.IdentityColumn),
                    Sil = table.Column<bool>(),
                    Tarih = table.Column<DateTime>(),
                    KullaniciId = table.Column<int>(),
                    AdSoyad = table.Column<string>(maxLength: 100),
                    Email = table.Column<string>(maxLength: 100),
                    Telefon = table.Column<string>(maxLength: 15),
                    Cinsiyet = table.Column<bool>(),
                    DogumTarihi = table.Column<DateTime>(),
                    Bolum = table.Column<string>(maxLength: 100),
                    Hakkinda = table.Column<string>(maxLength: 250)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Uyeler", x => x.Id);
                    table.ForeignKey(
                        "FK_Uyeler_Kullanicilar_KullaniciId",
                        x => x.KullaniciId,
                        "Kullanicilar",
                        "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                "FotografGalerisiDosya",
                table => new
                {
                    Id = table.Column<int>()
                        .Annotation("SqlServer:ValueGenerationStrategy",
                            SqlServerValueGenerationStrategy.IdentityColumn),
                    Sil = table.Column<bool>(),
                    Tarih = table.Column<DateTime>(),
                    KullaniciId = table.Column<int>(),
                    DosyaId = table.Column<int>()
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FotografGalerisiDosya", x => x.Id);
                    table.ForeignKey(
                        "FK_FotografGalerisiDosya_Dosyalar_DosyaId",
                        x => x.DosyaId,
                        "Dosyalar",
                        "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        "FK_FotografGalerisiDosya_Kullanicilar_KullaniciId",
                        x => x.KullaniciId,
                        "Kullanicilar",
                        "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                "Icerikler",
                table => new
                {
                    Id = table.Column<int>()
                        .Annotation("SqlServer:ValueGenerationStrategy",
                            SqlServerValueGenerationStrategy.IdentityColumn),
                    Sil = table.Column<bool>(),
                    Tarih = table.Column<DateTime>(),
                    KullaniciId = table.Column<int>(),
                    IcerikKategoriId = table.Column<int>(),
                    Baslik = table.Column<string>(maxLength: 200),
                    Giris = table.Column<string>(maxLength: 400),
                    Icerik = table.Column<string>(nullable: true),
                    YayinlanmaTarihi = table.Column<DateTime>(),
                    Durum = table.Column<int>(),
                    YazarId = table.Column<int>(),
                    Url = table.Column<string>(maxLength: 250)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Icerikler", x => x.Id);
                    table.ForeignKey(
                        "FK_Icerikler_IcerikKategoriler_IcerikKategoriId",
                        x => x.IcerikKategoriId,
                        "IcerikKategoriler",
                        "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        "FK_Icerikler_Kullanicilar_KullaniciId",
                        x => x.KullaniciId,
                        "Kullanicilar",
                        "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        "FK_Icerikler_Kullanicilar_YazarId",
                        x => x.YazarId,
                        "Kullanicilar",
                        "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                "Etkinlikler",
                table => new
                {
                    Id = table.Column<int>()
                        .Annotation("SqlServer:ValueGenerationStrategy",
                            SqlServerValueGenerationStrategy.IdentityColumn),
                    Sil = table.Column<bool>(),
                    Tarih = table.Column<DateTime>(),
                    KullaniciId = table.Column<int>(),
                    IcerikId = table.Column<int>(),
                    Latitude = table.Column<string>(nullable: true),
                    Longitude = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Etkinlikler", x => x.Id);
                    table.ForeignKey(
                        "FK_Etkinlikler_Icerikler_IcerikId",
                        x => x.IcerikId,
                        "Icerikler",
                        "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        "FK_Etkinlikler_Kullanicilar_KullaniciId",
                        x => x.KullaniciId,
                        "Kullanicilar",
                        "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                "FotografGalerisileri",
                table => new
                {
                    Id = table.Column<int>()
                        .Annotation("SqlServer:ValueGenerationStrategy",
                            SqlServerValueGenerationStrategy.IdentityColumn),
                    Sil = table.Column<bool>(),
                    Tarih = table.Column<DateTime>(),
                    KullaniciId = table.Column<int>(),
                    IcerikId = table.Column<int>(),
                    FotografGalerisiDosyaId = table.Column<int>()
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FotografGalerisileri", x => x.Id);
                    table.ForeignKey(
                        "FK_FotografGalerisileri_FotografGalerisiDosya_FotografGalerisiDosyaId",
                        x => x.FotografGalerisiDosyaId,
                        "FotografGalerisiDosya",
                        "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        "FK_FotografGalerisileri_Icerikler_IcerikId",
                        x => x.IcerikId,
                        "Icerikler",
                        "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        "FK_FotografGalerisileri_Kullanicilar_KullaniciId",
                        x => x.KullaniciId,
                        "Kullanicilar",
                        "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                "Kullanicilar",
                new[] {"Id", "AdSoyad", "Eposta", "KullaniciId", "Parola", "Rol", "Sil", "Tarih", "Telefon"},
                new object[]
                {
                    1, "Admin", "admin@crm.com", 1, "admin@crm.com", 1, false,
                    new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "05456286324"
                });

            migrationBuilder.CreateIndex(
                "IX_Dosyalar_KullaniciId",
                "Dosyalar",
                "KullaniciId");

            migrationBuilder.CreateIndex(
                "IX_Etkinlikler_IcerikId",
                "Etkinlikler",
                "IcerikId");

            migrationBuilder.CreateIndex(
                "IX_Etkinlikler_KullaniciId",
                "Etkinlikler",
                "KullaniciId");

            migrationBuilder.CreateIndex(
                "IX_FotografGalerisiDosya_DosyaId",
                "FotografGalerisiDosya",
                "DosyaId");

            migrationBuilder.CreateIndex(
                "IX_FotografGalerisiDosya_KullaniciId",
                "FotografGalerisiDosya",
                "KullaniciId");

            migrationBuilder.CreateIndex(
                "IX_FotografGalerisileri_FotografGalerisiDosyaId",
                "FotografGalerisileri",
                "FotografGalerisiDosyaId");

            migrationBuilder.CreateIndex(
                "IX_FotografGalerisileri_IcerikId",
                "FotografGalerisileri",
                "IcerikId");

            migrationBuilder.CreateIndex(
                "IX_FotografGalerisileri_KullaniciId",
                "FotografGalerisileri",
                "KullaniciId");

            migrationBuilder.CreateIndex(
                "IX_IcerikKategoriler_KullaniciId",
                "IcerikKategoriler",
                "KullaniciId");

            migrationBuilder.CreateIndex(
                "IX_Icerikler_IcerikKategoriId",
                "Icerikler",
                "IcerikKategoriId");

            migrationBuilder.CreateIndex(
                "IX_Icerikler_KullaniciId",
                "Icerikler",
                "KullaniciId");

            migrationBuilder.CreateIndex(
                "IX_Icerikler_YazarId",
                "Icerikler",
                "YazarId");

            migrationBuilder.CreateIndex(
                "IX_Kullanicilar_KullaniciId",
                "Kullanicilar",
                "KullaniciId");

            migrationBuilder.CreateIndex(
                "IX_Uyeler_KullaniciId",
                "Uyeler",
                "KullaniciId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                "Etkinlikler");

            migrationBuilder.DropTable(
                "FotografGalerisileri");

            migrationBuilder.DropTable(
                "Uyeler");

            migrationBuilder.DropTable(
                "FotografGalerisiDosya");

            migrationBuilder.DropTable(
                "Icerikler");

            migrationBuilder.DropTable(
                "Dosyalar");

            migrationBuilder.DropTable(
                "IcerikKategoriler");

            migrationBuilder.DropTable(
                "Kullanicilar");
        }
    }
}