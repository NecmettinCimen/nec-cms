using Microsoft.EntityFrameworkCore.Migrations;

namespace NecCms.Database.Migrations
{
    public partial class initial15 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Host",
                table: "Loggers");

            migrationBuilder.DropColumn(
                name: "Scheme",
                table: "Loggers");

            migrationBuilder.DropColumn(
                name: "Data",
                table: "Dosyalar");

            migrationBuilder.AlterColumn<string>(
                name: "RemoteIpAddress",
                table: "Loggers",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "QueryString",
                table: "Loggers",
                maxLength: 500,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Path",
                table: "Loggers",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LocalIpAddress",
                table: "Loggers",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RemoteIpAddress",
                table: "Loggers",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "QueryString",
                table: "Loggers",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 500);

            migrationBuilder.AlterColumn<string>(
                name: "Path",
                table: "Loggers",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "LocalIpAddress",
                table: "Loggers",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 20);

            migrationBuilder.AddColumn<string>(
                name: "Host",
                table: "Loggers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Scheme",
                table: "Loggers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Data",
                table: "Dosyalar",
                nullable: true);
        }
    }
}
