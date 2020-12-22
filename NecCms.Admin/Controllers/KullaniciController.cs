using System.Linq;
using Microsoft.AspNetCore.Mvc;
using NecCms.Admin.Filters;
using NecCms.Database;
using NecCms.Database.Service;

namespace NecCms.Admin.Controllers
{
    [NecCmsAuthorize]
    [AdminAuthorize]
    [ApiController]
    [Route("api/v1/[controller]")]
    public class KullaniciController : Controller
    {
        private readonly IGenericService _genericService;

        public KullaniciController(IGenericService genericService)
        {
            _genericService = genericService;
        }
        // GET
        [HttpGet("Index")]
        [ApiExplorerSettings(IgnoreApi = true)]
        public IActionResult Index()
        {
            return View("_Crud");
        }
        
        [HttpGet("Liste")]
        public IActionResult Liste(int? id)
        {
            return Json(new
            {
                data = _genericService.Queryable<Kullanici>().Where(x => !id.HasValue || x.Id == id).OrderByDescending(x => x.Id)
                    .ToList()
            });
        }

        [HttpPost("Liste")]
        public IActionResult Kaydet([FromBody] Kullanici model)
        {
            _genericService.Save(model);
            return Json(new {data = model});
        }
        [HttpPost("Kaldir")]
        public IActionResult Kaldir([FromBody] Kullanici model)
        {
            return Json(new {data = _genericService.Remove(model)});
        }
    }
}