using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Retribusi.Entities;

[Table("clientwr")]
public class ClientWR
{
    [Key]
    public Guid ClientId { get; set; } = Guid.Empty;

#nullable disable

    [Required(ErrorMessage = "Nama Objek Retribusi Wajib Diisi")]
    [MaxLength(150)]
    public string ObjectName { get; set; }    

    [Required(ErrorMessage = "Harap Pilih Jenis WR")]
    public int JenisID { get; set; }

#nullable enable

    [MaxLength(20)]
    public string? ObjectPhone { get; set; }

#nullable disable
    [Required(ErrorMessage = "Alamat Wajib Diisi")]
    [DataType(DataType.MultilineText)]
    public string Alamat { get; set; }

    [Required(ErrorMessage = "Kecamatan Wajib Dipilih")]
    [MaxLength(10)]
    public string KecamatanID { get; set; }

#nullable enable

    [MaxLength(15)]
    public string? KelurahanID { get; set; }

#nullable disable

    [Required(ErrorMessage = "Koordinat Lintang Wajib Diisi")]
    [MaxLength(50)]
    public string Latitude { get; set; }

    [MaxLength(50)]
    [Required(ErrorMessage = "Koordinat Bujur Wajib Diisi")]
    public string Longitude { get; set; }

    [MaxLength(150)]
    [Required(ErrorMessage = "Nama Wajib Retribusi Wajib Diisi")]
    public string ClientName { get; set; }

    [MinLength(16)]
    [MaxLength(16)]
    [Required(ErrorMessage = "NIK Wajib Retribusi Wajib Diisi")]
    public string ClientNIK { get; set; }

#nullable enable

    [MaxLength(20)]
    public string? ClientPhone { get; set; }

    [MaxLength(50)]
    public string? ClientNPWP { get; set; }

#nullable disable

    [Required(ErrorMessage = "Operator Wajib Dipilih")]
    public Guid PegawaiId { get; set; }

    public DateTime? CreatedAt { get; set; } = DateTime.Now;

    public DateTime? UpdatedAt { get; set; } = DateTime.Now;

    public JenisWR JenisWR { get; set; }

    public Kecamatan Kecamatan { get; set; }

    public Pegawai Pegawai { get; set; }

#nullable enable

    public Kelurahan? Kelurahan { get; set; }

#nullable disable

    public bool StatusAktif { get; set; } = true;

}
