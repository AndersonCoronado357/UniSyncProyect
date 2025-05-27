using UniSync.Models;
using System.Collections.Generic;
using System.Linq;
using UniSync.Clases;

namespace UniSync.Repositories
{
    public class UsuarioRepository
    {
        public bool Validar(USUARIO usuario)
        {
            return !string.IsNullOrWhiteSpace(usuario.NOMBRE) &&
                   !string.IsNullOrWhiteSpace(usuario.CORREO) &&
                   !string.IsNullOrWhiteSpace(usuario.CONTRASENA);
        }

        public USUARIO Preparar(USUARIO usuario)
        {
            usuario.CORREO = usuario.CORREO.Trim().ToLower();
            return usuario;
        }

        public USUARIO Login(string correo, string contrasena)
        {
            var usuarioDb = new Usuario();
            var todos = usuarioDb.ConsultarTodos();

            return todos.FirstOrDefault(u =>
                u.CORREO.Trim().ToLower() == correo.Trim().ToLower() &&
                u.CONTRASENA == contrasena);
        }
    }
}
