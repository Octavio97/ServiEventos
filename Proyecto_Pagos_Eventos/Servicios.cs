using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto_Pagos_Eventos.Clases;
using Proyecto_Pagos_Eventos.Models;

namespace Proyecto_Pagos_Eventos
{
    public partial class Servicios : Form
    {
        private int suma = 0;
        private Guid id, idS, idU, idC, idE;
        private Boolean activoPago, activo;

        public Servicios()
        {
            InitializeComponent();
        }

        private void Servicios_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: esta línea de código carga datos en la tabla 'equiposServDataSet.Equipo' Puede moverla o quitarla según sea necesario.
                this.equipoTableAdapter.Fill(this.equiposServDataSet.Equipo);

                cargarTabla();

                dgvServicios.Columns["idCliente"].Visible = false;
                dgvServicios.Columns["idUsuario"].Visible = false;

                DataGridViewButtonColumn bc = new DataGridViewButtonColumn();
                bc.Name = "document";
                bc.HeaderText = "PDF";
                bc.Text = "PDF";
                bc.UseColumnTextForButtonValue = true;
                bc.Width = 50;
                dgvServicios.Columns.Insert(13, bc);

                dgvEquiposA.Columns["check2"].ReadOnly = false;
                dgvEquiposA.Columns["tipoA"].ReadOnly = true;
                dgvEquiposA.Columns["descripcionA"].ReadOnly = true;
                dgvEquiposA.Columns["montoA"].ReadOnly = true;
                dgvEquiposA.DataSource = null;
                check2.TrueValue = true;
                check2.FalseValue = false;

                dgvEquiposD.Columns["check"].ReadOnly = false;
                dgvEquiposD.Columns["tipoD"].ReadOnly = true;
                dgvEquiposD.Columns["descripcionD"].ReadOnly = true;
                dgvEquiposD.Columns["montoD"].ReadOnly = true;
                check.TrueValue = true;
                check.FalseValue = false;

                var lista = Conexion.getInstance().Clientes.Select(s => new {
                    iCliente = s.idCliente,
                    nombre = s.nombre + " " + s.apellidos
                }).ToList();
                
                txtClientes.ValueMember = "iCliente";
                txtClientes.DisplayMember = "nombre";
                txtClientes.DataSource = lista;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearInterface();
        }

        private void btnGuardarServicio_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr = MessageBox.Show("¿Desea ingresar este comprobante?", "INFO", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);

