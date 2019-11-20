using Microsoft.AspNetCore.Mvc;
using NecCms.Models;
using NecCms.Database;
using NecCms.Database.Service;
using System.Linq;
using System.Collections.Generic;

namespace NecCms.Controllers
{
    public class IcerikController : Controller
    {
        readonly IGenericService _genericService;
        public IcerikController(IGenericService genericService) => _genericService = genericService;
        public IActionResult Index(string kategori, string icerik)
        {
            IcerikDto model = IcerikYonetimi.Find(kategori, icerik);

            return View(model);
        }
    }
}
