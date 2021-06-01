using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SL.Controllers
{
    public class HorariosController : ApiController
    {
        [HttpGet]
        [Route("api/GetAllH")]
        public IHttpActionResult GetAll()
        {
            ML.Response.Horarios_Response request = BL.Horarios.GetAll();
            return Ok(request.HorariosList);



        }

        [HttpGet]
        [Route("api/GetByIdH/{ID}")]
        public IHttpActionResult GetById(int ID)
        {
            ML.Response.Horarios_Response request = BL.Horarios.GetById(ID);
            return Ok(request.HorariosList);



        }

        [HttpPost]
        [Route("api/AddH")]
        public IHttpActionResult Add(ML.Entities.Horarios horarios)
        {
            ML.Response.Horarios_Response request = BL.Horarios.Add(horarios);
            return Ok(request);



        }

        [HttpPut]
        [Route("api/UpdateH")]
        public IHttpActionResult Update(ML.Entities.Horarios horarios)
        {
            ML.Response.Horarios_Response request = BL.Horarios.Update(horarios);
            return Ok(request);



        }

        [HttpDelete]
        [Route("api/DeleteH/{ID}/{ID2}")]
        public IHttpActionResult Delete(int ID, int ID2)
        {
            ML.Response.Horarios_Response request = BL.Horarios.Delete(ID, ID2);
            return Ok(request);



        }



    }
}
