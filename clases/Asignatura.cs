using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity.Migrations;
using UniSync.Models;

namespace UniSync.Clases
{
    public class Asignatura
    {
        private UNISYNCEntities3 DBUniSync = new UNISYNCEntities3();

        public ASIGNATURA asignatura { get; set; }

        public string Insertar()
        {
            try
            {
                DBUniSync.ASIGNATURAs.Add(asignatura);
                DBUniSync.SaveChanges();
                return "Asignatura ingresada correctamente: " + asignatura.NOMBRE;
            }
            catch (Exception ex)
            {
                return "Error al insertar la asignatura: " + ex.Message;
            }
        }

        public ASIGNATURA ConsultarXId(int id)
        {
            return DBUniSync.ASIGNATURAs.FirstOrDefault(a => a.ID_ASIGNATURA == id);
        }

        public string Actualizar()
        {
            ASIGNATURA existente = ConsultarXId(asignatura.ID_ASIGNATURA);
            if (existente == null)
            {
                return "ID de asignatura no válido.";
            }

            DBUniSync.ASIGNATURAs.AddOrUpdate(asignatura);
            DBUniSync.SaveChanges();
            return "Asignatura actualizada correctamente.";
        }

        public List<ASIGNATURA> ConsultarTodas()
        {
            return DBUniSync.ASIGNATURAs.OrderBy(a => a.NOMBRE).ToList();
        }

        public string Eliminar()
        {
            try
            {
                ASIGNATURA existente = ConsultarXId(asignatura.ID_ASIGNATURA);
                if (existente == null)
                    return "ID de asignatura no válido.";

                DBUniSync.ASIGNATURAs.Remove(existente);
                DBUniSync.SaveChanges();
                return "Asignatura eliminada correctamente.";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string EliminarXId(int id)
        {
            try
            {
                ASIGNATURA existente = ConsultarXId(id);
                if (existente == null)
                    return "ID de asignatura no válido.";

                DBUniSync.ASIGNATURAs.Remove(existente);
                DBUniSync.SaveChanges();
                return "Asignatura eliminada correctamente.";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
