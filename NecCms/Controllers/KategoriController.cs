using Microsoft.AspNetCore.Mvc;
using NecCms.Models;
using NecCms.Database;
using NecCms.Database.Service;
using System.Linq;
using System.Collections.Generic;
using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace NecCms.Controllers
{
    public class KategoriController : Controller
    {
        readonly IGenericService _genericService;
        private readonly IHostingEnvironment _hostingEnvironment;
        public KategoriController(IHostingEnvironment hostingEnvironment, IGenericService genericService)
        {
            _hostingEnvironment = hostingEnvironment;
            _genericService = genericService;
        }

        public IActionResult Index(string kategori, int skip)
        {
            if (kategori.Contains("."))
            {
                var path = Path.Combine(_hostingEnvironment.WebRootPath, kategori);
                var imageFileStream = System.IO.File.OpenRead(path);
                return File(imageFileStream, "image/vnd.microsoft.icon");
            }

            if (kategori.ToLower() == "iletisim")
                return View("~/Views/Iletisim/Index.cshtml");
            
            skip = skip == 0 ? 0 : skip - 1;
            KategoriDto model = IcerikYonetimi.FindByKategoriUrl(kategori, skip * 10, 10);
            
            model.SayfaNo=skip;

            return View(model);
        }
    }
}
