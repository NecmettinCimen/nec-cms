using System.Collections.Generic;
using System.Linq;
using NecCms.Database;
using NecCms.Database.Service;

namespace NecCms.Models
{
    public class AybatsHukuk
    {
        public static List<IcerikDto> Yayinlar()
        {
            GenericService genericService = new GenericService();

            var kategori = genericService.Queryable<Menu>().First(x => x.Url.Contains("yayinlar"));
            var kategorisub = genericService.Queryable<Menu>().Where(w => w.UstId == kategori.Id).Select(x => x.Id).ToList();
            kategorisub.Add(kategori.Id);
            
            var icerikler = from i in genericService.Queryable<Icerik.Icerikler>()
                join m in genericService.Queryable<Menu>() on i.MenuId equals  m.Id
                where i.Durum == Icerik.IcerikDurumEnum.Yayinlandi
                      && kategorisub.Contains(i.MenuId)
                orderby i.Id descending
                select new IcerikDto
                {
                    Baslik = i.Baslik,
                    Giris = i.Giris,
                    Tarih = i.YayinlanmaTarihi,
                    Url = i.Url,
                    Kategori = m.Isim,
                    KategoriUrl = m.Url
                };
            
            return icerikler.Take(5).ToList();
        }
    }
}