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
        public static void AltaComprobante(Comprobantes array)
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
            var tabla = Conexion.getInstance().Clientes
                .Join(
                    Conexion.getInstance().Comprobantes,
                    cl => cl.idCliente,
                    c => c.idCliente,
                    (cl, c) => new { cl, c }
                )
                .Join(
                    Conexion.getInstance().Servicio,
                    clc => clc.c.idServicio,
                    s => s.idServicio,
                    (clc, s) => new { clc, s }
                )
                .Join(
                    Conexion.getInstance().Equipo,
                    clcs => clcs.s.idEquipo,
                    e => e.idEquipo,
                    (clcs, e) => new
                    {
                        e,
                        clcs
                    }
                )
                .Join(
                    Conexion.getInstance().Usuarios,
                    clcse => clcse.clcs.clc.c.idUsuario,
                    u => u.idUsuario,
                    (clcse, u) => new
                    { clcse, u }
                ).GroupBy(g => new {
                    g.clcse.clcs.clc.c.idCliente,
                    g.clcse.clcs.clc.c.idComprobante,
                    g.clcse.clcs.clc.c.idUsuario,
                    g.clcse.clcs.clc.c.idServicio,
                    g.clcse.clcs.clc.c.monto,
                    g.clcse.clcs.clc.c.pagado,
                    g.clcse.clcs.clc.c.activo,
                    g.clcse.clcs.clc.c.fechaInicio,
                    g.clcse.clcs.clc.c.fechaFinal,
                    g.clcse.clcs.clc.cl.nombre,
                    g.clcse.clcs.clc.cl.apellidos,
                    g.clcse.clcs.clc.cl.celular,
                    g.clcse.clcs.clc.cl.correo,
                    g.clcse.clcs.clc.cl.telefono,
                    g.u.usuario
                }).Select(s => new {
                    idComprobante = s.Key.idComprobante,
                    idCliente = s.Key.idCliente,
                    idUsuario = s.Key.idUsuario,
                    cliente = s.Key.nombre + " " + s.Key.apellidos,
                    telefono = s.Key.telefono,
                    celular = s.Key.celular,
                    correo = s.Key.correo,
                    Servicio = s.Key.idServicio,
                    fechaInicio = s.Key.fechaInicio,
                    fechaFinal = s.Key.fechaFinal,
                    monto = s.Key.monto,
                    activo = s.Key.activo,
                    pagado = s.Key.pagado
                }).ToList();
            return tabla;
        }

        public static void ModificarComprobante(Comprobantes array)
        {
            try
            {
                if (!Conexion.getInstance().Servicio.Where(w => w.idServicio == array.idServicio).Equals(true))
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static IEnumerable<Equipo> TraerEquipoD()
        {
            var tabla = Conexion.getInstance().Equipo.Where(w => w.activo == true).ToList();

            return tabla;
        }   

        public static Object TraerEquipoA(Guid id)
        {
            var tabla = (from s in Conexion.getInstance().Servicio
                         join e in Conexion.getInstance().Equipo on s.idEquipo equals e.idEquipo
                         where s.idServicio == id 
                         select new
                         {
                             idEquipo = e.idEquipo,
                             tipo = e.tipo,
                             descripcion = e.descripcion,
                             activo = e.activo,
                             monto = e.monto
                         }).ToList();

            return tabla;
        }

        public static bool verificarComprobante(Guid cliente, DateTime fi, DateTime ff)
        {
            bool i = false;

            var tabla = Conexion.getInstance().Comprobantes.Where(w => w.fechaInicio == fi && w.fechaFinal == ff && w.idCliente == cliente).FirstOrDefault();

            if (tabla != null)
            {
                i = true;
            }
            else
            {
                i = false;
            }

            return i;
        }

        public static void AltaServicio(Servicio array, bool activoCompr)
        {
            try
            {

                Conexion.getInstance().Servicio.Add(array);

                if (activoCompr)
                {
                    Equipo mod = Conexion.getInstance().Equipo.Where(w => w.idEquipo == array.idEquipo).FirstOrDefault();
                    mod.activo = false;
                }
                Conexion.getInstance().SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void BajaServicio(Guid idE, Guid idS)
        {
            try
            {
                var registro = Conexion.getInstance().Servicio.Where(w => w.idEquipo == idE && w.idServicio == idS).FirstOrDefault();
                Conexion.getInstance().Servicio.Remove(registro);
                var equipo = Conexion.getInstance().Equipo.Where(w => w.idEquipo == idE).FirstOrDefault();
                equipo.activo = true;
                Conexion.getInstance().SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
