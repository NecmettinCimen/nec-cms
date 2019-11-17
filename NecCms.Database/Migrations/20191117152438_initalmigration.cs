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
                name: "Kullanicilar",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Sil = table.Column<bool>(nullable: false),
                    Tarih = table.Column<DateTime>(nullable: false),
                    KullaniciId = table.Column<int>(nullable: false),
                    AdSoyad = table.Column<string>(maxLength: 25, nullable: false),
                    Telefon = table.Column<string>(maxLength: 15, nullable: false),
                    Eposta = table.Column<string>(maxLength: 50, nullable: false),
                    Parola = table.Column<string>(maxLength: 50, nullable: false),
                    Rol = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kullanicilar", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Kullanicilar_Kullanicilar_KullaniciId",
                        column: x => x.KullaniciId,
                        principalTable: "Kullanicilar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Dosyalar",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Sil = table.Column<bool>(nullable: false),
                    Tarih = table.Column<DateTime>(nullable: false),
                    KullaniciId = table.Column<int>(nullable: false),
                    Adi = table.Column<string>(maxLength: 200, nullable: false),
                    Yolu = table.Column<string>(maxLength: 250, nullable: false),
                    Boyutu = table.Column<long>(nullable: false),
                    Tipi = table.Column<string>(maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dosyalar", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Dosyalar_Kullanicilar_KullaniciId",
                        column: x => x.KullaniciId,
                        principalTable: "Kullanicilar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "IcerikKategoriler",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Sil = table.Column<bool>(nullable: false),
                    Tarih = table.Column<DateTime>(nullable: false),
                    KullaniciId = table.Column<int>(nullable: false),
                    Isim = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IcerikKategoriler", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IcerikKategoriler_Kullanicilar_KullaniciId",
                        column: x => x.KullaniciId,
                        principalTable: "Kullanicilar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Uyeler",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Sil = table.Column<bool>(nullable: false),
                    Tarih = table.Column<DateTime>(nullable: false),
                    KullaniciId = table.Column<int>(nullable: false),
                    AdSoyad = table.Column<string>(maxLength: 100, nullable: false),
                    Email = table.Column<string>(maxLength: 100, nullable: false),
                    Telefon = table.Column<string>(maxLength: 15, nullable: false),
                    Cinsiyet = table.Column<bool>(nullable: false),
                    DogumTarihi = table.Column<DateTime>(nullable: false),
                    Bolum = table.Column<string>(maxLength: 100, nullable: false),
                    Hakkinda = table.Column<string>(maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Uyeler", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Uyeler_Kullanicilar_KullaniciId",
                        column: x => x.KullaniciId,
                        principalTable: "Kullanicilar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FotografGalerisiDosya",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Sil = table.Column<bool>(nullable: false),
                    Tarih = table.Column<DateTime>(nullable: false),
                    KullaniciId = table.Column<int>(nullable: false),
                    DosyaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FotografGalerisiDosya", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FotografGalerisiDosya_Dosyalar_DosyaId",
                        column: x => x.DosyaId,
                        principalTable: "Dosyalar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FotografGalerisiDosya_Kullanicilar_KullaniciId",
                        column: x => x.KullaniciId,
                        principalTable: "Kullanicilar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Icerikler",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Sil = table.Column<bool>(nullable: false),
                    Tarih = table.Column<DateTime>(nullable: false),
                    KullaniciId = table.Column<int>(nullable: false),
                    IcerikKategoriId = table.Column<int>(nullable: false),
                    Baslik = table.Column<string>(maxLength: 200, nullable: false),
                    Giris = table.Column<string>(maxLength: 400, nullable: false),
                    Icerik = table.Column<string>(nullable: true),
                    YayinlanmaTarihi = table.Column<DateTime>(nullable: false),
                    Durum = table.Column<int>(nullable: false),
                    YazarId = table.Column<int>(nullable: false),
                    Url = table.Column<string>(maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Icerikler", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Icerikler_IcerikKategoriler_IcerikKategoriId",
                        column: x => x.IcerikKategoriId,
                        principalTable: "IcerikKategoriler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Icerikler_Kullanicilar_KullaniciId",
                        column: x => x.KullaniciId,
                        principalTable: "Kullanicilar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Icerikler_Kullanicilar_YazarId",
                        column: x => x.YazarId,
                        principalTable: "Kullanicilar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Etkinlikler",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Sil = table.Column<bool>(nullable: false),
                    Tarih = table.Column<DateTime>(nullable: false),
                    KullaniciId = table.Column<int>(nullable: false),
                    IcerikId = table.Column<int>(nullable: false),
                    Latitude = table.Column<string>(nullable: true),
                    Longitude = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Etkinlikler", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Etkinlikler_Icerikler_IcerikId",
                        column: x => x.IcerikId,
                        principalTable: "Icerikler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Etkinlikler_Kullanicilar_KullaniciId",
                        column: x => x.KullaniciId,
                        principalTable: "Kullanicilar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FotografGalerisileri",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Sil = table.Column<bool>(nullable: false),
                    Tarih = table.Column<DateTime>(nullable: false),
                    KullaniciId = table.Column<int>(nullable: false),
                    IcerikId = table.Column<int>(nullable: false),
                    FotografGalerisiDosyaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FotografGalerisileri", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FotografGalerisileri_FotografGalerisiDosya_FotografGalerisiDosyaId",
                        column: x => x.FotografGalerisiDosyaId,
                        principalTable: "FotografGalerisiDosya",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FotografGalerisileri_Icerikler_IcerikId",
                        column: x => x.IcerikId,
                        principalTable: "Icerikler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FotografGalerisileri_Kullanicilar_KullaniciId",
                        column: x => x.KullaniciId,
                        principalTable: "Kullanicilar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Kullanicilar",
                columns: new[] { "Id", "AdSoyad", "Eposta", "KullaniciId", "Parola", "Rol", "Sil", "Tarih", "Telefon" },
                values: new object[] { 1, "Admin", "admin@crm.com", 1, "admin@crm.com", 1, false, new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "05456286324" });

            migrationBuilder.CreateIndex(
                name: "IX_Dosyalar_KullaniciId",
                table: "Dosyalar",
                column: "KullaniciId");

            migrationBuilder.CreateIndex(
                name: "IX_Etkinlikler_IcerikId",
                table: "Etkinlikler",
                column: "IcerikId");

            migrationBuilder.CreateIndex(
                name: "IX_Etkinlikler_KullaniciId",
                table: "Etkinlikler",
                column: "KullaniciId");

            migrationBuilder.CreateIndex(
                name: "IX_FotografGalerisiDosya_DosyaId",
                table: "FotografGalerisiDosya",
                column: "DosyaId");

            migrationBuilder.CreateIndex(
                name: "IX_FotografGalerisiDosya_KullaniciId",
                table: "FotografGalerisiDosya",
                column: "KullaniciId");

            migrationBuilder.CreateIndex(
                name: "IX_FotografGalerisileri_FotografGalerisiDosyaId",
                table: "FotografGalerisileri",
                column: "FotografGalerisiDosyaId");

            migrationBuilder.CreateIndex(
                name: "IX_FotografGalerisileri_IcerikId",
                table: "FotografGalerisileri",
                column: "IcerikId");

            migrationBuilder.CreateIndex(
                name: "IX_FotografGalerisileri_KullaniciId",
                table: "FotografGalerisileri",
                column: "KullaniciId");

            migrationBuilder.CreateIndex(
                name: "IX_IcerikKategoriler_KullaniciId",
                table: "IcerikKategoriler",
                column: "KullaniciId");

            migrationBuilder.CreateIndex(
                name: "IX_Icerikler_IcerikKategoriId",
                table: "Icerikler",
                column: "IcerikKategoriId");

            migrationBuilder.CreateIndex(
                name: "IX_Icerikler_KullaniciId",
                table: "Icerikler",
                column: "KullaniciId");

            migrationBuilder.CreateIndex(
                name: "IX_Icerikler_YazarId",
                table: "Icerikler",
                column: "YazarId");

            migrationBuilder.CreateIndex(
                name: "IX_Kullanicilar_KullaniciId",
                table: "Kullanicilar",
                column: "KullaniciId");

            migrationBuilder.CreateIndex(
                name: "IX_Uyeler_KullaniciId",
                table: "Uyeler",
                column: "KullaniciId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Etkinlikler");

            migrationBuilder.DropTable(
                name: "FotografGalerisileri");

            migrationBuilder.DropTable(
                name: "Uyeler");

            migrationBuilder.DropTable(
                name: "FotografGalerisiDosya");

            migrationBuilder.DropTable(
                name: "Icerikler");

            migrationBuilder.DropTable(
                name: "Dosyalar");

            migrationBuilder.DropTable(
                name: "IcerikKategoriler");

            migrationBuilder.DropTable(
                name: "Kullanicilar");
        }
    }
}
