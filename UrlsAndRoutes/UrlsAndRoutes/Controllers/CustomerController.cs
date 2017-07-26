using System.Web.Mvc;

namespace UrlsAndRoutes.Controllers
{
    public class CustomerController : Controller
    {
         //GET: Customer
        [Route("Test")]
        public ActionResult Index()
        {
            ViewBag.Controller = "Customer";
            ViewBag.Action = "Index";
            return View("ActionName");
        }
        [Route("Users/Add/{user}/{id}")]
        public string Create(string user, int id)
        {
            return string.Format("User:{0},ID: {1}", user, id);
        }
        public ActionResult List(string id)
        {
            ViewBag.Controller = "Customer";
            ViewBag.Action = "List";
            ViewBag.CustomVariable = id;
            return View("ActionName");
        }

    }
}