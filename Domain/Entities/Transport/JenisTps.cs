using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Retribusi.Entities;

#nullable disable
[Table("JenisTps")]
public class JenisTps {
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int JenisID { get; set; }

    [Required(ErrorMessage = "Nama Jenis TPS Wajib Diisi")]
    [MaxLength(50, ErrorMessage = "Max 50 Karakter")]
    public string NamaJenis { get; set; }

    public DateTime? CreatedAt { get; set; } = DateTime.Now;

    public DateTime? UpdatedAt { get; set; } = DateTime.Now;

    public List<Tps> Tps { get; set; }
}