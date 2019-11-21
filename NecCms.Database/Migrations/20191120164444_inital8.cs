using Microsoft.EntityFrameworkCore.Migrations;

namespace NecCms.Database.Migrations
{
    public partial class inital8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                "Isim",
                "Menu",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                "Sira",
                "Menu",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                "Url",
                "Icerikler",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 250);

            migrationBuilder.AlterColumn<string>(
                "Giris",
                "Icerikler",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 400);

            migrationBuilder.AlterColumn<string>(
                "Baslik",
                "Icerikler",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 200);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                "Sira",
                "Menu");

            migrationBuilder.AlterColumn<string>(
                "Isim",
                "Menu",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                "Url",
                "Icerikler",
                maxLength: 250,
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                "Giris",
                "Icerikler",
                maxLength: 400,
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                "Baslik",
                "Icerikler",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string));
        }
    }
}