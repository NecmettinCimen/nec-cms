using System.Collections.Generic;
using NecCms.Database;
using System.Linq;

namespace NecCms.Models
{
    public class MenuYonetimi
    {
        public static void Fill()
        {
            menuler = (from m in IcerikYonetimi.genericService.IQueryable<Menu>()
                       where m.UstId == null
                       orderby m.Sira
                       select new MenuDto
                       {
                           Id = m.Id,
                           Isim = m.Isim,
                           Sira = m.Sira,
                           Url = m.Url,
                           Menuler = (from m2 in IcerikYonetimi.genericService.IQueryable<Menu>()
                                      where m2.UstId == m.Id
                                      orderby m2.Sira
                                      select new MenuDto
                                      {
                                          Isim = m2.Isim,
                                          Sira = m2.Sira,
                                          Url = m2.Url,
                                      }).ToList()
                       }).ToList();
        }

        static private List<MenuDto> menuler;
        static public List<MenuDto> Menuler
        {
            get
            {
                // if (menuler == null)
                if (true)
                {
                    menuler = (from m in IcerikYonetimi.genericService.IQueryable<Menu>()
                               where m.UstId == null
                               orderby m.Sira
                               select new MenuDto
                               {
                                   Id = m.Id,
                                   Isim = m.Isim,
                                   Sira = m.Sira,
                                   Url = m.Url,
                                   Menuler = (from m2 in IcerikYonetimi.genericService.IQueryable<Menu>()
                                              where m2.UstId == m.Id
                                              orderby m2.Sira
                                              select new MenuDto
                                              {
                                                  Isim = m2.Isim,
                                                  Sira = m2.Sira,
                                                  Url = m2.Url,
                                              }).ToList()
                               }).ToList();
                }
                return menuler;
            }
            set { menuler = value; }
        }

    }
}