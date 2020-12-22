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
    public class IcerikTipleriController : Controller
    {
        private readonly IGenericService _genericService;

        public IcerikTipleriController(IGenericService genericService)
        {
            _genericService = genericService;
        }

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
                data = _genericService.Queryable<IcerikTipleri>().Where(x => !id.HasValue || x.Id == id).OrderByDescending(x => x.Id)
                    .ToList()
            });
        }
        [HttpPost("Liste")]
        public IActionResult Kaydet([FromBody] IcerikTipleri model)
        {
            
            _genericService.Save(model);
            return Json(new {data = model});
        }
        [HttpPost("Kaldir")]
        public IActionResult Kaldir([FromBody] IcerikTipleri model)
        {
            return Json(new {data = _genericService.Remove(model)});
        }
        
    }
}