using Sistema_Tickets.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tickets.Models;

namespace Sistema_Tickets.Controllers
{
    public class Usuarios_LoginController : Controller
    {
        SqlConnection con = new SqlConnection();
        SqlDataReader dr;


        // GET: Interfaces
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        public ActionResult Verificar(Usuarios_Login usuario)
        {
           
            CadenaConexion();

            con.Open();

            SqlCommand com = new SqlCommand();
            com.Connection = con;
            com.CommandText = "Select * from dbo.Usuarios_Login where  Nombre_Usuarios_Login=@Usuario and Contraseña=@Contrasenia ";
            com.Parameters.AddWithValue("@Usuario", usuario.Nombre_Usuarios_Login);
            com.Parameters.AddWithValue("@Contrasenia", usuario.Contraseña);
 

            dr = com.ExecuteReader();

            if (dr.Read())
            {
                var estado = (bool)dr[3];
                var userName = (string)dr[1];
                var userID = (int)dr[0];

                if (estado == true)
                {

                    dr.Close();
                    ActualizarUltimaFecha(usuario);

                    Sesion.ID_Usuarios_Login = userID;
                    Sesion.Nombre_Usuarios_Login = userName;
                    Sesion.SesionActiva = true;

                    ViewData["Nombre_Usuarios_Login"] = Sesion.Nombre_Usuarios_Login;

                    con.Close();
                    return View("../Tickets/CrearTicket");
                }
                return View();
                
            }
            else
            {

                con.Close();
                return View();
            }

        }


        private void ActualizarUltimaFecha(Usuarios_Login usuario)
        {
            SqlCommand com = new SqlCommand();
            com.Connection = con;
            com.CommandText = "update dbo.Usuarios_Login set Ultimo_Login=@Fecha where Nombre_Usuarios_Login=@Usuario and Contraseña =@Contrasenia";
            com.Parameters.AddWithValue("@Fecha", DateTime.Now.ToString("yyyy/MM/dd"));
            com.Parameters.AddWithValue("@Usuario", usuario.Nombre_Usuarios_Login);
            com.Parameters.AddWithValue("@Contrasenia", usuario.Contraseña);
            com.ExecuteNonQuery();
        }


        private void CadenaConexion()
        {
            //con.ConnectionString = @"data source=GAVILES; database=Sistema_Tickets; user id=sa; password=1234;";
            con.ConnectionString = @"data source=OVELAZQUEZ; database=Sistema_Tickets; user id=sa; password=randiortonRKO97;";
        }

    }
}