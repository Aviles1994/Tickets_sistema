using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tickets.Models;

namespace Tickets.Controllers
{
    public class ClientesController : Controller
    {
        SqlConnection con = new SqlConnection();
        SqlDataReader dr;


        // GET: Clientes
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CrearCliente(Crear_Cliente cliente)
        {
            llenarlista();
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


        public void llenarlista() {

            CadenaConexion();

            con.Open();

            SqlCommand com = new SqlCommand();
            com.Connection = con;
            com.CommandText = "Select * from dbo.Entidad_Federativa ";

            dr = com.ExecuteReader();
            dr.Read();


            
        }

        private void CadenaConexion()
        {
            con.ConnectionString = @"data source=GAVILES; database=Sistema_Tickets; user id=sa; password=1234;";
            //con.ConnectionString = @"data source=OVELAZQUEZ; database=Sistema_Tickets; user id=sa; password=randiortonRKO97;";
        }
    }
}