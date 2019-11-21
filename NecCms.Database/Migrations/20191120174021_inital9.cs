using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NecCms.Database.Migrations
{
    public partial class inital9 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                "FK_Icerikler_IcerikKategorileri_IcerikKategoriId",
                "Icerikler");

            migrationBuilder.DropTable(
                "IcerikKategorileri");

            migrationBuilder.RenameColumn(
                "IcerikKategoriId",
                "Icerikler",
                "MenuId");

            migrationBuilder.RenameIndex(
                "IX_Icerikler_IcerikKategoriId",
                table: "Icerikler",
                newName: "IX_Icerikler_MenuId");

            migrationBuilder.AddForeignKey(
                "FK_Icerikler_Menu_MenuId",
                "Icerikler",
                "MenuId",
                "Menu",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                "FK_Icerikler_Menu_MenuId",
                "Icerikler");

            migrationBuilder.RenameColumn(
                "MenuId",
                "Icerikler",
                "IcerikKategoriId");

            migrationBuilder.RenameIndex(
                "IX_Icerikler_MenuId",
                table: "Icerikler",
                newName: "IX_Icerikler_IcerikKategoriId");

            migrationBuilder.CreateTable(
                "IcerikKategorileri",
                table => new
                {
                    Id = table.Column<int>()
                        .Annotation("SqlServer:ValueGenerationStrategy",
                            SqlServerValueGenerationStrategy.IdentityColumn),
                    Isim = table.Column<string>(maxLength: 50),
                    KullaniciId = table.Column<int>(),
                    Sil = table.Column<bool>(),
                    Tarih = table.Column<DateTime>(),
                    UstKategoriId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IcerikKategorileri", x => x.Id);
                    table.ForeignKey(
                        "FK_IcerikKategorileri_Kullanicilar_KullaniciId",
                        x => x.KullaniciId,
                        "Kullanicilar",
                        "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        "FK_IcerikKategorileri_IcerikKategorileri_UstKategoriId",
                        x => x.UstKategoriId,
                        "IcerikKategorileri",
                        "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                "IX_IcerikKategorileri_KullaniciId",
                "IcerikKategorileri",
                "KullaniciId");

            migrationBuilder.CreateIndex(
                "IX_IcerikKategorileri_UstKategoriId",
                "IcerikKategorileri",
                "UstKategoriId");

            migrationBuilder.AddForeignKey(
                "FK_Icerikler_IcerikKategorileri_IcerikKategoriId",
                "Icerikler",
                "IcerikKategoriId",
                "IcerikKategorileri",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}