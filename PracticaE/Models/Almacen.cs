using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PracticaE.Models
{
    public class Almacen
    {
        public int Id { get; set; }
        public int Disponibles { get; set; }
        public int Vendidos { get; set; }
        public Producto producto { get; set; }
    }
}