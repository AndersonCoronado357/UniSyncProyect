using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity.Migrations;
using UniSync.Models;

namespace UniSync.Clases
{
    public class Usuario
    {
        private UNISYNCEntities3 DBUniSync = new UNISYNCEntities3();

        public USUARIO usuario { get; set; }

        public string Insertar()
        {
            try
            {
                if (usuario == null)
                    return "El usuario es nulo";

                DBUniSync.USUARIOs.Add(usuario);
                DBUniSync.SaveChanges();
                return "Usuario insertado correctamente";
            }
            catch (Exception ex)
            {
                return "Error al insertar el usuario: " + ex.Message;
            }
        }


        public string Actualizar()
        {
            try
            {
                var existente = ConsultarXId(usuario.ID_USUARIO);
                if (existente == null)
                    return "El usuario no existe";

                DBUniSync.USUARIOs.AddOrUpdate(usuario);
                DBUniSync.SaveChanges();
                return "Usuario actualizado correctamente";
            }
            catch (Exception ex)
            {
                return "Error al actualizar: " + ex.Message;
            }
        }

        public string Eliminar(int idUsuario)
        {
            try
            {
                var existente = ConsultarXId(idUsuario);
                if (existente == null)
                    return "Usuario no encontrado";

                DBUniSync.USUARIOs.Remove(existente);
                DBUniSync.SaveChanges();
                return "Usuario eliminado correctamente";
            }
            catch (Exception ex)
            {
                return "Error al eliminar: " + ex.Message;
            }
        }

        public USUARIO ConsultarXId(int idUsuario)
        {
            return DBUniSync.USUARIOs.FirstOrDefault(u => u.ID_USUARIO == idUsuario);
        }

        public List<USUARIO> ConsultarTodos()
        {
            return DBUniSync.USUARIOs.OrderBy(u => u.NOMBRE).ToList();
        }
    }
}
