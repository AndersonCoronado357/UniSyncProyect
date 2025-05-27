using System;
using System.Collections.Generic;
using System.Linq;
using UniSync.Models;
using System.Data.Entity.Migrations;

namespace UniSync.Clases
{
    public class Horario
    {
        private UNISYNCEntities3 DBUniSync = new UNISYNCEntities3();

        public HORARIO horario { get; set; }

        public string Insertar()
        {
            try
            {
                DBUniSync.HORARIOs.Add(horario);
                DBUniSync.SaveChanges();
                return "Horario insertado correctamente.";
            }
            catch (Exception ex)
            {
                return "Error al insertar el horario: " + ex.Message;
            }
        }

        public string Actualizar()
        {
            try
            {
                DBUniSync.HORARIOs.AddOrUpdate(horario);
                DBUniSync.SaveChanges();
                return "Horario actualizado correctamente.";
            }
            catch (Exception ex)
            {
                return "Error al actualizar el horario: " + ex.Message;
            }
        }

        public string Eliminar(int id)
        {
            try
            {
                var item = DBUniSync.HORARIOs.FirstOrDefault(h => h.ID_HORARIO == id);
                if (item == null)
                    return "Horario no encontrado.";

                DBUniSync.HORARIOs.Remove(item);
                DBUniSync.SaveChanges();
                return "Horario eliminado correctamente.";
            }
            catch (Exception ex)
            {
                return "Error al eliminar el horario: " + ex.Message;
            }
        }

        public List<HORARIO> ConsultarTodos()
        {
            return DBUniSync.HORARIOs.ToList();
        }

        public List<HORARIO> ConsultarPorAsignatura(int idAsignatura)
        {
            return DBUniSync.HORARIOs
                .Where(h => h.ID_ASIGNATURA == idAsignatura)
                .ToList();
        }
    }
}
