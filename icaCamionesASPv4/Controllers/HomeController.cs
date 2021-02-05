using icaCamionesASPv4.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Globalization;
using System.Web.Mvc;

namespace icaCamionesASPv4.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Despachos()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Notificaciones()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Ventas()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}