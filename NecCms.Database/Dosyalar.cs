using System.ComponentModel.DataAnnotations;

namespace NecCms.Database
{
    public class Dosyalar : BaseEntity
    {
        [Required] [MaxLength(200)] public string Adi { get; set; }

        [Required] [MaxLength(250)] public string Yolu { get; set; }

        [Required] public long Boyutu { get; set; }

        [Required] [MaxLength(20)] public string Tipi { get; set; }
    }
}