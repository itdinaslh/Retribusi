using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Retribusi.Migrations
{
    public partial class SecondMigrations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_bidang",
                table: "bidang");

            migrationBuilder.RenameTable(
                name: "bidang",
                newName: "Bidang");

            migrationBuilder.RenameColumn(
                name: "BidangId",
                table: "Bidang",
                newName: "BidangID");

            migrationBuilder.AlterColumn<string>(
                name: "NamaBidang",
                table: "Bidang",
                type: "varchar(75)",
                maxLength: 75,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(100)",
                oldMaxLength: 100)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<Guid>(
                name: "BidangID",
                table: "Bidang",
                type: "char(36)",
                nullable: false,
                collation: "ascii_general_ci",
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddColumn<string>(
                name: "KepalaBidang",
                table: "Bidang",
                type: "varchar(75)",
                maxLength: 75,
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Bidang",
                table: "Bidang",
                column: "BidangID");

            migrationBuilder.CreateTable(
                name: "JenisKendaraan",
                columns: table => new
                {
                    JenisID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    KodeJenis = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NamaJenis = table.Column<string>(type: "varchar(75)", maxLength: 75, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JenisKendaraan", x => x.JenisID);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "JenisTps",
                columns: table => new
                {
                    JenisID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NamaJenis = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JenisTps", x => x.JenisID);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "MerkKendaraan",
                columns: table => new
                {
                    MerkKendaraanId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    KodeMerk = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NamaMerk = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IsActive = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MerkKendaraan", x => x.MerkKendaraanId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Penugasan",
                columns: table => new
                {
                    PenugasanId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NamaPenugasan = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IsActive = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Penugasan", x => x.PenugasanId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Provinsi",
                columns: table => new
                {
                    ProvinsiID = table.Column<string>(type: "varchar(5)", maxLength: 5, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NamaProvinsi = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    HcKey = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Latitude = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Longitude = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    KodeNegara = table.Column<string>(type: "varchar(5)", maxLength: 5, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Provinsi", x => x.ProvinsiID);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "StatusLahan",
                columns: table => new
                {
                    StatusLahanId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NamaStatus = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StatusLahan", x => x.StatusLahanId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "StatusWR",
                columns: table => new
                {
                    StatusId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    StatusName = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StatusWR", x => x.StatusId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "TipePegawai",
                columns: table => new
                {
                    TipePegawaiId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NamaTipe = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IsActive = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipePegawai", x => x.TipePegawaiId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "TipeKendaraan",
                columns: table => new
                {
                    TipeKendaraanId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    MerkKendaraanId = table.Column<int>(type: "int", nullable: true),
                    NamaTipe = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipeKendaraan", x => x.TipeKendaraanId);
                    table.ForeignKey(
                        name: "FK_TipeKendaraan_MerkKendaraan_MerkKendaraanId",
                        column: x => x.MerkKendaraanId,
                        principalTable: "MerkKendaraan",
                        principalColumn: "MerkKendaraanId");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Kabupaten",
                columns: table => new
                {
                    KabupatenID = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NamaKabupaten = table.Column<string>(type: "varchar(150)", maxLength: 150, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IsKota = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Latitude = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Longitude = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ProvinsiID = table.Column<string>(type: "varchar(5)", maxLength: 5, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kabupaten", x => x.KabupatenID);
                    table.ForeignKey(
                        name: "FK_Kabupaten_Provinsi_ProvinsiID",
                        column: x => x.ProvinsiID,
                        principalTable: "Provinsi",
                        principalColumn: "ProvinsiID");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Kecamatan",
                columns: table => new
                {
                    KecamatanID = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NamaKecamatan = table.Column<string>(type: "varchar(150)", maxLength: 150, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Latitude = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Longitude = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    KabupatenID = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kecamatan", x => x.KecamatanID);
                    table.ForeignKey(
                        name: "FK_Kecamatan_Kabupaten_KabupatenID",
                        column: x => x.KabupatenID,
                        principalTable: "Kabupaten",
                        principalColumn: "KabupatenID");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Kelurahan",
                columns: table => new
                {
                    KelurahanID = table.Column<string>(type: "varchar(15)", maxLength: 15, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NamaKelurahan = table.Column<string>(type: "varchar(150)", maxLength: 150, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Latitude = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Longitude = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    KecamatanID = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kelurahan", x => x.KelurahanID);
                    table.ForeignKey(
                        name: "FK_Kelurahan_Kecamatan_KecamatanID",
                        column: x => x.KecamatanID,
                        principalTable: "Kecamatan",
                        principalColumn: "KecamatanID");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Kendaraan",
                columns: table => new
                {
                    KendaraanId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NoPintu = table.Column<string>(type: "varchar(25)", maxLength: 25, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NoPolisi = table.Column<string>(type: "varchar(25)", maxLength: 25, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    MerkKendaraanId = table.Column<int>(type: "int", nullable: true),
                    TipeKendaraanId = table.Column<int>(type: "int", nullable: true),
                    JenisKendaraanId = table.Column<int>(type: "int", nullable: false),
                    Fungsi = table.Column<short>(type: "smallint", nullable: true),
                    BidangAsalId = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    KabupatenAsalId = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    KecamatanAsalId = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    BidangPenugasanId = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    KabupatenPenugasanId = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    KecamatanPenugasanId = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TahunPengadaan = table.Column<string>(type: "varchar(5)", maxLength: 5, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NoRangka = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    KonsumsiBBM = table.Column<double>(type: "double", nullable: true),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kendaraan", x => x.KendaraanId);
                    table.ForeignKey(
                        name: "FK_Kendaraan_Bidang_BidangAsalId",
                        column: x => x.BidangAsalId,
                        principalTable: "Bidang",
                        principalColumn: "BidangID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Kendaraan_Bidang_BidangPenugasanId",
                        column: x => x.BidangPenugasanId,
                        principalTable: "Bidang",
                        principalColumn: "BidangID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Kendaraan_JenisKendaraan_JenisKendaraanId",
                        column: x => x.JenisKendaraanId,
                        principalTable: "JenisKendaraan",
                        principalColumn: "JenisID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Kendaraan_Kabupaten_KabupatenAsalId",
                        column: x => x.KabupatenAsalId,
                        principalTable: "Kabupaten",
                        principalColumn: "KabupatenID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Kendaraan_Kabupaten_KabupatenPenugasanId",
                        column: x => x.KabupatenPenugasanId,
                        principalTable: "Kabupaten",
                        principalColumn: "KabupatenID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Kendaraan_Kecamatan_KecamatanAsalId",
                        column: x => x.KecamatanAsalId,
                        principalTable: "Kecamatan",
                        principalColumn: "KecamatanID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Kendaraan_Kecamatan_KecamatanPenugasanId",
                        column: x => x.KecamatanPenugasanId,
                        principalTable: "Kecamatan",
                        principalColumn: "KecamatanID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Kendaraan_MerkKendaraan_MerkKendaraanId",
                        column: x => x.MerkKendaraanId,
                        principalTable: "MerkKendaraan",
                        principalColumn: "MerkKendaraanId");
                    table.ForeignKey(
                        name: "FK_Kendaraan_TipeKendaraan_TipeKendaraanId",
                        column: x => x.TipeKendaraanId,
                        principalTable: "TipeKendaraan",
                        principalColumn: "TipeKendaraanId");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Pegawai",
                columns: table => new
                {
                    PegawaiId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NamaPegawai = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NIK = table.Column<string>(type: "varchar(16)", maxLength: 16, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TglLahir = table.Column<DateOnly>(type: "date", nullable: false),
                    NoHP = table.Column<string>(type: "varchar(16)", maxLength: 16, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email = table.Column<string>(type: "varchar(150)", maxLength: 150, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TipePegawaiId = table.Column<int>(type: "int", nullable: false),
                    StatusAktif = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    TahunMasuk = table.Column<short>(type: "smallint", nullable: true),
                    Catatan = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    BidangId = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    KabupatenId = table.Column<string>(type: "varchar(10)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    KecamatanId = table.Column<string>(type: "varchar(10)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    KelurahanId = table.Column<string>(type: "varchar(15)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pegawai", x => x.PegawaiId);
                    table.ForeignKey(
                        name: "FK_Pegawai_Bidang_BidangId",
                        column: x => x.BidangId,
                        principalTable: "Bidang",
                        principalColumn: "BidangID");
                    table.ForeignKey(
                        name: "FK_Pegawai_Kabupaten_KabupatenId",
                        column: x => x.KabupatenId,
                        principalTable: "Kabupaten",
                        principalColumn: "KabupatenID");
                    table.ForeignKey(
                        name: "FK_Pegawai_Kecamatan_KecamatanId",
                        column: x => x.KecamatanId,
                        principalTable: "Kecamatan",
                        principalColumn: "KecamatanID");
                    table.ForeignKey(
                        name: "FK_Pegawai_Kelurahan_KelurahanId",
                        column: x => x.KelurahanId,
                        principalTable: "Kelurahan",
                        principalColumn: "KelurahanID");
                    table.ForeignKey(
                        name: "FK_Pegawai_TipePegawai_TipePegawaiId",
                        column: x => x.TipePegawaiId,
                        principalTable: "TipePegawai",
                        principalColumn: "TipePegawaiId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Tps",
                columns: table => new
                {
                    TpsId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    TpsCode = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NamaTps = table.Column<string>(type: "varchar(150)", maxLength: 150, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    JenisTpsId = table.Column<int>(type: "int", nullable: false),
                    KelurahanID = table.Column<string>(type: "varchar(15)", maxLength: 15, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    KodePos = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Keterangan = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Latitude = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Longitude = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Alamat = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    StatusLahanId = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tps", x => x.TpsId);
                    table.ForeignKey(
                        name: "FK_Tps_JenisTps_JenisTpsId",
                        column: x => x.JenisTpsId,
                        principalTable: "JenisTps",
                        principalColumn: "JenisID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tps_Kelurahan_KelurahanID",
                        column: x => x.KelurahanID,
                        principalTable: "Kelurahan",
                        principalColumn: "KelurahanID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tps_StatusLahan_StatusLahanId",
                        column: x => x.StatusLahanId,
                        principalTable: "StatusLahan",
                        principalColumn: "StatusLahanId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Kabupaten_ProvinsiID",
                table: "Kabupaten",
                column: "ProvinsiID");

            migrationBuilder.CreateIndex(
                name: "IX_Kecamatan_KabupatenID",
                table: "Kecamatan",
                column: "KabupatenID");

            migrationBuilder.CreateIndex(
                name: "IX_Kelurahan_KecamatanID",
                table: "Kelurahan",
                column: "KecamatanID");

            migrationBuilder.CreateIndex(
                name: "IX_Kendaraan_BidangAsalId",
                table: "Kendaraan",
                column: "BidangAsalId");

            migrationBuilder.CreateIndex(
                name: "IX_Kendaraan_BidangPenugasanId",
                table: "Kendaraan",
                column: "BidangPenugasanId");

            migrationBuilder.CreateIndex(
                name: "IX_Kendaraan_JenisKendaraanId",
                table: "Kendaraan",
                column: "JenisKendaraanId");

            migrationBuilder.CreateIndex(
                name: "IX_Kendaraan_KabupatenAsalId",
                table: "Kendaraan",
                column: "KabupatenAsalId");

            migrationBuilder.CreateIndex(
                name: "IX_Kendaraan_KabupatenPenugasanId",
                table: "Kendaraan",
                column: "KabupatenPenugasanId");

            migrationBuilder.CreateIndex(
                name: "IX_Kendaraan_KecamatanAsalId",
                table: "Kendaraan",
                column: "KecamatanAsalId");

            migrationBuilder.CreateIndex(
                name: "IX_Kendaraan_KecamatanPenugasanId",
                table: "Kendaraan",
                column: "KecamatanPenugasanId");

            migrationBuilder.CreateIndex(
                name: "IX_Kendaraan_MerkKendaraanId",
                table: "Kendaraan",
                column: "MerkKendaraanId");

            migrationBuilder.CreateIndex(
                name: "IX_Kendaraan_TipeKendaraanId",
                table: "Kendaraan",
                column: "TipeKendaraanId");

            migrationBuilder.CreateIndex(
                name: "IX_Pegawai_BidangId",
                table: "Pegawai",
                column: "BidangId");

            migrationBuilder.CreateIndex(
                name: "IX_Pegawai_KabupatenId",
                table: "Pegawai",
                column: "KabupatenId");

            migrationBuilder.CreateIndex(
                name: "IX_Pegawai_KecamatanId",
                table: "Pegawai",
                column: "KecamatanId");

            migrationBuilder.CreateIndex(
                name: "IX_Pegawai_KelurahanId",
                table: "Pegawai",
                column: "KelurahanId");

            migrationBuilder.CreateIndex(
                name: "IX_Pegawai_TipePegawaiId",
                table: "Pegawai",
                column: "TipePegawaiId");

            migrationBuilder.CreateIndex(
                name: "IX_TipeKendaraan_MerkKendaraanId",
                table: "TipeKendaraan",
                column: "MerkKendaraanId");

            migrationBuilder.CreateIndex(
                name: "IX_Tps_JenisTpsId",
                table: "Tps",
                column: "JenisTpsId");

            migrationBuilder.CreateIndex(
                name: "IX_Tps_KelurahanID",
                table: "Tps",
                column: "KelurahanID");

            migrationBuilder.CreateIndex(
                name: "IX_Tps_StatusLahanId",
                table: "Tps",
                column: "StatusLahanId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Kendaraan");

            migrationBuilder.DropTable(
                name: "Pegawai");

            migrationBuilder.DropTable(
                name: "Penugasan");

            migrationBuilder.DropTable(
                name: "StatusWR");

            migrationBuilder.DropTable(
                name: "Tps");

            migrationBuilder.DropTable(
                name: "JenisKendaraan");

            migrationBuilder.DropTable(
                name: "TipeKendaraan");

            migrationBuilder.DropTable(
                name: "TipePegawai");

            migrationBuilder.DropTable(
                name: "JenisTps");

            migrationBuilder.DropTable(
                name: "Kelurahan");

            migrationBuilder.DropTable(
                name: "StatusLahan");

            migrationBuilder.DropTable(
                name: "MerkKendaraan");

            migrationBuilder.DropTable(
                name: "Kecamatan");

            migrationBuilder.DropTable(
                name: "Kabupaten");

            migrationBuilder.DropTable(
                name: "Provinsi");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Bidang",
                table: "Bidang");

            migrationBuilder.DropColumn(
                name: "KepalaBidang",
                table: "Bidang");

            migrationBuilder.RenameTable(
                name: "Bidang",
                newName: "bidang");

            migrationBuilder.RenameColumn(
                name: "BidangID",
                table: "bidang",
                newName: "BidangId");

            migrationBuilder.AlterColumn<string>(
                name: "NamaBidang",
                table: "bidang",
                type: "varchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(75)",
                oldMaxLength: 75)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<int>(
                name: "BidangId",
                table: "bidang",
                type: "int",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "char(36)")
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                .OldAnnotation("Relational:Collation", "ascii_general_ci");

            migrationBuilder.AddPrimaryKey(
                name: "PK_bidang",
                table: "bidang",
                column: "BidangId");
        }
    }
}
