using Retribusi.Entities;
using System.ComponentModel.DataAnnotations;

namespace Retribusi.Models;

public class CLientVM
{
#nullable disable

    public ClientWR ClientWR { get; set; }

    [Required(ErrorMessage = "Kota/Wilayah Wajib Diisi")]
    public string KotaID { get; set; }

    [Required(ErrorMessage = "Kecamatan Wajib Diisi")]
    public string KecamatanID { get; set; }

# nullable enable

    public string? NamaKota { get; set; }

    public string? NamaKecamatan { get; set; }
}
