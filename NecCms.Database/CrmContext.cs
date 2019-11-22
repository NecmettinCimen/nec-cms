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

        public DbQuery<IstekKullaniciSayisiDto> IstekKullaniciSayisi { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Server=sql.poseidon.domainhizmetleri.com;Database=aybarshu_kuk;User Id=aybarshu_kuk;Password=Huzt!903;");
            optionsBuilder.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Kullanici>().HasData(new Kullanici
            {
                Id = 1, AdSoyad = "Admin", Eposta = "admin@crm.com", Parola = "admin@crm.com", Rol = RolEnum.Admin,
                Telefon = "05456286324"
            });
        }
    }
    public class IstekKullaniciSayisiDto
    {
        public string y { get; set; }
        public int a { get; set; }
        public int b { get; set; }
    }
}