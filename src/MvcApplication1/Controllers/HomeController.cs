using MvcApplication1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication1.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Game()
        {
            List<string> testNames = new List<string>();
            testNames.Add("Mario");
            testNames.Add("Mario1");

            UserModel model = new UserModel();
            testNames = model.GetGameNames();
            return View(testNames);

        }
    }
}
