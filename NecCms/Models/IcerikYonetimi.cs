using System.Collections.Generic;
using NecCms.Database.Service;
using NecCms.Database;
using System.Linq;

namespace NecCms.Models
{
    public class IcerikYonetimi
    {

        static GenericService GenericService;
        static GenericService _genericService
        {
            get { if (GenericService == null) GenericService = new GenericService(); return GenericService; }
            set { GenericService = value; }
        }

        public static List<IcerikDto> Find(string kategori, string icerik=null,int skip=0, int take = 10)
        {
            List<IcerikDto> icerikler = (from k in _genericService.IQueryable<Icerik.IcerikKategori>().Where(x => x.Isim.ToLower() == kategori.ToLower())
                                         join i in _genericService.IQueryable<Icerik.Icerikler>().Where(x=>x.Durum == Icerik.IcerikDurumEnum.Yayinlandi)
                                         on k.Id equals i.IcerikKategoriId into inull
                                         from i in inull.DefaultIfEmpty()
                                         where icerik==null || i.Url.ToLower() == icerik.ToLower()
                                         join d in _genericService.IQueryable<Dosyalar>() on i.ResimId equals d.Id into dnull
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
                                             Tarih=i.YayinlanmaTarihi,
                                             Url=i.Url
                                         }
                        ).Skip(skip).Take(take).ToList();
            return icerikler;
        }
    }
}