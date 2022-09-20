using Retribusi.Entities;

namespace Retribusi.Models;

public class TipeKendaraanVM
{
#nullable disable
    public TipeKendaraan TipeKendaraan { get; set; } = new TipeKendaraan();

    public string NamaMerk { get; set; } = String.Empty;
}
