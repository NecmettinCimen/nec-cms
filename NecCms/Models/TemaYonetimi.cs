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
            var genericService = new GenericService();

            var parametre = (from pd in genericService.Queryable<Tema.ParametreDegeri>()
                join p in genericService.Queryable<Tema.Parametre>() on pd.ParametreId equals p
                    .Id
                where p.Kodu==kodu
                select new TemaDto
                {
                    Kodu = p.Kodu,
                    Deger = pd.Deger
                }).ToList();
            return parametre.Count > 0 ? parametre.First().Deger : "";
        }
    }
}