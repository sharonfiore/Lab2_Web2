using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lab2_MVC_Sosa.Models;

namespace Lab2_MVC_Sosa.Controllers
{
    public class PersonaController : Controller
    {
        List <ClsPersona> objLista = new List<ClsPersona>();

        // GET: Persona
        public ActionResult Index()
        {
         


            ClsPersona objPersona2 = new ClsPersona();
            objPersona2.apellido = "Robles Flores";
            objPersona2.nombre = "Anthony";
            objPersona2.email = "thony@gmail.com";
            objPersona2.edad = 26;
            objPersona2.sexo = true;
            objPersona2.talla = 1.73;

            objLista.Add(objPersona2);

            ClsPersona objPersona3 = new ClsPersona();
            objPersona3.apellido = "Estrella Palacios";
            objPersona3.nombre = "Katherine";
            objPersona3.email = "estrella2424@gmail.com";
            objPersona3.edad = 26;
            objPersona3.sexo = false;
            objPersona3.talla = 1.62;

            objLista.Add(objPersona3);

            ClsPersona objPersona4 = new ClsPersona();
            objPersona4.apellido = "Andia Zeballos";
            objPersona4.nombre = "Alonso";
            objPersona4.email = "ualonso@gmail.com";
            objPersona4.edad = 21;
            objPersona4.sexo = true;
            objPersona4.talla = 1.72;

            objLista.Add(objPersona4);

            ClsPersona objPersona5 = new ClsPersona();
            objPersona5.apellido = "Cotrado Coaquira";
            objPersona5.nombre = "Arlyn";
            objPersona5.email = "arlync@gmail.com";
            objPersona5.edad = 21;
            objPersona5.sexo = false;
            objPersona5.talla = 1.65;

            objLista.Add(objPersona5);

            return View(objLista);
        }

    }
}