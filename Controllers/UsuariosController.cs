using System;
using System.Web.Http;
using UniSync.Models;
using UniSync.Services;

namespace UniSync.Controllers
{
    [RoutePrefix("api/Usuario")]
    public class UsuarioController : ApiController
    {
        private readonly UsuarioService _service = new UsuarioService();

        [HttpPost]
        [Route("Insertar")]
        public IHttpActionResult Insertar([FromBody] USUARIO usuario)
        {
            try
            {
                var resultado = _service.Insertar(usuario);
                return Ok(resultado);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }


        [HttpPut]
        [Route("Actualizar")]
        public IHttpActionResult Actualizar([FromBody] USUARIO usuario)
        {
            var resultado = _service.Actualizar(usuario);
            return Ok(resultado);
        }

        [HttpDelete]
        [Route("Eliminar/{idUsuario}")]
        public IHttpActionResult Eliminar(int idUsuario)
        {
            var resultado = _service.Eliminar(idUsuario);
            return Ok(resultado);
        }

        [HttpGet]
        [Route("ConsultarXId/{idUsuario}")]
        public IHttpActionResult ConsultarXId(int idUsuario)
        {
            var usuario = _service.ConsultarXId(idUsuario);
            if (usuario == null)
                return NotFound();

            return Ok(usuario);
        }

        [HttpGet]
        [Route("ConsultarTodos")]
        public IHttpActionResult ConsultarTodos()
        {
            var usuarios = _service.ConsultarTodos();
            return Ok(usuarios);
        }

        // POST api/Usuario/Login
        [HttpPost]
        [Route("Login")]
        public IHttpActionResult Login([FromBody] LoginRequest login)
        {
            if (login == null || string.IsNullOrWhiteSpace(login.Correo) || string.IsNullOrWhiteSpace(login.Contrasena))
                return BadRequest("Credenciales inválidas.");

            var usuario = _service.Login(login.Correo, login.Contrasena);

            if (usuario == null)
                return Unauthorized();

            return Ok(usuario);
        }
    }

    public class LoginRequest
    {
        public string Correo { get; set; }
        public string Contrasena { get; set; }
    }
}
