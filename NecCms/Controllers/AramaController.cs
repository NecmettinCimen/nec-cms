using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using NecCms.Database.Service;
using NecCms.Models;

namespace NecCms.Controllers
{
    public class AramaController : Controller
    {
        public IActionResult Index(string arama,int skip)
        {
            skip = skip == 0 ? 0 : skip - 1;
            List<IcerikDto> model = IcerikYonetimi.Arama(arama, skip);

            return View(model:new KategoriDto(){Icerikler = model });
        }
    }
}