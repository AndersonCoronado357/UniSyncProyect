using UniSync.Models;

namespace UniSync.Repositories
{
    public class TareaRepository
    {
        public bool Validar(TAREA tarea)
        {
            return !string.IsNullOrEmpty(tarea.NOMBRE) &&
                   !string.IsNullOrEmpty(tarea.DESCRIPCION) &&
                   tarea.FECHA_ENTREGA != default &&
                   tarea.ID_ASIGNATURA.HasValue;
        }
    }
}
