using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto_Pagos_Eventos.Models;
using System.Windows.Forms;

namespace Proyecto_Pagos_Eventos.Clases
{
    class CrudEquipos
    {
        public static void Alta(Equipo array)
        {
            try
            {
                Conexion.getInstance().Equipo.Add(array);
                Conexion.getInstance().SaveChanges();
                MessageBox.Show("El equipo " + array.tipo + " fue agregado exitosamente", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static Object Consulta()
        {
            var tabla = Conexion.getInstance().Equipo.ToList();

            return tabla;
        }

        public static void Modificar(Equipo array)
        {
            try
            {
                Guid f = array.idEquipo;
                Equipo modificar = Conexion.getInstance().Equipo.Where(w => w.idEquipo == f).FirstOrDefault();
                modificar.idEquipo = array.idEquipo;
                modificar.tipo = array.tipo;
                modificar.descripcion = array.descripcion;
                modificar.activo = array.activo;
                Conexion.getInstance().SaveChanges();
                MessageBox.Show("El equipo " + array.tipo + " fue modificado exitosamente", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
