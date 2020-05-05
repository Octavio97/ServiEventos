namespace Proyecto_Pagos_Eventos
{
    partial class Servicios
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvEquipos = new System.Windows.Forms.DataGridView();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtFf = new System.Windows.Forms.MaskedTextBox();
            this.lblFF = new System.Windows.Forms.Label();
            this.txtFi = new System.Windows.Forms.MaskedTextBox();
            this.txtClientes = new System.Windows.Forms.ComboBox();
            this.radioBnoActivo = new System.Windows.Forms.RadioButton();
            this.radioBsiActivo = new System.Windows.Forms.RadioButton();
            this.lblActivo = new System.Windows.Forms.Label();
            this.radioBnoPagado = new System.Windows.Forms.RadioButton();
            this.radioBsiPagado = new System.Windows.Forms.RadioButton();
            this.lblPagado = new System.Windows.Forms.Label();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.lblMonto = new System.Windows.Forms.Label();
            this.lblFI = new System.Windows.Forms.Label();
            this.btnGuardarServicio = new System.Windows.Forms.Button();
            this.lblCliente = new System.Windows.Forms.Label();
            this.dgvServicios = new System.Windows.Forms.DataGridView();
            this.idComprobanteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idUsuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idServicioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.montoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pagadoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.activoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.fechaInicioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaFinalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comprobantesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.serviciosDataSet = new Proyecto_Pagos_Eventos.ServiciosDataSet();
            this.labelTexto = new System.Windows.Forms.Label();
            this.comprobantesTableAdapter = new Proyecto_Pagos_Eventos.ServiciosDataSetTableAdapters.ComprobantesTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquipos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServicios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comprobantesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviciosDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.Controls.Add(this.dgvEquipos);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.txtFf);
            this.panel1.Controls.Add(this.lblFF);
            this.panel1.Controls.Add(this.txtFi);
            this.panel1.Controls.Add(this.txtClientes);
            this.panel1.Controls.Add(this.radioBnoActivo);
            this.panel1.Controls.Add(this.radioBsiActivo);
            this.panel1.Controls.Add(this.lblActivo);
            this.panel1.Controls.Add(this.radioBnoPagado);
            this.panel1.Controls.Add(this.radioBsiPagado);
            this.panel1.Controls.Add(this.lblPagado);
            this.panel1.Controls.Add(this.txtMonto);
            this.panel1.Controls.Add(this.lblMonto);
            this.panel1.Controls.Add(this.lblFI);
            this.panel1.Controls.Add(this.btnGuardarServicio);
            this.panel1.Controls.Add(this.lblCliente);
            this.panel1.Location = new System.Drawing.Point(44, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(775, 292);
            this.panel1.TabIndex = 2;
            // 
            // dgvEquipos
            // 
            this.dgvEquipos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEquipos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEquipos.Location = new System.Drawing.Point(424, 19);
            this.dgvEquipos.Name = "dgvEquipos";
            this.dgvEquipos.Size = new System.Drawing.Size(328, 261);
            this.dgvEquipos.TabIndex = 11;
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
            this.btnClear.Location = new System.Drawing.Point(42, 240);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(250, 40);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "Limpiar";
            this.btnClear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClear.UseVisualStyleBackColor = false;
            // 
            // txtFf
            // 
            this.txtFf.Location = new System.Drawing.Point(328, 90);
            this.txtFf.Mask = "00/00/0000";
            this.txtFf.Name = "txtFf";
            this.txtFf.Size = new System.Drawing.Size(76, 20);
            this.txtFf.TabIndex = 4;
            this.txtFf.ValidatingType = typeof(System.DateTime);
            this.txtFf.TextChanged += new System.EventHandler(this.txtFi_TextChanged);
            // 
            // lblFF
            // 
            this.lblFF.AutoSize = true;
            this.lblFF.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFF.ForeColor = System.Drawing.Color.White;
            this.lblFF.Location = new System.Drawing.Point(230, 89);
            this.lblFF.Name = "lblFF";
            this.lblFF.Size = new System.Drawing.Size(92, 21);
            this.lblFF.TabIndex = 40;
            this.lblFF.Text = "Fecha final:";
            // 
            // txtFi
            // 
            this.txtFi.Location = new System.Drawing.Point(148, 90);
            this.txtFi.Mask = "00/00/0000";
            this.txtFi.Name = "txtFi";
            this.txtFi.Size = new System.Drawing.Size(76, 20);
            this.txtFi.TabIndex = 3;
            this.txtFi.ValidatingType = typeof(System.DateTime);
            this.txtFi.TextChanged += new System.EventHandler(this.txtFi_TextChanged);
            // 
            // txtClientes
            // 
            this.txtClientes.FormattingEnabled = true;
            this.txtClientes.Location = new System.Drawing.Point(133, 19);
            this.txtClientes.Name = "txtClientes";
            this.txtClientes.Size = new System.Drawing.Size(273, 21);
            this.txtClientes.TabIndex = 1;
            // 
            // radioBnoActivo
            // 
            this.radioBnoActivo.AutoSize = true;
            this.radioBnoActivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioBnoActivo.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBnoActivo.ForeColor = System.Drawing.Color.White;
            this.radioBnoActivo.Location = new System.Drawing.Point(191, 150);
            this.radioBnoActivo.Name = "radioBnoActivo";
            this.radioBnoActivo.Size = new System.Drawing.Size(49, 25);
            this.radioBnoActivo.TabIndex = 8;
            this.radioBnoActivo.TabStop = true;
            this.radioBnoActivo.Text = "No";
            this.radioBnoActivo.UseVisualStyleBackColor = true;
            // 
            // radioBsiActivo
            // 
            this.radioBsiActivo.AutoSize = true;
            this.radioBsiActivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioBsiActivo.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBsiActivo.ForeColor = System.Drawing.Color.White;
            this.radioBsiActivo.Location = new System.Drawing.Point(133, 150);
            this.radioBsiActivo.Name = "radioBsiActivo";
            this.radioBsiActivo.Size = new System.Drawing.Size(40, 25);
            this.radioBsiActivo.TabIndex = 7;
            this.radioBsiActivo.TabStop = true;
            this.radioBsiActivo.Text = "Si";
            this.radioBsiActivo.UseVisualStyleBackColor = true;
            // 
            // lblActivo
            // 
            this.lblActivo.AutoSize = true;
            this.lblActivo.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActivo.ForeColor = System.Drawing.Color.White;
            this.lblActivo.Location = new System.Drawing.Point(39, 150);
            this.lblActivo.Name = "lblActivo";
            this.lblActivo.Size = new System.Drawing.Size(61, 21);
            this.lblActivo.TabIndex = 34;
            this.lblActivo.Text = "Activo:";
            // 
            // radioBnoPagado
            // 
            this.radioBnoPagado.AutoSize = true;
            this.radioBnoPagado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioBnoPagado.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBnoPagado.ForeColor = System.Drawing.Color.White;
            this.radioBnoPagado.Location = new System.Drawing.Point(192, 120);
            this.radioBnoPagado.Name = "radioBnoPagado";
            this.radioBnoPagado.Size = new System.Drawing.Size(49, 25);
            this.radioBnoPagado.TabIndex = 6;
            this.radioBnoPagado.TabStop = true;
            this.radioBnoPagado.Text = "No";
            this.radioBnoPagado.UseVisualStyleBackColor = true;
            // 
            // radioBsiPagado
            // 
            this.radioBsiPagado.AutoSize = true;
            this.radioBsiPagado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioBsiPagado.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBsiPagado.ForeColor = System.Drawing.Color.White;
            this.radioBsiPagado.Location = new System.Drawing.Point(134, 120);
            this.radioBsiPagado.Name = "radioBsiPagado";
            this.radioBsiPagado.Size = new System.Drawing.Size(40, 25);
            this.radioBsiPagado.TabIndex = 5;
            this.radioBsiPagado.TabStop = true;
            this.radioBsiPagado.Text = "Si";
            this.radioBsiPagado.UseVisualStyleBackColor = true;
            // 
            // lblPagado
            // 
            this.lblPagado.AutoSize = true;
            this.lblPagado.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPagado.ForeColor = System.Drawing.Color.White;
            this.lblPagado.Location = new System.Drawing.Point(39, 120);
            this.lblPagado.Name = "lblPagado";
            this.lblPagado.Size = new System.Drawing.Size(69, 21);
            this.lblPagado.TabIndex = 31;
            this.lblPagado.Text = "Pagado:";
            // 
            // txtMonto
            // 
            this.txtMonto.Enabled = false;
            this.txtMonto.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMonto.Location = new System.Drawing.Point(134, 50);
            this.txtMonto.Multiline = true;
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(272, 28);
            this.txtMonto.TabIndex = 2;
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonto.ForeColor = System.Drawing.Color.White;
            this.lblMonto.Location = new System.Drawing.Point(38, 53);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(64, 21);
            this.lblMonto.TabIndex = 26;
            this.lblMonto.Text = "Monto:";
            // 
            // lblFI
            // 
            this.lblFI.AutoSize = true;
            this.lblFI.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFI.ForeColor = System.Drawing.Color.White;
            this.lblFI.Location = new System.Drawing.Point(39, 90);
            this.lblFI.Name = "lblFI";
            this.lblFI.Size = new System.Drawing.Size(103, 21);
            this.lblFI.TabIndex = 23;
            this.lblFI.Text = "Fecha inicial:";
            // 
            // btnGuardarServicio
            // 
            this.btnGuardarServicio.BackColor = System.Drawing.Color.OrangeRed;
            this.btnGuardarServicio.FlatAppearance.BorderSize = 0;
            this.btnGuardarServicio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OrangeRed;
            this.btnGuardarServicio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSalmon;
            this.btnGuardarServicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarServicio.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarServicio.ForeColor = System.Drawing.Color.White;
            this.btnGuardarServicio.Image = global::Proyecto_Pagos_Eventos.Properties.Resources.save;
            this.btnGuardarServicio.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardarServicio.Location = new System.Drawing.Point(43, 194);
            this.btnGuardarServicio.Name = "btnGuardarServicio";
            this.btnGuardarServicio.Size = new System.Drawing.Size(250, 40);
            this.btnGuardarServicio.TabIndex = 9;
            this.btnGuardarServicio.Text = "Guardar";
            this.btnGuardarServicio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardarServicio.UseVisualStyleBackColor = false;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.ForeColor = System.Drawing.Color.White;
            this.lblCliente.Location = new System.Drawing.Point(38, 19);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(65, 21);
            this.lblCliente.TabIndex = 0;
            this.lblCliente.Text = "Cliente:";
            // 
            // dgvServicios
            // 
            this.dgvServicios.AllowUserToDeleteRows = false;
            this.dgvServicios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvServicios.AutoGenerateColumns = false;
            this.dgvServicios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvServicios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idComprobanteDataGridViewTextBoxColumn,
            this.idClienteDataGridViewTextBoxColumn,
            this.idUsuarioDataGridViewTextBoxColumn,
            this.idServicioDataGridViewTextBoxColumn,
            this.montoDataGridViewTextBoxColumn,
            this.pagadoDataGridViewCheckBoxColumn,
            this.activoDataGridViewCheckBoxColumn,
            this.fechaInicioDataGridViewTextBoxColumn,
            this.fechaFinalDataGridViewTextBoxColumn});
            this.dgvServicios.DataSource = this.comprobantesBindingSource;
            this.dgvServicios.Location = new System.Drawing.Point(44, 350);
            this.dgvServicios.Name = "dgvServicios";
            this.dgvServicios.ReadOnly = true;
            this.dgvServicios.Size = new System.Drawing.Size(775, 213);
            this.dgvServicios.TabIndex = 12;
            // 
            // idComprobanteDataGridViewTextBoxColumn
            // 
            this.idComprobanteDataGridViewTextBoxColumn.DataPropertyName = "idComprobante";
            this.idComprobanteDataGridViewTextBoxColumn.HeaderText = "idComprobante";
            this.idComprobanteDataGridViewTextBoxColumn.Name = "idComprobanteDataGridViewTextBoxColumn";
            this.idComprobanteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idClienteDataGridViewTextBoxColumn
            // 
            this.idClienteDataGridViewTextBoxColumn.DataPropertyName = "idCliente";
            this.idClienteDataGridViewTextBoxColumn.HeaderText = "idCliente";
            this.idClienteDataGridViewTextBoxColumn.Name = "idClienteDataGridViewTextBoxColumn";
            this.idClienteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idUsuarioDataGridViewTextBoxColumn
            // 
            this.idUsuarioDataGridViewTextBoxColumn.DataPropertyName = "idUsuario";
            this.idUsuarioDataGridViewTextBoxColumn.HeaderText = "idUsuario";
            this.idUsuarioDataGridViewTextBoxColumn.Name = "idUsuarioDataGridViewTextBoxColumn";
            this.idUsuarioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idServicioDataGridViewTextBoxColumn
            // 
            this.idServicioDataGridViewTextBoxColumn.DataPropertyName = "idServicio";
            this.idServicioDataGridViewTextBoxColumn.HeaderText = "idServicio";
            this.idServicioDataGridViewTextBoxColumn.Name = "idServicioDataGridViewTextBoxColumn";
            this.idServicioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // montoDataGridViewTextBoxColumn
            // 
            this.montoDataGridViewTextBoxColumn.DataPropertyName = "monto";
            this.montoDataGridViewTextBoxColumn.HeaderText = "monto";
            this.montoDataGridViewTextBoxColumn.Name = "montoDataGridViewTextBoxColumn";
            this.montoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pagadoDataGridViewCheckBoxColumn
            // 
            this.pagadoDataGridViewCheckBoxColumn.DataPropertyName = "pagado";
            this.pagadoDataGridViewCheckBoxColumn.HeaderText = "pagado";
            this.pagadoDataGridViewCheckBoxColumn.Name = "pagadoDataGridViewCheckBoxColumn";
            this.pagadoDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // activoDataGridViewCheckBoxColumn
            // 
            this.activoDataGridViewCheckBoxColumn.DataPropertyName = "activo";
            this.activoDataGridViewCheckBoxColumn.HeaderText = "activo";
            this.activoDataGridViewCheckBoxColumn.Name = "activoDataGridViewCheckBoxColumn";
            this.activoDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // fechaInicioDataGridViewTextBoxColumn
            // 
            this.fechaInicioDataGridViewTextBoxColumn.DataPropertyName = "fechaInicio";
            this.fechaInicioDataGridViewTextBoxColumn.HeaderText = "fechaInicio";
            this.fechaInicioDataGridViewTextBoxColumn.Name = "fechaInicioDataGridViewTextBoxColumn";
            this.fechaInicioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaFinalDataGridViewTextBoxColumn
            // 
            this.fechaFinalDataGridViewTextBoxColumn.DataPropertyName = "fechaFinal";
            this.fechaFinalDataGridViewTextBoxColumn.HeaderText = "fechaFinal";
            this.fechaFinalDataGridViewTextBoxColumn.Name = "fechaFinalDataGridViewTextBoxColumn";
            this.fechaFinalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // comprobantesBindingSource
            // 
            this.comprobantesBindingSource.DataMember = "Comprobantes";
            this.comprobantesBindingSource.DataSource = this.serviciosDataSet;
            // 
            // serviciosDataSet
            // 
            this.serviciosDataSet.DataSetName = "ServiciosDataSet";
            this.serviciosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // labelTexto
            // 
            this.labelTexto.AutoSize = true;
            this.labelTexto.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTexto.ForeColor = System.Drawing.Color.White;
            this.labelTexto.Location = new System.Drawing.Point(40, 316);
            this.labelTexto.Name = "labelTexto";
            this.labelTexto.Size = new System.Drawing.Size(139, 21);
            this.labelTexto.TabIndex = 13;
            this.labelTexto.Text = "Lista de Servicios";
            // 
            // comprobantesTableAdapter
            // 
            this.comprobantesTableAdapter.ClearBeforeFill = true;
            // 
            // Servicios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(850, 575);
            this.Controls.Add(this.labelTexto);
            this.Controls.Add(this.dgvServicios);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Servicios";
            this.Text = "Servicios";
            this.Load += new System.EventHandler(this.Servicios_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquipos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServicios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comprobantesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviciosDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnGuardarServicio;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.DataGridView dgvServicios;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.Label lblFI;
        private System.Windows.Forms.RadioButton radioBnoPagado;
        private System.Windows.Forms.RadioButton radioBsiPagado;
        private System.Windows.Forms.Label lblPagado;
        private System.Windows.Forms.RadioButton radioBnoActivo;
        private System.Windows.Forms.RadioButton radioBsiActivo;
        private System.Windows.Forms.Label lblActivo;
        private System.Windows.Forms.Label lblFF;
        private System.Windows.Forms.MaskedTextBox txtFi;
        private System.Windows.Forms.ComboBox txtClientes;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.MaskedTextBox txtFf;
        private System.Windows.Forms.DataGridView dgvEquipos;
        private System.Windows.Forms.Label labelTexto;
        private ServiciosDataSet serviciosDataSet;
        private System.Windows.Forms.BindingSource comprobantesBindingSource;
        private ServiciosDataSetTableAdapters.ComprobantesTableAdapter comprobantesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idComprobanteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idUsuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idServicioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn montoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn pagadoDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn activoDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaInicioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaFinalDataGridViewTextBoxColumn;
    }
}