﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tickets.Models;

namespace Tickets.Controllers
{
    public class Crear_TicketController : Controller
    {
        // GET: Crear_Ticket
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CrearTicket()
        {
            ViewData["Nombre_Usuarios_Login"] = Sesion.Nombre_Usuarios_Login;

            return View();
        }

        public ActionResult GuardarTicket()
        {

            return View();
        }



    }
}