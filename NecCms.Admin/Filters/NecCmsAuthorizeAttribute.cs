using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Routing;
using NecCms.Admin.Models;
using NecCms.Database;

namespace NecCms.Admin.Filters
{
    public class NecCmsAuthorizeAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            if (filterContext.HttpContext.Session.Get<int>("UserId") == 0)
                filterContext.Result = new RedirectToRouteResult(
                    new RouteValueDictionary
                    {
                        {"action", "Index"},
                        {"controller", "Login"}
                    });
        }

        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            // var user = filterContext.HttpContext.Session.Get<User>("User");
        }
    }
    
    public class AdminAuthorizeAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            if (filterContext.HttpContext.Session.Get<RolEnum>("Rol") != RolEnum.Admin)
                filterContext.Result = new RedirectToRouteResult(
                    new RouteValueDictionary
                    {
                        {"action", "Index"},
                        {"controller", "Home"}
                    });
        }

        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            // var user = filterContext.HttpContext.Session.Get<User>("User");
        }
    }
}