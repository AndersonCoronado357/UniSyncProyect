using System.Collections.Generic;
using UniSync.Models;

namespace UniSync.Interfaces
{
    public interface IHorario
    {
        string Insertar(HORARIO horario);
        string Actualizar(HORARIO horario);
        string Eliminar(int id);
        List<HORARIO> ConsultarTodos();
        List<HORARIO> ConsultarPorAsignatura(int idAsignatura);
    }
}
