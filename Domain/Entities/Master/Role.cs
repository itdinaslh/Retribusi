using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Retribusi.Entities;

[Table("Roles")]
public class Role
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int RoleId { get; set; }

#nullable disable

    [MaxLength(30)]
    public string RoleName { get; set; }

#nullable enable

    public List<Pegawai>? Pegawais { get; set; }
}
