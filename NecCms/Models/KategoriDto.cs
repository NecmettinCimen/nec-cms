using System.Collections.Generic;

namespace NecCms.Models
{
    public class KategoriDto
    {
        public int Id { get; set; }
        public string Isim { get; set; }
        public string Url { get; set; }
        public MenuDto Menuler { get; set; }
        public List<IcerikDto> Icerikler { get; set; }
        public int SayfaNo { get; set; }
        public int IcerikSayisi { get; set; }
    }
}