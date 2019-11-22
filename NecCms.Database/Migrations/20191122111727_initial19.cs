using Microsoft.EntityFrameworkCore.Migrations;

namespace NecCms.Database.Migrations
{
    public partial class initial19 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LocalIpAddress",
                table: "Loggers");

            migrationBuilder.AlterColumn<string>(
                name: "QueryString",
                table: "Loggers",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 500,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Path",
                table: "Loggers",
                maxLength: 250,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 100);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "QueryString",
                table: "Loggers",
                maxLength: 500,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Path",
                table: "Loggers",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 250);

            migrationBuilder.AddColumn<string>(
                name: "LocalIpAddress",
                table: "Loggers",
                maxLength: 20,
                nullable: false,
                defaultValue: "");
        }
    }
}
