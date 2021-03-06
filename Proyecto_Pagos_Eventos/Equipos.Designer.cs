﻿namespace Proyecto_Pagos_Eventos
{
    partial class Equipos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtMonto = new System.Windows.Forms.MaskedTextBox();
            this.lblMonto = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.radioBno = new System.Windows.Forms.RadioButton();
            this.radioBsi = new System.Windows.Forms.RadioButton();
            this.labelActivo = new System.Windows.Forms.Label();
            this.textBoxTipo = new System.Windows.Forms.ComboBox();
            this.btnGuardarEquipo = new System.Windows.Forms.Button();
            this.textBoxDesc = new System.Windows.Forms.TextBox();
            this.labelDescripcion = new System.Windows.Forms.Label();
            this.labelTipo = new System.Windows.Forms.Label();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.dgvEquipos = new System.Windows.Forms.DataGridView();
            this.idEquipoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.equipoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.equiposDataSet = new Proyecto_Pagos_Eventos.EquiposDataSet();
            this.labelTexto = new System.Windows.Forms.Label();
            this.equipoTableAdapter = new Proyecto_Pagos_Eventos.EquiposDataSetTableAdapters.EquipoTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquipos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equiposDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.Controls.Add(this.txtMonto);
            this.panel1.Controls.Add(this.lblMonto);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.radioBno);
            this.panel1.Controls.Add(this.radioBsi);
            this.panel1.Controls.Add(this.labelActivo);
            this.panel1.Controls.Add(this.textBoxTipo);
            this.panel1.Controls.Add(this.btnGuardarEquipo);
            this.panel1.Controls.Add(this.textBoxDesc);
            this.panel1.Controls.Add(this.labelDescripcion);
            this.panel1.Controls.Add(this.labelTipo);
            this.panel1.Location = new System.Drawing.Point(44, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(775, 259);
            this.panel1.TabIndex = 1;
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(494, 29);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(100, 20);
            this.txtMonto.TabIndex = 2;
            this.txtMonto.ValidatingType = typeof(int);
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonto.ForeColor = System.Drawing.Color.White;
            this.lblMonto.Location = new System.Drawing.Point(424, 28);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(64, 21);
            this.lblMonto.TabIndex = 28;
            this.lblMonto.Text = "Monto:";
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
            this.btnClear.Location = new System.Drawing.Point(548, 203);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(182, 40);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Limpiar";
            this.btnClear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // radioBno
            // 
            this.radioBno.AutoSize = true;
            this.radioBno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioBno.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBno.ForeColor = System.Drawing.Color.White;
            this.radioBno.Location = new System.Drawing.Point(186, 208);
            this.radioBno.Name = "radioBno";
            this.radioBno.Size = new System.Drawing.Size(49, 25);
            this.radioBno.TabIndex = 5;
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
            this.radioBsi.Location = new System.Drawing.Point(128, 208);
            this.radioBsi.Name = "radioBsi";
            this.radioBsi.Size = new System.Drawing.Size(40, 25);
            this.radioBsi.TabIndex = 4;
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
            this.labelActivo.Location = new System.Drawing.Point(52, 208);
            this.labelActivo.Name = "labelActivo";
            this.labelActivo.Size = new System.Drawing.Size(61, 21);
            this.labelActivo.TabIndex = 24;
            this.labelActivo.Text = "Activo:";
            // 
            // textBoxTipo
            // 
            this.textBoxTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.textBoxTipo.FormattingEnabled = true;
            this.textBoxTipo.Items.AddRange(new object[] {
            "Salon",
            "Mesa",
            "Silla",
            "Banquete",
            "Sonido"});
            this.textBoxTipo.Location = new System.Drawing.Point(128, 28);
            this.textBoxTipo.Name = "textBoxTipo";
            this.textBoxTipo.Size = new System.Drawing.Size(272, 21);
            this.textBoxTipo.TabIndex = 1;
            // 
            // btnGuardarEquipo
            // 
            this.btnGuardarEquipo.BackColor = System.Drawing.Color.OrangeRed;
            this.btnGuardarEquipo.FlatAppearance.BorderSize = 0;
            this.btnGuardarEquipo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OrangeRed;
            this.btnGuardarEquipo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSalmon;
            this.btnGuardarEquipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarEquipo.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarEquipo.ForeColor = System.Drawing.Color.White;
            this.btnGuardarEquipo.Image = global::Proyecto_Pagos_Eventos.Properties.Resources.save;
            this.btnGuardarEquipo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardarEquipo.Location = new System.Drawing.Point(351, 203);
            this.btnGuardarEquipo.Name = "btnGuardarEquipo";
            this.btnGuardarEquipo.Size = new System.Drawing.Size(182, 40);
            this.btnGuardarEquipo.TabIndex = 6;
            this.btnGuardarEquipo.Text = "Guardar";
            this.btnGuardarEquipo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardarEquipo.UseVisualStyleBackColor = false;
            this.btnGuardarEquipo.Click += new System.EventHandler(this.btnGuardarEquipo_Click);
            // 
            // textBoxDesc
            // 
            this.textBoxDesc.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDesc.Location = new System.Drawing.Point(128, 62);
            this.textBoxDesc.MaxLength = 200;
            this.textBoxDesc.Multiline = true;
            this.textBoxDesc.Name = "textBoxDesc";
            this.textBoxDesc.Size = new System.Drawing.Size(602, 135);
            this.textBoxDesc.TabIndex = 3;
            // 
            // labelDescripcion
            // 
            this.labelDescripcion.AutoSize = true;
            this.labelDescripcion.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescripcion.ForeColor = System.Drawing.Color.White;
            this.labelDescripcion.Location = new System.Drawing.Point(17, 62);
            this.labelDescripcion.Name = "labelDescripcion";
            this.labelDescripcion.Size = new System.Drawing.Size(100, 21);
            this.labelDescripcion.TabIndex = 2;
            this.labelDescripcion.Text = "Descripción:";
            // 
            // labelTipo
            // 
            this.labelTipo.AutoSize = true;
            this.labelTipo.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTipo.ForeColor = System.Drawing.Color.White;
            this.labelTipo.Location = new System.Drawing.Point(70, 25);
            this.labelTipo.Name = "labelTipo";
            this.labelTipo.Size = new System.Drawing.Size(47, 21);
            this.labelTipo.TabIndex = 0;
            this.labelTipo.Text = "Tipo:";
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(802, 320);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(17, 205);
            this.vScrollBar1.TabIndex = 3;
            // 
            // dgvEquipos
            // 
            this.dgvEquipos.AllowUserToAddRows = false;
            this.dgvEquipos.AllowUserToDeleteRows = false;
            this.dgvEquipos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEquipos.AutoGenerateColumns = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEquipos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvEquipos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEquipos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idEquipoDataGridViewTextBoxColumn,
            this.tipoDataGridViewTextBoxColumn,
            this.descripcionDataGridViewTextBoxColumn,
            this.activoDataGridViewCheckBoxColumn,
            this.dataGridViewTextBoxColumn1});
            this.dgvEquipos.DataSource = this.equipoBindingSource;
            this.dgvEquipos.Location = new System.Drawing.Point(44, 311);
            this.dgvEquipos.MultiSelect = false;
            this.dgvEquipos.Name = "dgvEquipos";
            this.dgvEquipos.ReadOnly = true;
            this.dgvEquipos.RowHeadersVisible = false;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvEquipos.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvEquipos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEquipos.Size = new System.Drawing.Size(775, 252);
            this.dgvEquipos.TabIndex = 8;
            this.dgvEquipos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEquipos_CellContentClick);
            // 
            // idEquipoDataGridViewTextBoxColumn
            // 
            this.idEquipoDataGridViewTextBoxColumn.DataPropertyName = "idEquipo";
            this.idEquipoDataGridViewTextBoxColumn.HeaderText = "idEquipo";
            this.idEquipoDataGridViewTextBoxColumn.Name = "idEquipoDataGridViewTextBoxColumn";
            this.idEquipoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tipoDataGridViewTextBoxColumn
            // 
            this.tipoDataGridViewTextBoxColumn.DataPropertyName = "tipo";
            this.tipoDataGridViewTextBoxColumn.HeaderText = "tipo";
            this.tipoDataGridViewTextBoxColumn.Name = "tipoDataGridViewTextBoxColumn";
            this.tipoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            this.descripcionDataGridViewTextBoxColumn.DataPropertyName = "descripcion";
            this.descripcionDataGridViewTextBoxColumn.HeaderText = "descripcion";
            this.descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            this.descripcionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // activoDataGridViewCheckBoxColumn
            // 
            this.activoDataGridViewCheckBoxColumn.DataPropertyName = "activo";
            this.activoDataGridViewCheckBoxColumn.HeaderText = "activo";
            this.activoDataGridViewCheckBoxColumn.Name = "activoDataGridViewCheckBoxColumn";
            this.activoDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "monto";
            this.dataGridViewTextBoxColumn1.HeaderText = "monto";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // equipoBindingSource
            // 
            this.equipoBindingSource.DataMember = "Equipo";
            this.equipoBindingSource.DataSource = this.equiposDataSet;
            // 
            // equiposDataSet
            // 
            this.equiposDataSet.DataSetName = "EquiposDataSet";
            this.equiposDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // labelTexto
            // 
            this.labelTexto.AutoSize = true;
            this.labelTexto.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTexto.ForeColor = System.Drawing.Color.White;
            this.labelTexto.Location = new System.Drawing.Point(40, 280);
            this.labelTexto.Name = "labelTexto";
            this.labelTexto.Size = new System.Drawing.Size(132, 21);
            this.labelTexto.TabIndex = 28;
            this.labelTexto.Text = "Lista de Equipos";
            // 
            // equipoTableAdapter
            // 
            this.equipoTableAdapter.ClearBeforeFill = true;
            // 
            // Equipos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(850, 575);
            this.Controls.Add(this.labelTexto);
            this.Controls.Add(this.dgvEquipos);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Equipos";
            this.Text = "Equipo";
            this.Load += new System.EventHandler(this.Equipo_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquipos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.equiposDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnGuardarEquipo;
        private System.Windows.Forms.TextBox textBoxDesc;
        private System.Windows.Forms.Label labelDescripcion;
        private System.Windows.Forms.Label labelTipo;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.DataGridView dgvEquipos;
        private System.Windows.Forms.ComboBox textBoxTipo;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.RadioButton radioBno;
        private System.Windows.Forms.RadioButton radioBsi;
        private System.Windows.Forms.Label labelActivo;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.MaskedTextBox txtMonto;
        private System.Windows.Forms.DataGridViewTextBoxColumn montoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label labelTexto;
        private EquiposDataSet equiposDataSet;
        private System.Windows.Forms.BindingSource equipoBindingSource;
        private EquiposDataSetTableAdapters.EquipoTableAdapter equipoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEquipoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn activoDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    }
}