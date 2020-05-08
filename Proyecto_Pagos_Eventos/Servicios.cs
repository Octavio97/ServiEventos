using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto_Pagos_Eventos.Clases;

namespace Proyecto_Pagos_Eventos
{
    public partial class Servicios : Form
    {
        public Servicios()
        {
            InitializeComponent();
        }

        private void Servicios_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'equipoServiciosDataSet.Equipo' Puede moverla o quitarla según sea necesario.
            this.equipoTableAdapter.Fill(this.equipoServiciosDataSet.Equipo);
            this.dgvServicios.AutoResizeColumns();
            this.dgvEquipos.AutoResizeColumns();
            this.dgvEquiposServicio.AutoResizeColumns();
            cargarTabla();

            var lista = Conexion.getInstance().Clientes.ToList();

            txtClientes.DataSource = lista;
            txtClientes.DisplayMember = "nombre";
            txtClientes.ValueMember = "idCliente";
        }

        private void cargarTabla()
        {
            dgvServicios.AutoGenerateColumns = false;
            dgvServicios.DataSource = CrudServicios.Consulta();
            dgvEquipos.DataSource = CrudServicios.TraerEquipo();
        }
        
        private void clearInterface()
        {
            txtMonto.Clear();
            txtFi.Clear();
            txtFf.Clear();
            radioBnoActivo.Checked = false;
            radioBsiActivo.Checked = false;
            radioBsiPagado.Checked = false;
            radioBnoPagado.Checked = false;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearInterface();
        }

        private void dgvEquipos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.dgvEquiposServicio.AutoResizeColumns();
            dgvEquiposServicio.Rows.Add(dgvEquipos.CurrentRow.Cells[0].Value,
                                        dgvEquipos.CurrentRow.Cells[1].Value,
                                        dgvEquipos.CurrentRow.Cells[2].Value);
        }

        private void dgvEquiposServicio_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.dgvEquiposServicio.AutoResizeColumns();
            dgvEquiposServicio.Rows.Remove(dgvEquiposServicio.CurrentRow);
        }
    }
}
