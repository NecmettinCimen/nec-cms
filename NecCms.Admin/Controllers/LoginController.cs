using System.Linq;
using Microsoft.AspNetCore.Mvc;
using NecCms.Admin.Models;
using NecCms.Database;
using NecCms.Database.Service;

namespace NecCms.Admin.Controllers
{
    public class LoginController : Controller
    {
        private readonly IGenericService _genericService;

        public LoginController(IGenericService genericService)
        {
            _genericService = genericService;
        }
        public IActionResult Index()
        {
            return View(false);
        }

        public IActionResult Kontrol([FromForm]Kullanici model)
        {
            if (_genericService.Queryable<Kullanici>()
                    .Count(w => w.Eposta == model.Eposta && w.Parola == model.Parola) > 0)
            {
                var dbmodel = _genericService.Queryable<Kullanici>()
                    .First(w => w.Eposta == model.Eposta && w.Parola == model.Parola);
                HttpContext.Session.Set<int>("UserId",dbmodel.Id);
                HttpContext.Session.Set<RolEnum>("Rol",dbmodel.Rol);
                HttpContext.Session.Set<string>("AdSoyad",dbmodel.AdSoyad);
                return Redirect("/");
            }
            else
            {
                return View("Index", model: true);
            }
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return Redirect("/Login");
        }
    }
}