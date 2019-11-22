using Microsoft.EntityFrameworkCore.Migrations;

namespace NecCms.Database.Migrations
{
    public partial class initial21 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "UserAgent",
                table: "Loggers",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 50);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "UserAgent",
                table: "Loggers",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 100);
        }
    }
}
