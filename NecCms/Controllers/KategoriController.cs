using System.IO;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using NecCms.Database.Service;
using NecCms.Models;

namespace NecCms.Controllers
{
    public class KategoriController : Controller
    {
        private readonly IGenericService _genericService;
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
            var model = IcerikYonetimi.FindByKategoriUrl(kategori, skip * 10, 10);

            model.SayfaNo = skip;

            return View(model);
        }
    }
}