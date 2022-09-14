using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Retribusi.Migrations
{
    public partial class RenamingTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Kabupaten_Provinsi_ProvinsiID",
                table: "Kabupaten");

            migrationBuilder.DropForeignKey(
                name: "FK_Kecamatan_Kabupaten_KabupatenID",
                table: "Kecamatan");

            migrationBuilder.DropForeignKey(
                name: "FK_Kelurahan_Kecamatan_KecamatanID",
                table: "Kelurahan");

            migrationBuilder.DropForeignKey(
                name: "FK_Kendaraan_Bidang_BidangAsalId",
                table: "Kendaraan");

            migrationBuilder.DropForeignKey(
                name: "FK_Kendaraan_Bidang_BidangPenugasanId",
                table: "Kendaraan");

            migrationBuilder.DropForeignKey(
                name: "FK_Kendaraan_JenisKendaraan_JenisKendaraanId",
                table: "Kendaraan");

            migrationBuilder.DropForeignKey(
                name: "FK_Kendaraan_Kabupaten_KabupatenAsalId",
                table: "Kendaraan");

            migrationBuilder.DropForeignKey(
                name: "FK_Kendaraan_Kabupaten_KabupatenPenugasanId",
                table: "Kendaraan");

            migrationBuilder.DropForeignKey(
                name: "FK_Kendaraan_Kecamatan_KecamatanAsalId",
                table: "Kendaraan");

            migrationBuilder.DropForeignKey(
                name: "FK_Kendaraan_Kecamatan_KecamatanPenugasanId",
                table: "Kendaraan");

            migrationBuilder.DropForeignKey(
                name: "FK_Kendaraan_MerkKendaraan_MerkKendaraanId",
                table: "Kendaraan");

            migrationBuilder.DropForeignKey(
                name: "FK_Kendaraan_TipeKendaraan_TipeKendaraanId",
                table: "Kendaraan");

            migrationBuilder.DropForeignKey(
                name: "FK_Pegawai_Bidang_BidangId",
                table: "Pegawai");

            migrationBuilder.DropForeignKey(
                name: "FK_Pegawai_Kabupaten_KabupatenId",
                table: "Pegawai");

            migrationBuilder.DropForeignKey(
                name: "FK_Pegawai_Kecamatan_KecamatanId",
                table: "Pegawai");

            migrationBuilder.DropForeignKey(
                name: "FK_Pegawai_Kelurahan_KelurahanId",
                table: "Pegawai");

            migrationBuilder.DropForeignKey(
                name: "FK_Pegawai_TipePegawai_TipePegawaiId",
                table: "Pegawai");

            migrationBuilder.DropForeignKey(
                name: "FK_TipeKendaraan_MerkKendaraan_MerkKendaraanId",
                table: "TipeKendaraan");

            migrationBuilder.DropForeignKey(
                name: "FK_Tps_JenisTps_JenisTpsId",
                table: "Tps");

            migrationBuilder.DropForeignKey(
                name: "FK_Tps_Kelurahan_KelurahanID",
                table: "Tps");

            migrationBuilder.DropForeignKey(
                name: "FK_Tps_StatusLahan_StatusLahanId",
                table: "Tps");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tps",
                table: "Tps");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TipePegawai",
                table: "TipePegawai");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TipeKendaraan",
                table: "TipeKendaraan");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StatusWR",
                table: "StatusWR");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StatusLahan",
                table: "StatusLahan");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Provinsi",
                table: "Provinsi");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Penugasan",
                table: "Penugasan");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Pegawai",
                table: "Pegawai");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MerkKendaraan",
                table: "MerkKendaraan");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Kendaraan",
                table: "Kendaraan");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Kelurahan",
                table: "Kelurahan");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Kecamatan",
                table: "Kecamatan");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Kabupaten",
                table: "Kabupaten");

            migrationBuilder.DropPrimaryKey(
                name: "PK_JenisTps",
                table: "JenisTps");

            migrationBuilder.DropPrimaryKey(
                name: "PK_JenisKendaraan",
                table: "JenisKendaraan");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Bidang",
                table: "Bidang");

            migrationBuilder.RenameTable(
                name: "Tps",
                newName: "tps");

            migrationBuilder.RenameTable(
                name: "TipePegawai",
                newName: "tipepegawai");

            migrationBuilder.RenameTable(
                name: "TipeKendaraan",
                newName: "tipekendaraan");

            migrationBuilder.RenameTable(
                name: "StatusWR",
                newName: "statuswr");

            migrationBuilder.RenameTable(
                name: "StatusLahan",
                newName: "statuslahan");

            migrationBuilder.RenameTable(
                name: "Provinsi",
                newName: "provinsi");

            migrationBuilder.RenameTable(
                name: "Penugasan",
                newName: "penugasan");

            migrationBuilder.RenameTable(
                name: "Pegawai",
                newName: "pegawai");

            migrationBuilder.RenameTable(
                name: "MerkKendaraan",
                newName: "merkkendaraan");

            migrationBuilder.RenameTable(
                name: "Kendaraan",
                newName: "kendaraan");

            migrationBuilder.RenameTable(
                name: "Kelurahan",
                newName: "kelurahan");

            migrationBuilder.RenameTable(
                name: "Kecamatan",
                newName: "kecamatan");

            migrationBuilder.RenameTable(
                name: "Kabupaten",
                newName: "kabupaten");

            migrationBuilder.RenameTable(
                name: "JenisTps",
                newName: "jenistps");

            migrationBuilder.RenameTable(
                name: "JenisKendaraan",
                newName: "jeniskendaraan");

            migrationBuilder.RenameTable(
                name: "Bidang",
                newName: "bidang");

            migrationBuilder.RenameIndex(
                name: "IX_Tps_StatusLahanId",
                table: "tps",
                newName: "IX_tps_StatusLahanId");

            migrationBuilder.RenameIndex(
                name: "IX_Tps_KelurahanID",
                table: "tps",
                newName: "IX_tps_KelurahanID");

            migrationBuilder.RenameIndex(
                name: "IX_Tps_JenisTpsId",
                table: "tps",
                newName: "IX_tps_JenisTpsId");

            migrationBuilder.RenameIndex(
                name: "IX_TipeKendaraan_MerkKendaraanId",
                table: "tipekendaraan",
                newName: "IX_tipekendaraan_MerkKendaraanId");

            migrationBuilder.RenameIndex(
                name: "IX_Pegawai_TipePegawaiId",
                table: "pegawai",
                newName: "IX_pegawai_TipePegawaiId");

            migrationBuilder.RenameIndex(
                name: "IX_Pegawai_KelurahanId",
                table: "pegawai",
                newName: "IX_pegawai_KelurahanId");

            migrationBuilder.RenameIndex(
                name: "IX_Pegawai_KecamatanId",
                table: "pegawai",
                newName: "IX_pegawai_KecamatanId");

            migrationBuilder.RenameIndex(
                name: "IX_Pegawai_KabupatenId",
                table: "pegawai",
                newName: "IX_pegawai_KabupatenId");

            migrationBuilder.RenameIndex(
                name: "IX_Pegawai_BidangId",
                table: "pegawai",
                newName: "IX_pegawai_BidangId");

            migrationBuilder.RenameIndex(
                name: "IX_Kendaraan_TipeKendaraanId",
                table: "kendaraan",
                newName: "IX_kendaraan_TipeKendaraanId");

            migrationBuilder.RenameIndex(
                name: "IX_Kendaraan_MerkKendaraanId",
                table: "kendaraan",
                newName: "IX_kendaraan_MerkKendaraanId");

            migrationBuilder.RenameIndex(
                name: "IX_Kendaraan_KecamatanPenugasanId",
                table: "kendaraan",
                newName: "IX_kendaraan_KecamatanPenugasanId");

            migrationBuilder.RenameIndex(
                name: "IX_Kendaraan_KecamatanAsalId",
                table: "kendaraan",
                newName: "IX_kendaraan_KecamatanAsalId");

            migrationBuilder.RenameIndex(
                name: "IX_Kendaraan_KabupatenPenugasanId",
                table: "kendaraan",
                newName: "IX_kendaraan_KabupatenPenugasanId");

            migrationBuilder.RenameIndex(
                name: "IX_Kendaraan_KabupatenAsalId",
                table: "kendaraan",
                newName: "IX_kendaraan_KabupatenAsalId");

            migrationBuilder.RenameIndex(
                name: "IX_Kendaraan_JenisKendaraanId",
                table: "kendaraan",
                newName: "IX_kendaraan_JenisKendaraanId");

            migrationBuilder.RenameIndex(
                name: "IX_Kendaraan_BidangPenugasanId",
                table: "kendaraan",
                newName: "IX_kendaraan_BidangPenugasanId");

            migrationBuilder.RenameIndex(
                name: "IX_Kendaraan_BidangAsalId",
                table: "kendaraan",
                newName: "IX_kendaraan_BidangAsalId");

            migrationBuilder.RenameIndex(
                name: "IX_Kelurahan_KecamatanID",
                table: "kelurahan",
                newName: "IX_kelurahan_KecamatanID");

            migrationBuilder.RenameIndex(
                name: "IX_Kecamatan_KabupatenID",
                table: "kecamatan",
                newName: "IX_kecamatan_KabupatenID");

            migrationBuilder.RenameIndex(
                name: "IX_Kabupaten_ProvinsiID",
                table: "kabupaten",
                newName: "IX_kabupaten_ProvinsiID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tps",
                table: "tps",
                column: "TpsId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tipepegawai",
                table: "tipepegawai",
                column: "TipePegawaiId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tipekendaraan",
                table: "tipekendaraan",
                column: "TipeKendaraanId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_statuswr",
                table: "statuswr",
                column: "StatusId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_statuslahan",
                table: "statuslahan",
                column: "StatusLahanId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_provinsi",
                table: "provinsi",
                column: "ProvinsiID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_penugasan",
                table: "penugasan",
                column: "PenugasanId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_pegawai",
                table: "pegawai",
                column: "PegawaiId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_merkkendaraan",
                table: "merkkendaraan",
                column: "MerkKendaraanId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_kendaraan",
                table: "kendaraan",
                column: "KendaraanId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_kelurahan",
                table: "kelurahan",
                column: "KelurahanID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_kecamatan",
                table: "kecamatan",
                column: "KecamatanID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_kabupaten",
                table: "kabupaten",
                column: "KabupatenID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_jenistps",
                table: "jenistps",
                column: "JenisID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_jeniskendaraan",
                table: "jeniskendaraan",
                column: "JenisID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_bidang",
                table: "bidang",
                column: "BidangID");

            migrationBuilder.AddForeignKey(
                name: "FK_kabupaten_provinsi_ProvinsiID",
                table: "kabupaten",
                column: "ProvinsiID",
                principalTable: "provinsi",
                principalColumn: "ProvinsiID");

            migrationBuilder.AddForeignKey(
                name: "FK_kecamatan_kabupaten_KabupatenID",
                table: "kecamatan",
                column: "KabupatenID",
                principalTable: "kabupaten",
                principalColumn: "KabupatenID");

            migrationBuilder.AddForeignKey(
                name: "FK_kelurahan_kecamatan_KecamatanID",
                table: "kelurahan",
                column: "KecamatanID",
                principalTable: "kecamatan",
                principalColumn: "KecamatanID");

            migrationBuilder.AddForeignKey(
                name: "FK_kendaraan_bidang_BidangAsalId",
                table: "kendaraan",
                column: "BidangAsalId",
                principalTable: "bidang",
                principalColumn: "BidangID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_kendaraan_bidang_BidangPenugasanId",
                table: "kendaraan",
                column: "BidangPenugasanId",
                principalTable: "bidang",
                principalColumn: "BidangID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_kendaraan_jeniskendaraan_JenisKendaraanId",
                table: "kendaraan",
                column: "JenisKendaraanId",
                principalTable: "jeniskendaraan",
                principalColumn: "JenisID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_kendaraan_kabupaten_KabupatenAsalId",
                table: "kendaraan",
                column: "KabupatenAsalId",
                principalTable: "kabupaten",
                principalColumn: "KabupatenID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_kendaraan_kabupaten_KabupatenPenugasanId",
                table: "kendaraan",
                column: "KabupatenPenugasanId",
                principalTable: "kabupaten",
                principalColumn: "KabupatenID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_kendaraan_kecamatan_KecamatanAsalId",
                table: "kendaraan",
                column: "KecamatanAsalId",
                principalTable: "kecamatan",
                principalColumn: "KecamatanID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_kendaraan_kecamatan_KecamatanPenugasanId",
                table: "kendaraan",
                column: "KecamatanPenugasanId",
                principalTable: "kecamatan",
                principalColumn: "KecamatanID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_kendaraan_merkkendaraan_MerkKendaraanId",
                table: "kendaraan",
                column: "MerkKendaraanId",
                principalTable: "merkkendaraan",
                principalColumn: "MerkKendaraanId");

            migrationBuilder.AddForeignKey(
                name: "FK_kendaraan_tipekendaraan_TipeKendaraanId",
                table: "kendaraan",
                column: "TipeKendaraanId",
                principalTable: "tipekendaraan",
                principalColumn: "TipeKendaraanId");

            migrationBuilder.AddForeignKey(
                name: "FK_pegawai_bidang_BidangId",
                table: "pegawai",
                column: "BidangId",
                principalTable: "bidang",
                principalColumn: "BidangID");

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

            migrationBuilder.AddForeignKey(
                name: "FK_pegawai_tipepegawai_TipePegawaiId",
                table: "pegawai",
                column: "TipePegawaiId",
                principalTable: "tipepegawai",
                principalColumn: "TipePegawaiId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tipekendaraan_merkkendaraan_MerkKendaraanId",
                table: "tipekendaraan",
                column: "MerkKendaraanId",
                principalTable: "merkkendaraan",
                principalColumn: "MerkKendaraanId");

            migrationBuilder.AddForeignKey(
                name: "FK_tps_jenistps_JenisTpsId",
                table: "tps",
                column: "JenisTpsId",
                principalTable: "jenistps",
                principalColumn: "JenisID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tps_kelurahan_KelurahanID",
                table: "tps",
                column: "KelurahanID",
                principalTable: "kelurahan",
                principalColumn: "KelurahanID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tps_statuslahan_StatusLahanId",
                table: "tps",
                column: "StatusLahanId",
                principalTable: "statuslahan",
                principalColumn: "StatusLahanId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_kabupaten_provinsi_ProvinsiID",
                table: "kabupaten");

            migrationBuilder.DropForeignKey(
                name: "FK_kecamatan_kabupaten_KabupatenID",
                table: "kecamatan");

            migrationBuilder.DropForeignKey(
                name: "FK_kelurahan_kecamatan_KecamatanID",
                table: "kelurahan");

            migrationBuilder.DropForeignKey(
                name: "FK_kendaraan_bidang_BidangAsalId",
                table: "kendaraan");

            migrationBuilder.DropForeignKey(
                name: "FK_kendaraan_bidang_BidangPenugasanId",
                table: "kendaraan");

            migrationBuilder.DropForeignKey(
                name: "FK_kendaraan_jeniskendaraan_JenisKendaraanId",
                table: "kendaraan");

            migrationBuilder.DropForeignKey(
                name: "FK_kendaraan_kabupaten_KabupatenAsalId",
                table: "kendaraan");

            migrationBuilder.DropForeignKey(
                name: "FK_kendaraan_kabupaten_KabupatenPenugasanId",
                table: "kendaraan");

            migrationBuilder.DropForeignKey(
                name: "FK_kendaraan_kecamatan_KecamatanAsalId",
                table: "kendaraan");

            migrationBuilder.DropForeignKey(
                name: "FK_kendaraan_kecamatan_KecamatanPenugasanId",
                table: "kendaraan");

            migrationBuilder.DropForeignKey(
                name: "FK_kendaraan_merkkendaraan_MerkKendaraanId",
                table: "kendaraan");

            migrationBuilder.DropForeignKey(
                name: "FK_kendaraan_tipekendaraan_TipeKendaraanId",
                table: "kendaraan");

            migrationBuilder.DropForeignKey(
                name: "FK_pegawai_bidang_BidangId",
                table: "pegawai");

            migrationBuilder.DropForeignKey(
                name: "FK_pegawai_kabupaten_KabupatenId",
                table: "pegawai");

            migrationBuilder.DropForeignKey(
                name: "FK_pegawai_kecamatan_KecamatanId",
                table: "pegawai");

            migrationBuilder.DropForeignKey(
                name: "FK_pegawai_kelurahan_KelurahanId",
                table: "pegawai");

            migrationBuilder.DropForeignKey(
                name: "FK_pegawai_tipepegawai_TipePegawaiId",
                table: "pegawai");

            migrationBuilder.DropForeignKey(
                name: "FK_tipekendaraan_merkkendaraan_MerkKendaraanId",
                table: "tipekendaraan");

            migrationBuilder.DropForeignKey(
                name: "FK_tps_jenistps_JenisTpsId",
                table: "tps");

            migrationBuilder.DropForeignKey(
                name: "FK_tps_kelurahan_KelurahanID",
                table: "tps");

            migrationBuilder.DropForeignKey(
                name: "FK_tps_statuslahan_StatusLahanId",
                table: "tps");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tps",
                table: "tps");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tipepegawai",
                table: "tipepegawai");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tipekendaraan",
                table: "tipekendaraan");

            migrationBuilder.DropPrimaryKey(
                name: "PK_statuswr",
                table: "statuswr");

            migrationBuilder.DropPrimaryKey(
                name: "PK_statuslahan",
                table: "statuslahan");

            migrationBuilder.DropPrimaryKey(
                name: "PK_provinsi",
                table: "provinsi");

            migrationBuilder.DropPrimaryKey(
                name: "PK_penugasan",
                table: "penugasan");

            migrationBuilder.DropPrimaryKey(
                name: "PK_pegawai",
                table: "pegawai");

            migrationBuilder.DropPrimaryKey(
                name: "PK_merkkendaraan",
                table: "merkkendaraan");

            migrationBuilder.DropPrimaryKey(
                name: "PK_kendaraan",
                table: "kendaraan");

            migrationBuilder.DropPrimaryKey(
                name: "PK_kelurahan",
                table: "kelurahan");

            migrationBuilder.DropPrimaryKey(
                name: "PK_kecamatan",
                table: "kecamatan");

            migrationBuilder.DropPrimaryKey(
                name: "PK_kabupaten",
                table: "kabupaten");

            migrationBuilder.DropPrimaryKey(
                name: "PK_jenistps",
                table: "jenistps");

            migrationBuilder.DropPrimaryKey(
                name: "PK_jeniskendaraan",
                table: "jeniskendaraan");

            migrationBuilder.DropPrimaryKey(
                name: "PK_bidang",
                table: "bidang");

            migrationBuilder.RenameTable(
                name: "tps",
                newName: "Tps");

            migrationBuilder.RenameTable(
                name: "tipepegawai",
                newName: "TipePegawai");

            migrationBuilder.RenameTable(
                name: "tipekendaraan",
                newName: "TipeKendaraan");

            migrationBuilder.RenameTable(
                name: "statuswr",
                newName: "StatusWR");

            migrationBuilder.RenameTable(
                name: "statuslahan",
                newName: "StatusLahan");

            migrationBuilder.RenameTable(
                name: "provinsi",
                newName: "Provinsi");

            migrationBuilder.RenameTable(
                name: "penugasan",
                newName: "Penugasan");

            migrationBuilder.RenameTable(
                name: "pegawai",
                newName: "Pegawai");

            migrationBuilder.RenameTable(
                name: "merkkendaraan",
                newName: "MerkKendaraan");

            migrationBuilder.RenameTable(
                name: "kendaraan",
                newName: "Kendaraan");

            migrationBuilder.RenameTable(
                name: "kelurahan",
                newName: "Kelurahan");

            migrationBuilder.RenameTable(
                name: "kecamatan",
                newName: "Kecamatan");

            migrationBuilder.RenameTable(
                name: "kabupaten",
                newName: "Kabupaten");

            migrationBuilder.RenameTable(
                name: "jenistps",
                newName: "JenisTps");

            migrationBuilder.RenameTable(
                name: "jeniskendaraan",
                newName: "JenisKendaraan");

            migrationBuilder.RenameTable(
                name: "bidang",
                newName: "Bidang");

            migrationBuilder.RenameIndex(
                name: "IX_tps_StatusLahanId",
                table: "Tps",
                newName: "IX_Tps_StatusLahanId");

            migrationBuilder.RenameIndex(
                name: "IX_tps_KelurahanID",
                table: "Tps",
                newName: "IX_Tps_KelurahanID");

            migrationBuilder.RenameIndex(
                name: "IX_tps_JenisTpsId",
                table: "Tps",
                newName: "IX_Tps_JenisTpsId");

            migrationBuilder.RenameIndex(
                name: "IX_tipekendaraan_MerkKendaraanId",
                table: "TipeKendaraan",
                newName: "IX_TipeKendaraan_MerkKendaraanId");

            migrationBuilder.RenameIndex(
                name: "IX_pegawai_TipePegawaiId",
                table: "Pegawai",
                newName: "IX_Pegawai_TipePegawaiId");

            migrationBuilder.RenameIndex(
                name: "IX_pegawai_KelurahanId",
                table: "Pegawai",
                newName: "IX_Pegawai_KelurahanId");

            migrationBuilder.RenameIndex(
                name: "IX_pegawai_KecamatanId",
                table: "Pegawai",
                newName: "IX_Pegawai_KecamatanId");

            migrationBuilder.RenameIndex(
                name: "IX_pegawai_KabupatenId",
                table: "Pegawai",
                newName: "IX_Pegawai_KabupatenId");

            migrationBuilder.RenameIndex(
                name: "IX_pegawai_BidangId",
                table: "Pegawai",
                newName: "IX_Pegawai_BidangId");

            migrationBuilder.RenameIndex(
                name: "IX_kendaraan_TipeKendaraanId",
                table: "Kendaraan",
                newName: "IX_Kendaraan_TipeKendaraanId");

            migrationBuilder.RenameIndex(
                name: "IX_kendaraan_MerkKendaraanId",
                table: "Kendaraan",
                newName: "IX_Kendaraan_MerkKendaraanId");

            migrationBuilder.RenameIndex(
                name: "IX_kendaraan_KecamatanPenugasanId",
                table: "Kendaraan",
                newName: "IX_Kendaraan_KecamatanPenugasanId");

            migrationBuilder.RenameIndex(
                name: "IX_kendaraan_KecamatanAsalId",
                table: "Kendaraan",
                newName: "IX_Kendaraan_KecamatanAsalId");

            migrationBuilder.RenameIndex(
                name: "IX_kendaraan_KabupatenPenugasanId",
                table: "Kendaraan",
                newName: "IX_Kendaraan_KabupatenPenugasanId");

            migrationBuilder.RenameIndex(
                name: "IX_kendaraan_KabupatenAsalId",
                table: "Kendaraan",
                newName: "IX_Kendaraan_KabupatenAsalId");

            migrationBuilder.RenameIndex(
                name: "IX_kendaraan_JenisKendaraanId",
                table: "Kendaraan",
                newName: "IX_Kendaraan_JenisKendaraanId");

            migrationBuilder.RenameIndex(
                name: "IX_kendaraan_BidangPenugasanId",
                table: "Kendaraan",
                newName: "IX_Kendaraan_BidangPenugasanId");

            migrationBuilder.RenameIndex(
                name: "IX_kendaraan_BidangAsalId",
                table: "Kendaraan",
                newName: "IX_Kendaraan_BidangAsalId");

            migrationBuilder.RenameIndex(
                name: "IX_kelurahan_KecamatanID",
                table: "Kelurahan",
                newName: "IX_Kelurahan_KecamatanID");

            migrationBuilder.RenameIndex(
                name: "IX_kecamatan_KabupatenID",
                table: "Kecamatan",
                newName: "IX_Kecamatan_KabupatenID");

            migrationBuilder.RenameIndex(
                name: "IX_kabupaten_ProvinsiID",
                table: "Kabupaten",
                newName: "IX_Kabupaten_ProvinsiID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tps",
                table: "Tps",
                column: "TpsId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TipePegawai",
                table: "TipePegawai",
                column: "TipePegawaiId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TipeKendaraan",
                table: "TipeKendaraan",
                column: "TipeKendaraanId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StatusWR",
                table: "StatusWR",
                column: "StatusId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StatusLahan",
                table: "StatusLahan",
                column: "StatusLahanId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Provinsi",
                table: "Provinsi",
                column: "ProvinsiID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Penugasan",
                table: "Penugasan",
                column: "PenugasanId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Pegawai",
                table: "Pegawai",
                column: "PegawaiId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MerkKendaraan",
                table: "MerkKendaraan",
                column: "MerkKendaraanId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Kendaraan",
                table: "Kendaraan",
                column: "KendaraanId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Kelurahan",
                table: "Kelurahan",
                column: "KelurahanID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Kecamatan",
                table: "Kecamatan",
                column: "KecamatanID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Kabupaten",
                table: "Kabupaten",
                column: "KabupatenID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_JenisTps",
                table: "JenisTps",
                column: "JenisID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_JenisKendaraan",
                table: "JenisKendaraan",
                column: "JenisID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Bidang",
                table: "Bidang",
                column: "BidangID");

            migrationBuilder.AddForeignKey(
                name: "FK_Kabupaten_Provinsi_ProvinsiID",
                table: "Kabupaten",
                column: "ProvinsiID",
                principalTable: "Provinsi",
                principalColumn: "ProvinsiID");

            migrationBuilder.AddForeignKey(
                name: "FK_Kecamatan_Kabupaten_KabupatenID",
                table: "Kecamatan",
                column: "KabupatenID",
                principalTable: "Kabupaten",
                principalColumn: "KabupatenID");

            migrationBuilder.AddForeignKey(
                name: "FK_Kelurahan_Kecamatan_KecamatanID",
                table: "Kelurahan",
                column: "KecamatanID",
                principalTable: "Kecamatan",
                principalColumn: "KecamatanID");

            migrationBuilder.AddForeignKey(
                name: "FK_Kendaraan_Bidang_BidangAsalId",
                table: "Kendaraan",
                column: "BidangAsalId",
                principalTable: "Bidang",
                principalColumn: "BidangID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Kendaraan_Bidang_BidangPenugasanId",
                table: "Kendaraan",
                column: "BidangPenugasanId",
                principalTable: "Bidang",
                principalColumn: "BidangID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Kendaraan_JenisKendaraan_JenisKendaraanId",
                table: "Kendaraan",
                column: "JenisKendaraanId",
                principalTable: "JenisKendaraan",
                principalColumn: "JenisID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Kendaraan_Kabupaten_KabupatenAsalId",
                table: "Kendaraan",
                column: "KabupatenAsalId",
                principalTable: "Kabupaten",
                principalColumn: "KabupatenID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Kendaraan_Kabupaten_KabupatenPenugasanId",
                table: "Kendaraan",
                column: "KabupatenPenugasanId",
                principalTable: "Kabupaten",
                principalColumn: "KabupatenID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Kendaraan_Kecamatan_KecamatanAsalId",
                table: "Kendaraan",
                column: "KecamatanAsalId",
                principalTable: "Kecamatan",
                principalColumn: "KecamatanID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Kendaraan_Kecamatan_KecamatanPenugasanId",
                table: "Kendaraan",
                column: "KecamatanPenugasanId",
                principalTable: "Kecamatan",
                principalColumn: "KecamatanID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Kendaraan_MerkKendaraan_MerkKendaraanId",
                table: "Kendaraan",
                column: "MerkKendaraanId",
                principalTable: "MerkKendaraan",
                principalColumn: "MerkKendaraanId");

            migrationBuilder.AddForeignKey(
                name: "FK_Kendaraan_TipeKendaraan_TipeKendaraanId",
                table: "Kendaraan",
                column: "TipeKendaraanId",
                principalTable: "TipeKendaraan",
                principalColumn: "TipeKendaraanId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pegawai_Bidang_BidangId",
                table: "Pegawai",
                column: "BidangId",
                principalTable: "Bidang",
                principalColumn: "BidangID");

            migrationBuilder.AddForeignKey(
                name: "FK_Pegawai_Kabupaten_KabupatenId",
                table: "Pegawai",
                column: "KabupatenId",
                principalTable: "Kabupaten",
                principalColumn: "KabupatenID");

            migrationBuilder.AddForeignKey(
                name: "FK_Pegawai_Kecamatan_KecamatanId",
                table: "Pegawai",
                column: "KecamatanId",
                principalTable: "Kecamatan",
                principalColumn: "KecamatanID");

            migrationBuilder.AddForeignKey(
                name: "FK_Pegawai_Kelurahan_KelurahanId",
                table: "Pegawai",
                column: "KelurahanId",
                principalTable: "Kelurahan",
                principalColumn: "KelurahanID");

            migrationBuilder.AddForeignKey(
                name: "FK_Pegawai_TipePegawai_TipePegawaiId",
                table: "Pegawai",
                column: "TipePegawaiId",
                principalTable: "TipePegawai",
                principalColumn: "TipePegawaiId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TipeKendaraan_MerkKendaraan_MerkKendaraanId",
                table: "TipeKendaraan",
                column: "MerkKendaraanId",
                principalTable: "MerkKendaraan",
                principalColumn: "MerkKendaraanId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tps_JenisTps_JenisTpsId",
                table: "Tps",
                column: "JenisTpsId",
                principalTable: "JenisTps",
                principalColumn: "JenisID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tps_Kelurahan_KelurahanID",
                table: "Tps",
                column: "KelurahanID",
                principalTable: "Kelurahan",
                principalColumn: "KelurahanID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tps_StatusLahan_StatusLahanId",
                table: "Tps",
                column: "StatusLahanId",
                principalTable: "StatusLahan",
                principalColumn: "StatusLahanId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
