using Microsoft.EntityFrameworkCore.Migrations;

namespace NecCms.Database.Migrations
{
    public partial class initial16 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "QueryString",
                table: "Loggers",
                maxLength: 500,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 500);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "QueryString",
                table: "Loggers",
                maxLength: 500,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 500,
                oldNullable: true);
        }
    }
}
