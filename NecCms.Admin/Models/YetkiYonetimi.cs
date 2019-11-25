using System;
using Microsoft.AspNetCore.Hosting.Internal;
using Microsoft.AspNetCore.Http;
using NecCms.Database;

namespace NecCms.Admin.Models
{
    public static class AppHttpContext {
        static IServiceProvider services = null;

        /// <summary>
        /// Provides static access to the framework's services provider
        /// </summary>
        public static IServiceProvider Services {
            get { return services; }
            set {
                if(services != null) {
                    throw new Exception("Can't set once a value has already been set.");
                }
                services = value;
            }
        }

        /// <summary>
        /// Provides static access to the current HttpContext
        /// </summary>
        public static HttpContext Current {
            get {
                var httpContextAccessor = services.GetService(typeof(IHttpContextAccessor)) as IHttpContextAccessor;
                return httpContextAccessor?.HttpContext;
            }
        } 

    }
    
    public class YetkiYonetimi
    {
        public static RolEnum GetRol() => AppHttpContext.Current.Session.Get<RolEnum>("Rol");
        public static string GetAdSoyad() => AppHttpContext.Current.Session.Get<string>("AdSoyad");
    }
}