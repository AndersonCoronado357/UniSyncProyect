using System.Collections.Generic;
using UniSync.Models;
using UniSync.Clases;
using UniSync.Interfaces;
using UniSync.Repositories;

namespace UniSync.Services
{
    public class AsignaturaService : IAsignatura
    {
        private readonly AsignaturaRepository _repo = new AsignaturaRepository();

        public string Insertar(ASIGNATURA asignatura)
        {
            if (!_repo.Validar(asignatura))
                return "Datos inválidos";

            asignatura = _repo.Preparar(asignatura);

            var asignaturaDb = new Asignatura { asignatura = asignatura };
            return asignaturaDb.Insertar();
        }

        public ASIGNATURA ConsultarXId(int id)
        {
            var asignaturaDb = new Asignatura();
            return asignaturaDb.ConsultarXId(id);
        }

        public string Actualizar(ASIGNATURA asignatura)
        {
            if (!_repo.Validar(asignatura))
                return "Datos inválidos";

            asignatura = _repo.Preparar(asignatura);

            var asignaturaDb = new Asignatura { asignatura = asignatura };
            return asignaturaDb.Actualizar();
        }

        public List<ASIGNATURA> ConsultarTodas()
        {
            var asignaturaDb = new Asignatura();
            return asignaturaDb.ConsultarTodas();
        }

        public List<ASIGNATURA> ConsultarPorUsuario(int idUsuario)
        {
            return _repo.FiltrarPorUsuario(idUsuario);
        }

        public string Eliminar(ASIGNATURA asignatura)
        {
            var asignaturaDb = new Asignatura { asignatura = asignatura };
            return asignaturaDb.Eliminar();
        }

        public string EliminarXId(int id)
        {
            var asignaturaDb = new Asignatura();
            return asignaturaDb.EliminarXId(id);
        }
    }
}
