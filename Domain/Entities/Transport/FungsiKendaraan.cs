using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Retribusi.Entities;

[Table("fungsikendaraan")]
public class FungsiKendaraan
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int FungsiKendaraanID { get; set; }

#nullable disable

    [MaxLength(30)]
    [Required(ErrorMessage = "Nama Fungsi Kendaraan Wajib Diisi")]
    public string NamaFungsi { get; set; }

    public List<Kendaraan> Kendaraans { get; set; }
}
