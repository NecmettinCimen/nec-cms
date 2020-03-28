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
                            Url = m.Url
                        }).ToList();
                return menuler;
            }
            set => menuler = value;
        }

    }
}