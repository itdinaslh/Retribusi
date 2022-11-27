using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Retribusi.Migrations
{
    public partial class AlterClient : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_clientwr_jeniswr_JenisWRJenisID",
                table: "clientwr");

            migrationBuilder.DropIndex(
                name: "IX_clientwr_JenisWRJenisID",
                table: "clientwr");

            migrationBuilder.DropColumn(
                name: "JenisWRJenisID",
                table: "clientwr");

            migrationBuilder.CreateIndex(
                name: "IX_clientwr_JenisID",
                table: "clientwr",
                column: "JenisID");

            migrationBuilder.AddForeignKey(
                name: "FK_clientwr_jeniswr_JenisID",
                table: "clientwr",
                column: "JenisID",
                principalTable: "jeniswr",
                principalColumn: "JenisID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_clientwr_jeniswr_JenisID",
                table: "clientwr");

            migrationBuilder.DropIndex(
                name: "IX_clientwr_JenisID",
                table: "clientwr");

            migrationBuilder.AddColumn<int>(
                name: "JenisWRJenisID",
                table: "clientwr",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_clientwr_JenisWRJenisID",
                table: "clientwr",
                column: "JenisWRJenisID");

            migrationBuilder.AddForeignKey(
                name: "FK_clientwr_jeniswr_JenisWRJenisID",
                table: "clientwr",
                column: "JenisWRJenisID",
                principalTable: "jeniswr",
                principalColumn: "JenisID");
        }
    }
}
