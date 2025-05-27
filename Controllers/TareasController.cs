using System.Collections.Generic;
using System.Web.Http;
using UniSync.Models;
using UniSync.Interfaces;
using UniSync.Services;

namespace UniSync.Controllers
{
    [RoutePrefix("api/Tarea")]
    public class TareasController : ApiController
    {
        private readonly ITarea _service = new TareaService();

        [HttpPost]
        [Route("Insertar")]
        public string Insertar([FromBody] TAREA tarea)
        {
            return _service.Insertar(tarea);
        }

        [HttpPut]
        [Route("Actualizar")]
        public string Actualizar([FromBody] TAREA tarea)
        {
            return _service.Actualizar(tarea);
        }

        [HttpDelete]
        [Route("Eliminar")]
        public string Eliminar(int id)
        {
            return _service.Eliminar(id);
        }

        [HttpGet]
        [Route("ConsultarTodos")]
        public List<TAREA> ConsultarTodos()
        {
            return _service.ConsultarTodos();
        }

        [HttpGet]
        [Route("ConsultarPorAsignatura")]
        public List<TAREA> ConsultarPorAsignatura(int idAsignatura)
        {
            return _service.ConsultarPorAsignatura(idAsignatura);
        }
    }
}
