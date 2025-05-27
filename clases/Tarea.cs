using System;
using System.Collections.Generic;
using System.Linq;
using UniSync.Models;
using System.Data.Entity.Migrations;

namespace UniSync.Clases
{
    public class Tarea
    {
        private UNISYNCEntities3 DBUniSync = new UNISYNCEntities3();

        public TAREA tarea { get; set; }

        public string Insertar()
        {
            try
            {
                DBUniSync.TAREAs.Add(tarea);
                DBUniSync.SaveChanges();
                return "Tarea insertada correctamente.";
            }
            catch (Exception ex)
            {
                return "Error al insertar la tarea: " + ex.Message;
            }
        }

        public string Actualizar()
        {
            try
            {
                DBUniSync.TAREAs.AddOrUpdate(tarea);
                DBUniSync.SaveChanges();
                return "Tarea actualizada correctamente.";
            }
            catch (Exception ex)
            {
                return "Error al actualizar la tarea: " + ex.Message;
            }
        }

        public string Eliminar(int id)
        {
            try
            {
                var item = DBUniSync.TAREAs.FirstOrDefault(t => t.ID_TAREA == id);
                if (item == null)
                    return "Tarea no encontrada.";

                DBUniSync.TAREAs.Remove(item);
                DBUniSync.SaveChanges();
                return "Tarea eliminada correctamente.";
            }
            catch (Exception ex)
            {
                return "Error al eliminar la tarea: " + ex.Message;
            }
        }

        public List<TAREA> ConsultarTodos()
        {
            return DBUniSync.TAREAs.ToList();
        }

        public List<TAREA> ConsultarPorAsignatura(int idAsignatura)
        {
            return DBUniSync.TAREAs
                .Where(t => t.ID_ASIGNATURA == idAsignatura)
                .ToList();
        }
    }
}
