using System;
using System.IO;
using System.Linq;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using NecCms.Database.Service;
using NecCms.Database;
using NecCms.Models;

namespace NecCms.Controllers
{
    public class KategoriController : Controller
    {
        private readonly IHostingEnvironment _hostingEnvironment;
        public KategoriController(IHostingEnvironment hostingEnvironment, IGenericService genericService, CrmContext crmContext)
        {
            _hostingEnvironment = hostingEnvironment;
        }

        public IActionResult Index(string kategori, int skip)
        {
            if (kategori.ToLower() == "iletisim")
                return View("~/Views/Iletisim/Index.cshtml");

            skip = skip == 0 ? 0 : skip - 1;
            var model = IcerikYonetimi.FindByKategoriUrl(kategori, skip * 10, 10);

            model.SayfaNo = skip;

            return View(model);
        }
    }
}