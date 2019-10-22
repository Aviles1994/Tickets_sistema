using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sistema_Tickets.Models
{
    public class Usuarios_Login
    {
        public int ID_Usuarios_Login { get; set; }
        public string Nombre_Usuarios_Login { get; set; }
        public string Contraseña { get; set; }
        public bool Estatus { get; set; }
        public DateTime Ultimo_Login { get; set; }
        public string Corre_Electronico { get; set; }
        public int ID_Tipo_usuario { get; set; }   
    }
}