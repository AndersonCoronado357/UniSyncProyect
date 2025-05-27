using System.Collections.Generic;
using System.Linq;
using UniSync.Models;
using UniSync.Clases;

namespace UniSync.Repositories
{
    public class AsignaturaRepository
    {
        public bool Validar(ASIGNATURA asignatura)
        {
            return !string.IsNullOrWhiteSpace(asignatura.NOMBRE) &&
                   !string.IsNullOrWhiteSpace(asignatura.DOCENTE) &&
                   asignatura.ID_USUARIO > 0;
        }

        public ASIGNATURA Preparar(ASIGNATURA asignatura)
        {
            asignatura.NOMBRE = asignatura.NOMBRE.Trim();
            asignatura.DOCENTE = asignatura.DOCENTE.Trim();
            asignatura.AULA = asignatura.AULA?.Trim();
            return asignatura;
        }

        public List<ASIGNATURA> FiltrarPorUsuario(int idUsuario)
        {
            var asignaturaDb = new Asignatura();
            var todas = asignaturaDb.ConsultarTodas();
            return todas.Where(a => a.ID_USUARIO == idUsuario).ToList();
        }
    }
}
