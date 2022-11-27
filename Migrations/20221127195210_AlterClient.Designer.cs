﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Retribusi.Data;

#nullable disable

namespace Retribusi.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20221127195210_AlterClient")]
    partial class AlterClient
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Retribusi.Entities.Bidang", b =>
                {
                    b.Property<Guid>("BidangID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("KepalaBidang")
                        .HasMaxLength(75)
                        .HasColumnType("varchar(75)");

                    b.Property<string>("NamaBidang")
                        .IsRequired()
                        .HasMaxLength(75)
                        .HasColumnType("varchar(75)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime(6)");

                    b.HasKey("BidangID");

                    b.ToTable("bidang");
                });

            modelBuilder.Entity("Retribusi.Entities.ClientWR", b =>
                {
                    b.Property<Guid>("ClientId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Alamat")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("ClientNIK")
                        .IsRequired()
                        .HasMaxLength(16)
                        .HasColumnType("varchar(16)");

                    b.Property<string>("ClientNPWP")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("ClientName")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("varchar(150)");

                    b.Property<string>("ClientPhone")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("JenisID")
                        .HasColumnType("int");

                    b.Property<string>("KecamatanID")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)");

                    b.Property<string>("KelurahanID")
                        .HasMaxLength(15)
                        .HasColumnType("varchar(15)");

                    b.Property<string>("Latitude")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Longitude")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("ObjectName")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("varchar(150)");

                    b.Property<string>("ObjectPhone")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.Property<Guid>("PegawaiId")
                        .HasColumnType("char(36)");

                    b.Property<bool>("StatusAktif")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime(6)");

                    b.HasKey("ClientId");

                    b.HasIndex("JenisID");

                    b.HasIndex("KecamatanID");

                    b.HasIndex("KelurahanID");

                    b.HasIndex("PegawaiId");

                    b.ToTable("clientwr");
                });

            modelBuilder.Entity("Retribusi.Entities.FungsiKendaraan", b =>
                {
                    b.Property<int>("FungsiKendaraanID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("NamaFungsi")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("varchar(30)");

                    b.HasKey("FungsiKendaraanID");

                    b.ToTable("fungsikendaraan");
                });

            modelBuilder.Entity("Retribusi.Entities.JenisKendaraan", b =>
                {
                    b.Property<int>("JenisID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("KodeJenis")
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.Property<string>("NamaJenis")
                        .IsRequired()
                        .HasMaxLength(75)
                        .HasColumnType("varchar(75)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime(6)");

                    b.HasKey("JenisID");

                    b.ToTable("jeniskendaraan");
                });

            modelBuilder.Entity("Retribusi.Entities.JenisTps", b =>
                {
                    b.Property<int>("JenisID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("NamaJenis")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime(6)");

                    b.HasKey("JenisID");

                    b.ToTable("jenistps");
                });

            modelBuilder.Entity("Retribusi.Entities.JenisWR", b =>
                {
                    b.Property<int>("JenisID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("NamaJenis")
                        .IsRequired()
                        .HasMaxLength(75)
                        .HasColumnType("varchar(75)");

                    b.Property<string>("NoRekening")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("varchar(30)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime(6)");

                    b.HasKey("JenisID");

                    b.ToTable("jeniswr");
                });

            modelBuilder.Entity("Retribusi.Entities.Kabupaten", b =>
                {
                    b.Property<string>("KabupatenID")
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)");

                    b.Property<bool>("IsKota")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Latitude")
                        .HasMaxLength(30)
                        .HasColumnType("varchar(30)");

                    b.Property<string>("Longitude")
                        .HasMaxLength(30)
                        .HasColumnType("varchar(30)");

                    b.Property<string>("NamaKabupaten")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("varchar(150)");

                    b.Property<string>("ProvinsiID")
                        .HasMaxLength(5)
                        .HasColumnType("varchar(5)");

                    b.HasKey("KabupatenID");

                    b.HasIndex("ProvinsiID");

                    b.ToTable("kabupaten");
                });

            modelBuilder.Entity("Retribusi.Entities.Kecamatan", b =>
                {
                    b.Property<string>("KecamatanID")
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)");

                    b.Property<string>("KabupatenID")
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)");

                    b.Property<string>("Latitude")
                        .HasMaxLength(30)
                        .HasColumnType("varchar(30)");

                    b.Property<string>("Longitude")
                        .HasMaxLength(30)
                        .HasColumnType("varchar(30)");

                    b.Property<string>("NamaKecamatan")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("varchar(150)");

                    b.HasKey("KecamatanID");

                    b.HasIndex("KabupatenID");

                    b.ToTable("kecamatan");
                });

            modelBuilder.Entity("Retribusi.Entities.Kelurahan", b =>
                {
                    b.Property<string>("KelurahanID")
                        .HasMaxLength(15)
                        .HasColumnType("varchar(15)");

                    b.Property<string>("KecamatanID")
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)");

                    b.Property<string>("Latitude")
                        .HasMaxLength(30)
                        .HasColumnType("varchar(30)");

                    b.Property<string>("Longitude")
                        .HasMaxLength(30)
                        .HasColumnType("varchar(30)");

                    b.Property<string>("NamaKelurahan")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("varchar(150)");

                    b.HasKey("KelurahanID");

                    b.HasIndex("KecamatanID");

                    b.ToTable("kelurahan");
                });

            modelBuilder.Entity("Retribusi.Entities.Kendaraan", b =>
                {
                    b.Property<int>("KendaraanId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<Guid?>("BidangAsalId")
                        .HasColumnType("char(36)");

                    b.Property<Guid?>("BidangPenugasanId")
                        .HasColumnType("char(36)");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<short?>("Fungsi")
                        .HasColumnType("smallint");

                    b.Property<int?>("FungsiKendaraanID")
                        .HasColumnType("int");

                    b.Property<bool?>("IsDeleted")
                        .HasColumnType("tinyint(1)");

                    b.Property<int>("JenisKendaraanId")
                        .HasColumnType("int");

                    b.Property<string>("KabupatenAsalId")
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)");

                    b.Property<string>("KabupatenPenugasanId")
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)");

                    b.Property<string>("KecamatanAsalId")
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)");

                    b.Property<string>("KecamatanPenugasanId")
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)");

                    b.Property<double?>("KonsumsiBBM")
                        .HasColumnType("double");

                    b.Property<int?>("MerkKendaraanId")
                        .HasColumnType("int");

                    b.Property<string>("NoPintu")
                        .HasMaxLength(25)
                        .HasColumnType("varchar(25)");

                    b.Property<string>("NoPolisi")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("varchar(25)");

                    b.Property<string>("NoRangka")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("TahunPengadaan")
                        .HasMaxLength(5)
                        .HasColumnType("varchar(5)");

                    b.Property<int?>("TipeKendaraanId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime(6)");

                    b.HasKey("KendaraanId");

                    b.HasIndex("BidangAsalId");

                    b.HasIndex("BidangPenugasanId");

                    b.HasIndex("FungsiKendaraanID");

                    b.HasIndex("JenisKendaraanId");

                    b.HasIndex("KabupatenAsalId");

                    b.HasIndex("KabupatenPenugasanId");

                    b.HasIndex("KecamatanAsalId");

                    b.HasIndex("KecamatanPenugasanId");

                    b.HasIndex("MerkKendaraanId");

                    b.HasIndex("TipeKendaraanId");

                    b.ToTable("kendaraan");
                });

            modelBuilder.Entity("Retribusi.Entities.MerkKendaraan", b =>
                {
                    b.Property<int>("MerkKendaraanId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<bool?>("IsActive")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("KodeMerk")
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.Property<string>("NamaMerk")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime(6)");

                    b.HasKey("MerkKendaraanId");

                    b.ToTable("merkkendaraan");
                });

            modelBuilder.Entity("Retribusi.Entities.Pegawai", b =>
                {
                    b.Property<Guid>("PegawaiId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Alamat")
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)");

                    b.Property<Guid?>("BidangId")
                        .HasColumnType("char(36)");

                    b.Property<string>("Catatan")
                        .HasColumnType("longtext");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Email")
                        .HasMaxLength(150)
                        .HasColumnType("varchar(150)");

                    b.Property<string>("KabupatenID")
                        .HasColumnType("varchar(10)");

                    b.Property<string>("KecamatanID")
                        .HasColumnType("varchar(10)");

                    b.Property<string>("KelurahanID")
                        .HasColumnType("varchar(15)");

                    b.Property<string>("NIK")
                        .IsRequired()
                        .HasMaxLength(16)
                        .HasColumnType("varchar(16)");

                    b.Property<string>("NIP")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("NamaPegawai")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("NoHP")
                        .IsRequired()
                        .HasMaxLength(16)
                        .HasColumnType("varchar(16)");

                    b.Property<int?>("RoleId")
                        .HasColumnType("int");

                    b.Property<bool>("StatusAktif")
                        .HasColumnType("tinyint(1)");

                    b.Property<short?>("TahunMasuk")
                        .HasColumnType("smallint");

                    b.Property<DateOnly>("TglLahir")
                        .HasColumnType("date");

                    b.Property<int>("TipePegawaiId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime(6)");

                    b.HasKey("PegawaiId");

                    b.HasIndex("BidangId");

                    b.HasIndex("KabupatenID");

                    b.HasIndex("KecamatanID");

                    b.HasIndex("KelurahanID");

                    b.HasIndex("RoleId");

                    b.HasIndex("TipePegawaiId");

                    b.ToTable("pegawai");
                });

            modelBuilder.Entity("Retribusi.Entities.Penugasan", b =>
                {
                    b.Property<int>("PenugasanId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<bool>("IsActive")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("NamaPenugasan")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.HasKey("PenugasanId");

                    b.ToTable("penugasan");
                });

            modelBuilder.Entity("Retribusi.Entities.Provinsi", b =>
                {
                    b.Property<string>("ProvinsiID")
                        .HasMaxLength(5)
                        .HasColumnType("varchar(5)");

                    b.Property<string>("HcKey")
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.Property<string>("KodeNegara")
                        .IsRequired()
                        .HasMaxLength(5)
                        .HasColumnType("varchar(5)");

                    b.Property<string>("Latitude")
                        .HasMaxLength(30)
                        .HasColumnType("varchar(30)");

                    b.Property<string>("Longitude")
                        .HasMaxLength(30)
                        .HasColumnType("varchar(30)");

                    b.Property<string>("NamaProvinsi")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("ProvinsiID");

                    b.ToTable("provinsi");
                });

            modelBuilder.Entity("Retribusi.Entities.Role", b =>
                {
                    b.Property<int>("RoleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("RoleName")
                        .HasMaxLength(30)
                        .HasColumnType("varchar(30)");

                    b.HasKey("RoleId");

                    b.ToTable("roles");
                });

            modelBuilder.Entity("Retribusi.Entities.StatusLahan", b =>
                {
                    b.Property<int>("StatusLahanId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<bool?>("IsDeleted")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("NamaStatus")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime(6)");

                    b.HasKey("StatusLahanId");

                    b.ToTable("statuslahan");
                });

            modelBuilder.Entity("Retribusi.Entities.StatusWR", b =>
                {
                    b.Property<int>("StatusId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("StatusName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime(6)");

                    b.HasKey("StatusId");

                    b.ToTable("statuswr");
                });

            modelBuilder.Entity("Retribusi.Entities.TipeKendaraan", b =>
                {
                    b.Property<int>("TipeKendaraanId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<int?>("MerkKendaraanId")
                        .HasColumnType("int");

                    b.Property<string>("NamaTipe")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime(6)");

                    b.HasKey("TipeKendaraanId");

                    b.HasIndex("MerkKendaraanId");

                    b.ToTable("tipekendaraan");
                });

            modelBuilder.Entity("Retribusi.Entities.TipePegawai", b =>
                {
                    b.Property<int>("TipePegawaiId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<bool>("IsActive")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("NamaTipe")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("TipePegawaiId");

                    b.ToTable("tipepegawai");
                });

            modelBuilder.Entity("Retribusi.Entities.Tps", b =>
                {
                    b.Property<int>("TpsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Alamat")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<bool?>("IsDeleted")
                        .HasColumnType("tinyint(1)");

                    b.Property<int>("JenisTpsId")
                        .HasColumnType("int");

                    b.Property<string>("KelurahanID")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("varchar(15)");

                    b.Property<string>("Keterangan")
                        .HasColumnType("longtext");

                    b.Property<string>("KodePos")
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)");

                    b.Property<string>("Latitude")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Longitude")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("NamaTps")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("varchar(150)");

                    b.Property<int>("StatusLahanId")
                        .HasColumnType("int");

                    b.Property<string>("TpsCode")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime(6)");

                    b.HasKey("TpsId");

                    b.HasIndex("JenisTpsId");

                    b.HasIndex("KelurahanID");

                    b.HasIndex("StatusLahanId");

                    b.ToTable("tps");
                });

            modelBuilder.Entity("Retribusi.Entities.ClientWR", b =>
                {
                    b.HasOne("Retribusi.Entities.JenisWR", "JenisWR")
                        .WithMany("ClientWRs")
                        .HasForeignKey("JenisID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Retribusi.Entities.Kecamatan", "Kecamatan")
                        .WithMany("ClientWRs")
                        .HasForeignKey("KecamatanID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Retribusi.Entities.Kelurahan", "Kelurahan")
                        .WithMany("ClientWRs")
                        .HasForeignKey("KelurahanID");

                    b.HasOne("Retribusi.Entities.Pegawai", "Pegawai")
                        .WithMany("ClientWRs")
                        .HasForeignKey("PegawaiId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("JenisWR");

                    b.Navigation("Kecamatan");

                    b.Navigation("Kelurahan");

                    b.Navigation("Pegawai");
                });

            modelBuilder.Entity("Retribusi.Entities.Kabupaten", b =>
                {
                    b.HasOne("Retribusi.Entities.Provinsi", "Provinsi")
                        .WithMany("Kabupatens")
                        .HasForeignKey("ProvinsiID");

                    b.Navigation("Provinsi");
                });

            modelBuilder.Entity("Retribusi.Entities.Kecamatan", b =>
                {
                    b.HasOne("Retribusi.Entities.Kabupaten", "Kabupaten")
                        .WithMany("Kecamatans")
                        .HasForeignKey("KabupatenID");

                    b.Navigation("Kabupaten");
                });

            modelBuilder.Entity("Retribusi.Entities.Kelurahan", b =>
                {
                    b.HasOne("Retribusi.Entities.Kecamatan", "Kecamatan")
                        .WithMany("Kelurahans")
                        .HasForeignKey("KecamatanID");

                    b.Navigation("Kecamatan");
                });

            modelBuilder.Entity("Retribusi.Entities.Kendaraan", b =>
                {
                    b.HasOne("Retribusi.Entities.Bidang", "BidangAsal")
                        .WithMany("KendaraanAsal")
                        .HasForeignKey("BidangAsalId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Retribusi.Entities.Bidang", "BidangPenugasan")
                        .WithMany("KendaraanPenugasan")
                        .HasForeignKey("BidangPenugasanId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Retribusi.Entities.FungsiKendaraan", "FungsiKendaraan")
                        .WithMany("Kendaraans")
                        .HasForeignKey("FungsiKendaraanID");

                    b.HasOne("Retribusi.Entities.JenisKendaraan", "JenisKendaraan")
                        .WithMany("Kendaraans")
                        .HasForeignKey("JenisKendaraanId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Retribusi.Entities.Kabupaten", "KabupatenAsal")
                        .WithMany("KendaraanAsal")
                        .HasForeignKey("KabupatenAsalId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Retribusi.Entities.Kabupaten", "KabupatenPenugasan")
                        .WithMany("KendaraanPenugasan")
                        .HasForeignKey("KabupatenPenugasanId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Retribusi.Entities.Kecamatan", "KecamatanAsal")
                        .WithMany("KendaraanAsal")
                        .HasForeignKey("KecamatanAsalId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Retribusi.Entities.Kecamatan", "KecamatanPenugasan")
                        .WithMany("KendaraanPenugasan")
                        .HasForeignKey("KecamatanPenugasanId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Retribusi.Entities.MerkKendaraan", "MerkKendaraan")
                        .WithMany("Kendaraans")
                        .HasForeignKey("MerkKendaraanId");

                    b.HasOne("Retribusi.Entities.TipeKendaraan", "TipeKendaraan")
                        .WithMany("Kendaraans")
                        .HasForeignKey("TipeKendaraanId");

                    b.Navigation("BidangAsal");

                    b.Navigation("BidangPenugasan");

                    b.Navigation("FungsiKendaraan");

                    b.Navigation("JenisKendaraan");

                    b.Navigation("KabupatenAsal");

                    b.Navigation("KabupatenPenugasan");

                    b.Navigation("KecamatanAsal");

                    b.Navigation("KecamatanPenugasan");

                    b.Navigation("MerkKendaraan");

                    b.Navigation("TipeKendaraan");
                });

            modelBuilder.Entity("Retribusi.Entities.Pegawai", b =>
                {
                    b.HasOne("Retribusi.Entities.Bidang", "Bidang")
                        .WithMany("Pegawais")
                        .HasForeignKey("BidangId");

                    b.HasOne("Retribusi.Entities.Kabupaten", null)
                        .WithMany("Pegawais")
                        .HasForeignKey("KabupatenID");

                    b.HasOne("Retribusi.Entities.Kecamatan", "Kecamatan")
                        .WithMany("Pegawais")
                        .HasForeignKey("KecamatanID");

                    b.HasOne("Retribusi.Entities.Kelurahan", "Kelurahan")
                        .WithMany("Pegawais")
                        .HasForeignKey("KelurahanID");

                    b.HasOne("Retribusi.Entities.Role", "Role")
                        .WithMany("Pegawais")
                        .HasForeignKey("RoleId");

                    b.HasOne("Retribusi.Entities.TipePegawai", "TipePegawai")
                        .WithMany("Pegawais")
                        .HasForeignKey("TipePegawaiId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Bidang");

                    b.Navigation("Kecamatan");

                    b.Navigation("Kelurahan");

                    b.Navigation("Role");

                    b.Navigation("TipePegawai");
                });

            modelBuilder.Entity("Retribusi.Entities.TipeKendaraan", b =>
                {
                    b.HasOne("Retribusi.Entities.MerkKendaraan", "MerkKendaraan")
                        .WithMany("TipeKendaraans")
                        .HasForeignKey("MerkKendaraanId");

                    b.Navigation("MerkKendaraan");
                });

            modelBuilder.Entity("Retribusi.Entities.Tps", b =>
                {
                    b.HasOne("Retribusi.Entities.JenisTps", "JenisTps")
                        .WithMany("Tps")
                        .HasForeignKey("JenisTpsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Retribusi.Entities.Kelurahan", "Kelurahan")
                        .WithMany("Tps")
                        .HasForeignKey("KelurahanID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Retribusi.Entities.StatusLahan", "StatusLahan")
                        .WithMany()
                        .HasForeignKey("StatusLahanId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("JenisTps");

                    b.Navigation("Kelurahan");

                    b.Navigation("StatusLahan");
                });

            modelBuilder.Entity("Retribusi.Entities.Bidang", b =>
                {
                    b.Navigation("KendaraanAsal");

                    b.Navigation("KendaraanPenugasan");

                    b.Navigation("Pegawais");
                });

            modelBuilder.Entity("Retribusi.Entities.FungsiKendaraan", b =>
                {
                    b.Navigation("Kendaraans");
                });

            modelBuilder.Entity("Retribusi.Entities.JenisKendaraan", b =>
                {
                    b.Navigation("Kendaraans");
                });

            modelBuilder.Entity("Retribusi.Entities.JenisTps", b =>
                {
                    b.Navigation("Tps");
                });

            modelBuilder.Entity("Retribusi.Entities.JenisWR", b =>
                {
                    b.Navigation("ClientWRs");
                });

            modelBuilder.Entity("Retribusi.Entities.Kabupaten", b =>
                {
                    b.Navigation("Kecamatans");

                    b.Navigation("KendaraanAsal");

                    b.Navigation("KendaraanPenugasan");

                    b.Navigation("Pegawais");
                });

            modelBuilder.Entity("Retribusi.Entities.Kecamatan", b =>
                {
                    b.Navigation("ClientWRs");

                    b.Navigation("Kelurahans");

                    b.Navigation("KendaraanAsal");

                    b.Navigation("KendaraanPenugasan");

                    b.Navigation("Pegawais");
                });

            modelBuilder.Entity("Retribusi.Entities.Kelurahan", b =>
                {
                    b.Navigation("ClientWRs");

                    b.Navigation("Pegawais");

                    b.Navigation("Tps");
                });

            modelBuilder.Entity("Retribusi.Entities.MerkKendaraan", b =>
                {
                    b.Navigation("Kendaraans");

                    b.Navigation("TipeKendaraans");
                });

            modelBuilder.Entity("Retribusi.Entities.Pegawai", b =>
                {
                    b.Navigation("ClientWRs");
                });

            modelBuilder.Entity("Retribusi.Entities.Provinsi", b =>
                {
                    b.Navigation("Kabupatens");
                });

            modelBuilder.Entity("Retribusi.Entities.Role", b =>
                {
                    b.Navigation("Pegawais");
                });

            modelBuilder.Entity("Retribusi.Entities.TipeKendaraan", b =>
                {
                    b.Navigation("Kendaraans");
                });

            modelBuilder.Entity("Retribusi.Entities.TipePegawai", b =>
                {
                    b.Navigation("Pegawais");
                });
#pragma warning restore 612, 618
        }
    }
}
