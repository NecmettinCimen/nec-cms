using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using NecCms.Database;
using NecCms.Database.Service;

namespace NecCms.Admin.Controllers
{
    public class MenuController : Controller
    {
        private readonly IGenericService _genericService;

        public MenuController(IGenericService genericService)
        {
            _genericService = genericService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Liste(int? id)
        {
            return Json(new
            {
                data = _genericService.Queryable<Menu>().Where(x => !id.HasValue || x.Id == id).OrderBy(x => x.Sira)
                    .ToList()
            });
        }

        public IActionResult Kaydet([FromBody] Menu model)
        {
            _genericService.Save(model);
            return Json(new {data = model});
        }

        public IActionResult SiralamaKaydet([FromBody] List<Menu> model)
        {
            foreach (var item in model)
            {
                var temp = _genericService.Queryable<Menu>().First(x => x.Id == item.Id);
                temp.Sira = item.Sira;
                temp.UstId = item.UstId;
                _genericService.Save(temp);
            }
            return Json(new {data = true});
        }
        
        public IActionResult Kaldir([FromBody] Menu model)
        {
            return Json(new {data = _genericService.Remove(model)});
        }
    }
}