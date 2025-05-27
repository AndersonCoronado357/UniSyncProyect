using System.Collections.Generic;
using UniSync.Models;
using UniSync.Interfaces;
using UniSync.Repositories;
using UniSync.Clases;

namespace UniSync.Services
{
    public class UsuarioService : IUsuario
    {
        private readonly UsuarioRepository _repo = new UsuarioRepository();

        public string Insertar(USUARIO usuario)
        {
            if (!_repo.Validar(usuario))
                return "Datos inválidos";

            usuario = _repo.Preparar(usuario);
            var db = new Usuario { usuario = usuario };
            return db.Insertar();
        }

        public string Actualizar(USUARIO usuario)
        {
            if (!_repo.Validar(usuario))
                return "Datos inválidos";

            usuario = _repo.Preparar(usuario);
            var db = new Usuario { usuario = usuario };
            return db.Actualizar();
        }

        public string Eliminar(int idUsuario)
        {
            var db = new Usuario();
            return db.Eliminar(idUsuario);
        }

        public USUARIO ConsultarXId(int idUsuario)
        {
            var db = new Usuario();
            return db.ConsultarXId(idUsuario);
        }

        public List<USUARIO> ConsultarTodos()
        {
            var db = new Usuario();
            return db.ConsultarTodos();
        }

        public USUARIO Login(string correo, string contrasena)
        {
            return _repo.Login(correo, contrasena);
        }
    }
}
