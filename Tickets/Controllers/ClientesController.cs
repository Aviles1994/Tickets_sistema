using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tickets.Models;

namespace Tickets.Controllers
{
    public class ClientesController : Controller
    {
        // GET: Clientes
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CrearCliente()
        {
            ViewData["Nombre_Usuarios_Login"] = Sesion.Nombre_Usuarios_Login;
            return View();
        }

        public ActionResult BuscarCliente()
        {
            ViewData["Nombre_Usuarios_Login"] = Sesion.Nombre_Usuarios_Login;
            return View();
        }

        public ActionResult VerClientes()
        {
            ViewData["Nombre_Usuarios_Login"] = Sesion.Nombre_Usuarios_Login;
            return View();
        }
    }
}