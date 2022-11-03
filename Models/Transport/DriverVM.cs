using Retribusi.Entities;

namespace Retribusi.Models;

public class DriverVM
{
#nullable disable

    public Driver Driver { get; set; }

#nullable enable

    public string? NamaBidang { get; set; }

    public string? KotaId { get; set; }

    public string? NamaKota { get; set; }

    public string? NamaKecamatan { get; set; }

    public string? NamaKelurahan { get; set; }
}