                if (dr.Equals(DialogResult.Yes))
                {
                    if (txtMonto.Text != null &&
                        txtFi.Text != null &&
                        DateTime.Parse(txtFi.Text) <= DateTime.Parse(txtFf.Text) &&
                        txtFf.Text != null &&
                        (radioBnoActivo.Checked != false ||
                        radioBsiActivo.Checked != false) &&
                        (radioBnoPagado.Checked != false ||
                        radioBsiPagado.Checked != false))
                    {
                        if (id.Equals(Guid.Empty))
                        {
                            if (CrudServicios.verificarComprobante(Guid.Parse(txtClientes.SelectedValue.ToString()), Convert.ToDateTime(txtFi.Text), Convert.ToDateTime(txtFf.Text)).Equals(false))
                            {
                                int c1 = DateTime.Compare(DateTime.Parse(txtFi.Text), DateTime.Parse(DateTime.Today.ToShortDateString()));
                                int c2 = DateTime.Compare(DateTime.Parse(txtFf.Text), DateTime.Parse(DateTime.Today.ToShortDateString()));

                                if (c1 >= 0 && c2 >= 0)
                                {
                                    id = Guid.NewGuid();
                                    idS = Guid.NewGuid();
                                    idU = Conexion.usuario.idUsuario;
                                    idC = Guid.Parse(txtClientes.SelectedValue.ToString());
                                    
                                    foreach (DataGridViewRow item in dgvEquiposD.Rows)
                                    {
                                        if (item.Cells[0].Value.Equals(true))
                                        {
                                            CrudServicios.AltaServicio(new Servicio
                                            {
                                                idServicio = idS,
                                                idEquipo = Guid.Parse(item.Cells[1].Value.ToString())
                                            }, activo);
                                        }
                                    }

                                    Comprobantes newRecibo = new Comprobantes
                                    {
                                        idComprobante = id,
                                        idCliente = idC,
                                        idUsuario = idU,
                                        idServicio = idS,
                                        fechaInicio = Convert.ToDateTime(txtFi.Text),
                                        fechaFinal = Convert.ToDateTime(txtFf.Text),
                                        pagado = activoPago,
                                        activo = activo,
                                        monto = Convert.ToDecimal(txtMonto.Text)
                                    };
                                    CrudServicios.AltaComprobante(newRecibo);
                                    clearInterface();
                                    cargarTabla();
                                }
                                else
                                {
                                    MessageBox.Show("La fecha no es la correcta", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                MessageBox.Show("El comprobante ya ha sido creado, búscalo en la tabla debajo", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            foreach (DataGridViewRow item in dgvEquiposA.Rows)
                            {
                                if (!item.Cells[0].Value.Equals(true))
                                {
                                    CrudServicios.BajaServicio(Guid.Parse(item.Cells[1].Value.ToString()), idS);
                                }
                            }

                            foreach (DataGridViewRow item in dgvEquiposD.Rows)
                            {
                                if (item.Cells[0].Value.Equals(true))
                                {
                                    CrudServicios.AltaServicio(new Servicio
                                    {
                                        idServicio = idS,
                                        idEquipo = Guid.Parse(item.Cells[1].Value.ToString())
                                    }, activo);
                                }
                            }

                            Comprobantes recibo = new Comprobantes
                            {
                                idComprobante = id,
                                idCliente = idC,
                                idUsuario = idU,
                                idServicio = idS,
                                fechaInicio = Convert.ToDateTime(txtFi.Text),
                                fechaFinal = Convert.ToDateTime(txtFf.Text),
                                pagado = activoPago,
                                activo = activo,
                                monto = Convert.ToDecimal(txtMonto.Text)
                            };

                            CrudServicios.ModificarComprobante(recibo);
                            clearInterface();
                            cargarTabla();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ingrese o corrija los campos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message ,"ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void radioBsiPagado_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBsiPagado.Checked == true)
            {
                activoPago = true;
                radioBnoPagado.Checked = false;
            }
        }

        private void radioBnoPagado_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBnoPagado.Checked == true)
            {
                activoPago = false;
                radioBsiPagado.Checked = false;
            }
        }

        private void dgvEquiposD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                foreach (DataGridViewRow item in dgvEquiposD.Rows)
                {
                    if(item.Cells[0].Value == null)
                        item.Cells[0].Value = false;
                }

                if (dgvEquiposD.CurrentCell == dgvEquiposD.CurrentRow.Cells[0])
                {
                    DataGridViewCheckBoxCell cell = (DataGridViewCheckBoxCell)dgvEquiposD.CurrentRow.Cells[0];
                    if (cell.Value.Equals(true))
                    {
                        suma += Convert.ToInt32(dgvEquiposD.CurrentRow.Cells[5].Value);
                    }
                    else if (!cell.Value.Equals(true))
                    {
                        suma -= Convert.ToInt32(dgvEquiposD.CurrentRow.Cells[5].Value);
                    }
                }
                txtMonto.Text = suma.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvEquiposA_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvEquiposA.CurrentCell == dgvEquiposA.CurrentRow.Cells[0])
            {
                DataGridViewCheckBoxCell cell = (DataGridViewCheckBoxCell)dgvEquiposA.CurrentRow.Cells[0];
                if (cell.Value.Equals(true))
                {
                    suma += Convert.ToInt32(dgvEquiposA.CurrentRow.Cells[5].Value);
                }
                else if (!cell.Value.Equals(true))
                {
                    suma -= Convert.ToInt32(dgvEquiposA.CurrentRow.Cells[5].Value);
                }
            }
            txtMonto.Text = suma.ToString();
        }

        private void dgvEquiposD_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgvEquiposD.IsCurrentCellDirty)
            {
                dgvEquiposD.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void dgvEquiposA_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgvEquiposA.IsCurrentCellDirty)
            {
                dgvEquiposA.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void radioBsiActivo_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBsiActivo.Checked == true)
            {
                activo = true;
                radioBnoActivo.Checked = false;
            }
        }

