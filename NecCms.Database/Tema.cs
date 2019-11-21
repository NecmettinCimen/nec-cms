using System.ComponentModel.DataAnnotations;

namespace NecCms.Database
{
    public class Tema
    {
        public class Parametre : BaseEntity
        {
            [Required]
            public string Kodu { get; set; }
            public string Isim { get; set; }
            public string Aciklama { get; set; }
            [Required]
            public int Tip { get; set; }
            public int Sira { get; set; }
        }
        public class ParametreDegeri : BaseEntity
        {
            public int ParametreId { get; set; }
            public Parametre Parametre { get; set; }
            public string Deger { get; set; }
            public int DegerInt { get; set; }
        }
    }
}