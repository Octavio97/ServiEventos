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
        public static void Alta(Servicio array)
        {
            try
            {
                Conexion.getInstance().Servicio.Add(array);
                Conexion.getInstance().SaveChanges();
                MessageBox.Show("El servicio fue agregado exitosamente", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        public static void Modificar(Servicio array)
        {
            try
            {
                Guid f = array.idServicio;
                Servicio modificar = Conexion.getInstance().Servicio.Where(w => w.idServicio == f).FirstOrDefault();
                modificar.idServicio = array.idServicio;
                modificar.idEquipo = array.idEquipo;
                Conexion.getInstance().SaveChanges();
                MessageBox.Show("El servicio " + array.idServicio + " fue modificado exitosamente", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static IEnumerable<Equipo> TraerEquipo(string fi, string ff)
        {
            return (
                from e in Conexion.getInstance().Equipo
                join s in Conexion.getInstance().Servicio
                on e.idEquipo equals s.idEquipo
                join c in Conexion.getInstance().Comprobantes
                on s.idServicio equals c.idServicio
                where c.fechaInicio != DateTime.Today
                select new Equipo()
                {
                    idEquipo = e.idEquipo,
                    tipo = e.tipo,
                    descripcion = e.descripcion,
                    monto = e.monto,
                    activo = e.activo
                }
                ).ToList();
        }
    }
}
