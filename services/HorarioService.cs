using System.Collections.Generic;
using UniSync.Models;
using UniSync.Clases;
using UniSync.Interfaces;
using UniSync.Repositories;

namespace UniSync.Services
{
    public class HorarioService : IHorario
    {
        private readonly HorarioRepository _repo = new HorarioRepository();

        public string Insertar(HORARIO horario)
        {
            if (!_repo.Validar(horario))
                return "Datos inválidos";

            var db = new Horario { horario = horario };
            return db.Insertar();
        }

        public string Actualizar(HORARIO horario)
        {
            if (!_repo.Validar(horario))
                return "Datos inválidos";

            var db = new Horario { horario = horario };
            return db.Actualizar();
        }

        public string Eliminar(int id)
        {
            var db = new Horario();
            return db.Eliminar(id);
        }

        public List<HORARIO> ConsultarTodos()
        {
            var db = new Horario();
            return db.ConsultarTodos();
        }

        public List<HORARIO> ConsultarPorAsignatura(int idAsignatura)
        {
            var db = new Horario();
            return db.ConsultarPorAsignatura(idAsignatura);
        }
    }
}
