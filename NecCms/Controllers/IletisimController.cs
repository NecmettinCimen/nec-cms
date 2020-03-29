
using System;
using Microsoft.AspNetCore.Mvc;
using NecCms.Database;
using NecCms.Database.Service;
using NecCms.Models;

namespace NecCms.Controllers
{
    public class IletisimController : Controller
    {
        private readonly IGenericService _genericService;

        public IletisimController(IGenericService genericService)
        {
            _genericService = genericService;
        }
        public IActionResult Index()
        {
            return View(false);
        }

        [HttpPost]
        public IActionResult Index(Iletisim model)
        {
            try
            {
                var result = _genericService.Save(model);
                return View(true);
            }
            catch (Exception ex)
            {
                return View(false);
            }
        }

    }
}