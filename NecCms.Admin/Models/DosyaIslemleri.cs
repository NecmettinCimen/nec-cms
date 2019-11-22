using System;
using System.IO;
using System.Linq;
using Microsoft.AspNetCore.Http;
using NecCms.Database;
using NecCms.Database.Service;

namespace NecCms.Admin.Models
{
    public class DosyaIslemleri
    {
        public static int Kaydet(IFormFile file, IGenericService _genericService)
        {
            var resim = string.Format("{0:yyyyMMddHHmmss.}{1}", DateTime.Now, Path.GetFileName(file.FileName).Split(".").Last());
            var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images", resim).Replace("admin.aybarshukuk.com","httpdocs");
            using (var fileStream = new FileStream(filePath, FileMode.Create))
            {
                file.CopyTo(fileStream);
            }

//            string data;
//            using (var memoryStream = new MemoryStream())
//            {
//                file.CopyTo(memoryStream);
//                data = Convert.ToBase64String(memoryStream.ToArray());
//            }

            var dosya = new Dosyalar
            {
                Adi = resim,
                Boyutu = file.Length,
                Tipi = file.ContentType,
                Yolu = filePath
            };
            _genericService.Save(dosya);
            return dosya.Id;
        }
    }
}