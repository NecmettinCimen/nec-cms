using Microsoft.EntityFrameworkCore.Migrations;

namespace NecCms.Database.Migrations
{
    public partial class inital5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Deger",
                table: "ParametreDegeri",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AddColumn<int>(
                name: "DegerInt",
                table: "ParametreDegeri",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DegerInt",
                table: "ParametreDegeri");

            migrationBuilder.AlterColumn<string>(
                name: "Deger",
                table: "ParametreDegeri",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
