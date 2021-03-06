﻿using System;
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
    public partial class Cliente : Form
    {
        private Boolean activo;
        EventosBDEntities crud = Conexion.getInstance();
        private Guid id;

        public Cliente()
        {
            InitializeComponent();
        }

        private void clearInterface()
        {
            textBoxNom.Clear();
            textBoxApe.Clear();
            textBoxTel.Clear();
            textBoxCel.Clear();
            textBoxEmail.Clear();
            radioBno.Checked = false;
            radioBsi.Checked = false;
            id = Guid.Empty;
        }

        private void cargarTabla()
        {
            dgvClientes.AutoGenerateColumns = false;
            dgvClientes.DataSource = CrudClientes.Consulta();
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

        private void Clientes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'clientesDataSet.Clientes' Puede moverla o quitarla según sea necesario.
            this.clientesTableAdapter.Fill(this.clientesDataSet.Clientes);
            this.dgvClientes.AutoResizeColumns();
            cargarTabla();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr = MessageBox.Show("¿Esta seguro de guardar al cliente " + textBoxNom.Text + " " + textBoxApe.Text + "?", "INFO", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);

                if (dr.Equals(DialogResult.Yes))
                {
                    if (textBoxNom.Text != "" &&
                    textBoxApe.Text != "" &&
                    textBoxTel.Text != "" &&
                    textBoxCel.Text != "" &&
                    textBoxEmail.Text != "" &&
                    (radioBno.Checked != false ||
                    radioBsi.Checked != false))
                    {
                        if (!id.Equals(Guid.Empty))
                        {
                            Clientes client = new Clientes
                                {
                                    idCliente = id,
                                    nombre = textBoxNom.Text,
                                    apellidos = textBoxApe.Text,
                                    telefono = textBoxTel.Text,
                                    celular = textBoxCel.Text,
                                    correo = textBoxEmail.Text,
                                    activo = activo
                            };

                            CrudClientes.Modificar(client);
                            clearInterface();
                            cargarTabla();
                        }
                        else
                        {
                            if (CrudClientes.VerificarClientes(textBoxTel.Text).Equals(false))
                            {
                                Clientes newClient = new Clientes
                                {
                                    idCliente = Guid.NewGuid(),
                                    nombre = textBoxNom.Text,
                                    apellidos = textBoxApe.Text,
                                    telefono = textBoxTel.Text,
                                    celular = textBoxCel.Text,
                                    correo = textBoxEmail.Text,
                                    activo = activo
                                };

                                CrudClientes.Alta(newClient);
                                clearInterface();
                                cargarTabla();        
                            }
                            else
                            {
                                MessageBox.Show("El cliente " + textBoxNom.Text + " " + textBoxApe.Text + "ya existe si quiere modificar solo seleccionelo en las tablas de abajo", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
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

        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            clearInterface();
            id = Guid.Parse(dgvClientes.CurrentRow.Cells[0].Value.ToString());
            textBoxNom.Text = dgvClientes.CurrentRow.Cells[1].Value.ToString();
            textBoxApe.Text = dgvClientes.CurrentRow.Cells[2].Value.ToString();
            textBoxTel.Text = dgvClientes.CurrentRow.Cells[3].Value.ToString();
            textBoxCel.Text = dgvClientes.CurrentRow.Cells[4].Value.ToString();
            textBoxEmail.Text = dgvClientes.CurrentRow.Cells[5].Value.ToString();
            if (dgvClientes.CurrentRow.Cells[6].Value.Equals(true))
            {
                radioBsi.Checked = true;
            }
            else
            {
                radioBno.Checked = true;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            try
            {
                id = Guid.Empty;
                clearInterface();
            }
            catch (Exception ex)
            {

            }
        }
    }
}
