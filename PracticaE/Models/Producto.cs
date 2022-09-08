using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PracticaE.Models
{
    public class Producto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Proveedor { get; set; }
        public int Dia { get; set; }
    }
}