using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NecCms.Database.Migrations
{
    public partial class initial14 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Loggers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Sil = table.Column<bool>(nullable: false),
                    Tarih = table.Column<DateTime>(nullable: false),
                    KullaniciId = table.Column<int>(nullable: false),
                    LocalIpAddress = table.Column<string>(nullable: true),
                    RemoteIpAddress = table.Column<string>(nullable: true),
                    Scheme = table.Column<string>(nullable: true),
                    Host = table.Column<string>(nullable: true),
                    Path = table.Column<string>(nullable: true),
                    QueryString = table.Column<string>(nullable: true),
                    StatusCode = table.Column<int>(nullable: false),
                    Time = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Loggers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Loggers_Kullanicilar_KullaniciId",
                        column: x => x.KullaniciId,
                        principalTable: "Kullanicilar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Loggers_KullaniciId",
                table: "Loggers",
                column: "KullaniciId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Loggers");
        }
    }
}
