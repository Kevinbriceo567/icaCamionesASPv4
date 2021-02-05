using System;
using System.Globalization;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using System.Web.Security;
using System.Data;
using icaCamionesASPv4.Models;

namespace icaCamionesASPv4.Controllers
{
    public class AccountController : Controller
    {
        Database.db db = new Database.db(); // CLASE DE LA BASE DE DATOS (ALMACENA LOS MÉTODOS QUE LLAMAN A LOS PROCEDIMIENTOS ALMACENADOS)

        public ActionResult Perfil()
        {
            DateTime hoy = DateTime.Now;
            string hoyS = hoy.Year.ToString() + "-" + hoy.Month.ToString() + "-" + hoy.Day.ToString();
            string mesYear = hoy.Month.ToString() + "/" + hoy.Year.ToString();

            DateTime FEC_FIN = DateTime.Parse(hoyS);
            ViewBag.mostrar = true;

            return View();
        }

        // GET: AccountNew
        public ActionResult Login()
        {
            DateTime hoy = DateTime.Now;
            string hoyS = hoy.Year.ToString() + "-" + hoy.Month.ToString() + "-" + hoy.Day.ToString();
            string mesYear = hoy.Month.ToString() + "/" + hoy.Year.ToString();

            DateTime FEC_FIN = DateTime.Parse(hoyS);
            ViewBag.mostrar = true;

            ViewBag.anno = hoy.Year.ToString();

            return View();
        }

        [HttpPost]
        public ActionResult Login(Models.Membership model)
        {
            using (var context = new DESACDCEntities())
            {
                bool isValid = context.tb_Usuarios.Any(x => x.NIC_USU == model.NIC_USU && x.PWD_USU == model.PWD_USU);
                if (isValid)
                {
                    FormsAuthentication.SetAuthCookie(model.NIC_USU, false);
                    //Session["Login"] = model.NIC_USU.ToString();
                    return RedirectToAction("Index", "Home");
                }
                ModelState.AddModelError("", "Invalid username or password");
                return View();
            }
        }


        public ActionResult Signup()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Signup(tb_Usuarios model)
        {
            using (var context = new DESACDCEntities())
            {
                context.tb_Usuarios.Add(model);
                context.SaveChanges();
            }
            return RedirectToAction("Login");
        }


        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login");
        }

        public ActionResult ManageAccount()
        {
            string username = User.Identity.Name;

            DataSet ds = db.All_Usuario(); // OBTENEMOS LOS DATOS DE LA CONSULTA
            ViewBag.usuarios = ds.Tables[0]; // ALMACENAMOS LA TABLA

            foreach (System.Data.DataRow dr in ViewBag.usuarios.Rows)
            {
                if (dr["NIC_USU"].ToString() == username)
                {
                    ViewBag.cod = dr["COD_USU"].ToString();
                    ViewBag.nom = dr["NOM_USU"].ToString();
                    ViewBag.nic = dr["NIC_USU"].ToString();
                    ViewBag.per = dr["PER_USU"].ToString();
                }
            }

            return View();
        }

        [Authorize]
        [HttpPost]
        public ActionResult ManageAccount(string submitButton)
        {
            return View();
        }
    }
    
}