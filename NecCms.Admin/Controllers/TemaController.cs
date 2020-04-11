using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NecCms.Admin.Filters;
using NecCms.Admin.Models;
using NecCms.Database;
using NecCms.Database.Service;

namespace NecCms.Admin.Controllers
{
    [NecCmsAuthorize]
    public class TemaController : Controller
    {
        private readonly IGenericService _genericService;

        public TemaController(IGenericService genericService)
        {
            _genericService = genericService;
        }
        
        public IActionResult Resim(int id)
        {
                Dosyalar resim = _genericService.Queryable<Dosyalar>().First(f=>f.Id == id);
                return File(System.IO.File.OpenRead(resim.Yolu), resim.Tipi);
            }

        [AdminAuthorize]
        public IActionResult Yonetim()
        {
            return View("~/Views/Shared/_Crud.cshtml");
        }

        public IActionResult Duzenle()
        {
            return View();
        }

        public IActionResult ParametreListesi(int? id)
        {
            return Json(new
            {
                data = _genericService.Queryable<Tema.Parametre>().Where(x => x.Id == id || !id.HasValue)
                    .OrderByDescending(x => x.Id).ToList()
            });
        }

        public IActionResult ParametreKaydet([FromBody] Tema.Parametre model)
        {
            return Json(new {data = _genericService.Save(model)});
        }

        public IActionResult ParametreKaldir([FromBody] Tema.Parametre model)
        {
            return Json(new {data = _genericService.Remove(model)});
        }

        public IActionResult ParametreDegerListesi(int? id)
        {
            return Json(new
            {
                data = (from p in _genericService.Queryable<Tema.Parametre>()
                        .Where(x => x.Id == id || !id.HasValue)
                        join pd in _genericService.Queryable<Tema.ParametreDegeri>() on p.Id equals pd.ParametreId 
                            into pdn
                        from pd in pdn.DefaultIfEmpty()
                        select new
                        {
                            p.Id,
                            p.Isim,
                            p.Kodu,
                            p.Aciklama,
                            p.Tip,
                            pd.Deger
                        })
                    .OrderByDescending(x => x.Id)
                    .ToList()
            });
        }

        public async Task<IActionResult> ParametreDegeriKaydet(Tema.ParametreDegeri model)
        {
            var file = Request.Form.Files.Count > 0 ? Request.Form.Files.First() : null;

            if (model.Id != 0)
            {
                var dbmodel = await _genericService.Queryable<Tema.ParametreDegeri>().FirstAsync(f => f.Id == model.Id);
                if (dbmodel.DegerInt != 0)
                {
                    var dbdosya = await _genericService.Queryable<Dosyalar>().FirstAsync(f => f.Id == dbmodel.DegerInt);
                    DosyaIslemleri.Delete(dbdosya.Adi);
                }
            }
            if (file != null)
            {
                var dosya = await DosyaIslemleri.Kaydet(file, _genericService);
                model.DegerInt = dosya.Id;
                model.Deger = dosya.Adi;
            }

            return Json(new {data = _genericService.Save(model)});
        }
    }
}