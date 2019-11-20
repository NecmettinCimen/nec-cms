using Microsoft.AspNetCore.Mvc;
using NecCms.Models;
using NecCms.Database;
using NecCms.Database.Service;
using System.Linq;
using System.Collections.Generic;

namespace NecCms.Controllers
{
    public class KategoriController : Controller
    {
        readonly IGenericService _genericService;
        public KategoriController(IGenericService genericService) => _genericService = genericService;
        public IActionResult Index(string kategori)
        {
            KategoriDto model = IcerikYonetimi.FindByKategoriUrl(kategori, 0, 5);

            return View(model);
        }
        public IActionResult Skip(string kategori, int skip)
        {
            KategoriDto model = IcerikYonetimi.FindByKategoriUrl(kategori, skip, 5);

            return Json(model);
        }
    }
}
