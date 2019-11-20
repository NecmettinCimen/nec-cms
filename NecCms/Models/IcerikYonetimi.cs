using System.Collections.Generic;
using NecCms.Database.Service;
using NecCms.Database;
using System.Linq;

namespace NecCms.Models
{
    public class IcerikYonetimi
    {

        static GenericService GenericService;
        public static GenericService genericService
        {
            get { if (GenericService == null) GenericService = new GenericService(); return GenericService; }
            set { GenericService = value; }
        }

        public static List<IcerikDto> Find(string kategori, string icerik = null, int skip = 0, int take = 10)
        {
            List<IcerikDto> icerikler = (from k in genericService.IQueryable<Menu>().Where(x => x.Url.ToLower().Contains(kategori.ToLower()))
                                         join i in genericService.IQueryable<Icerik.Icerikler>().Where(x => x.Durum == Icerik.IcerikDurumEnum.Yayinlandi)
                                         on k.Id equals i.MenuId into inull
                                         from i in inull.DefaultIfEmpty()
                                         where icerik == null || i.Url.ToLower() == (icerik==null?"":icerik).ToLower()
                                         join d in genericService.IQueryable<Dosyalar>() on i.ResimId equals d.Id into dnull
                                         from d in dnull.DefaultIfEmpty()
                                         orderby k.Id descending
                                         orderby i.Id descending
                                         select new IcerikDto
                                         {
                                             Baslik = i.Baslik,
                                             Icerik = i.Icerik,
                                             Giris = i.Giris,
                                             ResimData = d != null ? "data:" + d.Tipi + ";base64," + d.Data : "",
                                             Kategori = k.Isim,
                                             Tarih = i.YayinlanmaTarihi,
                                             Url = i.Url
                                         }
                        ).Skip(skip).Take(take).ToList();
            return icerikler;
        }
    }
}