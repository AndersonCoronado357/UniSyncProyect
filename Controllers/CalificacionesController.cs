using System.Collections.Generic;
using System.Web.Http;
using UniSync.Models;
using UniSync.Interfaces;
using UniSync.Services;

namespace UniSync.Controllers
{
    [RoutePrefix("api/Calificacion")]
    public class CalificacionesController : ApiController
    {
        private readonly ICalificacion _service = new CalificacionService();

        [HttpPost]
        [Route("Insertar")]
        public string Insertar([FromBody] CALIFICACION calificacion)
        {
            return _service.Insertar(calificacion);
        }

        [HttpPut]
        [Route("Actualizar")]
        public string Actualizar([FromBody] CALIFICACION calificacion)
        {
            return _service.Actualizar(calificacion);
        }

        [HttpDelete]
        [Route("Eliminar")]
        public string Eliminar(int id)
        {
            return _service.Eliminar(id);
        }

        [HttpGet]
        [Route("ConsultarTodos")]
        public List<CALIFICACION> ConsultarTodos()
        {
            return _service.ConsultarTodos();
        }

        [HttpGet]
        [Route("ConsultarPorAsignatura")]
        public List<CALIFICACION> ConsultarPorAsignatura(int idAsignatura)
        {
            return _service.ConsultarPorAsignatura(idAsignatura);
        }
    }
}
