using System.Collections.Generic;
using System.Linq;
using NecCms.Database;
using NecCms.Database.Service;

namespace NecCms.Models
{
    public class IcerikYonetimi
    {
        private static GenericService GenericService;

        public static GenericService genericService
        {
            get
            {
                if (GenericService == null) GenericService = new GenericService();
                return GenericService;
            }
            set => GenericService = value;
        }

        private static KategoriDto findByKategoriUrl(string url, int skip, int take)
        {
            var dbkategoriList = genericService.IQueryable<Menu>().Where(x => x.Url.ToLower().Contains(url.ToLower()))
                .ToList();
            if (dbkategoriList.Count == 0)
                return null;

            var kategori = dbkategoriList.First();

            var icerikler = from i in genericService.IQueryable<Icerik.Icerikler>()
                where i.Durum == Icerik.IcerikDurumEnum.Yayinlandi
                      && i.MenuId == kategori.Id
                orderby i.Id descending
                select new IcerikDto
                {
                    Baslik = i.Baslik,
                    Giris = i.Giris,
                    Kategori = kategori.Isim,
                    Tarih = i.YayinlanmaTarihi,
                    Url = i.Url
                };

            return new KategoriDto
            {
                Icerikler = icerikler.Skip(skip).Take(take).ToList(),
                IcerikSayisi = icerikler.Count(),
                Id = kategori.Id,
                Isim = kategori.Isim,
                Url = kategori.Url,
                Menuler = MenuYonetimi.Menuler.Find(x =>
                    kategori.UstId.HasValue ? x.Id == kategori.UstId : x.Id == kategori.Id)
            };
        }

        public static KategoriDto FindByKategoriUrl(string url, int skip, int take = 5)
        {
            return findByKategoriUrl(url, skip, take);
        }

        public static List<IcerikDto> FindByKategoriUrl(string url, int take)
        {
            return findByKategoriUrl(url, 0, take).Icerikler;
        }

        public static IcerikDto Find(string kategoriurl, string icerikurl)
        {
            var icerik = (from m in genericService.IQueryable<Menu>()
                    .Where(x => x.Url.ToLower().Contains(kategoriurl.ToLower()))
                join i in genericService.IQueryable<Icerik.Icerikler>() on m.Id equals i.MenuId
                where i.Durum == Icerik.IcerikDurumEnum.Yayinlandi
                      && i.Url.ToLower().Contains(icerikurl.ToLower())
                join d in genericService.IQueryable<Dosyalar>() on i.ResimId equals d.Id into dnull
                from d in dnull.DefaultIfEmpty()
                orderby i.Id descending
                select new IcerikDto
                {
                    Baslik = i.Baslik,
                    Icerik = i.Icerik,
                    Giris = i.Giris,
                    ResimData = d != null ? "data:" + d.Tipi + ";base64," + d.Data : "",
                    Kategori = m.Isim,
                    Tarih = i.YayinlanmaTarihi,
                    Url = i.Url
                }).FirstOrDefault();
            return icerik;
        }
    }
}