using System.Collections.Generic;
using UniSync.Models;
using UniSync.Interfaces;
using UniSync.Repositories;
using UniSync.Clases;

namespace UniSync.Services
{
    public class ApunteService : IApunte
    {
        private readonly ApunteRepository _repo = new ApunteRepository();

        public string Insertar(APUNTE apunte)
        {
            if (!_repo.Validar(apunte))
                return "Datos inválidos";

            apunte = _repo.Preparar(apunte);
            var db = new Apunte { apunte = apunte };
            return db.Insertar();
        }

        public string Actualizar(APUNTE apunte)
        {
            if (!_repo.Validar(apunte))
                return "Datos inválidos";

            apunte = _repo.Preparar(apunte);
            var db = new Apunte { apunte = apunte };
            return db.Actualizar();
        }

        public string Eliminar(int idApunte)
        {
            var db = new Apunte();
            return db.Eliminar(idApunte);
        }

        public APUNTE ConsultarXId(int idApunte)
        {
            var db = new Apunte();
            return db.ConsultarXId(idApunte);
        }

        public List<APUNTE> ConsultarTodos()
        {
            var db = new Apunte();
            return db.ConsultarTodos();
        }

        public List<APUNTE> ConsultarXAsignatura(int idAsignatura)
        {
            var db = new Apunte();
            return db.ConsultarXAsignatura(idAsignatura);
        }
    }
}
