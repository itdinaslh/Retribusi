using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Retribusi.Migrations
{
    public partial class CreateClientWR : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "clientwr",
                columns: table => new
                {
                    ClientId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    ObjectName = table.Column<string>(type: "varchar(150)", maxLength: 150, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    JenisID = table.Column<int>(type: "int", nullable: false),
                    ObjectPhone = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Alamat = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    KecamatanID = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    KelurahanID = table.Column<string>(type: "varchar(15)", maxLength: 15, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Latitude = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Longitude = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClientName = table.Column<string>(type: "varchar(150)", maxLength: 150, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClientNIK = table.Column<string>(type: "varchar(16)", maxLength: 16, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClientPhone = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClientNPWP = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PegawaiId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    JenisWRJenisID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_clientwr", x => x.ClientId);
                    table.ForeignKey(
                        name: "FK_clientwr_jeniswr_JenisWRJenisID",
                        column: x => x.JenisWRJenisID,
                        principalTable: "jeniswr",
                        principalColumn: "JenisID");
                    table.ForeignKey(
                        name: "FK_clientwr_kecamatan_KecamatanID",
                        column: x => x.KecamatanID,
                        principalTable: "kecamatan",
                        principalColumn: "KecamatanID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_clientwr_kelurahan_KelurahanID",
                        column: x => x.KelurahanID,
                        principalTable: "kelurahan",
                        principalColumn: "KelurahanID");
                    table.ForeignKey(
                        name: "FK_clientwr_pegawai_PegawaiId",
                        column: x => x.PegawaiId,
                        principalTable: "pegawai",
                        principalColumn: "PegawaiId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_clientwr_JenisWRJenisID",
                table: "clientwr",
                column: "JenisWRJenisID");

            migrationBuilder.CreateIndex(
                name: "IX_clientwr_KecamatanID",
                table: "clientwr",
                column: "KecamatanID");

            migrationBuilder.CreateIndex(
                name: "IX_clientwr_KelurahanID",
                table: "clientwr",
                column: "KelurahanID");

            migrationBuilder.CreateIndex(
                name: "IX_clientwr_PegawaiId",
                table: "clientwr",
                column: "PegawaiId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "clientwr");
        }
    }
}
