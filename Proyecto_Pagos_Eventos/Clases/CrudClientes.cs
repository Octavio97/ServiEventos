using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using Proyecto_Pagos_Eventos.Models;
using Proyecto_Pagos_Eventos.Clases;

namespace Proyecto_Pagos_Eventos.Clases
{
    class CrudClientes
    {
        public static void Alta(Clientes array)
        {
            try
            {
                Conexion.getInstance().Clientes.Add(array);
                Conexion.getInstance().SaveChanges();
                MessageBox.Show("El cliente " + array.nombre + " " + array.apellidos + " fue agregado exitosamente", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static Object Consulta()
        {
            var tabla = Conexion.getInstance().Clientes.ToList();

            return tabla;
        }

        public static void Modificar(Clientes array)
        {
            try
            {
                Guid f = array.idCliente;
                Clientes modificar = Conexion.getInstance().Clientes.Where(w => w.idCliente == f).FirstOrDefault();
                modificar.idCliente = array.idCliente;
                modificar.nombre = array.nombre;
                modificar.apellidos = array.apellidos;
                modificar.telefono = array.telefono;
                modificar.celular = array.celular;
                modificar.correo = array.correo;
                modificar.activo = array.activo;
                Conexion.getInstance().SaveChanges();
                MessageBox.Show("El cliente " + array.nombre + " " + array.apellidos + " fue modificado exitosamente", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static bool VerificarClientes(string tel)
        {
            bool i = true;

            var verClientes = Conexion.getInstance().Clientes.Where(w => w.telefono == tel).FirstOrDefault();

            if (verClientes != null)
            {
                i = true;
            }
            else
            {
                i = false;
            }

            return i;
        }
    }
}
