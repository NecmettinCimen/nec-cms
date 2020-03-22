using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace NecCms.Database
{
    public class CrmContext : DbContext
    {
        public DbSet<Kullanici> Kullanicilar { get; set; }
        public DbSet<Icerik.Icerikler> Icerikler { get; set; }
        public DbSet<Icerik.FotografGalerisi> FotografGalerisi { get; set; }
        public DbSet<Icerik.FotografGalerisiDosyalar> FotografGalerisiDosyalar { get; set; }
        public DbSet<Dosyalar> Dosyalar { get; set; }
        public DbSet<Uyeler> Uyeler { get; set; }

        public DbSet<Tema.Parametre> Parametre { get; set; }
        public DbSet<Tema.ParametreDegeri> ParametreDegeri { get; set; }

        public DbSet<Menu> Menu { get; set; }
        public DbSet<Iletisim> Iletisim { get; set; }

        public DbSet<CustomLogger> Loggers { get; set; }

        public DbSet<IcerikTipleri> IcerikTipleri { get; set; }
        public DbSet<IcerikTipDegerleri> IcerikTipDegerleri { get; set; }

        public DbQuery<IstekKullaniciSayisiDto> IstekKullaniciSayisi { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
#if DEBUG
            optionsBuilder.UseSqlServer("Data Source=23.97.247.65,51433;Initial Catalog=dbmarket;User ID=sa;Password=A{J8c]fu^j\\FuZ&>", builder => builder.UseRowNumberForPaging());
#endif
#if !DEBUG
            optionsBuilder.UseSqlServer("Data Source=localhost\\sekiz;Initial Catalog=dbmarket;User ID=sa;Password=A{J8c]fu^j\\FuZ&>", builder => builder.UseRowNumberForPaging());
#endif
            optionsBuilder.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Kullanici>().HasData(new Kullanici
            {
                Id = 1,
                AdSoyad = "Admin",
                Eposta = "admin@crm.com",
                Parola = "admin@crm.com",
                Rol = RolEnum.Admin,
                Telefon = "05456286324"
            });
        }
    }

    public class IcerikTipleri : BaseEntity
    {
        [Required] [MaxLength(50)] public string Isim { get; set; }
        [Required] [MaxLength(50)] public string Kodu { get; set; }
        [Required] [MaxLength(500)] public string Alanlar { get; set; }
    }
    public class IcerikTipDegerleri : BaseEntity
    {
        [Required] public int Sira { get; set; }
        [Required] public int IcerikTipiId { get; set; }
        public IcerikTipleri IcerikTipi { get; set; }
        [Required] [MaxLength(50)] public string Alan { get; set; }
        [MaxLength(500)] public string Deger { get; set; }
        public int DegerInt { get; set; }
    }
}