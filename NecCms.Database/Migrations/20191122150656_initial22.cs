using Microsoft.EntityFrameworkCore.Migrations;

namespace NecCms.Database.Migrations
{
    public partial class initial22 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "UserAgent",
                table: "Loggers",
                maxLength: 250,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 100);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "UserAgent",
                table: "Loggers",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 250);
        }
    }
}
