using Microsoft.AspNetCore.Mvc;
using NecCms.Database;
using NecCms.Models;

namespace NecCms.Controllers
{
    public class IletisimController : Controller
    {
        public IActionResult Index()
        {
            return View(false);
        }

        public IActionResult Kaydet(Iletisim model)
        {
            IcerikYonetimi.genericService.Save(model);
            return View("Index", true);
        }
    }
}