using System.Collections.Generic;
using System.Linq;
using NecCms.Database;
using NecCms.Database.Service;

namespace NecCms.Models
{
    public class TemaYonetimi
    {
        public static string Find(string kodu)
        {
            
            string prefix = "";
#if DEBUG
            prefix = "https://aybarshukuk.com";
#endif
            var genericService = new GenericService();

            var parametre = (from pd in genericService.Queryable<Tema.ParametreDegeri>()
                join p in genericService.Queryable<Tema.Parametre>() on pd.ParametreId equals p
                    .Id
                where p.Kodu==kodu
                join d in genericService.Queryable<Dosyalar>() on pd.DegerInt equals d.Id into
                    dn
                from d in dn.DefaultIfEmpty()
                select new TemaDto
                {
                    Kodu = p.Kodu,
                    Deger = d == null ? pd.Deger : $"{prefix}/images/{d.Adi}"
                }).ToList();
            return parametre.Count > 0 ? parametre.First().Deger : "";
        }
    }
}