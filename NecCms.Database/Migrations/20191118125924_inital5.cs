using Microsoft.EntityFrameworkCore.Migrations;

namespace NecCms.Database.Migrations
{
    public partial class inital5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                "Deger",
                "ParametreDegeri",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AddColumn<int>(
                "DegerInt",
                "ParametreDegeri",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                "DegerInt",
                "ParametreDegeri");

            migrationBuilder.AlterColumn<string>(
                "Deger",
                "ParametreDegeri",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}