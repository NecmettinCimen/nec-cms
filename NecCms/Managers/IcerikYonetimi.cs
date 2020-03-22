using System.Collections.Generic;
using System.Linq;
using NecCms.Database;
using NecCms.Database.Service;

namespace NecCms.Models
{
    public static class IcerikYonetimi
    {
        private static KategoriDto findByKategoriUrl(string url, int skip, int take)
        {
            var genericService = new GenericService();
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
                            where i.Durum == Icerik.IcerikDurumEnum.Yayinlandi
                                  && dbkategoriList2.Contains(i.MenuId)
                            join d in genericService.Queryable<Dosyalar>() on i.ResimId equals d.Id into dn
                            from d in dn.DefaultIfEmpty()
                            orderby i.Id descending
                            select new IcerikDto
                            {
                                Baslik = i.Baslik,
                                Giris = i.Giris,
                                Kategori = m.Isim,
                                Tarih = i.YayinlanmaTarihi,
                                Url = i.Url,
                                ResimData = d.Adi,
                                KategoriUrl = m.Url
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
            var genericService = new GenericService();
            var icerik = (from m in genericService.Queryable<Menu>()
                          where m.Url.ToLower().Contains(kategoriurl.ToLower())
                          join i in genericService.Queryable<Icerik.Icerikler>() on m.Id equals i.MenuId
                          where i.Durum == Icerik.IcerikDurumEnum.Yayinlandi && i.Url.ToLower().Contains(icerikurl.ToLower())
                          join d in genericService.Queryable<Dosyalar>() on i.ResimId equals d.Id into dn
                          from d in dn.DefaultIfEmpty()
                          select new IcerikDto
                          {
                              Baslik = i.Baslik,
                              Icerik = i.Icerik,
                              Giris = i.Giris,
                              ResimData = d.Adi,
                              Kategori = m.Isim,
                              KategoriUrl = m.Url,
                              Tarih = i.YayinlanmaTarihi,
                              Url = i.Url
                          }).FirstOrDefault();
            return icerik;
        }

        public static List<IcerikDto> Arama(string arama, int skip)
        {

            GenericService genericService = new GenericService();
            var icerik = (from m in genericService.Queryable<Menu>()
                          join i in genericService.Queryable<Icerik.Icerikler>() on m.Id equals i.MenuId
                          where i.Durum == Icerik.IcerikDurumEnum.Yayinlandi && i.Baslik.Contains(arama)
                          orderby i.Id descending
                          select new IcerikDto
                          {
                              Baslik = i.Baslik,
                              Giris = i.Giris,
                              Kategori = m.Isim,
                              Tarih = i.YayinlanmaTarihi,
                              Url = i.Url
                          }).Skip(skip).Take(10).ToList();
            return icerik;
        }
    }
}