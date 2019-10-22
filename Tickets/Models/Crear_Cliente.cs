using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tickets.Models
{
    public class Crear_Cliente
    {
        public int     ID_Cliente { get; set; }
        public string  Nombre_Cliente { get; set; }
        public string Calle { get; set; }
        public string Numero { get; set;}
        public string Colonia { get; set; }
        public string Telefono { get; set; }
        public string Correo_Electronico { get; set; }
        public string ID_Entidad_Federativa { get; set; }
    }
}