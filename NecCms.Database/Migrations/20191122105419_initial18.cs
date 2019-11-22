using Microsoft.EntityFrameworkCore.Migrations;

namespace NecCms.Database.Migrations
{
    public partial class initial18 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Loggers_Kullanicilar_KullaniciId",
                table: "Loggers");

            migrationBuilder.DropIndex(
                name: "IX_Loggers_KullaniciId",
                table: "Loggers");

            migrationBuilder.DropColumn(
                name: "KullaniciId",
                table: "Loggers");

            migrationBuilder.DropColumn(
                name: "Sil",
                table: "Loggers");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "KullaniciId",
                table: "Loggers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "Sil",
                table: "Loggers",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateIndex(
                name: "IX_Loggers_KullaniciId",
                table: "Loggers",
                column: "KullaniciId");

            migrationBuilder.AddForeignKey(
                name: "FK_Loggers_Kullanicilar_KullaniciId",
                table: "Loggers",
                column: "KullaniciId",
                principalTable: "Kullanicilar",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
