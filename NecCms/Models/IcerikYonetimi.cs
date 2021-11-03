using System;
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

            string prefix = "";
#if DEBUG
                        prefix = "https://showlazer.com";
#endif

            GenericService genericService = new GenericService();
            var dbkategoriList = genericService.Queryable<Menu>().Where(x => x.Url.ToLower().Contains(url.ToLower()))
                .ToList();
            if (dbkategoriList.Count == 0)
                return null;

            var kategori = dbkategoriList.First();

            var dbkategoriList2 = genericService.Queryable<Menu>()
                .Where(x => x.UstId == kategori.Id).Select(s => s.Id).ToList();
            dbkategoriList2.Add(kategori.Id);

            var icerikler = from i in genericService.Queryable<Icerik.Icerikler>()
                            join m in genericService.Queryable<Menu>() on i.MenuId equals m.Id
                            join r in genericService.Queryable<Dosyalar>() on i.ResimId equals r.Id into rn
                            from r in rn.DefaultIfEmpty()
                            where i.Durum == Icerik.IcerikDurumEnum.Yayinlandi
                                  && dbkategoriList2.Contains(i.MenuId)
                            orderby i.Id descending
                            select new IcerikDto
                            {
                                Baslik = i.Baslik,
                                Giris = i.Giris,
                                Kategori = m.Isim,  
                                KategoriUrl = m.Url,
                                Tarih = i.YayinlanmaTarihi,
                                Url = i.Url,
                                ResimData = r != null ? $"{prefix}/images/{r.Adi}" : "",
                            };

            return new KategoriDto
            {
                Icerikler = icerikler.Skip(skip).Take(take).ToList(),
                IcerikSayisi = icerikler.Count(),
                Id = kategori.Id,
                Isim = kategori.Isim,
                KategoriUrl = kategori.Url,
                Tip = kategori.Tip,
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
                        prefix = "https://showlazer.com";
#endif
            GenericService genericService = new GenericService();
            return (from m in genericService.Queryable<Menu>()
                    where m.Url.ToLower().Contains(kategoriurl.ToLower())
                    join icerik in genericService.Queryable<Icerik.Icerikler>() on m.Id equals icerik.MenuId
                    where icerik.Durum == Icerik.IcerikDurumEnum.Yayinlandi
                    && icerik.Url.ToLower().Contains(icerikurl.ToLower())
                    join dosya in genericService.Queryable<Dosyalar>() on icerik.ResimId equals dosya.Id into dn
                    from dosya in dn.DefaultIfEmpty()
                    select new IcerikDto
                    {
                        Baslik = icerik.Baslik,
                        Icerik = icerik.Icerik,
                        Giris = icerik.Giris,
                        ResimData = dosya != null ? $"{prefix}/images/{dosya.Adi}" : "",
                        Kategori = m.Isim,
                        Tarih = icerik.YayinlanmaTarihi,
                        Url = icerik.Url
                    }).FirstOrDefault();
        }

        public static List<IcerikDto> Arama(string arama, int skip)
        {

            GenericService genericService = new GenericService();
            var icerik = (genericService.Queryable<Menu>()
                .Join(genericService.Queryable<Icerik.Icerikler>(), m => m.Id, i => i.MenuId, (m, i) => new { m, i })
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