using Microsoft.AspNetCore.Mvc;
using NecCms.Database.Service;
using NecCms.Models;

namespace NecCms.Controllers
{
    public class IcerikController : Controller
    {
        public IActionResult Index(string kategori, string icerik)
        {
            var model = IcerikYonetimi.Find(kategori, icerik);

            return View(model);
        }
    }
}