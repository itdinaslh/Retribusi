using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Retribusi.Entites;

[Table("bidang")]
public class Bidang
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int BidangId { get; set; }

#nullable disable

    [Required(ErrorMessage = "Nama Bidang Wajib Diisi")]
    [MaxLength(100)]
    public string NamaBidang { get; set; }

    public DateTime? CreatedAt { get; set; } = DateTime.Now;

    public DateTime? UpdatedAt { get; set; } = DateTime.Now;
}
