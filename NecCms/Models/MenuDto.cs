using System.Collections.Generic;

namespace NecCms.Models
{
    public class MenuDto
    {
        public int Sira { get; set; }
        public string Isim { get; set; }
        public int Id { get; set; }
        public string Url { get; set; }
        public List<MenuDto> Menuler { get; set; }
    }
}