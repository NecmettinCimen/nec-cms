using System.ComponentModel.DataAnnotations;

namespace NecCms.Database
{
    public class Menu : BaseEntity
    {
        [Required] public string Isim { get; set; }

        public string Url { get; set; }

        [Required] public int Sira { get; set; }

        public int? UstId { get; set; }
        public Menu Ust { get; set; }
    }
}