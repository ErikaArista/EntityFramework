using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace PracticaE.Models
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=BDEri")
        {
        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }    
        public virtual DbSet<Producto> Productos { get; set; }
        public virtual DbSet<Almacen> Almacens { get; set; }
   
    }
}
