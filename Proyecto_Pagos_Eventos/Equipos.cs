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
        private Guid id;

        public Equipos()
        {
            InitializeComponent();
        }

        private void Equipo_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: esta línea de código carga datos en la tabla 'equiposDataSet.Equipo' Puede moverla o quitarla según sea necesario.
                this.equipoTableAdapter.Fill(this.equiposDataSet.Equipo);
                cargarTabla();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void clearInterface()
        {
            try
            {
                textBoxDesc.Clear();
                radioBno.Checked = false;
                radioBsi.Checked = false;
                id = Guid.Empty;
                txtMonto.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void cargarTabla()
        {
            try
            {
                dgvEquipos.AutoGenerateColumns = false;
                dgvEquipos.DataSource = CrudEquipos.Consulta();
                this.dgvEquipos.AutoResizeColumns();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                    if (textBoxDesc.Text != "" && (radioBno.Checked != false || radioBsi.Checked != false) && txtMonto.Text != ""  && textBoxTipo.Text != "")
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
            try
            {
                clearInterface();
                id = Guid.Parse(dgvEquipos.CurrentRow.Cells[0].Value.ToString());
                textBoxTipo.SelectedItem = dgvEquipos.CurrentRow.Cells[1].Value.ToString();
                textBoxDesc.Text = dgvEquipos.CurrentRow.Cells[2].Value.ToString();
                txtMonto.Text = dgvEquipos.CurrentRow.Cells[4].Value.ToString().ToString();

                if (dgvEquipos.CurrentRow.Cells[3].Value.Equals(true))
                {
                    radioBsi.Checked = true;
                }
                else
                {
                    radioBno.Checked = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
