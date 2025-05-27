using UniSync.Models;

namespace UniSync.Repositories
{
    public class HorarioRepository
    {
        public bool Validar(HORARIO horario)
        {
            return horario.HORA_INICIO.HasValue &&
                   horario.HORA_FIN.HasValue &&
                   !string.IsNullOrEmpty(horario.DIAS) &&
                   horario.ID_ASIGNATURA.HasValue;
        }
    }
}
