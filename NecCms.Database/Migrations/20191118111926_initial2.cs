using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NecCms.Database.Migrations
{
    public partial class initial2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                "Parametre",
                table => new
                {
                    Id = table.Column<int>()
                        .Annotation("SqlServer:ValueGenerationStrategy",
                            SqlServerValueGenerationStrategy.IdentityColumn),
                    Sil = table.Column<bool>(),
                    Tarih = table.Column<DateTime>(),
                    KullaniciId = table.Column<int>(),
                    Kodu = table.Column<string>(nullable: true),
                    Isim = table.Column<string>(nullable: true),
                    Aciklama = table.Column<string>(nullable: true),
                    Tip = table.Column<int>()
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parametre", x => x.Id);
                    table.ForeignKey(
                        "FK_Parametre_Kullanicilar_KullaniciId",
                        x => x.KullaniciId,
                        "Kullanicilar",
                        "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                "ParametreDegeri",
                table => new
                {
                    Id = table.Column<int>()
                        .Annotation("SqlServer:ValueGenerationStrategy",
                            SqlServerValueGenerationStrategy.IdentityColumn),
                    Sil = table.Column<bool>(),
                    Tarih = table.Column<DateTime>(),
                    KullaniciId = table.Column<int>(),
                    ParametreId = table.Column<int>(),
                    Deger = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ParametreDegeri", x => x.Id);
                    table.ForeignKey(
                        "FK_ParametreDegeri_Kullanicilar_KullaniciId",
                        x => x.KullaniciId,
                        "Kullanicilar",
                        "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        "FK_ParametreDegeri_Parametre_ParametreId",
                        x => x.ParametreId,
                        "Parametre",
                        "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                "IX_Parametre_KullaniciId",
                "Parametre",
                "KullaniciId");

            migrationBuilder.CreateIndex(
                "IX_ParametreDegeri_KullaniciId",
                "ParametreDegeri",
                "KullaniciId");

            migrationBuilder.CreateIndex(
                "IX_ParametreDegeri_ParametreId",
                "ParametreDegeri",
                "ParametreId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                "ParametreDegeri");

            migrationBuilder.DropTable(
                "Parametre");
        }
    }
}