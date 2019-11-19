using System;
using System.IO;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using NecCms.Admin.Models;
using NecCms.Database;
using NecCms.Database.Service;

namespace NecCms.Admin.Controllers
{
    public class TemaController : Controller
    {
        readonly IGenericService _genericService;
        public TemaController(IGenericService genericService) => _genericService = genericService;
        public IActionResult Yonetim() => View("~/Views/Shared/_Crud.cshtml");
        public IActionResult Duzenle() => View();
        public IActionResult ParametreListesi(int? id) => Json(new { data = _genericService.IQueryable<Tema.Parametre>().Where(x => x.Id == id || !id.HasValue).ToList() });
        public IActionResult ParametreKaydet([FromBody]Tema.Parametre model) => Json(new { data = _genericService.Save(model) });
        public IActionResult ParametreKaldir([FromBody]Tema.Parametre model) => Json(new { data = _genericService.Remove(model) });
        public IActionResult ParametreDegerListesi(int? id) => Json(new
        {
            data = _genericService.IQueryable<Tema.Parametre>()
            .Where(x => x.Id == id || !id.HasValue)
            .Select(e => new
            {
                e.Id,
                e.Isim,
                e.Kodu,
                e.Aciklama,
                e.Tip,
                Parametre = !id.HasValue ? null : _genericService.IQueryable<Tema.ParametreDegeri>()
                    .Where(w => w.ParametreId == e.Id).Select(x => new
                    {
                        x.Id,
                        x.Deger,
                        x.DegerInt,
                        Dosya = _genericService.IQueryable<Dosyalar>().FirstOrDefault(f => f.Id == x.DegerInt)
                    }).FirstOrDefault()
            })
            .ToList()
        });
        public IActionResult ParametreDegeriKaydet(Tema.ParametreDegeri model)
        {

            var file = Request.Form.Files.Count > 0 ? Request.Form.Files.First() : null;

            if (file != null)
            {
                model.DegerInt = DosyaIslemleri.Kaydet(file, _genericService);
            }

            return Json(new { data = _genericService.Save(model) });
        }
    }
}