using System.Collections.Generic;
using NecCms.Database;
using NecCms.Database.Service;
using System.Linq;

namespace NecCms.Models
{
    public class TemaYonetimi
    {
        static List<TemaDto> nesne { get; set; }

        public static List<TemaDto> Nesne()
        {
            // if (nesne == null)
            if (true)
            {

                using (CrmContext db = new CrmContext())
                {
                    nesne = (from pd in IcerikYonetimi.genericService.IQueryable<Tema.ParametreDegeri>()
                             join p in IcerikYonetimi.genericService.IQueryable<Tema.Parametre>() on pd.ParametreId equals p.Id
                             join d in IcerikYonetimi.genericService.IQueryable<Dosyalar>() on pd.DegerInt equals d.Id into dn
                             from d in dn.DefaultIfEmpty()
                             select new TemaDto
                             {
                                 Kodu = p.Kodu,
                                 Deger = d == null ? pd.Deger : "data:"+d.Tipi+";base64,"+ d.Data
                             }).ToList();
                }
            }

            return nesne;
        }
        public static string Find(string kodu)
        {
            List<TemaDto> parametre = nesne.Where(x => x.Kodu == kodu).ToList();
            if (parametre.Count>0)
                return parametre.First().Deger;
            else
                return "";

        }

    }

}