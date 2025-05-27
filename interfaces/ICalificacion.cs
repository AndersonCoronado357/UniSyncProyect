using System.Collections.Generic;
using UniSync.Models;

namespace UniSync.Interfaces
{
    public interface ICalificacion
    {
        string Insertar(CALIFICACION calificacion);
        string Actualizar(CALIFICACION calificacion);
        string Eliminar(int id);
        List<CALIFICACION> ConsultarTodos();
        List<CALIFICACION> ConsultarPorAsignatura(int idAsignatura);
    }
}
