using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Retribusi.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bidang",
                columns: table => new
                {
                    BidangID = table.Column<Guid>(type: "uuid", nullable: false),
                    NamaBidang = table.Column<string>(type: "character varying(75)", maxLength: 75, nullable: false),
                    KepalaBidang = table.Column<string>(type: "character varying(75)", maxLength: 75, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bidang", x => x.BidangID);
                });

            migrationBuilder.CreateTable(
                name: "FungsiKendaraan",
                columns: table => new
                {
                    FungsiKendaraanID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NamaFungsi = table.Column<string>(type: "character varying(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FungsiKendaraan", x => x.FungsiKendaraanID);
                });

            migrationBuilder.CreateTable(
                name: "JenisKendaraan",
                columns: table => new
                {
                    JenisID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    KodeJenis = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: true),
                    NamaJenis = table.Column<string>(type: "character varying(75)", maxLength: 75, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JenisKendaraan", x => x.JenisID);
                });

            migrationBuilder.CreateTable(
                name: "JenisTps",
                columns: table => new
                {
                    JenisID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NamaJenis = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JenisTps", x => x.JenisID);
                });

            migrationBuilder.CreateTable(
                name: "JenisWR",
                columns: table => new
                {
                    JenisID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NamaJenis = table.Column<string>(type: "character varying(75)", maxLength: 75, nullable: false),
                    NoRekening = table.Column<string>(type: "character varying(30)", maxLength: 30, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JenisWR", x => x.JenisID);
                });

            migrationBuilder.CreateTable(
                name: "MerkKendaraan",
                columns: table => new
                {
                    MerkKendaraanId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    KodeMerk = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: true),
                    NamaMerk = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    IsActive = table.Column<bool>(type: "boolean", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MerkKendaraan", x => x.MerkKendaraanId);
                });

            migrationBuilder.CreateTable(
                name: "Penugasan",
                columns: table => new
                {
                    PenugasanId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NamaPenugasan = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Penugasan", x => x.PenugasanId);
                });

            migrationBuilder.CreateTable(
                name: "Provinsi",
                columns: table => new
                {
                    ProvinsiID = table.Column<string>(type: "character varying(5)", maxLength: 5, nullable: false),
                    NamaProvinsi = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    HcKey = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: true),
                    Latitude = table.Column<string>(type: "character varying(30)", maxLength: 30, nullable: true),
                    Longitude = table.Column<string>(type: "character varying(30)", maxLength: 30, nullable: true),
                    KodeNegara = table.Column<string>(type: "character varying(5)", maxLength: 5, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Provinsi", x => x.ProvinsiID);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    RoleId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RoleName = table.Column<string>(type: "character varying(30)", maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.RoleId);
                });

            migrationBuilder.CreateTable(
                name: "StatusLahan",
                columns: table => new
                {
                    StatusLahanId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NamaStatus = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StatusLahan", x => x.StatusLahanId);
                });

            migrationBuilder.CreateTable(
                name: "StatusWR",
                columns: table => new
                {
                    StatusId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    StatusName = table.Column<string>(type: "text", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StatusWR", x => x.StatusId);
                });

            migrationBuilder.CreateTable(
                name: "TipePegawai",
                columns: table => new
                {
                    TipePegawaiId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NamaTipe = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipePegawai", x => x.TipePegawaiId);
                });

            migrationBuilder.CreateTable(
                name: "TipeKendaraan",
                columns: table => new
                {
                    TipeKendaraanId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    MerkKendaraanId = table.Column<int>(type: "integer", nullable: true),
                    NamaTipe = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipeKendaraan", x => x.TipeKendaraanId);
                    table.ForeignKey(
                        name: "FK_TipeKendaraan_MerkKendaraan_MerkKendaraanId",
                        column: x => x.MerkKendaraanId,
                        principalTable: "MerkKendaraan",
                        principalColumn: "MerkKendaraanId");
                });

            migrationBuilder.CreateTable(
                name: "Kabupaten",
                columns: table => new
                {
                    KabupatenID = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: false),
                    NamaKabupaten = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: false),
                    IsKota = table.Column<bool>(type: "boolean", nullable: false),
                    Latitude = table.Column<string>(type: "character varying(30)", maxLength: 30, nullable: true),
                    Longitude = table.Column<string>(type: "character varying(30)", maxLength: 30, nullable: true),
                    ProvinsiID = table.Column<string>(type: "character varying(5)", maxLength: 5, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kabupaten", x => x.KabupatenID);
                    table.ForeignKey(
                        name: "FK_Kabupaten_Provinsi_ProvinsiID",
                        column: x => x.ProvinsiID,
                        principalTable: "Provinsi",
                        principalColumn: "ProvinsiID");
                });

            migrationBuilder.CreateTable(
                name: "Kecamatan",
                columns: table => new
                {
                    KecamatanID = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: false),
                    NamaKecamatan = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: false),
                    Latitude = table.Column<string>(type: "character varying(30)", maxLength: 30, nullable: true),
                    Longitude = table.Column<string>(type: "character varying(30)", maxLength: 30, nullable: true),
                    KabupatenID = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kecamatan", x => x.KecamatanID);
                    table.ForeignKey(
                        name: "FK_Kecamatan_Kabupaten_KabupatenID",
                        column: x => x.KabupatenID,
                        principalTable: "Kabupaten",
                        principalColumn: "KabupatenID");
                });

            migrationBuilder.CreateTable(
                name: "Kelurahan",
                columns: table => new
                {
                    KelurahanID = table.Column<string>(type: "character varying(15)", maxLength: 15, nullable: false),
                    NamaKelurahan = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: false),
                    Latitude = table.Column<string>(type: "character varying(30)", maxLength: 30, nullable: true),
                    Longitude = table.Column<string>(type: "character varying(30)", maxLength: 30, nullable: true),
                    KecamatanID = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kelurahan", x => x.KelurahanID);
                    table.ForeignKey(
                        name: "FK_Kelurahan_Kecamatan_KecamatanID",
                        column: x => x.KecamatanID,
                        principalTable: "Kecamatan",
                        principalColumn: "KecamatanID");
                });

            migrationBuilder.CreateTable(
                name: "Kendaraan",
                columns: table => new
                {
                    KendaraanId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NoPintu = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: true),
                    NoPolisi = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: false),
                    MerkKendaraanId = table.Column<int>(type: "integer", nullable: true),
                    TipeKendaraanId = table.Column<int>(type: "integer", nullable: true),
                    JenisKendaraanId = table.Column<int>(type: "integer", nullable: false),
                    Fungsi = table.Column<short>(type: "smallint", nullable: true),
                    BidangAsalId = table.Column<Guid>(type: "uuid", nullable: true),
                    KabupatenAsalId = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true),
                    KecamatanAsalId = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true),
                    BidangPenugasanId = table.Column<Guid>(type: "uuid", nullable: true),
                    KabupatenPenugasanId = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true),
                    KecamatanPenugasanId = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true),
                    TahunPengadaan = table.Column<string>(type: "character varying(5)", maxLength: 5, nullable: true),
                    NoRangka = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    KonsumsiBBM = table.Column<double>(type: "double precision", nullable: true),
                    FungsiKendaraanID = table.Column<int>(type: "integer", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
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
                        name: "FK_Kendaraan_FungsiKendaraan_FungsiKendaraanID",
                        column: x => x.FungsiKendaraanID,
                        principalTable: "FungsiKendaraan",
                        principalColumn: "FungsiKendaraanID");
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
                });

            migrationBuilder.CreateTable(
                name: "Pegawai",
                columns: table => new
                {
                    PegawaiId = table.Column<Guid>(type: "uuid", nullable: false),
                    NamaPegawai = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    NIK = table.Column<string>(type: "character varying(16)", maxLength: 16, nullable: false),
                    NIP = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    TglLahir = table.Column<DateOnly>(type: "date", nullable: false),
                    NoHP = table.Column<string>(type: "character varying(16)", maxLength: 16, nullable: false),
                    Email = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: true),
                    TipePegawaiId = table.Column<int>(type: "integer", nullable: false),
                    StatusAktif = table.Column<bool>(type: "boolean", nullable: false),
                    TahunMasuk = table.Column<short>(type: "smallint", nullable: true),
                    Catatan = table.Column<string>(type: "text", nullable: true),
                    BidangId = table.Column<Guid>(type: "uuid", nullable: true),
                    KecamatanID = table.Column<string>(type: "character varying(10)", nullable: true),
                    KelurahanID = table.Column<string>(type: "character varying(15)", nullable: true),
                    RoleId = table.Column<int>(type: "integer", nullable: true),
                    Alamat = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    KabupatenID = table.Column<string>(type: "character varying(10)", nullable: true)
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
                        name: "FK_Pegawai_Kabupaten_KabupatenID",
                        column: x => x.KabupatenID,
                        principalTable: "Kabupaten",
                        principalColumn: "KabupatenID");
                    table.ForeignKey(
                        name: "FK_Pegawai_Kecamatan_KecamatanID",
                        column: x => x.KecamatanID,
                        principalTable: "Kecamatan",
                        principalColumn: "KecamatanID");
                    table.ForeignKey(
                        name: "FK_Pegawai_Kelurahan_KelurahanID",
                        column: x => x.KelurahanID,
                        principalTable: "Kelurahan",
                        principalColumn: "KelurahanID");
                    table.ForeignKey(
                        name: "FK_Pegawai_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "RoleId");
                    table.ForeignKey(
                        name: "FK_Pegawai_TipePegawai_TipePegawaiId",
                        column: x => x.TipePegawaiId,
                        principalTable: "TipePegawai",
                        principalColumn: "TipePegawaiId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tps",
                columns: table => new
                {
                    TpsId = table.Column<Guid>(type: "uuid", nullable: false),
                    TpsCode = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    NamaTps = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: false),
                    JenisTpsId = table.Column<int>(type: "integer", nullable: false),
                    KelurahanID = table.Column<string>(type: "character varying(15)", maxLength: 15, nullable: false),
                    Latitude = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    Longitude = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    LuasLahan = table.Column<double>(type: "double precision", nullable: true),
                    Volume = table.Column<double>(type: "double precision", nullable: true),
                    Alamat = table.Column<string>(type: "text", nullable: false),
                    StatusLahanId = table.Column<int>(type: "integer", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
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
                });

            migrationBuilder.CreateTable(
                name: "ClientWR",
                columns: table => new
                {
                    ClientId = table.Column<Guid>(type: "uuid", nullable: false),
                    ObjectName = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: false),
                    JenisID = table.Column<int>(type: "integer", nullable: false),
                    ObjectPhone = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: true),
                    Alamat = table.Column<string>(type: "text", nullable: false),
                    KecamatanID = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: false),
                    KelurahanID = table.Column<string>(type: "character varying(15)", maxLength: 15, nullable: true),
                    Latitude = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    Longitude = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    ClientName = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: false),
                    ClientNIK = table.Column<string>(type: "character varying(16)", maxLength: 16, nullable: false),
                    ClientPhone = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: true),
                    ClientNPWP = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    PegawaiId = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    StatusAktif = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientWR", x => x.ClientId);
                    table.ForeignKey(
                        name: "FK_ClientWR_JenisWR_JenisID",
                        column: x => x.JenisID,
                        principalTable: "JenisWR",
                        principalColumn: "JenisID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ClientWR_Kecamatan_KecamatanID",
                        column: x => x.KecamatanID,
                        principalTable: "Kecamatan",
                        principalColumn: "KecamatanID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClientWR_Kelurahan_KelurahanID",
                        column: x => x.KelurahanID,
                        principalTable: "Kelurahan",
                        principalColumn: "KelurahanID");
                    table.ForeignKey(
                        name: "FK_ClientWR_Pegawai_PegawaiId",
                        column: x => x.PegawaiId,
                        principalTable: "Pegawai",
                        principalColumn: "PegawaiId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ClientWR_JenisID",
                table: "ClientWR",
                column: "JenisID");

            migrationBuilder.CreateIndex(
                name: "IX_ClientWR_KecamatanID",
                table: "ClientWR",
                column: "KecamatanID");

            migrationBuilder.CreateIndex(
                name: "IX_ClientWR_KelurahanID",
                table: "ClientWR",
                column: "KelurahanID");

            migrationBuilder.CreateIndex(
                name: "IX_ClientWR_PegawaiId",
                table: "ClientWR",
                column: "PegawaiId");

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
                name: "IX_Kendaraan_FungsiKendaraanID",
                table: "Kendaraan",
                column: "FungsiKendaraanID");

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
                name: "IX_Pegawai_KabupatenID",
                table: "Pegawai",
                column: "KabupatenID");

            migrationBuilder.CreateIndex(
                name: "IX_Pegawai_KecamatanID",
                table: "Pegawai",
                column: "KecamatanID");

            migrationBuilder.CreateIndex(
                name: "IX_Pegawai_KelurahanID",
                table: "Pegawai",
                column: "KelurahanID");

            migrationBuilder.CreateIndex(
                name: "IX_Pegawai_RoleId",
                table: "Pegawai",
                column: "RoleId");

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
                name: "ClientWR");

            migrationBuilder.DropTable(
                name: "Kendaraan");

            migrationBuilder.DropTable(
                name: "Penugasan");

            migrationBuilder.DropTable(
                name: "StatusWR");

            migrationBuilder.DropTable(
                name: "Tps");

            migrationBuilder.DropTable(
                name: "JenisWR");

            migrationBuilder.DropTable(
                name: "Pegawai");

            migrationBuilder.DropTable(
                name: "FungsiKendaraan");

            migrationBuilder.DropTable(
                name: "JenisKendaraan");

            migrationBuilder.DropTable(
                name: "TipeKendaraan");

            migrationBuilder.DropTable(
                name: "JenisTps");

            migrationBuilder.DropTable(
                name: "StatusLahan");

            migrationBuilder.DropTable(
                name: "Bidang");

            migrationBuilder.DropTable(
                name: "Kelurahan");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "TipePegawai");

            migrationBuilder.DropTable(
                name: "MerkKendaraan");

            migrationBuilder.DropTable(
                name: "Kecamatan");

            migrationBuilder.DropTable(
                name: "Kabupaten");

            migrationBuilder.DropTable(
                name: "Provinsi");
        }
    }
}
