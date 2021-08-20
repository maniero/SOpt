public class MvcApplication : System.Web.HttpApplication {
    public static void RegisterGlobalFilters(GlobalFilterCollection filters) {
        filters.Add(new CheckForDownPage());
    }
    //o resto do global asax
}
public sealed class CheckForDownPage : ActionFilterAttribute {
    public override void OnActionExecuting(ActionExecutingContext filterContext) {
        var path = System.Web.Hosting.HostingEnvironment.MapPath("~/Down.htm");
        if (System.IO.File.Exists(path) && IpAddress != "1.2.3.4") {
            filterContext.HttpContext.Response.Clear();
            filterContext.HttpContext.Response.Redirect("~/Down.htm");
            return;
        }
        base.OnActionExecuting(filterContext);
    }
}

routes.MapRoute("Offline", "{controller}/{action}/{id}",
    new {
        action = "Offline",
        controller = "Home",
        id = UrlParameter.Optional
        },
    new { constraint = new OfflineRouteConstraint() });

//https://pt.stackoverflow.com/q/363560/101
