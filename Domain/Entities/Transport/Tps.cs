using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Retribusi.Entities;

[Table("Tps")]
public class Tps
{
    [Key]
    public Guid TpsId { get; set; } = Guid.Empty;

    [MaxLength(50)]
    public string? TpsCode { get; set; }

#nullable disable
    [Required(ErrorMessage = "Nama TPS Wajib Diisi..")]
    [MaxLength(150)]
    public string NamaTps { get; set; }

    public int JenisTpsId { get; set; }

    [MaxLength(15)]
    [Required(ErrorMessage = "Kelurahan Wajib Dipilih..")]
    public string KelurahanID { get; set; }

#nullable enable   

    [MaxLength(50)]
    public string? Latitude { get; set; }

    [MaxLength(50)]
    public string? Longitude { get; set; }

    public double? LuasLahan { get; set; }

    public double? Volume { get; set; }

#nullable disable
    [Required(ErrorMessage = "Alamat Wajib Diisi...")]
    public string Alamat { get; set; }

    public int StatusLahanId { get; set; }
    
    public Kelurahan Kelurahan { get; set; }

    public StatusLahan StatusLahan { get; set; }

    public JenisTps JenisTps { get; set; }

    public bool? IsDeleted { get; set; } = false;

    public DateTime? CreatedAt { get; set; } = DateTime.Now;

    public DateTime? UpdatedAt { get; set; } = DateTime.Now;
}