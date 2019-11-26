using System.Linq;
using Microsoft.AspNetCore.Mvc;
using NecCms.Admin.Filters;
using NecCms.Database;
using NecCms.Database.Service;

namespace NecCms.Admin.Controllers
{
    [NecCmsAuthorize]
    [AdminAuthorize]
    public class IcerikTipleriController : Controller
    {
        private readonly IGenericService _genericService;

        public IcerikTipleriController(IGenericService genericService)
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
                data = _genericService.Queryable<IcerikTipleri>().Where(x => !id.HasValue || x.Id == id).OrderByDescending(x => x.Id)
                    .ToList()
            });
        }

        public IActionResult Kaydet([FromBody] IcerikTipleri model)
        {
            
            _genericService.Save(model);
            return Json(new {data = model});
        }

        public IActionResult Kaldir([FromBody] IcerikTipleri model)
        {
            return Json(new {data = _genericService.Remove(model)});
        }
        
    }
}