using System;
using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using NecCms.Admin.Models;
using NecCms.Database;
using  System.Linq;
using Microsoft.EntityFrameworkCore;

namespace NecCms.Admin.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        private string DateSql(string sql, DateTime baslangic, DateTime bitis) => $@"set language  turkish;
                        DECLARE @i date = '{baslangic.ToString("yyyy-MM-dd")}';
                        DECLARE @length date = '{bitis.ToString("yyyy-MM-dd")}';

                        CREATE TABLE #Temporary(y varchar(100),a int,b int);

                        WHILE 0<datediff(day,@i,@length) 
                            BEGIN
                                insert into #Temporary values (format(@i,'dd MMMM yyyy dddd'),0,0);
                                update #Temporary set a=l.a , b=l.b from 
                                ({sql}) l where #Temporary.y =  l.y;
                                SET @i = dateadd(day,1,@i);
                            END;
                            
                            select * from #Temporary;
                        drop table  #Temporary;";

        private static List<IstekKullaniciSayisiDto> GetSql(string sql)
        {
            List<IstekKullaniciSayisiDto> result;
            using (var db = new CrmContext())
            {
                result =db.IstekKullaniciSayisi.FromSql(sql).ToList();
            }

            return result;
        }
        
        public IActionResult IstekKullaniciSayisi(DateTime baslangic, DateTime bitis)
        {
            var result = GetSql(DateSql(
                $@"select format(Tarih,'dd MMMM yyyy dddd') y, count(*) a, count(distinct RemoteIpAddress) b from Loggers
                                where datepart(dayofyear ,Tarih) = datepart(dayofyear,@i)
                                group by format(Tarih,'dd MMMM yyyy dddd')", baslangic,bitis));

            return Json(result);
        }
        public IActionResult ToplamIcerikIletisimSayisi(DateTime baslangic, DateTime bitis)
        {
            var result = GetSql(DateSql(
                $@"select format(i.Tarih,'dd') y, count(distinct i.Id) a,count(distinct i2.Id) b from Icerikler i
                        left join Iletisim i2 on format(i.Tarih,'yyyyMMdd') = format(i2.Tarih,'yyyyMMdd')
                        where i.Sil=0 and i2.Sil=0 and datepart(dayofyear ,i.Tarih) = datepart(dayofyear,@i)
                        group by format(i.Tarih,'dd')",baslangic,bitis));

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

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            var model = new ErrorViewModel();
            model.RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier;
            return View(model);
        }
    }
}