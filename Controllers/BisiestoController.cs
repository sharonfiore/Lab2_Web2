using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using Lab2_MVC_Sosa.Models;

namespace Lab2_MVC_Sosa.Controllers
{
    public class BisiestoController : Controller
    {
        //ClsBisiesto objBisiesto = new ClsBisiesto();
        // GET: Bisiesto
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Visualizar(ClsBisiesto objBisiesto)
        {

            return View(objBisiesto);
        }
    }
}