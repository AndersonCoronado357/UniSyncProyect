using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity.Migrations;
using UniSync.Models;

namespace UniSync.Clases
{
    public class Apunte
    {
        private UNISYNCEntities3 DBUniSync = new UNISYNCEntities3();

        public APUNTE apunte { get; set; }

        public string Insertar()
        {
            try
            {
                DBUniSync.APUNTEs.Add(apunte);
                DBUniSync.SaveChanges();
                return "Apunte insertado correctamente";
            }
            catch (Exception ex)
            {
                return "Error al insertar el apunte: " + ex.Message;
            }
        }

        public string Actualizar()
        {
            try
            {
                var existente = ConsultarXId(apunte.ID_APUNTE);
                if (existente == null)
                    return "El apunte no existe";

                DBUniSync.APUNTEs.AddOrUpdate(apunte);
                DBUniSync.SaveChanges();
                return "Apunte actualizado correctamente";
            }
            catch (Exception ex)
            {
                return "Error al actualizar: " + ex.Message;
            }
        }

        public string Eliminar(int idApunte)
        {
            try
            {
                var existente = ConsultarXId(idApunte);
                if (existente == null)
                    return "Apunte no encontrado";

                DBUniSync.APUNTEs.Remove(existente);
                DBUniSync.SaveChanges();
                return "Apunte eliminado correctamente";
            }
            catch (Exception ex)
            {
                return "Error al eliminar: " + ex.Message;
            }
        }

        public APUNTE ConsultarXId(int idApunte)
        {
            return DBUniSync.APUNTEs.FirstOrDefault(a => a.ID_APUNTE == idApunte);
        }

        public List<APUNTE> ConsultarTodos()
        {
            return DBUniSync.APUNTEs.OrderBy(a => a.FECHA).ToList();
        }

        public List<APUNTE> ConsultarXAsignatura(int idAsignatura)
        {
            return DBUniSync.APUNTEs
                .Where(a => a.ID_ASIGNATURA == idAsignatura)
                .OrderByDescending(a => a.FECHA)
                .ToList();
        }
    }
}
