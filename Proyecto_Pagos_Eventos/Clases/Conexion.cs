using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto_Pagos_Eventos.Models;

namespace Proyecto_Pagos_Eventos.Clases
{
    public class Conexion
    {
        public static Usuarios usuario;

        private static EventosBDEntities instance;

        public static EventosBDEntities getInstance()
        {
            if (instance == null)
            {
                instance = new EventosBDEntities();
            }
            return instance;
        }

        public static bool session(string user, string pass)
        {
            bool i = false;

            Usuarios usr = getInstance().Usuarios.Where(w => w.usuario == user && w.contrasena == pass && w.activo == true).FirstOrDefault();

            if (usr != null)
            {
                i = true;
                usuario = usr;
            }
            else
            {
                i = false;
            }
            return i;
        }
    }
}
