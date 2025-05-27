using System.Collections.Generic;
using System.Web.Http;
using UniSync.Models;
using UniSync.Interfaces;
using UniSync.Services;

namespace UniSync.Controllers
{
    [RoutePrefix("api/Asignatura")]
    public class AsignaturasController : ApiController
    {
        private readonly IAsignatura _service = new AsignaturaService();

        [HttpPost]
        [Route("Insertar")]
        public string Insertar([FromBody] ASIGNATURA asignatura)
        {
            return _service.Insertar(asignatura);
        }

        [HttpGet]
        [Route("ConsultarXId")]
        public ASIGNATURA ConsultarXId(int id)
        {
            return _service.ConsultarXId(id);
        }

        [HttpPut]
        [Route("Actualizar")]
        public string Actualizar([FromBody] ASIGNATURA asignatura)
        {
            return _service.Actualizar(asignatura);
        }

        [HttpDelete]
        [Route("Eliminar")]
        public string Eliminar([FromBody] ASIGNATURA asignatura)
        {
            return _service.Eliminar(asignatura);
        }

        [HttpDelete]
        [Route("EliminarXId")]
        public string EliminarXId(int id)
        {
            return _service.EliminarXId(id);
        }

        [HttpGet]
        [Route("ConsultarTodas")]
        public List<ASIGNATURA> ConsultarTodas()
        {
            return _service.ConsultarTodas();
        }

        [HttpGet]
        [Route("ConsultarPorUsuario")]
        public List<ASIGNATURA> ConsultarPorUsuario(int idUsuario)
        {
            return _service.ConsultarPorUsuario(idUsuario);
        }
    }
}
