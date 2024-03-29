﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Retribusi.Entities;

[Table("JenisWR")]
public class JenisWR
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int JenisID { get; set; }

#nullable disable

    [Required(ErrorMessage = "Nama Jenis WR Wajib disii!")]
    [MaxLength(75, ErrorMessage = "Maksimal 75 Karakter")]
    public string NamaJenis { get; set; }

    [Required(ErrorMessage = "No Rekening Wajib Diisi")]
    [MaxLength(30, ErrorMessage = "Maksimal 30 Karakter")]
    public string NoRekening { get; set; }

    public DateTime? CreatedAt { get; set; } = DateTime.Now;

    public DateTime? UpdatedAt { get; set; } = DateTime.Now;

    public List<ClientWR> ClientWRs { get; set; }

}
