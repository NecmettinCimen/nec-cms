using System.Collections.Generic;

namespace NecCms.Models{
    public class KategoriDto{
        public int Id { get; set; }
        public string Isim { get; set; }
        public List<IcerikDto> Icerikler { get; set; }
    }
}