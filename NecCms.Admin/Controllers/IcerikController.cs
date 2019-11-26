using System.Linq;
using Microsoft.AspNetCore.Mvc;
using NecCms.Admin.Filters;
using NecCms.Admin.Models;
using NecCms.Database;
using NecCms.Database.Service;

namespace NecCms.Admin.Controllers
{
    [NecCmsAuthorize]
    public class IcerikController : Controller
    {
        private readonly IGenericService _genericService;

        public IcerikController(IGenericService genericService)
        {
            _genericService = genericService;
        }

        public IActionResult Liste()
        {
            return View();
        }

        public IActionResult Ekle()
        {
            return View();
        }

        public IActionResult Duzenle(int id)
        {
            return View("Ekle");
        }

        public IActionResult Bul(int id)
        {
            return Json(new {data = _genericService.Queryable<Icerik.Icerikler>().First(x => x.Id == id)});
        }

        public IActionResult Kaydet(Icerik.Icerikler model)
        {
            var file = Request.Form.Files.Count > 0 ? Request.Form.Files.First() : null;

            if (file != null)
            {
                model.ResimId = DosyaIslemleri.Kaydet(file, _genericService).Id;
            }

            if (model.Id != 0)
            {
                var dbmodel = _genericService.Queryable<Icerik.Icerikler>().First(x => x.Id == model.Id);
                if (file == null)
                {
                    model.ResimId = dbmodel.ResimId;
                }
                else
                {
                    var eskidosya = _genericService.Queryable<Dosyalar>().First(f => f.Id == dbmodel.ResimId);
                    DosyaIslemleri.Delete(eskidosya.Adi);
                }
                model.YazarId = dbmodel.YazarId;
                model.Durum = dbmodel.Durum;
            }
            else
            {
                model.YazarId = 1;
                model.Durum = Icerik.IcerikDurumEnum.Hazirlandi;
            }

            return Json(new
            {
                data = _genericService.Save(model)
            });
        }

        public IActionResult Kaldir([FromBody] Icerik.Icerikler model)
        {
            return Json(new {data = _genericService.Remove(model)});
        }

        public IActionResult IcerikListesi()
        {
            return Json(new
            {
                data = from x in _genericService.Queryable<Icerik.Icerikler>()
                    join m in _genericService.Queryable<Menu>() on x.MenuId equals m.Id
                    orderby x.Id descending
                    select new
                    {
                        x.Baslik,
                        x.Id,
                        x.Durum,
                        Menu = m.Isim
                    }
            });
        }

        public IActionResult Durum(int id)
        {
            var dbmodel = _genericService.Queryable<Icerik.Icerikler>().First(x => x.Id == id);
            dbmodel.Durum = dbmodel.Durum == Icerik.IcerikDurumEnum.Hazirlandi
                ? Icerik.IcerikDurumEnum.Yayinlandi
                : Icerik.IcerikDurumEnum.Hazirlandi;

            return Json(new {data = _genericService.Save(dbmodel)});
        }
    }
}