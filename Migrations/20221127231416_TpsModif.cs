using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Retribusi.Migrations
{
    public partial class TpsModif : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Keterangan",
                table: "tps");

            migrationBuilder.DropColumn(
                name: "KodePos",
                table: "tps");

            migrationBuilder.AddColumn<double>(
                name: "LuasLahan",
                table: "tps",
                type: "double",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Volume",
                table: "tps",
                type: "double",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LuasLahan",
                table: "tps");

            migrationBuilder.DropColumn(
                name: "Volume",
                table: "tps");

            migrationBuilder.AddColumn<string>(
                name: "Keterangan",
                table: "tps",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "KodePos",
                table: "tps",
                type: "varchar(10)",
                maxLength: 10,
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");
        }
    }
}
