using System.Linq;
using Microsoft.AspNetCore.Mvc;
using NecCms.Admin.Filters;
using NecCms.Admin.Models;
using NecCms.Database;
using NecCms.Database.Service;
using DocumentFormat.OpenXml.Packaging;
using OpenXmlPowerTools;
using System.Xml.Linq;
using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

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
            return Json(new { data = _genericService.Queryable<Icerik.Icerikler>().First(x => x.Id == id) });
        }

        public async Task<IActionResult> Kaydet(Icerik.Icerikler model, string[] tags)
        {
            var file = Request.Form.Files.Count > 0 ? Request.Form.Files.First() : null;

            if (file != null)
            {
                model.ResimId = DosyaIslemleri.Kaydet(file, _genericService).Id;
            }

            if (model.Id != 0)
            {
                var dbmodel = await _genericService.Queryable<Icerik.Icerikler>().FirstAsync(x => x.Id == model.Id);
                if (file == null)
                {
                    model.ResimId = dbmodel.ResimId;
                }
                else
                {
                    var eskidosya = await _genericService.Queryable<Dosyalar>().FirstAsync(f => f.Id == dbmodel.ResimId);
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
            int icerikId = await _genericService.Save(model);

            await _genericService.Save(tags.Select(s => new Tags
            {
                IcerikId = icerikId,
                Icerik = s,
                Id = !_genericService.Queryable<Tags>().Any(w => w.Icerik.ToLower().Trim() == s.ToLower().Trim()) ?
                 0 : _genericService.Queryable<Tags>().Where(w => w.Icerik.ToLower().Trim() == s.ToLower().Trim()).Select(f => f.Id).First()
            }).ToList());

            return Json(new
            {
                data = icerikId
            });
        }

        public IActionResult WordToHtml()
        {
            var file = Request.Form.Files.First();
            try
            {
                using (MemoryStream memoryStream = new MemoryStream())
                {
                    file.CopyTo(memoryStream);
                    using (WordprocessingDocument doc =
                        WordprocessingDocument.Open(memoryStream, true))
                    {
                        HtmlConverterSettings settings = new HtmlConverterSettings()
                        {
                            PageTitle = file.Name
                        };
                        XElement html = HtmlConverter.ConvertToHtml(doc, settings);

                        return Json(new { success = true, data = html.ToStringNewLineOnAttributes() });
                    }
                }
            }
            catch (Exception ex)
            {
                return Json(new { success = false, data = ex.Message });
            }
        }
        public IActionResult Kaldir([FromBody] Icerik.Icerikler model)
        {
            return Json(new { data = _genericService.Remove(model) });
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

            return Json(new { data = _genericService.Save(dbmodel) });
        }
        public IActionResult Tags()
        {

            return Json(new
            {
                data = _genericService.Queryable<Tags>().OrderBy(x => x.Icerik)
                    .ToList()
            });
        }
    }
}