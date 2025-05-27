using System.Collections.Generic;
using UniSync.Models;

namespace UniSync.Interfaces
{
    public interface ITarea
    {
        string Insertar(TAREA tarea);
        string Actualizar(TAREA tarea);
        string Eliminar(int id);
        List<TAREA> ConsultarTodos();
        List<TAREA> ConsultarPorAsignatura(int idAsignatura);
    }
}
