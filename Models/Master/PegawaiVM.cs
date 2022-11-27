using Retribusi.Entities;

namespace Retribusi.Models;

public class PegawaiVM
{
#nullable disable

    public Pegawai Pegawai { get; set; } = new Pegawai();

#nullable enable
    
    public string? Lahir { get; set; }

    public string? TheNIK { get; set; }

    public string? NamaOrang { get; set; }

    public string? NamaBidang { get; set; }

    public string? KotaID { get; set; }

    public string? NamaKota { get; set; }

    public string? NamaKecamatan { get; set; }

    public string? NamaKelurahan { get; set; }
}
