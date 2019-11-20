using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel.DataAnnotations;

namespace NecCms.Database
{
    public class CrmContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=sql.poseidon.domainhizmetleri.com;Database=aybarshu_kuk;User Id=aybarshu_kuk;Password=Huzt!903;");
            optionsBuilder.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Kullanici>().HasData(new Kullanici { Id = 1, AdSoyad = "Admin", Eposta = "admin@crm.com", Parola = "admin@crm.com", Rol = RolEnum.Admin, Telefon = "05456286324" });
        }
        public DbSet<Kullanici> Kullanicilar { get; set; }
        public DbSet<Icerik.IcerikKategori> IcerikKategorileri { get; set; }
        public DbSet<Icerik.Icerikler> Icerikler { get; set; }
        public DbSet<Icerik.FotografGalerisi> FotografGalerisi { get; set; }
        public DbSet<Icerik.FotografGalerisiDosyalar> FotografGalerisiDosyalar { get; set; }
        public DbSet<Dosyalar> Dosyalar { get; set; }
        public DbSet<Uyeler> Uyeler { get; set; }
        public DbSet<Etkinlikler> Etkinlikler { get; set; }

        public DbSet<Tema.Parametre> Parametre { get; set; }
        public DbSet<Tema.ParametreDegeri> ParametreDegeri { get; set; }
    }
    public class BaseEntity
    {
        public int Id { get; set; }
        [Required]
        public bool Sil { get; set; } = false;
        [Required]
        public DateTime Tarih { get; set; } = new DateTime(2019, 1, 1);
        [Required]
        public int KullaniciId { get; set; } = 1;
        public Kullanici Kullanici { get; set; }
    }
    public class Kullanici : BaseEntity
    {
        [Required]
        [MaxLength(25)]
        public string AdSoyad { get; set; }
        [Required]
        [MaxLength(15)]
        public string Telefon { get; set; }
        [Required]
        [MaxLength(50)]
        public string Eposta { get; set; }
        [Required]
        [MaxLength(50)]
        public string Parola { get; set; }
        [Required]
        public RolEnum Rol { get; set; }
    }
    public enum RolEnum
    {
        Admin = 1,
        Kullanici = 2,
        Uye = 3
    }

    public class Icerik
    {
        public class IcerikKategori : BaseEntity
        {
            public int? UstKategoriId { get; set; }
            public IcerikKategori UstKategori { get; set; }
            [Required]
            [MaxLength(50)]
            public string Isim { get; set; }
        }
        public class Icerikler : BaseEntity
        {
            public int IcerikKategoriId { get; set; }
            public IcerikKategori IcerikKategori { get; set; }
            [MaxLength(200)]
            [Required]
            public string Baslik { get; set; }
            [MaxLength(400)]
            [Required]
            public string Giris { get; set; }
            public string Icerik { get; set; }
            [Required]
            public DateTime YayinlanmaTarihi { get; set; }
            [Required]
            public IcerikDurumEnum Durum { get; set; }
            public int YazarId { get; set; }
            public Kullanici Yazar { get; set; }
            public int? ResimId { get; set; }
            public Dosyalar Resim { get; set; }
            [Required]
            [MaxLength(250)]
            public string Url { get; set; }
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
        public enum IcerikDurumEnum
        {
            Hazirlandi = 1,
            Yayinlandi = 2,
            Rededildi = 3,
        }
    }
    public class Dosyalar : BaseEntity
    {
        [Required]
        [MaxLength(200)]
        public string Adi { get; set; }
        [Required]
        [MaxLength(250)]
        public string Yolu { get; set; }
        [Required]
        public long Boyutu { get; set; }
        [Required]
        [MaxLength(20)]
        public string Tipi { get; set; }
        public string Data { get; set; }
    }
    public class Uyeler : BaseEntity
    {
        [Required]
        [MaxLength(100)]
        public string AdSoyad { get; set; }
        [Required]
        [MaxLength(100)]
        public string Email { get; set; }
        [Required]
        [MaxLength(15)]
        public string Telefon { get; set; }
        [Required]
        public bool Cinsiyet { get; set; }
        [Required]
        public DateTime DogumTarihi { get; set; }
        [Required]
        [MaxLength(100)]
        public string Bolum { get; set; }
        [Required]
        [MaxLength(250)]
        public string Hakkinda { get; set; }
    }
    public class Etkinlikler : BaseEntity
    {
        public int IcerikId { get; set; }
        public Icerik.Icerikler Icerik { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
    }

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
