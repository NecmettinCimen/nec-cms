using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NecCms.Database.Migrations
{
    public partial class initial12 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                "Etkinlikler");

            migrationBuilder.CreateTable(
                "Iletisim",
                table => new
                {
                    Id = table.Column<int>()
                        .Annotation("SqlServer:ValueGenerationStrategy",
                            SqlServerValueGenerationStrategy.IdentityColumn),
                    Sil = table.Column<bool>(),
                    Tarih = table.Column<DateTime>(),
                    KullaniciId = table.Column<int>(),
                    Konu = table.Column<string>(maxLength: 100),
                    AdSoyad = table.Column<string>(maxLength: 100),
                    Eposta = table.Column<string>(maxLength: 50),
                    Aciklama = table.Column<string>(maxLength: 500)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Iletisim", x => x.Id);
                    table.ForeignKey(
                        "FK_Iletisim_Kullanicilar_KullaniciId",
                        x => x.KullaniciId,
                        "Kullanicilar",
                        "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                "IX_Iletisim_KullaniciId",
                "Iletisim",
                "KullaniciId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                "Iletisim");

            migrationBuilder.CreateTable(
                "Etkinlikler",
                table => new
                {
                    Id = table.Column<int>()
                        .Annotation("SqlServer:ValueGenerationStrategy",
                            SqlServerValueGenerationStrategy.IdentityColumn),
                    IcerikId = table.Column<int>(),
                    KullaniciId = table.Column<int>(),
                    Latitude = table.Column<string>(nullable: true),
                    Longitude = table.Column<string>(nullable: true),
                    Sil = table.Column<bool>(),
                    Tarih = table.Column<DateTime>()
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Etkinlikler", x => x.Id);
                    table.ForeignKey(
                        "FK_Etkinlikler_Icerikler_IcerikId",
                        x => x.IcerikId,
                        "Icerikler",
                        "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        "FK_Etkinlikler_Kullanicilar_KullaniciId",
                        x => x.KullaniciId,
                        "Kullanicilar",
                        "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                "IX_Etkinlikler_IcerikId",
                "Etkinlikler",
                "IcerikId");

            migrationBuilder.CreateIndex(
                "IX_Etkinlikler_KullaniciId",
                "Etkinlikler",
                "KullaniciId");
        }
    }
}