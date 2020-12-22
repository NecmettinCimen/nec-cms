using System;
using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using NecCms.Admin.Models;
using NecCms.Database;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using NecCms.Admin.Filters;

namespace NecCms.Admin.Controllers
{
    [NecCmsAuthorize]
    public class HomeController : Controller
    {
        private readonly CrmContext _crmContext;

        public HomeController(CrmContext crmContext)
        {
            _crmContext = crmContext;
        }

        public IActionResult Index()
        {
#if DEBUG

            HttpContext.Session.Set<int>("UserId", 1);
            HttpContext.Session.Set<RolEnum>("Rol", RolEnum.Admin);
            HttpContext.Session.Set<string>("AdSoyad", "DEBUG");
#endif
            return View();
        }

        private static string DateSql(string sql, DateTime baslangic, DateTime bitis) => $@"set language  turkish;
                        DECLARE @i date = '{baslangic.ToString("yyyy-MM-dd")}';
                        DECLARE @length date = '{bitis.ToString("yyyy-MM-dd")}';

                        CREATE TABLE #Temporary(y varchar(100),a int,b int);

                        WHILE 0<datediff(day,@i,@length) 
                            BEGIN
                                insert into #Temporary values (convert(varchar,@i,104),0,0);
                                update #Temporary set a=l.a , b=l.b from 
                                ({sql}) l where #Temporary.y =  l.y;
                                SET @i = dateadd(day,1,@i);
                            END;
                            
                            select * from #Temporary;
                        drop table  #Temporary;";

        private List<IstekKullaniciSayisiDto> GetSql(string sql)
        {
            var result = _crmContext.IstekKullaniciSayisi.FromSql(sql).ToList();

            return result;
        }

        public IActionResult IstekKullaniciSayisi(DateTime baslangic, DateTime bitis)
        {
            var result = GetSql(DateSql(
                $@"select convert(varchar,Tarih,104) y, count(*) a, count(distinct RemoteIpAddress) b from Loggers
                                where datepart(dayofyear ,Tarih) = datepart(dayofyear,@i)
                                group by convert(varchar,Tarih,104)", baslangic, bitis));

            return Json(result);
        }

        public IActionResult ToplamIcerikIletisimSayisi(DateTime baslangic, DateTime bitis)
        {
            var result = GetSql(DateSql(
                $@"select convert(varchar,i.Tarih,104) y, count(distinct i.Id) a,count(distinct i2.Id) b from Icerikler i
                        left join Iletisim i2 on convert(varchar,i.Tarih,104) = convert(varchar,i2.Tarih,104)
                        where i.Sil=0 and i2.Sil=0 and datepart(dayofyear ,i.Tarih) = datepart(dayofyear,@i)
                        group by convert(varchar,i.Tarih,104)", baslangic, bitis));

            return Json(result);
        }

        public IActionResult MenuSayilari(DateTime baslangic, DateTime bitis)
        {
            var result = GetSql(
                $@"select 'Anasayfa' y, (select count(*) from Loggers where Path='/') a,0 b
                union select  m.Isim y, count(*) a, 0 b from Menu m
                join Loggers L on L.Path like '%'+m.Url+'%'
                where L.Tarih > '{baslangic.ToString("yyyy-MM-dd")}' and L.Tarih< '{bitis.ToString("yyyy-MM-dd")}'
                group by m.Isim order by a desc").ToList();

            return Json(result);
        }

        public IActionResult Istekler(DateTime baslangic, DateTime bitis, int take)
        {
            var result = _crmContext.Set<CustomLogger>().Where(w => w.Tarih > baslangic && w.Tarih < bitis)
                .OrderByDescending(o => o.Id).Take(take).ToList();

            return Json(result);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            var model = new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier};
            return View(model);
        }
    }
}