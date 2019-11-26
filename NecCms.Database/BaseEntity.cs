using System;
using System.ComponentModel.DataAnnotations;

namespace NecCms.Database
{
    public class BaseEntity
    {
        public int Id { get; set; }

        [Required] public short Sil { get; set; } = 0;

        [Required] public DateTime Tarih { get; set; } = new DateTime(2019, 1, 1);
        public int? KullaniciId { get; set; }
    }
}