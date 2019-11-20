using System.Linq;
using Microsoft.AspNetCore.Mvc;
using NecCms.Database;
using NecCms.Database.Service;

namespace NecCms.Admin.Controllers
{
    public class MenuController : Controller
    {
        readonly IGenericService _genericService;

        public MenuController(IGenericService genericService) => _genericService = genericService;

        public IActionResult Index() => View();

        public IActionResult Liste(int? id) => Json(new { data = _genericService.IQueryable<Menu>().Where(x => !id.HasValue || x.Id == id).OrderBy(x=>x.Sira).ToList() });

        public IActionResult Kaydet([FromBody]Menu model) { _genericService.Save<Menu>(model); return Json(new { data = model });}

        public IActionResult Kaldir([FromBody]Menu model) => Json(new { data = _genericService.Remove<Menu>(model) });
    }
}