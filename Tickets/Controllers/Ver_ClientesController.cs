using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Tickets.Controllers
{
    public class Ver_ClientesController : Controller
    {
        // GET: Ver_Clientes
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult VerClientes()
        {
            return View();
        }
    }
}