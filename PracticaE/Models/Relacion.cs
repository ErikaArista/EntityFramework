using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PracticaE.Models
{
    public class Relacion
    {
        public int Id { get; set; }
        public Producto producto { get; set; }
        public Almacen  almacen  { get; set; }
    }
}