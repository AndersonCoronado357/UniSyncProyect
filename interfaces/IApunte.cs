using UniSync.Models;
using System.Collections.Generic;

namespace UniSync.Interfaces
{
    public interface IApunte
    {
        string Insertar(APUNTE apunte);
        string Actualizar(APUNTE apunte);
        string Eliminar(int idApunte);
        APUNTE ConsultarXId(int idApunte);
        List<APUNTE> ConsultarTodos();
        List<APUNTE> ConsultarXAsignatura(int idAsignatura);
    }
}
