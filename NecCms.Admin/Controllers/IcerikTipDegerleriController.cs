using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NecCms.Admin.Models;
using NecCms.Database;
using NecCms.Database.Service;

namespace NecCms.Admin.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class IcerikTipDegerleriController : Controller
    {
        private readonly IGenericService _genericService;

        public IcerikTipDegerleriController(IGenericService genericService)
        {
            _genericService = genericService;
        }

        [HttpGet("Index")]
        [ApiExplorerSettings(IgnoreApi = true)]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("Liste")]
        [ApiExplorerSettings(IgnoreApi = true)]
        public IActionResult Liste(int? id)
        {
            return Json(new
            {
                data = (from itd in _genericService.Queryable<IcerikTipDegerleri>()
                        .Where(x => !id.HasValue || x.Id == id)
                        join it in _genericService.Queryable<IcerikTipleri>() on itd.IcerikTipiId equals it.Id
                        select new
                        {
                            itd.Id,
                            itd.Alan,
                            itd.Deger,
                            itd.DegerInt,
                            itd.IcerikTipiId,
                            it.Isim,
                            it.Alanlar
                        })
                        .OrderByDescending(x => x.Id)
                    .ToList()
            });
        }

        [HttpGet("Bul")]
        public IActionResult Bul(int id)
        {
            var icerikTipDegeri = _genericService.Queryable<IcerikTipDegerleri>().First(x => x.Id == id);
            return Json(new
            {
                iceriktip = _genericService.Queryable<IcerikTipleri>().First(x => x.Id == icerikTipDegeri.IcerikTipiId),
                icerikTipDegeri = _genericService.Queryable<IcerikTipDegerleri>().Where(x => x.Sira == icerikTipDegeri.Sira).ToList()
            });
        }
        [HttpPost("Bul")]
        public async Task<IActionResult> Kaydet(IcerikTipDegerleri[] model)
        {
            var file = Request.Form.Files.Count > 0 ? Request.Form.Files.First() : null;
            var sira = 1;
            if (await _genericService.Queryable<IcerikTipDegerleri>().CountAsync() > 0)
                sira += await _genericService.Queryable<IcerikTipDegerleri>().Select(x => x.Sira).LastAsync();
            foreach (var item in model)
            {
                if (item.Id != 0)
                {
                    var dbmodel = await _genericService.Queryable<IcerikTipDegerleri>().FirstAsync(f => f.Id == item.Id);
                    if (dbmodel.DegerInt != 0)
                    {
                        if (file != null)
                        {
                            var dbdosya =await _genericService.Queryable<Dosyalar>().FirstAsync(f => f.Id == dbmodel.DegerInt);
                            DosyaIslemleri.Delete(dbdosya.Adi);
                            var dosya = await DosyaIslemleri.Kaydet(file, _genericService);
                            item.DegerInt = dosya.Id;
                            item.Deger = dosya.Adi;
                        }
                        else
                        {
                            item.Deger = dbmodel.Deger;
                            item.DegerInt = dbmodel.DegerInt;
                        }
                    }
                }
                else
                {
                    if (file != null && item.Deger == null)
                    {
                        var dosya =await DosyaIslemleri.Kaydet(file, _genericService);
                        item.DegerInt = dosya.Id;
                        item.Deger = dosya.Adi;
                    }

                    item.Sira = sira;
                }


                await _genericService.Save(item);

            }
            return Json(new { data = true });
        }
        [HttpPost("Kaldir")]
        public IActionResult Kaldir([FromBody] IcerikTipDegerleri model)
        {
            var list = _genericService.Queryable<IcerikTipDegerleri>().Where(x => x.Sira == model.Sira).ToList();
            foreach (var item in list)
            {
                _genericService.Remove(item);
            }
            return Json(new { data = true });
        }
    }
}