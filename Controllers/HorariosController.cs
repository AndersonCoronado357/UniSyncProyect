using System.Collections.Generic;
using System.Web.Http;
using UniSync.Models;
using UniSync.Interfaces;
using UniSync.Services;

namespace UniSync.Controllers
{
    [RoutePrefix("api/Horario")]
    public class HorariosController : ApiController
    {
        private readonly IHorario _service = new HorarioService();

        [HttpPost]
        [Route("Insertar")]
        public string Insertar([FromBody] HORARIO horario)
        {
            return _service.Insertar(horario);
        }

        [HttpPut]
        [Route("Actualizar")]
        public string Actualizar([FromBody] HORARIO horario)
        {
            return _service.Actualizar(horario);
        }

        [HttpDelete]
        [Route("Eliminar")]
        public string Eliminar(int id)
        {
            return _service.Eliminar(id);
        }

        [HttpGet]
        [Route("ConsultarTodos")]
        public List<HORARIO> ConsultarTodos()
        {
            return _service.ConsultarTodos();
        }

        [HttpGet]
        [Route("ConsultarPorAsignatura")]
        public List<HORARIO> ConsultarPorAsignatura(int idAsignatura)
        {
            return _service.ConsultarPorAsignatura(idAsignatura);
        }
    }
}
