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
            // TODO: esta línea de código carga datos en la tabla 'serviciosDataSet.Comprobantes' Puede moverla o quitarla según sea necesario.
            this.comprobantesTableAdapter.Fill(this.serviciosDataSet.Comprobantes);
            this.dgvServicios.AutoResizeColumns();
            cargarTabla();
        }

        private void cargarTabla()
        {
            dgvServicios.AutoGenerateColumns = false;
            dgvServicios.DataSource = CrudServicios.Consulta();
        }

        private void txtFi_TextChanged(object sender, EventArgs e)
        {
            CrudServicios.TraerEquipo(txtFi.Text, txtFf.Text);
        }
    }
}
