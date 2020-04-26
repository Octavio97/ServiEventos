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
        private static EventosBDEntities instance;

        public static EventosBDEntities getInstance()
        {
            if (instance == null)
            {
                instance = new EventosBDEntities();
            }
            return instance;
        }
    }
}