        private void radioBnoActivo_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBnoActivo.Checked == true)
            {
                activo = false;
                radioBsiActivo.Checked = false;
            }
        }

        private void dgvServicios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var senderGrid = (DataGridView)sender;
                if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
                {
                    var i = Guid.Parse(dgvServicios.CurrentRow.Cells[1].Value.ToString());
                    var doc = Conexion.getInstance().Documentos.Where(w => w.idComprobante == i).FirstOrDefault();
                    string path = AppDomain.CurrentDomain.BaseDirectory;
                    string folder = path + "temp/";
                    string fullFilePath = folder + doc.nombre;

                    Directory.CreateDirectory(folder);
                    File.WriteAllBytes(fullFilePath, doc.pdf);
                    Process.Start(fullFilePath);
                    return;
                }

                if (id.Equals(Guid.Empty))
                {
                    id = Guid.Parse(dgvServicios.CurrentRow.Cells[1].Value.ToString());
                    idC = Guid.Parse(dgvServicios.CurrentRow.Cells[2].Value.ToString());
                    idS = Guid.Parse(dgvServicios.CurrentRow.Cells[8].Value.ToString());
                    idU = Guid.Parse(dgvServicios.CurrentRow.Cells[3].Value.ToString());
                    txtClientes.SelectedValue = idC;
                    txtFi.Text = dgvServicios.CurrentRow.Cells[9].Value.ToString();
                    txtFf.Text = dgvServicios.CurrentRow.Cells[10].Value.ToString();
                    //activo
                    if (Convert.ToBoolean(dgvServicios.CurrentRow.Cells[12].Value))
                    {
                        radioBsiActivo.Checked = true;
                        radioBnoActivo.Checked = false;
                    }
                    else
                    {
                        radioBsiActivo.Checked = false;
                        radioBnoActivo.Checked = true;
                    }
                    // pagado
                    if (Convert.ToBoolean(dgvServicios.CurrentRow.Cells[13].Value))
                    {
                        radioBsiPagado.Checked = true;
                        radioBnoPagado.Checked = false;
                    }
                    else
                    {
                        radioBsiPagado.Checked = false;
                        radioBnoPagado.Checked = true;
                    }
                    dgvEquiposA.DataSource = CrudServicios.TraerEquipoA(idS);
                    foreach (DataGridViewRow item in dgvEquiposA.Rows)
                    {
                        item.Cells[0].Value = true;
                        suma += Convert.ToInt32(item.Cells[5].Value);
                    }
                    foreach (DataGridViewRow item in dgvEquiposD.Rows)
                    {
                        item.Cells[0].Value = false;
                    }
                    dgvEquiposA.AutoResizeColumns();
                    txtMonto.Text = suma.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cargarTabla()
        {
            dgvServicios.DataSource = CrudServicios.Consulta();
            dgvEquiposD.DataSource = CrudServicios.TraerEquipoD();
            dgvServicios.AutoResizeColumns();
            dgvEquiposD.AutoResizeColumns();
        }
        
        private void clearInterface()
        {
            txtMonto.Text = "0";
            txtFi.Clear();
            txtFf.Clear();
            radioBnoActivo.Checked = false;
            radioBsiActivo.Checked = false;
            radioBsiPagado.Checked = false;
            radioBnoPagado.Checked = false;
            suma = 0;
            id = Guid.Empty;
            idS = Guid.Empty;
            idU = Guid.Empty;
            idC = Guid.Empty;
            idE = Guid.Empty;
            activo = false;
            activoPago = false;
            dgvEquiposA.DataSource = null;
            foreach (DataGridViewRow item in dgvEquiposD.Rows)
            {
                DataGridViewCheckBoxCell cell = (DataGridViewCheckBoxCell)dgvEquiposD.CurrentRow.Cells[0];
                item.Cells[0].Value = cell.FalseValue;
            }
        }
    }
}
