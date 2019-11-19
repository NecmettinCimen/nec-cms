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
            string resim = DateTime.Now.ToString("yyyyMMddHHmmss.") + Path.GetFileName(file.FileName).Split(".").Last();
            var filePath = Path.Combine(Directory.GetCurrentDirectory(), @"wwwroot\images", resim);
            using (FileStream fileStream = new FileStream(filePath, FileMode.Create))
            {
                file.CopyTo(fileStream);
            }
            Dosyalar dosya = new Dosyalar
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