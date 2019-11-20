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
                name: "FK_Icerikler_IcerikKategorileri_IcerikKategoriId",
                table: "Icerikler");

            migrationBuilder.DropTable(
                name: "IcerikKategorileri");

            migrationBuilder.RenameColumn(
                name: "IcerikKategoriId",
                table: "Icerikler",
                newName: "MenuId");

            migrationBuilder.RenameIndex(
                name: "IX_Icerikler_IcerikKategoriId",
                table: "Icerikler",
                newName: "IX_Icerikler_MenuId");

            migrationBuilder.AddForeignKey(
                name: "FK_Icerikler_Menu_MenuId",
                table: "Icerikler",
                column: "MenuId",
                principalTable: "Menu",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Icerikler_Menu_MenuId",
                table: "Icerikler");

            migrationBuilder.RenameColumn(
                name: "MenuId",
                table: "Icerikler",
                newName: "IcerikKategoriId");

            migrationBuilder.RenameIndex(
                name: "IX_Icerikler_MenuId",
                table: "Icerikler",
                newName: "IX_Icerikler_IcerikKategoriId");

            migrationBuilder.CreateTable(
                name: "IcerikKategorileri",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Isim = table.Column<string>(maxLength: 50, nullable: false),
                    KullaniciId = table.Column<int>(nullable: false),
                    Sil = table.Column<bool>(nullable: false),
                    Tarih = table.Column<DateTime>(nullable: false),
                    UstKategoriId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IcerikKategorileri", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IcerikKategorileri_Kullanicilar_KullaniciId",
                        column: x => x.KullaniciId,
                        principalTable: "Kullanicilar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_IcerikKategorileri_IcerikKategorileri_UstKategoriId",
                        column: x => x.UstKategoriId,
                        principalTable: "IcerikKategorileri",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_IcerikKategorileri_KullaniciId",
                table: "IcerikKategorileri",
                column: "KullaniciId");

            migrationBuilder.CreateIndex(
                name: "IX_IcerikKategorileri_UstKategoriId",
                table: "IcerikKategorileri",
                column: "UstKategoriId");

            migrationBuilder.AddForeignKey(
                name: "FK_Icerikler_IcerikKategorileri_IcerikKategoriId",
                table: "Icerikler",
                column: "IcerikKategoriId",
                principalTable: "IcerikKategorileri",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
