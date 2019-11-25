using System.Linq;
using Microsoft.AspNetCore.Mvc;
using NecCms.Admin.Filters;
using NecCms.Database;
using NecCms.Database.Service;

namespace NecCms.Admin.Controllers
{
    [NecCmsAuthorize]
    [AdminAuthorize]
    public class KullaniciController : Controller
    {
        private readonly IGenericService _genericService;

        public KullaniciController(IGenericService genericService)
        {
            _genericService = genericService;
        }
        // GET
        public IActionResult Index()
        {
            return View("_Crud");
        }
        
        public IActionResult Liste(int? id)
        {
            return Json(new
            {
                data = _genericService.Queryable<Kullanici>().Where(x => !id.HasValue || x.Id == id).OrderByDescending(x => x.Id)
                    .ToList()
            });
        }

        public IActionResult Kaydet([FromBody] Kullanici model)
        {
            _genericService.Save(model);
            return Json(new {data = model});
        }

        public IActionResult Kaldir([FromBody] Kullanici model)
        {
            return Json(new {data = _genericService.Remove(model)});
        }
    }
}