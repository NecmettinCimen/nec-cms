using System.Collections.Generic;
using System.Linq;
using NecCms.Database;
using NecCms.Database.Service;

namespace NecCms.Models
{
    public static class IcerikTipiYonetimi
    {
        public static string DosyaPrefix
        {
            get
            {
                var prefix = "http://market.admin.necmettincimen.com";
#if DEBUG
                prefix = "https://localhost:5001";
#endif
                return $"{prefix}/images";
            }
        }

        public static List<string[]> Bul(string kod)
        {
            var genericService = new GenericService();
            var icerikTip = genericService.Queryable<IcerikTipleri>().First(f => f.Kodu == kod);
            var icerikTipDegerleri
                = genericService.Queryable<IcerikTipDegerleri>().Where(w => w.IcerikTipiId == icerikTip.Id).ToList();
            var sira = icerikTipDegerleri.Select(x => x.Sira).Distinct();
            return sira.Select(s => icerikTipDegerleri.Where(w => w.Sira == s).Select(x => x.Deger).ToArray()).ToList();
        }
    }
}