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
                name: "Etkinlikler");

            migrationBuilder.CreateTable(
                name: "Iletisim",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Sil = table.Column<bool>(nullable: false),
                    Tarih = table.Column<DateTime>(nullable: false),
                    KullaniciId = table.Column<int>(nullable: false),
                    Konu = table.Column<string>(maxLength: 100, nullable: false),
                    AdSoyad = table.Column<string>(maxLength: 100, nullable: false),
                    Eposta = table.Column<string>(maxLength: 50, nullable: false),
                    Aciklama = table.Column<string>(maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Iletisim", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Iletisim_Kullanicilar_KullaniciId",
                        column: x => x.KullaniciId,
                        principalTable: "Kullanicilar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Iletisim_KullaniciId",
                table: "Iletisim",
                column: "KullaniciId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Iletisim");

            migrationBuilder.CreateTable(
                name: "Etkinlikler",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IcerikId = table.Column<int>(nullable: false),
                    KullaniciId = table.Column<int>(nullable: false),
                    Latitude = table.Column<string>(nullable: true),
                    Longitude = table.Column<string>(nullable: true),
                    Sil = table.Column<bool>(nullable: false),
                    Tarih = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Etkinlikler", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Etkinlikler_Icerikler_IcerikId",
                        column: x => x.IcerikId,
                        principalTable: "Icerikler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Etkinlikler_Kullanicilar_KullaniciId",
                        column: x => x.KullaniciId,
                        principalTable: "Kullanicilar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Etkinlikler_IcerikId",
                table: "Etkinlikler",
                column: "IcerikId");

            migrationBuilder.CreateIndex(
                name: "IX_Etkinlikler_KullaniciId",
                table: "Etkinlikler",
                column: "KullaniciId");
        }
    }
}
