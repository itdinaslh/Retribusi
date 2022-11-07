using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Retribusi.Migrations
{
    public partial class AlterPegawaiNew : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_pegawai_kabupaten_KabupatenId",
                table: "pegawai");

            migrationBuilder.DropForeignKey(
                name: "FK_pegawai_kecamatan_KecamatanId",
                table: "pegawai");

            migrationBuilder.DropForeignKey(
                name: "FK_pegawai_kelurahan_KelurahanId",
                table: "pegawai");

            migrationBuilder.RenameColumn(
                name: "KelurahanId",
                table: "pegawai",
                newName: "KelurahanID");

            migrationBuilder.RenameColumn(
                name: "KecamatanId",
                table: "pegawai",
                newName: "KecamatanID");

            migrationBuilder.RenameColumn(
                name: "KabupatenId",
                table: "pegawai",
                newName: "KabupatenID");

            migrationBuilder.RenameIndex(
                name: "IX_pegawai_KelurahanId",
                table: "pegawai",
                newName: "IX_pegawai_KelurahanID");

            migrationBuilder.RenameIndex(
                name: "IX_pegawai_KecamatanId",
                table: "pegawai",
                newName: "IX_pegawai_KecamatanID");

            migrationBuilder.RenameIndex(
                name: "IX_pegawai_KabupatenId",
                table: "pegawai",
                newName: "IX_pegawai_KabupatenID");

            migrationBuilder.AlterColumn<Guid>(
                name: "PegawaiId",
                table: "pegawai",
                type: "char(36)",
                nullable: false,
                collation: "ascii_general_ci",
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddForeignKey(
                name: "FK_pegawai_kabupaten_KabupatenID",
                table: "pegawai",
                column: "KabupatenID",
                principalTable: "kabupaten",
                principalColumn: "KabupatenID");

            migrationBuilder.AddForeignKey(
                name: "FK_pegawai_kecamatan_KecamatanID",
                table: "pegawai",
                column: "KecamatanID",
                principalTable: "kecamatan",
                principalColumn: "KecamatanID");

            migrationBuilder.AddForeignKey(
                name: "FK_pegawai_kelurahan_KelurahanID",
                table: "pegawai",
                column: "KelurahanID",
                principalTable: "kelurahan",
                principalColumn: "KelurahanID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_pegawai_kabupaten_KabupatenID",
                table: "pegawai");

            migrationBuilder.DropForeignKey(
                name: "FK_pegawai_kecamatan_KecamatanID",
                table: "pegawai");

            migrationBuilder.DropForeignKey(
                name: "FK_pegawai_kelurahan_KelurahanID",
                table: "pegawai");

            migrationBuilder.RenameColumn(
                name: "KelurahanID",
                table: "pegawai",
                newName: "KelurahanId");

            migrationBuilder.RenameColumn(
                name: "KecamatanID",
                table: "pegawai",
                newName: "KecamatanId");

            migrationBuilder.RenameColumn(
                name: "KabupatenID",
                table: "pegawai",
                newName: "KabupatenId");

            migrationBuilder.RenameIndex(
                name: "IX_pegawai_KelurahanID",
                table: "pegawai",
                newName: "IX_pegawai_KelurahanId");

            migrationBuilder.RenameIndex(
                name: "IX_pegawai_KecamatanID",
                table: "pegawai",
                newName: "IX_pegawai_KecamatanId");

            migrationBuilder.RenameIndex(
                name: "IX_pegawai_KabupatenID",
                table: "pegawai",
                newName: "IX_pegawai_KabupatenId");

            migrationBuilder.AlterColumn<int>(
                name: "PegawaiId",
                table: "pegawai",
                type: "int",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "char(36)")
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                .OldAnnotation("Relational:Collation", "ascii_general_ci");

            migrationBuilder.AddForeignKey(
                name: "FK_pegawai_kabupaten_KabupatenId",
                table: "pegawai",
                column: "KabupatenId",
                principalTable: "kabupaten",
                principalColumn: "KabupatenID");

            migrationBuilder.AddForeignKey(
                name: "FK_pegawai_kecamatan_KecamatanId",
                table: "pegawai",
                column: "KecamatanId",
                principalTable: "kecamatan",
                principalColumn: "KecamatanID");

            migrationBuilder.AddForeignKey(
                name: "FK_pegawai_kelurahan_KelurahanId",
                table: "pegawai",
                column: "KelurahanId",
                principalTable: "kelurahan",
                principalColumn: "KelurahanID");
        }
    }
}
