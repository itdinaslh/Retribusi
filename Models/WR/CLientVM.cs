using Retribusi.Entities;
using System.ComponentModel.DataAnnotations;

namespace Retribusi.Models;

public class CLientVM
{
#nullable disable

    public ClientWR ClientWR { get; set; }

    public string KotaID { get; set; }

# nullable enable

    public string? NamaKota { get; set; }

    public string? NamaKecamatan { get; set; }
}
