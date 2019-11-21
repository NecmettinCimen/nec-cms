using System.Linq;
using Microsoft.AspNetCore.Mvc;
using NecCms.Database;
using NecCms.Database.Service;

namespace NecCms.Admin.Controllers
{
    public class IletisimController : Controller
    {
        private readonly IGenericService _genericService;

        public IletisimController(IGenericService genericService)
        {
            _genericService = genericService;
        }

        public IActionResult Index()
        {
            return View("_Table");
        }

        public IActionResult List()
        {
            return Json(new
            {
                data = _genericService.IQueryable<Iletisim>().Select(x => new
                {
                    x.Id,
                    x.Konu,
                    x.AdSoyad,
                    x.Eposta,
                    x.Aciklama,
                    x.Tarih
                }).OrderByDescending(x => x.Id).ToList()
            });
        }
    }
}