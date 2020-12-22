using System.Linq;
using Microsoft.AspNetCore.Mvc;
using NecCms.Admin.Filters;
using NecCms.Database;
using NecCms.Database.Service;

namespace NecCms.Admin.Controllers
{
    [NecCmsAuthorize]
    [ApiController]
    [Route("api/v1/[controller]")]
    public class IletisimController : Controller
    {
        private readonly IGenericService _genericService;

        public IletisimController(IGenericService genericService)
        {
            _genericService = genericService;
        }

        [HttpGet("Index")]
        [ApiExplorerSettings(IgnoreApi = true)]
        public IActionResult Index()
        {
            return View("_Table");
        }

        [HttpGet("List")]
        public IActionResult List()
        {
            return Json(new
            {
                data = _genericService.Queryable<Iletisim>().Select(x => new
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