using System.Collections.Generic;
using System.Web.Http;
using UniSync.Models;
using UniSync.Interfaces;
using UniSync.Services;

namespace UniSync.Controllers
{
    [RoutePrefix("api/Apunte")]
    public class ApuntesController : ApiController
    {
        private readonly IApunte _service = new ApunteService();

        [HttpPost]
        [Route("Insertar")]
        public string Insertar([FromBody] APUNTE apunte)
        {
            return _service.Insertar(apunte);
        }

        [HttpPut]
        [Route("Actualizar")]
        public string Actualizar([FromBody] APUNTE apunte)
        {
            return _service.Actualizar(apunte);
        }

        [HttpDelete]
        [Route("Eliminar")]
        public string Eliminar(int idApunte)
        {
            return _service.Eliminar(idApunte);
        }

        [HttpGet]
        [Route("ConsultarXId")]
        public APUNTE ConsultarXId(int idApunte)
        {
            return _service.ConsultarXId(idApunte);
        }

        [HttpGet]
        [Route("ConsultarTodos")]
        public List<APUNTE> ConsultarTodos()
        {
            return _service.ConsultarTodos();
        }

        [HttpGet]
        [Route("ConsultarXAsignatura")]
        public List<APUNTE> ConsultarXAsignatura(int idAsignatura)
        {
            return _service.ConsultarXAsignatura(idAsignatura);
        }
    }
}
