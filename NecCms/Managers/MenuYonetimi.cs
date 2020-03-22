using System.Collections.Generic;
using System.Linq;
using NecCms.Database;
using NecCms.Database.Service;

namespace NecCms.Models
{
    public class MenuYonetimi
    {
        private static List<MenuDto> menuler;

        public static List<MenuDto> Menuler
        {
            get
            {
                var genericService = new GenericService();
                
                // if (menuler == null)
                if (true)
                    menuler = (from m in genericService.Queryable<Menu>()
                        where m.UstId == null
                        orderby m.Sira
                        select new MenuDto
                        {
                            Id = m.Id,
                            Isim = m.Isim,
                            Sira = m.Sira,
                            Url = m.Url,
                            Menuler = (from m2 in genericService.Queryable<Menu>()
                                where m2.UstId == m.Id
                                orderby m2.Sira
                                select new MenuDto
                                {
                                    Isim = m2.Isim,
                                    Sira = m2.Sira,
                                    Url = m2.Url
                                }).ToList()
                        }).ToList();
                return menuler;
            }
            set => menuler = value;
        }

    }
}