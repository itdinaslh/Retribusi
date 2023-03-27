using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Retribusi.Entities;

[Table("Pegawai")]
public class Pegawai
{
    [Key]
    public Guid PegawaiId { get; set; } = Guid.Empty;

#nullable disable

    [Required(ErrorMessage = "Nama Pegawai Wajib Diisi")]
    [MaxLength(100)]
    public string NamaPegawai { get; set; }

    [Required(ErrorMessage = "NIK Wajib Diisi")]
    [MinLength(16)]
    [MaxLength(16)]
    public string NIK { get; set; }

#nullable enable

    [MaxLength(50)]
    public string? NIP { get; set; }

#nullable disable

    [Required(ErrorMessage = "Tanggal Lahir Wajib Diisi")]
    public DateOnly TglLahir { get; set; }

    [Required(ErrorMessage = "No HP Wajib Diisi")]
    [MaxLength(16)]
    public string NoHP { get; set; }

#nullable enable

    [MaxLength(150)]
    public string? Email { get; set; }

    [Required(ErrorMessage = "Tipe Pegawai Wajib Diisi")]
    public int TipePegawaiId { get; set; }

    [Required(ErrorMessage = "Status Aktif Wajib Dipilih")]
    public bool StatusAktif { get; set; } = true;

    public Int16? TahunMasuk { get; set; }

    public string? Catatan { get; set; }

    public Guid? BidangId { get; set; }

    public string? KecamatanID { get; set; }

    public string? KelurahanID { get; set; }

    public int? RoleId { get; set; }

    public Bidang? Bidang { get; set; }
    
    public Kecamatan? Kecamatan { get; set; }
    
    public Kelurahan? Kelurahan { get; set; }

    [MaxLength(255)]
    public string? Alamat { get; set; }

#nullable disable
    public TipePegawai TipePegawai { get; set; }

    public Role Role { get; set; }

    public DateTime? CreatedAt { get; set; } = DateTime.Now;

    public DateTime? UpdatedAt { get; set; } = DateTime.Now;
    
    public List<ClientWR> ClientWRs { get; set; }
}