using System;

namespace NecCms.Models
{
    public class IcerikDto
    {
        public string Url { get; set; }
        public string Baslik { get; set; }
        public string Icerik { get; set; }
        public string Giris { get; set; }
        public string Kategori { get; set; }
        public string ResimData { get; set; }
        public DateTime? Tarih { get; set; }
        public string KategoriUrl { get; set; }
    }
}