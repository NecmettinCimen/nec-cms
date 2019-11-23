using System.Collections.Generic;
using NecCms.Database;

namespace NecCms.Models
{
    public class KategoriDto
    {
        public int Id { get; set; }
        public string Isim { get; set; }
        public string KategoriUrl { get; set; }
        public MenuTip Tip { get; set; }
        public MenuDto Menuler { get; set; }
        public List<IcerikDto> Icerikler { get; set; }
        public int SayfaNo { get; set; }
        public int IcerikSayisi { get; set; }
    }
}