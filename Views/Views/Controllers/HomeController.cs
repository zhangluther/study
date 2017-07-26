using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Views.Models;

namespace Views.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            Person person = new Person
            {
                Surname = "Wei",
                FirstName = "Zhang",
                Patronymic = "China",
                BirthDate = new DateTime(1988, 6, 15)
            };
            return View(person);
        }

        public ActionResult List()
        {
            return View();
        }
    }
}