using System.ComponentModel.DataAnnotations;

namespace NecCms.Database
{
    public enum MenuTip
    {
        TekSayfa=1,
        Liste=2,
        MenuListesi=3
    }
    public class Menu : BaseEntity
    {
        [Required] public string Isim { get; set; }

        public string Url { get; set; }

        [Required] public int Sira { get; set; }

        [Required] public MenuTip Tip { get; set; }
        
        public int? UstId { get; set; }
        public Menu Ust { get; set; }
    }
}