using System.Web.Mvc;

namespace UrlsAndRoutes.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Controller = "Home";
            ViewBag.Action = "Index";
            return View("ActionName");
        }

        public ActionResult CustomVariable(string id)
        {
            ViewBag.Controller = RouteData.Values["controller"];
            ViewBag.Action = RouteData.Values["action"];
            ViewBag.CustomVariable = id ?? "NA";
            return View("ActionName");
        }
    }
}