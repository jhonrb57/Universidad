using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Universidad.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Inicio()
        {
            return View();
        }

        public ActionResult IndexAdministrador()
        {
            return View();
        }

        public ActionResult IndexEstudiante()
        {
            return View();
        }
    }
}