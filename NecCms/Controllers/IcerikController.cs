using Microsoft.AspNetCore.Mvc;
using NecCms.Database.Service;
using NecCms.Models;

namespace NecCms.Controllers
{
    public class IcerikController : Controller
    {
        private readonly IGenericService _genericService;

        public IcerikController(IGenericService genericService)
        {
            _genericService = genericService;
        }

        public IActionResult Index(string kategori, string icerik)
        {
            var model = IcerikYonetimi.Find(kategori, icerik);

            return View(model);
        }
    }
}