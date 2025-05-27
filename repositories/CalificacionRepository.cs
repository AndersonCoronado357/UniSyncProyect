using UniSync.Models;

namespace UniSync.Repositories
{
    public class CalificacionRepository
    {
        public bool Validar(CALIFICACION calificacion)
        {
            return calificacion.NOTA >= 0 &&
                   calificacion.PORCENTAJE >= 0 &&
                   calificacion.ID_ASIGNATURA.HasValue;
        }
    }
}
