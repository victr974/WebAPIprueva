using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPIprueva.Controllers
{
    public class PersonaController : ApiController
    {

        //public IHttpActionResult Add()
        //{
        //    using (Models.BDEntities db = new Models.BDEntities())
        //    {
        //        var ObjPersona = new Models.tbPersona();
        //        ObjPersona.nombre = "Karla";
        //        ObjPersona.edad = 21;
        //        db.tbPersona.Add(ObjPersona);
        //        db.SaveChanges();
        //    }
        //    return Ok("exito");
        //}

        [HttpPost]
        public IHttpActionResult Add(Models.Request.PersonaRequest model)
        {
            using (Models.BDEntities db = new Models.BDEntities())
            {
                var ObjPersona = new Models.tbPersona();
                ObjPersona.nombre = model.Nombre;
                ObjPersona.edad = model.Edad;
                db.tbPersona.Add(ObjPersona);
                db.SaveChanges();
            }
            return Ok("exito");
        }
    } 
}
