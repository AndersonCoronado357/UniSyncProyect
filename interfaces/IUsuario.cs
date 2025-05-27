using UniSync.Models;
using System.Collections.Generic;

namespace UniSync.Interfaces
{
    public interface IUsuario
    {
        string Insertar(USUARIO usuario);
        string Actualizar(USUARIO usuario);
        string Eliminar(int idUsuario);
        USUARIO ConsultarXId(int idUsuario);
        List<USUARIO> ConsultarTodos();
        USUARIO Login(string correo, string contrasena);
    }
}
