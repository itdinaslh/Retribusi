using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Retribusi.Entities;

[Table("JenisKendaraan")]
public class JenisKendaraan {
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int JenisID { get; set; }

    #nullable enable
    
    [MaxLength(20)]
    public string? KodeJenis { get; set; }

    #nullable disable
    [Required(ErrorMessage = "Jenis Kendaraan Wajib Diisi")]
    [MaxLength(75, ErrorMessage = "Max 75 Karakter")]
    public string NamaJenis { get; set; }

    public DateTime? CreatedAt { get; set; } = DateTime.Now;

    public DateTime? UpdatedAt { get; set; } = DateTime.Now;

#nullable enable
    public List<Kendaraan>? Kendaraans { get; set; }
}