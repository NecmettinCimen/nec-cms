using System.ComponentModel.DataAnnotations;

namespace NecCms.Database
{
    public class Iletisim : BaseEntity
    {
        [Required] [MaxLength(100)]public string Konu { get; set; }
        [Required] [MaxLength(100)]public string AdSoyad { get; set; }
        [Required] [MaxLength(50)]public string Eposta { get; set; }
        [Required] [MaxLength(500)]public string Aciklama { get; set; }

    }
}