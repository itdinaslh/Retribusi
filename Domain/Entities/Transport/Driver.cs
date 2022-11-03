using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Retribusi.Entities;

[Table("drivers")]
public class Driver
{
    [Key]
    public Guid DriverId { get; set; }

#nullable disable

    [Required(ErrorMessage = "NIK Wajib Diisi")]
    [MaxLength(16)]
    public string NIK { get; set; }

    [Required(ErrorMessage = "Nama Wajib Diisi")]
    [MaxLength(150)]
    public string Nama { get; set; }

    [DataType(DataType.Text)]
    public string Alamat { get; set; }

    public DateOnly? TglLahir { get; set; }

#nullable enable

    [MaxLength(20)]
    public string? NoHP { get; set; }

    [MaxLength(255)]
    public string? Email { get; set; }    

    public bool? IsActive { get; set; } = true;

    public int? TahunMasuk { get; set; }

    [MaxLength(255)]
    public string? Catatan { get; set; }

    [DataType(DataType.Text)]
    public string? ImgPath { get; set; }

    public Guid BidangId { get; set; }

    public int TipePegawaiId { get; set; }

#nullable disable

    [MaxLength(10)]
    [Required(ErrorMessage = "Kecamatan Wajib Diisi")]
    public string KecamatanID { get; set; }

#nullable enable

    [MaxLength(15)]
    public string? KelurahanID { get; set; }

    public string? CreatedBy { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? CreatedAt { get; set; } = DateTime.Now;
    public DateTime? UpdatedAt { get; set; } = DateTime.Now;

#nullable disable
    public Bidang Bidang { get; set; }

    public TipePegawai TipePegawai { get; set; }

    public Kecamatan Kecamatan { get; set; }

#nullable enable

    public Kelurahan? Kelurahan { get; set; }
}
