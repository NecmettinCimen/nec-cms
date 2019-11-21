using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NecCms.Database.Migrations
{
    public partial class initial7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                "Menu",
                table => new
                {
                    Id = table.Column<int>()
                        .Annotation("SqlServer:ValueGenerationStrategy",
                            SqlServerValueGenerationStrategy.IdentityColumn),
                    Sil = table.Column<bool>(),
                    Tarih = table.Column<DateTime>(),
                    KullaniciId = table.Column<int>(),
                    Isim = table.Column<string>(nullable: true),
                    Url = table.Column<string>(nullable: true),
                    UstId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Menu", x => x.Id);
                    table.ForeignKey(
                        "FK_Menu_Kullanicilar_KullaniciId",
                        x => x.KullaniciId,
                        "Kullanicilar",
                        "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        "FK_Menu_Menu_UstId",
                        x => x.UstId,
                        "Menu",
                        "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                "IX_Menu_KullaniciId",
                "Menu",
                "KullaniciId");

            migrationBuilder.CreateIndex(
                "IX_Menu_UstId",
                "Menu",
                "UstId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                "Menu");
        }
    }
}