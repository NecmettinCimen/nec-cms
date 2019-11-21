using System.ComponentModel.DataAnnotations;

namespace NecCms.Database
{
    public class Kullanici : BaseEntity
    {
        [Required] [MaxLength(25)] public string AdSoyad { get; set; }

        [Required] [MaxLength(15)] public string Telefon { get; set; }

        [Required] [MaxLength(50)] public string Eposta { get; set; }

        [Required] [MaxLength(50)] public string Parola { get; set; }

        [Required] public RolEnum Rol { get; set; }
    }
}