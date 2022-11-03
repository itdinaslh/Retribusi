using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Retribusi.Entities;

[Table("tipepegawai")]
public class TipePegawai
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int TipePegawaiId { get; set; }

#nullable disable

    [Required(ErrorMessage = "Nama Tipe Harus Diisi..")]
    [MaxLength(50)]
    public string NamaTipe { get; set; }

    public bool IsActive { get; set; } = true;

    public List<Driver> Drivers  { get; set; }
}