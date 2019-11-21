using System;
using System.ComponentModel.DataAnnotations;

namespace NecCms.Database
{
    public class BaseEntity
    {
        public int Id { get; set; }

        [Required] public bool Sil { get; set; } = false;

        [Required] public DateTime Tarih { get; set; } = new DateTime(2019, 1, 1);

        [Required] public int KullaniciId { get; set; } = 1;

        public Kullanici Kullanici { get; set; }
    }
}