
using Microsoft.AspNetCore.Mvc;
using NecCms.Database;
using NecCms.Database.Service;
using NecCms.Models;

namespace NecCms.Controllers
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
            return View(false);
        }

        public IActionResult Kaydet([FromBody]Iletisim model)
        {
            _genericService.Save(model);
            return Json(true);
        }

    }
}