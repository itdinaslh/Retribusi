using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Retribusi.Migrations
{
    public partial class CreateFungsiKendaraan : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "FungsiKendaraanID",
                table: "kendaraan",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "fungsikendaraan",
                columns: table => new
                {
                    FungsiKendaraanID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NamaFungsi = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_fungsikendaraan", x => x.FungsiKendaraanID);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_kendaraan_FungsiKendaraanID",
                table: "kendaraan",
                column: "FungsiKendaraanID");

            migrationBuilder.AddForeignKey(
                name: "FK_kendaraan_fungsikendaraan_FungsiKendaraanID",
                table: "kendaraan",
                column: "FungsiKendaraanID",
                principalTable: "fungsikendaraan",
                principalColumn: "FungsiKendaraanID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_kendaraan_fungsikendaraan_FungsiKendaraanID",
                table: "kendaraan");

            migrationBuilder.DropTable(
                name: "fungsikendaraan");

            migrationBuilder.DropIndex(
                name: "IX_kendaraan_FungsiKendaraanID",
                table: "kendaraan");

            migrationBuilder.DropColumn(
                name: "FungsiKendaraanID",
                table: "kendaraan");
        }
    }
}
