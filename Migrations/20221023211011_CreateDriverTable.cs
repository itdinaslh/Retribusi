using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Retribusi.Migrations
{
    public partial class CreateDriverTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Alamat",
                table: "pegawai",
                type: "varchar(255)",
                maxLength: 255,
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "drivers",
                columns: table => new
                {
                    DriverId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    NIK = table.Column<string>(type: "varchar(16)", maxLength: 16, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Nama = table.Column<string>(type: "varchar(150)", maxLength: 150, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TglLahir = table.Column<DateOnly>(type: "date", nullable: true),
                    NoHP = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IsActive = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    TahunMasuk = table.Column<int>(type: "int", nullable: true),
                    Catatan = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ImgPath = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    BidangId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    TipePegawaiId = table.Column<int>(type: "int", nullable: false),
                    KecamatanID = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    KelurahanID = table.Column<string>(type: "varchar(15)", maxLength: 15, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreatedBy = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UpdatedBy = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_drivers", x => x.DriverId);
                    table.ForeignKey(
                        name: "FK_drivers_bidang_BidangId",
                        column: x => x.BidangId,
                        principalTable: "bidang",
                        principalColumn: "BidangID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_drivers_kecamatan_KecamatanID",
                        column: x => x.KecamatanID,
                        principalTable: "kecamatan",
                        principalColumn: "KecamatanID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_drivers_kelurahan_KelurahanID",
                        column: x => x.KelurahanID,
                        principalTable: "kelurahan",
                        principalColumn: "KelurahanID");
                    table.ForeignKey(
                        name: "FK_drivers_tipepegawai_TipePegawaiId",
                        column: x => x.TipePegawaiId,
                        principalTable: "tipepegawai",
                        principalColumn: "TipePegawaiId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_drivers_BidangId",
                table: "drivers",
                column: "BidangId");

            migrationBuilder.CreateIndex(
                name: "IX_drivers_KecamatanID",
                table: "drivers",
                column: "KecamatanID");

            migrationBuilder.CreateIndex(
                name: "IX_drivers_KelurahanID",
                table: "drivers",
                column: "KelurahanID");

            migrationBuilder.CreateIndex(
                name: "IX_drivers_TipePegawaiId",
                table: "drivers",
                column: "TipePegawaiId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "drivers");

            migrationBuilder.DropColumn(
                name: "Alamat",
                table: "pegawai");
        }
    }
}
