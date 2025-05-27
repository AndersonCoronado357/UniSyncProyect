using System;
using System.Collections.Generic;
using System.Linq;
using UniSync.Models;
using System.Data.Entity.Migrations;

namespace UniSync.Clases
{
    public class Calificacion
    {
        private UNISYNCEntities3 DBUniSync = new UNISYNCEntities3();

        public CALIFICACION calificacion { get; set; }

        public string Insertar()
        {
            try
            {
                DBUniSync.CALIFICACIONs.Add(calificacion);
                DBUniSync.SaveChanges();
                return "Calificación insertada correctamente.";
            }
            catch (Exception ex)
            {
                return "Error al insertar la calificación: " + ex.Message;
            }
        }

        public string Actualizar()
        {
            try
            {
                DBUniSync.CALIFICACIONs.AddOrUpdate(calificacion);
                DBUniSync.SaveChanges();
                return "Calificación actualizada correctamente.";
            }
            catch (Exception ex)
            {
                return "Error al actualizar la calificación: " + ex.Message;
            }
        }

        public string Eliminar(int id)
        {
            try
            {
                var calif = DBUniSync.CALIFICACIONs.FirstOrDefault(c => c.ID_CALIFICACION == id);
                if (calif == null)
                    return "Calificación no encontrada.";

                DBUniSync.CALIFICACIONs.Remove(calif);
                DBUniSync.SaveChanges();
                return "Calificación eliminada correctamente.";
            }
            catch (Exception ex)
            {
                return "Error al eliminar la calificación: " + ex.Message;
            }
        }

        public List<CALIFICACION> ConsultarTodos()
        {
            return DBUniSync.CALIFICACIONs.ToList();
        }

        public List<CALIFICACION> ConsultarPorAsignatura(int idAsignatura)
        {
            return DBUniSync.CALIFICACIONs
                .Where(c => c.ID_ASIGNATURA == idAsignatura)
                .ToList();
        }
    }
}
