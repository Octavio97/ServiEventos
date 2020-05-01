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
using Proyecto_Pagos_Eventos.Models;

namespace Proyecto_Pagos_Eventos
{
    public partial class Equipos : Form
    {
        private Boolean activo;
        EventosBDEntities crud = Conexion.getInstance();
        private Guid id;

        public Equipos()
        {
            InitializeComponent();
        }

        private void Equipo_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'equiposDataSet.Equipo' Puede moverla o quitarla según sea necesario.
            this.equipoTableAdapter.Fill(this.equiposDataSet.Equipo);
            cargarTabla();
        }

        private void clearInterface()
        {
            textBoxDesc.Clear();
            radioBno.Checked = false;
            radioBsi.Checked = false;
            txtMonto.Clear();
        }

        private void cargarTabla()
        {
            dgvEquipos.AutoGenerateColumns = false;
            dgvEquipos.DataSource = CrudEquipos.Consulta();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearInterface();
        }

        private void btnGuardarEquipo_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr = MessageBox.Show("¿Esta seguro de guardar el equipo?", "INFO", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);

                if (dr.Equals(DialogResult.Yes))
                {
                    if (textBoxDesc.Text != null && radioBno.Checked != false && txtMonto.Text != null || radioBsi.Checked != false)
                    {
                        if (id != Guid.Empty)
                        {
                            Equipo equipo = new Equipo
                            {
                                idEquipo = id,
                                tipo = textBoxTipo.SelectedItem.ToString(),
                                descripcion = textBoxDesc.Text,
                                activo = activo,
                                monto = Convert.ToDecimal(txtMonto.Text)
                            };

                            CrudEquipos.Modificar(equipo);
                            clearInterface();
                            cargarTabla();
                        }
                        else
                        {
                            Equipo newEquipo = new Equipo
                            {
                                idEquipo = Guid.NewGuid(),
                                tipo = textBoxTipo.SelectedItem.ToString(),
                                descripcion = textBoxDesc.Text,
                                activo = activo,
                                monto = Convert.ToDecimal(txtMonto.Text)
                            };

                            CrudEquipos.Alta(newEquipo);
                            clearInterface();
                            cargarTabla();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ingrese los campos faltantes", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void radioBsi_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBsi.Checked == true)
            {
                activo = true;
            }
        }

        private void radioBno_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBno.Checked == true)
            {
                activo = false;
            }
        }

        private void dgvEquipos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            clearInterface();
            id = Guid.Parse(dgvEquipos.CurrentRow.Cells[0].Value.ToString());
            textBoxTipo.SelectedItem = dgvEquipos.CurrentRow.Cells[1].Value.ToString();
            textBoxDesc.Text = dgvEquipos.CurrentRow.Cells[2].Value.ToString();
            txtMonto.Text = dgvEquipos.CurrentRow.Cells[3].Value.ToString();

            if (dgvEquipos.CurrentRow.Cells[4].Value.Equals(true))
            {
                radioBsi.Checked = true;
            }
            else
            {
                radioBno.Checked = true;
            }
        }
    }
}
