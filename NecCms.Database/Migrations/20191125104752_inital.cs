using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NecCms.Database.Migrations
{
    public partial class inital : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Dosyalar",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Sil = table.Column<bool>(nullable: false),
                    Tarih = table.Column<DateTime>(nullable: false),
                    KullaniciId = table.Column<int>(nullable: true),
                    Adi = table.Column<string>(maxLength: 200, nullable: false),
                    Yolu = table.Column<string>(maxLength: 250, nullable: false),
                    Boyutu = table.Column<long>(nullable: false),
                    Tipi = table.Column<string>(maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dosyalar", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Iletisim",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Sil = table.Column<bool>(nullable: false),
                    Tarih = table.Column<DateTime>(nullable: false),
                    KullaniciId = table.Column<int>(nullable: true),
                    Konu = table.Column<string>(maxLength: 100, nullable: false),
                    AdSoyad = table.Column<string>(maxLength: 100, nullable: false),
                    Eposta = table.Column<string>(maxLength: 50, nullable: false),
                    Aciklama = table.Column<string>(maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Iletisim", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Kullanicilar",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Sil = table.Column<bool>(nullable: false),
                    Tarih = table.Column<DateTime>(nullable: false),
                    KullaniciId = table.Column<int>(nullable: true),
                    AdSoyad = table.Column<string>(maxLength: 25, nullable: false),
                    Telefon = table.Column<string>(maxLength: 15, nullable: false),
                    Eposta = table.Column<string>(maxLength: 50, nullable: false),
                    Parola = table.Column<string>(maxLength: 50, nullable: false),
                    Rol = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kullanicilar", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Loggers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Tarih = table.Column<DateTime>(nullable: false),
                    RemoteIpAddress = table.Column<string>(maxLength: 20, nullable: false),
                    Path = table.Column<string>(maxLength: 250, nullable: false),
                    QueryString = table.Column<string>(maxLength: 100, nullable: true),
                    UserAgent = table.Column<string>(maxLength: 250, nullable: false),
                    StatusCode = table.Column<int>(nullable: false),
                    Time = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Loggers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Menu",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Sil = table.Column<bool>(nullable: false),
                    Tarih = table.Column<DateTime>(nullable: false),
                    KullaniciId = table.Column<int>(nullable: true),
                    Isim = table.Column<string>(nullable: false),
                    Url = table.Column<string>(nullable: true),
                    Sira = table.Column<int>(nullable: false),
                    Tip = table.Column<int>(nullable: false),
                    UstId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Menu", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Menu_Menu_UstId",
                        column: x => x.UstId,
                        principalTable: "Menu",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Parametre",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Sil = table.Column<bool>(nullable: false),
                    Tarih = table.Column<DateTime>(nullable: false),
                    KullaniciId = table.Column<int>(nullable: true),
                    Kodu = table.Column<string>(nullable: false),
                    Isim = table.Column<string>(nullable: true),
                    Aciklama = table.Column<string>(nullable: true),
                    Tip = table.Column<int>(nullable: false),
                    Sira = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parametre", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Uyeler",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Sil = table.Column<bool>(nullable: false),
                    Tarih = table.Column<DateTime>(nullable: false),
                    KullaniciId = table.Column<int>(nullable: true),
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
                });

            migrationBuilder.CreateTable(
                name: "FotografGalerisiDosyalar",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Sil = table.Column<bool>(nullable: false),
                    Tarih = table.Column<DateTime>(nullable: false),
                    KullaniciId = table.Column<int>(nullable: true),
                    DosyaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FotografGalerisiDosyalar", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FotografGalerisiDosyalar_Dosyalar_DosyaId",
                        column: x => x.DosyaId,
                        principalTable: "Dosyalar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Icerikler",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Sil = table.Column<bool>(nullable: false),
                    Tarih = table.Column<DateTime>(nullable: false),
                    KullaniciId = table.Column<int>(nullable: true),
                    MenuId = table.Column<int>(nullable: false),
                    Baslik = table.Column<string>(nullable: false),
                    Giris = table.Column<string>(nullable: false),
                    Icerik = table.Column<string>(nullable: true),
                    YayinlanmaTarihi = table.Column<DateTime>(nullable: false),
                    Durum = table.Column<int>(nullable: false),
                    YazarId = table.Column<int>(nullable: false),
                    ResimId = table.Column<int>(nullable: true),
                    Url = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Icerikler", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Icerikler_Menu_MenuId",
                        column: x => x.MenuId,
                        principalTable: "Menu",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Icerikler_Dosyalar_ResimId",
                        column: x => x.ResimId,
                        principalTable: "Dosyalar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Icerikler_Kullanicilar_YazarId",
                        column: x => x.YazarId,
                        principalTable: "Kullanicilar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ParametreDegeri",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Sil = table.Column<bool>(nullable: false),
                    Tarih = table.Column<DateTime>(nullable: false),
                    KullaniciId = table.Column<int>(nullable: true),
                    ParametreId = table.Column<int>(nullable: false),
                    Deger = table.Column<string>(nullable: true),
                    DegerInt = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ParametreDegeri", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ParametreDegeri_Parametre_ParametreId",
                        column: x => x.ParametreId,
                        principalTable: "Parametre",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FotografGalerisi",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Sil = table.Column<bool>(nullable: false),
                    Tarih = table.Column<DateTime>(nullable: false),
                    KullaniciId = table.Column<int>(nullable: true),
                    IcerikId = table.Column<int>(nullable: false),
                    FotografGalerisiDosyaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FotografGalerisi", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FotografGalerisi_FotografGalerisiDosyalar_FotografGalerisiDosyaId",
                        column: x => x.FotografGalerisiDosyaId,
                        principalTable: "FotografGalerisiDosyalar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FotografGalerisi_Icerikler_IcerikId",
                        column: x => x.IcerikId,
                        principalTable: "Icerikler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Kullanicilar",
                columns: new[] { "Id", "AdSoyad", "Eposta", "KullaniciId", "Parola", "Rol", "Sil", "Tarih", "Telefon" },
                values: new object[] { 1, "Admin", "admin@crm.com", null, "admin@crm.com", 1, false, new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "05456286324" });

            migrationBuilder.CreateIndex(
                name: "IX_FotografGalerisi_FotografGalerisiDosyaId",
                table: "FotografGalerisi",
                column: "FotografGalerisiDosyaId");

            migrationBuilder.CreateIndex(
                name: "IX_FotografGalerisi_IcerikId",
                table: "FotografGalerisi",
                column: "IcerikId");

            migrationBuilder.CreateIndex(
                name: "IX_FotografGalerisiDosyalar_DosyaId",
                table: "FotografGalerisiDosyalar",
                column: "DosyaId");

            migrationBuilder.CreateIndex(
                name: "IX_Icerikler_MenuId",
                table: "Icerikler",
                column: "MenuId");

            migrationBuilder.CreateIndex(
                name: "IX_Icerikler_ResimId",
                table: "Icerikler",
                column: "ResimId");

            migrationBuilder.CreateIndex(
                name: "IX_Icerikler_YazarId",
                table: "Icerikler",
                column: "YazarId");

            migrationBuilder.CreateIndex(
                name: "IX_Menu_UstId",
                table: "Menu",
                column: "UstId");

            migrationBuilder.CreateIndex(
                name: "IX_ParametreDegeri_ParametreId",
                table: "ParametreDegeri",
                column: "ParametreId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FotografGalerisi");

            migrationBuilder.DropTable(
                name: "Iletisim");

            migrationBuilder.DropTable(
                name: "Loggers");

            migrationBuilder.DropTable(
                name: "ParametreDegeri");

            migrationBuilder.DropTable(
                name: "Uyeler");

            migrationBuilder.DropTable(
                name: "FotografGalerisiDosyalar");

            migrationBuilder.DropTable(
                name: "Icerikler");

            migrationBuilder.DropTable(
                name: "Parametre");

            migrationBuilder.DropTable(
                name: "Menu");

            migrationBuilder.DropTable(
                name: "Dosyalar");

            migrationBuilder.DropTable(
                name: "Kullanicilar");
        }
    }
}
