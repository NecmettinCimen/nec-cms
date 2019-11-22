using System.Collections.Generic;
using System.Linq;
using NecCms.Database;
using NecCms.Database.Service;

namespace NecCms.Models
{
    public class IcerikYonetimi
    {
        private static KategoriDto findByKategoriUrl(string url, int skip, int take)
        {
            GenericService genericService = new GenericService();
            var dbkategoriList = genericService.Queryable<Menu>().Where(x => x.Url.ToLower().Contains(url.ToLower()))
                .ToList();
            if (dbkategoriList.Count == 0)
                return null;

            var kategori = dbkategoriList.First();

            var icerikler = from i in genericService.Queryable<Icerik.Icerikler>()
                join m in genericService.Queryable<Menu>() on i.MenuId equals  m.Id
                where i.Durum == Icerik.IcerikDurumEnum.Yayinlandi
                      && m.Url.ToLower() == kategori.Url.ToLower()
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
            string prefix = "";
            #if DEBUG
                        prefix = "https://aybarshukuk.com";
            #endif
            GenericService genericService = new GenericService();
            var icerik = (genericService.Queryable<Menu>()
                .Where(x => x.Url.ToLower().Contains(kategoriurl.ToLower()))
                .Join(genericService.Queryable<Icerik.Icerikler>(), m => m.Id, i => i.MenuId, (m, i) => new {m, i})
                .Where(@t =>
                    @t.i.Durum == Icerik.IcerikDurumEnum.Yayinlandi && @t.i.Url.ToLower().Contains(icerikurl.ToLower()))
                .GroupJoin(genericService.Queryable<Dosyalar>(), @t => @t.i.ResimId, d => d.Id,
                    (@t, dnull) => new {@t, dnull})
                .SelectMany(@t => @t.dnull.DefaultIfEmpty(), (@t, d) => new {@t, d})
                .OrderByDescending(@t => @t.@t.@t.i.Id)
                .Select(@t => new IcerikDto
                {
                    Baslik = @t.@t.@t.i.Baslik,
                    Icerik = @t.@t.@t.i.Icerik,
                    Giris = @t.@t.@t.i.Giris,
                    ResimData = @t.d != null ? $"{prefix}/images/{@t.d.Adi}" : "",
                    Kategori = @t.@t.@t.m.Isim,
                    Tarih = @t.@t.@t.i.YayinlanmaTarihi,
                    Url = @t.@t.@t.i.Url
                })).FirstOrDefault();
            return icerik;
        }

        public static List<IcerikDto> Arama(string arama, int skip)
        {
      
            GenericService genericService = new GenericService();
            var icerik = (genericService.Queryable<Menu>()
                .Join(genericService.Queryable<Icerik.Icerikler>(), m => m.Id, i => i.MenuId, (m, i) => new {m, i})
                .Where(@t =>
                    @t.i.Durum == Icerik.IcerikDurumEnum.Yayinlandi && @t.i.Baslik.Contains(arama))
                .OrderByDescending(@t => @t.i.Id)
                .Select(@t => new IcerikDto
                {
                    Baslik = @t.i.Baslik,
                    Giris = @t.i.Giris,
                    Kategori = @t.m.Isim,
                    Tarih = @t.i.YayinlanmaTarihi,
                    Url = @t.i.Url
                })).Skip(skip).Take(10).ToList();
            return icerik;
        }
    }
}