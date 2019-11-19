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
                name: "Parametre",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Sil = table.Column<bool>(nullable: false),
                    Tarih = table.Column<DateTime>(nullable: false),
                    KullaniciId = table.Column<int>(nullable: false),
                    Kodu = table.Column<string>(nullable: true),
                    Isim = table.Column<string>(nullable: true),
                    Aciklama = table.Column<string>(nullable: true),
                    Tip = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parametre", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Parametre_Kullanicilar_KullaniciId",
                        column: x => x.KullaniciId,
                        principalTable: "Kullanicilar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ParametreDegeri",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Sil = table.Column<bool>(nullable: false),
                    Tarih = table.Column<DateTime>(nullable: false),
                    KullaniciId = table.Column<int>(nullable: false),
                    ParametreId = table.Column<int>(nullable: false),
                    Deger = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ParametreDegeri", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ParametreDegeri_Kullanicilar_KullaniciId",
                        column: x => x.KullaniciId,
                        principalTable: "Kullanicilar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ParametreDegeri_Parametre_ParametreId",
                        column: x => x.ParametreId,
                        principalTable: "Parametre",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Parametre_KullaniciId",
                table: "Parametre",
                column: "KullaniciId");

            migrationBuilder.CreateIndex(
                name: "IX_ParametreDegeri_KullaniciId",
                table: "ParametreDegeri",
                column: "KullaniciId");

            migrationBuilder.CreateIndex(
                name: "IX_ParametreDegeri_ParametreId",
                table: "ParametreDegeri",
                column: "ParametreId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ParametreDegeri");

            migrationBuilder.DropTable(
                name: "Parametre");
        }
    }
}
