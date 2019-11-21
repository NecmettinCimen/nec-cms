<<<<<<< HEAD
=======
using System;
>>>>>>> 7899e80702cea993dd3d3d649b173e1502ac6eb6
using Microsoft.AspNetCore.Mvc;
using NecCms.Database;
using NecCms.Models;

namespace NecCms.Controllers
{
    public class IletisimController : Controller
    {
<<<<<<< HEAD
        public IActionResult Index()
        {
            return View(false);
        }

        public IActionResult Kaydet(Iletisim model)
        {
            IcerikYonetimi.genericService.Save(model);
            return View("Index", true);
=======
        public IActionResult Index() => View(model:false);
        
        public IActionResult Kaydet(Iletisim model)
        {
            IcerikYonetimi.genericService.Save(model);
            return View("Index",true);
>>>>>>> 7899e80702cea993dd3d3d649b173e1502ac6eb6
        }
    }
}