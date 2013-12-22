using MvcApplication1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication1.Controllers
{
    public class UserController : Controller
    {
        //
        // GET: /User/

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Music()
        {
            UserModel model = new UserModel();
            ViewBag.Numb = model.GetGameNames().Count ;
            return View();
            
        }
    }
}
