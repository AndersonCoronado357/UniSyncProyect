using System.Collections.Generic;
using UniSync.Models;
using UniSync.Clases;
using UniSync.Interfaces;
using UniSync.Repositories;

namespace UniSync.Services
{
    public class TareaService : ITarea
    {
        private readonly TareaRepository _repo = new TareaRepository();

        public string Insertar(TAREA tarea)
        {
            if (!_repo.Validar(tarea))
                return "Datos inválidos";

            var db = new Tarea { tarea = tarea };
            return db.Insertar();
        }

        public string Actualizar(TAREA tarea)
        {
            if (!_repo.Validar(tarea))
                return "Datos inválidos";

            var db = new Tarea { tarea = tarea };
            return db.Actualizar();
        }

        public string Eliminar(int id)
        {
            var db = new Tarea();
            return db.Eliminar(id);
        }

        public List<TAREA> ConsultarTodos()
        {
            var db = new Tarea();
            return db.ConsultarTodos();
        }

        public List<TAREA> ConsultarPorAsignatura(int idAsignatura)
        {
            var db = new Tarea();
            return db.ConsultarPorAsignatura(idAsignatura);
        }
    }
}
