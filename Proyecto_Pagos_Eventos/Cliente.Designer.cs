namespace Proyecto_Pagos_Eventos
{
    partial class Cliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClear = new System.Windows.Forms.Button();
            this.textBoxCel = new System.Windows.Forms.MaskedTextBox();
            this.textBoxTel = new System.Windows.Forms.MaskedTextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.radioBno = new System.Windows.Forms.RadioButton();
            this.radioBsi = new System.Windows.Forms.RadioButton();
            this.labelActivo = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxApe = new System.Windows.Forms.TextBox();
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelCel = new System.Windows.Forms.Label();
            this.labelTel = new System.Windows.Forms.Label();
            this.labelApellidos = new System.Windows.Forms.Label();
            this.labelNom = new System.Windows.Forms.Label();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.labelTexto = new System.Windows.Forms.Label();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientesDataSet = new Proyecto_Pagos_Eventos.ClientesDataSet();
            this.clientesTableAdapter = new Proyecto_Pagos_Eventos.ClientesDataSetTableAdapters.ClientesTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.textBoxCel);
            this.panel1.Controls.Add(this.textBoxTel);
            this.panel1.Controls.Add(this.btnGuardar);
            this.panel1.Controls.Add(this.radioBno);
            this.panel1.Controls.Add(this.radioBsi);
            this.panel1.Controls.Add(this.labelActivo);
            this.panel1.Controls.Add(this.textBoxEmail);
            this.panel1.Controls.Add(this.textBoxApe);
            this.panel1.Controls.Add(this.textBoxNom);
            this.panel1.Controls.Add(this.labelEmail);
            this.panel1.Controls.Add(this.labelCel);
            this.panel1.Controls.Add(this.labelTel);
            this.panel1.Controls.Add(this.labelApellidos);
            this.panel1.Controls.Add(this.labelNom);
            this.panel1.Location = new System.Drawing.Point(44, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(775, 259);
            this.panel1.TabIndex = 0;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.OrangeRed;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OrangeRed;
            this.btnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSalmon;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Image = global::Proyecto_Pagos_Eventos.Properties.Resources.delete;
            this.btnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClear.Location = new System.Drawing.Point(465, 115);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(250, 40);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Limpiar";
            this.btnClear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // textBoxCel
            // 
            this.textBoxCel.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCel.Location = new System.Drawing.Point(128, 165);
            this.textBoxCel.Mask = "(999)000-0000";
            this.textBoxCel.Name = "textBoxCel";
            this.textBoxCel.Size = new System.Drawing.Size(272, 29);
            this.textBoxCel.TabIndex = 3;
            // 
            // textBoxTel
            // 
            this.textBoxTel.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTel.Location = new System.Drawing.Point(128, 115);
            this.textBoxTel.Mask = "000-0000";
            this.textBoxTel.Name = "textBoxTel";
            this.textBoxTel.Size = new System.Drawing.Size(272, 29);
            this.textBoxTel.TabIndex = 2;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.OrangeRed;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OrangeRed;
            this.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSalmon;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Image = global::Proyecto_Pagos_Eventos.Properties.Resources.save;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.Location = new System.Drawing.Point(465, 67);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(250, 40);
            this.btnGuardar.TabIndex = 7;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // radioBno
            // 
            this.radioBno.AutoSize = true;
            this.radioBno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioBno.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBno.ForeColor = System.Drawing.Color.White;
            this.radioBno.Location = new System.Drawing.Point(621, 20);
            this.radioBno.Name = "radioBno";
            this.radioBno.Size = new System.Drawing.Size(49, 25);
            this.radioBno.TabIndex = 6;
            this.radioBno.TabStop = true;
            this.radioBno.Text = "No";
            this.radioBno.UseVisualStyleBackColor = true;
            this.radioBno.CheckedChanged += new System.EventHandler(this.radioBno_CheckedChanged);
            // 
            // radioBsi
            // 
            this.radioBsi.AutoSize = true;
            this.radioBsi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioBsi.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBsi.ForeColor = System.Drawing.Color.White;
            this.radioBsi.Location = new System.Drawing.Point(563, 20);
            this.radioBsi.Name = "radioBsi";
            this.radioBsi.Size = new System.Drawing.Size(40, 25);
            this.radioBsi.TabIndex = 5;
            this.radioBsi.TabStop = true;
            this.radioBsi.Text = "Si";
            this.radioBsi.UseVisualStyleBackColor = true;
            this.radioBsi.CheckedChanged += new System.EventHandler(this.radioBsi_CheckedChanged);
            // 
            // labelActivo
            // 
            this.labelActivo.AutoSize = true;
            this.labelActivo.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelActivo.ForeColor = System.Drawing.Color.White;
            this.labelActivo.Location = new System.Drawing.Point(487, 20);
            this.labelActivo.Name = "labelActivo";
            this.labelActivo.Size = new System.Drawing.Size(61, 21);
            this.labelActivo.TabIndex = 0;
            this.labelActivo.Text = "Activo:";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEmail.Location = new System.Drawing.Point(128, 215);
            this.textBoxEmail.Multiline = true;
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(272, 28);
            this.textBoxEmail.TabIndex = 4;
            // 
            // textBoxApe
            // 
            this.textBoxApe.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxApe.Location = new System.Drawing.Point(128, 67);
            this.textBoxApe.Multiline = true;
            this.textBoxApe.Name = "textBoxApe";
            this.textBoxApe.Size = new System.Drawing.Size(272, 28);
            this.textBoxApe.TabIndex = 1;
            // 
            // textBoxNom
            // 
            this.textBoxNom.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNom.Location = new System.Drawing.Point(128, 20);
            this.textBoxNom.Multiline = true;
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(272, 28);
            this.textBoxNom.TabIndex = 0;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.ForeColor = System.Drawing.Color.White;
            this.labelEmail.Location = new System.Drawing.Point(32, 215);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(48, 21);
            this.labelEmail.TabIndex = 0;
            this.labelEmail.Text = "Email";
            // 
            // labelCel
            // 
            this.labelCel.AutoSize = true;
            this.labelCel.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCel.ForeColor = System.Drawing.Color.White;
            this.labelCel.Location = new System.Drawing.Point(32, 165);
            this.labelCel.Name = "labelCel";
            this.labelCel.Size = new System.Drawing.Size(60, 21);
            this.labelCel.TabIndex = 0;
            this.labelCel.Text = "Celular";
            // 
            // labelTel
            // 
            this.labelTel.AutoSize = true;
            this.labelTel.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTel.ForeColor = System.Drawing.Color.White;
            this.labelTel.Location = new System.Drawing.Point(32, 115);
            this.labelTel.Name = "labelTel";
            this.labelTel.Size = new System.Drawing.Size(75, 21);
            this.labelTel.TabIndex = 0;
            this.labelTel.Text = "Telefono";
            // 
            // labelApellidos
            // 
            this.labelApellidos.AutoSize = true;
            this.labelApellidos.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelApellidos.ForeColor = System.Drawing.Color.White;
            this.labelApellidos.Location = new System.Drawing.Point(32, 67);
            this.labelApellidos.Name = "labelApellidos";
            this.labelApellidos.Size = new System.Drawing.Size(79, 21);
            this.labelApellidos.TabIndex = 0;
            this.labelApellidos.Text = "Apellidos";
            // 
            // labelNom
            // 
            this.labelNom.AutoSize = true;
            this.labelNom.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNom.ForeColor = System.Drawing.Color.White;
            this.labelNom.Location = new System.Drawing.Point(32, 24);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(71, 21);
            this.labelNom.TabIndex = 0;
            this.labelNom.Text = "Nombre";
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(802, 320);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(17, 205);
            this.vScrollBar1.TabIndex = 2;
            // 
            // labelTexto
            // 
            this.labelTexto.AutoSize = true;
            this.labelTexto.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTexto.ForeColor = System.Drawing.Color.White;
            this.labelTexto.Location = new System.Drawing.Point(40, 287);
            this.labelTexto.Name = "labelTexto";
            this.labelTexto.Size = new System.Drawing.Size(132, 21);
            this.labelTexto.TabIndex = 0;
            this.labelTexto.Text = "Lista de Clientes";
            // 
            // dgvClientes
            // 
            this.dgvClientes.AllowUserToAddRows = false;
            this.dgvClientes.AllowUserToDeleteRows = false;
            this.dgvClientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvClientes.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewCheckBoxColumn1});
            this.dgvClientes.DataSource = this.clientesBindingSource;
            this.dgvClientes.Location = new System.Drawing.Point(44, 320);
            this.dgvClientes.MultiSelect = false;
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClientes.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvClientes.RowHeadersVisible = false;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvClientes.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClientes.Size = new System.Drawing.Size(775, 232);
            this.dgvClientes.TabIndex = 9;
            this.dgvClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClientes_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "idCliente";
            this.dataGridViewTextBoxColumn1.HeaderText = "idCliente";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nombre";
            this.dataGridViewTextBoxColumn2.HeaderText = "nombre";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "apellidos";
            this.dataGridViewTextBoxColumn3.HeaderText = "apellidos";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "telefono";
            this.dataGridViewTextBoxColumn4.HeaderText = "telefono";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "celular";
            this.dataGridViewTextBoxColumn5.HeaderText = "celular";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "correo";
            this.dataGridViewTextBoxColumn6.HeaderText = "correo";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "activo";
            this.dataGridViewCheckBoxColumn1.HeaderText = "activo";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.ReadOnly = true;
            // 
            // clientesBindingSource
            // 
            this.clientesBindingSource.DataMember = "Clientes";
            this.clientesBindingSource.DataSource = this.clientesDataSet;
            // 
            // clientesDataSet
            // 
            this.clientesDataSet.DataSetName = "ClientesDataSet";
            this.clientesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientesTableAdapter
            // 
            this.clientesTableAdapter.ClearBeforeFill = true;
            // 
            // Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(850, 575);
            this.Controls.Add(this.dgvClientes);
            this.Controls.Add(this.labelTexto);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Cliente";
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.Clientes_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelNom;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelCel;
        private System.Windows.Forms.Label labelTel;
        private System.Windows.Forms.Label labelApellidos;
        private System.Windows.Forms.RadioButton radioBsi;
        private System.Windows.Forms.Label labelActivo;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxApe;
        private System.Windows.Forms.TextBox textBoxNom;
        private System.Windows.Forms.RadioButton radioBno;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.Label labelTexto;
        private System.Windows.Forms.MaskedTextBox textBoxTel;
        private System.Windows.Forms.MaskedTextBox textBoxCel;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn celularDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn correoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn activoDataGridViewCheckBoxColumn;
        private ClientesDataSet clientesDataSet;
        private System.Windows.Forms.BindingSource clientesBindingSource;
        private ClientesDataSetTableAdapters.ClientesTableAdapter clientesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
    }
}