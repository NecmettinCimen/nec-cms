using System;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using NecCms.Database.Service;
using NecCms.Database;
using NecCms.Models;
using Microsoft.AspNetCore.StaticFiles;

namespace NecCms.Controllers
{
    public class KategoriController : Controller
    {
        IHostingEnvironment env;
        public KategoriController(IHostingEnvironment _env)
        {
            env = _env;
        }
        public IActionResult Index(string kategori, int skip)
        {
            if (kategori.Contains("."))
            {
                var path = Path.Combine(env.WebRootPath, kategori);
                FileInfo fileInfo = new FileInfo(path);
                var provider = new FileExtensionContentTypeProvider();
                if (!provider.TryGetContentType(fileInfo.Name, out string contentType))
                {
                    contentType = "application/octet-stream";
                }

                return File(path, contentType);
            }

            if (kategori.ToLower() == "iletisim")
                return View("~/Views/Iletisim/Index.cshtml");

            skip = skip == 0 ? 0 : skip - 1;
            var model = IcerikYonetimi.FindByKategoriUrl(kategori, skip * 10, 10);

            model.SayfaNo = skip;

            switch (model.Tip)
            {
                case MenuTip.TekSayfa when model.Icerikler.Count == 0:
                    return Redirect("/");
                case MenuTip.TekSayfa:
                    {
                        var kategoriicerik = model.Icerikler.First();
                        var icerik = IcerikYonetimi.Find(kategori, kategoriicerik.Url);
                        return View("~/Views/Icerik/Index.cshtml", icerik);
                    }
                case MenuTip.MenuListesi when model.Icerikler.Count == 0:
                    return Redirect("/");
                case MenuTip.MenuListesi:
                    {
                        return View("~/Views/Kategori/MenuListesi.cshtml", model);
                    }
            }
            return View(model);
        }
    }
}