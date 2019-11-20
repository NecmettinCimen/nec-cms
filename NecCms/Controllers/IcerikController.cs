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
            List<IcerikDto> icerikler = IcerikYonetimi.Find(kategori, icerik);

            if (icerikler.Count == 0)
            {
                return Redirect("/");
            }
            else if (icerikler.Count == 1)
            {
                return View(icerikler.First());
            }
            else
            {
                return View(icerikler);
            }
        }
    }
}
