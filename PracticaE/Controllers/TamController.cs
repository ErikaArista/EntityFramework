using PracticaE.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using PracticaE.Models;

namespace PracticaE.Controllers
{
    public class TamController : ApiController
    {
        [ActionName("Agregar")]
        [HttpPost]

        public void post(Almacen almacen)
        {
            Model1 model = new Model1();
            model.Almacens.Add(almacen);
            model.SaveChanges();
        }
    }
}
