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
            ClsPersona objPersona1 = new ClsPersona();
            objPersona1.apellido = "Sosa Bedoya";
            objPersona1.nombre = "Sharon";
            objPersona1.email = "sharonfiore05@gmail.com";
            objPersona1.edad = 22;
            objPersona1.sexo = false;
            objPersona1.talla = 1.54;

            objLista.Add(objPersona1);


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
            objPersona3.email = "kestrella@gmail.com";
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

            return View(objLista);
        }

    }
}