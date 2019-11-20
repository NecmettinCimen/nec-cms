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
            List<Menu> dbkategori = IcerikYonetimi.genericService.IQueryable<Menu>().Where(x => x.Url.ToLower().Contains(kategori.ToLower())).ToList();
            if (dbkategori.Count == 0)
                return Redirect("/");

            List<IcerikDto> icerikler = IcerikYonetimi.Find(kategori);
            return View(new KategoriDto
            {
                Id = dbkategori.First().Id,
                Isim = dbkategori.First().Isim,
                Icerikler = icerikler
            });
        }
    }
}
