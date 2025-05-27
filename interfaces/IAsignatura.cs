using System.Collections.Generic;
using UniSync.Models;

namespace UniSync.Interfaces
{
    public interface IAsignatura
    {
        string Insertar(ASIGNATURA asignatura);
        ASIGNATURA ConsultarXId(int id);
        string Actualizar(ASIGNATURA asignatura);
        List<ASIGNATURA> ConsultarTodas();
        List<ASIGNATURA> ConsultarPorUsuario(int idUsuario);
        string Eliminar(ASIGNATURA asignatura);
        string EliminarXId(int id);
    }
}
