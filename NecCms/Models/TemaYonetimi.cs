using System.Collections.Generic;
using System.Linq;
using NecCms.Database;
using NecCms.Database.Service;

namespace NecCms.Models
{
    public class TemaYonetimi
    {
        public static string Find(string kodu, string val = "")
        {

            string prefix = "";
#if DEBUG
            prefix = "https://necmettin.me";
#endif
            var genericService = new GenericService();

            var parametre = (from pd in genericService.Queryable<Tema.ParametreDegeri>()
                             join p in genericService.Queryable<Tema.Parametre>() on pd.ParametreId equals p
                                 .Id
                             where p.Kodu == kodu
                             join d in genericService.Queryable<Dosyalar>() on pd.DegerInt equals d.Id into
                                 dn
                             from d in dn.DefaultIfEmpty()
                             select new TemaDto
                             {
                                 Kodu = p.Kodu,
                                 Deger = d == null ? pd.Deger : $"{prefix}/images/{d.Adi}"
                             }).ToList();
            if (parametre.Count > 0)
            {
                return parametre.First().Deger;
            }
            else
            {
                var p = genericService.Save(new Tema.Parametre
                {
                    Kodu = kodu,
                    Aciklama = kodu,
                    Isim = kodu,
                    Sira = 1,
                    Tarih = System.DateTime.Now,
                    KullaniciId = 1,
                    Sil = false,
                    Tip = 1
                });

                var pd = genericService.Save(new Tema.ParametreDegeri
                {
                    ParametreId = p,
                    Deger = val,
                    Tarih = System.DateTime.Now,
                    KullaniciId = 1,
                    Sil = false,
                });

                return val;
            }
        }
    }
}