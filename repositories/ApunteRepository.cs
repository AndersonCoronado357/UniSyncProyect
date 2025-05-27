using UniSync.Models;

namespace UniSync.Repositories
{
    public class ApunteRepository
    {
        public bool Validar(APUNTE apunte)
        {
            return !string.IsNullOrWhiteSpace(apunte.CONTENIDO) && apunte.ID_ASIGNATURA != null;
        }

        public APUNTE Preparar(APUNTE apunte)
        {
            apunte.ETIQUETA = apunte.ETIQUETA?.Trim();
            apunte.CONTENIDO = apunte.CONTENIDO.Trim();
            return apunte;
        }
    }
}
