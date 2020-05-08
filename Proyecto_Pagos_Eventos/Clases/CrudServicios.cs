using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto_Pagos_Eventos.Models;
using System.Windows.Forms;

namespace Proyecto_Pagos_Eventos.Clases
{
    class CrudServicios
    {
        public static void Alta(Comprobantes array)
        {
            try
            {
                Conexion.getInstance().Comprobantes.Add(array);
                Conexion.getInstance().SaveChanges();
                MessageBox.Show("El Comprobante fue agregado exitosamente", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static Object Consulta()
        {
            var tabla = Conexion.getInstance().Comprobantes.ToList();

            return tabla;
        }

        public static void Modificar(Comprobantes array)
        {
            try
            {
                Guid f = array.idComprobante;
                Comprobantes modificar = Conexion.getInstance().Comprobantes.Where(w => w.idComprobante == f).FirstOrDefault();
                modificar.monto = array.monto;
                modificar.pagado = array.pagado;
                modificar.activo = array.activo;
                modificar.fechaFinal = array.fechaFinal;
                modificar.fechaInicio = array.fechaInicio;
                modificar.idCliente = array.idCliente;
                modificar.idServicio = array.idServicio;
                modificar.idUsuario = array.idUsuario;
                Conexion.getInstance().SaveChanges();
                MessageBox.Show("El Comrobante fue modificado exitosamente", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static IEnumerable<Equipo> TraerEquipo()
        {
            var tabla = Conexion.getInstance().Equipo.Where(w => w.activo == true).ToList();

            return tabla;
        }
    }
}
