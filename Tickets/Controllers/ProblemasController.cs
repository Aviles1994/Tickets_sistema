using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tickets.Models;

namespace Tickets.Controllers
{
    public class ProblemasController : Controller
    {
        // GET: Problemas
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult BuscarProblemas()
        {
            ViewData["Nombre_Usuarios_Login"] = Sesion.Nombre_Usuarios_Login;
            return View();
        }
    }
}