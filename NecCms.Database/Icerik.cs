using System;
using System.ComponentModel.DataAnnotations;

namespace NecCms.Database
{
    public class Icerik
    {
        public enum IcerikDurumEnum
        {
            Hazirlandi = 1,
            Yayinlandi = 2,
            Rededildi = 3
        }

        public class Icerikler : BaseEntity
        {
            public int MenuId { get; set; }
            public Menu Menu { get; set; }

            [Required] public string Baslik { get; set; }

            [Required] public string Giris { get; set; }

            public string Icerik { get; set; }

            [Required] public DateTime YayinlanmaTarihi { get; set; }

            [Required] public IcerikDurumEnum Durum { get; set; }

            public int YazarId { get; set; }
            public Kullanici Yazar { get; set; }
            public int? ResimId { get; set; }
            public Dosyalar Resim { get; set; }

            [Required] public string Url { get; set; }
        }

        public class FotografGalerisi : BaseEntity
        {
            public int IcerikId { get; set; }
            public Icerikler Icerik { get; set; }
            public int FotografGalerisiDosyaId { get; set; }
            public FotografGalerisiDosyalar FotografGalerisiDosya { get; set; }
        }

        public class FotografGalerisiDosyalar : BaseEntity
        {
            public int DosyaId { get; set; }
            public Dosyalar Dosya { get; set; }
        }
    }
}