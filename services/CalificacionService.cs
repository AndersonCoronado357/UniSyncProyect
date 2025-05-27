using System.Collections.Generic;
using UniSync.Models;
using UniSync.Clases;
using UniSync.Interfaces;
using UniSync.Repositories;

namespace UniSync.Services
{
    public class CalificacionService : ICalificacion
    {
        private readonly CalificacionRepository _repo = new CalificacionRepository();

        public string Insertar(CALIFICACION calificacion)
        {
            if (!_repo.Validar(calificacion))
                return "Datos inválidos";

            var califDb = new Calificacion { calificacion = calificacion };
            return califDb.Insertar();
        }

        public string Actualizar(CALIFICACION calificacion)
        {
            if (!_repo.Validar(calificacion))
                return "Datos inválidos";

            var califDb = new Calificacion { calificacion = calificacion };
            return califDb.Actualizar();
        }

        public string Eliminar(int id)
        {
            var califDb = new Calificacion();
            return califDb.Eliminar(id);
        }

        public List<CALIFICACION> ConsultarTodos()
        {
            var califDb = new Calificacion();
            return califDb.ConsultarTodos();
        }

        public List<CALIFICACION> ConsultarPorAsignatura(int idAsignatura)
        {
            var califDb = new Calificacion();
            return califDb.ConsultarPorAsignatura(idAsignatura);
        }
    }
}
