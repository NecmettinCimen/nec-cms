using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using NecCms.Database;
using NecCms.Database.Service;

namespace NecCms.Admin.Models
{
    public static class DosyaIslemleri
    {
        private static readonly string Dir = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images")
            .Replace("admin.aybarshukuk.com", "httpdocs");

        public static async Task<Dosyalar> Kaydet(IFormFile file, IGenericService genericService)
        {
            var resim = $"{DateTime.Now:yyyyMMddHHmmss.}{Path.GetFileName(file.FileName).Split(".").Last()}";
            var filePath = Path.Combine(Dir, resim).Replace("admin.", "");

            using (var fileStream = new FileStream(filePath, FileMode.Create))
            {
                await file.CopyToAsync(fileStream);
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
            await genericService.Save(dosya);
            return dosya;
        }

        public static void Delete(string olddosya)
        {
            try
            {
                var oldFile = Path.Combine(Dir, olddosya);
                File.Delete(oldFile);
            }
            catch (Exception)
            {
                // ignored
            }
        }
    }
}