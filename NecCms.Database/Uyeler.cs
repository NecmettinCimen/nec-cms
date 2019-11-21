using System;
using System.ComponentModel.DataAnnotations;

namespace NecCms.Database
{
    public class Uyeler : BaseEntity
    {
        [Required] [MaxLength(100)] public string AdSoyad { get; set; }

        [Required] [MaxLength(100)] public string Email { get; set; }

        [Required] [MaxLength(15)] public string Telefon { get; set; }

        [Required] public bool Cinsiyet { get; set; }

        [Required] public DateTime DogumTarihi { get; set; }

        [Required] [MaxLength(100)] public string Bolum { get; set; }

        [Required] [MaxLength(250)] public string Hakkinda { get; set; }
    }
}