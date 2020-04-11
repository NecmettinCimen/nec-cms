using System.ComponentModel.DataAnnotations;

namespace NecCms.Database
{
    public class Tags : BaseEntity
    {
        [Required] [MaxLength(200)] public string Icerik { get; set; }

        [Required] public int? IcerikId { get; set; }
    }
}