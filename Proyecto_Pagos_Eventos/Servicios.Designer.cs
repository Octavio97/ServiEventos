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
            this.lblActual = new System.Windows.Forms.Label();
            this.lblDisponible = new System.Windows.Forms.Label();
            this.dgvEquiposA = new System.Windows.Forms.DataGridView();
            this.radioBnoActivo = new System.Windows.Forms.CheckBox();
            this.radioBsiActivo = new System.Windows.Forms.CheckBox();
            this.radioBnoPagado = new System.Windows.Forms.CheckBox();
            this.radioBsiPagado = new System.Windows.Forms.CheckBox();
            this.dgvEquiposD = new System.Windows.Forms.DataGridView();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtFf = new System.Windows.Forms.MaskedTextBox();
            this.lblFF = new System.Windows.Forms.Label();
            this.txtFi = new System.Windows.Forms.MaskedTextBox();
            this.txtClientes = new System.Windows.Forms.ComboBox();
            this.lblActivo = new System.Windows.Forms.Label();
            this.lblPagado = new System.Windows.Forms.Label();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.lblMonto = new System.Windows.Forms.Label();
            this.lblFI = new System.Windows.Forms.Label();
            this.btnGuardarServicio = new System.Windows.Forms.Button();
            this.lblCliente = new System.Windows.Forms.Label();
            this.dgvServicios = new System.Windows.Forms.DataGridView();
            this.comprobantesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.serviciosDataSet = new Proyecto_Pagos_Eventos.ServiciosDataSet();
            this.labelTexto = new System.Windows.Forms.Label();
            this.comprobantesTableAdapter = new Proyecto_Pagos_Eventos.ServiciosDataSetTableAdapters.ComprobantesTableAdapter();
            this.equiposServDataSet = new Proyecto_Pagos_Eventos.EquiposServDataSet();
            this.equipoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.equipoTableAdapter = new Proyecto_Pagos_Eventos.EquiposServDataSetTableAdapters.EquipoTableAdapter();
            this.check = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.idEquipoD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activoD = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.montoD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.check2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.idEquipoA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activoA = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.montoA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquiposA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquiposD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServicios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comprobantesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviciosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equiposServDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.Controls.Add(this.lblActual);
            this.panel1.Controls.Add(this.lblDisponible);
            this.panel1.Controls.Add(this.dgvEquiposA);
            this.panel1.Controls.Add(this.radioBnoActivo);
            this.panel1.Controls.Add(this.radioBsiActivo);
            this.panel1.Controls.Add(this.radioBnoPagado);
            this.panel1.Controls.Add(this.radioBsiPagado);
            this.panel1.Controls.Add(this.dgvEquiposD);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.txtFf);
            this.panel1.Controls.Add(this.lblFF);
            this.panel1.Controls.Add(this.txtFi);
            this.panel1.Controls.Add(this.txtClientes);
            this.panel1.Controls.Add(this.lblActivo);
            this.panel1.Controls.Add(this.lblPagado);
            this.panel1.Controls.Add(this.txtMonto);
            this.panel1.Controls.Add(this.lblMonto);
            this.panel1.Controls.Add(this.lblFI);
            this.panel1.Controls.Add(this.btnGuardarServicio);
            this.panel1.Controls.Add(this.lblCliente);
            this.panel1.Location = new System.Drawing.Point(44, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(775, 301);
            this.panel1.TabIndex = 2;
            // 
            // lblActual
            // 
            this.lblActual.AutoSize = true;
            this.lblActual.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActual.ForeColor = System.Drawing.Color.White;
            this.lblActual.Location = new System.Drawing.Point(386, 89);
            this.lblActual.Name = "lblActual";
            this.lblActual.Size = new System.Drawing.Size(137, 21);
            this.lblActual.TabIndex = 43;
            this.lblActual.Text = "Equipos actuales:";
            // 
            // lblDisponible
            // 
            this.lblDisponible.AutoSize = true;
            this.lblDisponible.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisponible.ForeColor = System.Drawing.Color.White;
            this.lblDisponible.Location = new System.Drawing.Point(16, 89);
            this.lblDisponible.Name = "lblDisponible";
            this.lblDisponible.Size = new System.Drawing.Size(162, 21);
            this.lblDisponible.TabIndex = 42;
            this.lblDisponible.Text = "Equipos disponibles:";
            // 
            // dgvEquiposA
            // 
            this.dgvEquiposA.AllowUserToAddRows = false;
            this.dgvEquiposA.AllowUserToDeleteRows = false;
            this.dgvEquiposA.AutoGenerateColumns = false;
            this.dgvEquiposA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEquiposA.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.check2,
            this.idEquipoA,
            this.tipoA,
            this.descripcionA,
            this.activoA,
            this.montoA});
            this.dgvEquiposA.DataSource = this.equipoBindingSource;
            this.dgvEquiposA.Location = new System.Drawing.Point(390, 113);
            this.dgvEquiposA.Name = "dgvEquiposA";
            this.dgvEquiposA.RowHeadersVisible = false;
            this.dgvEquiposA.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEquiposA.Size = new System.Drawing.Size(364, 130);
            this.dgvEquiposA.TabIndex = 41;
            this.dgvEquiposA.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEquiposA_CellContentClick);
            this.dgvEquiposA.CurrentCellDirtyStateChanged += new System.EventHandler(this.dgvEquiposA_CurrentCellDirtyStateChanged);
            // 
            // radioBnoActivo
            // 
            this.radioBnoActivo.AutoSize = true;
            this.radioBnoActivo.Font = new System.Drawing.Font("Malgun Gothic", 12F);
            this.radioBnoActivo.ForeColor = System.Drawing.Color.White;
            this.radioBnoActivo.Location = new System.Drawing.Point(509, 50);
            this.radioBnoActivo.Name = "radioBnoActivo";
            this.radioBnoActivo.Size = new System.Drawing.Size(51, 25);
            this.radioBnoActivo.TabIndex = 8;
            this.radioBnoActivo.Text = "No";
            this.radioBnoActivo.UseVisualStyleBackColor = true;
            this.radioBnoActivo.CheckedChanged += new System.EventHandler(this.radioBnoActivo_CheckedChanged);
            // 
            // radioBsiActivo
            // 
            this.radioBsiActivo.AutoSize = true;
            this.radioBsiActivo.Font = new System.Drawing.Font("Malgun Gothic", 12F);
            this.radioBsiActivo.ForeColor = System.Drawing.Color.White;
            this.radioBsiActivo.Location = new System.Drawing.Point(461, 50);
            this.radioBsiActivo.Name = "radioBsiActivo";
            this.radioBsiActivo.Size = new System.Drawing.Size(42, 25);
            this.radioBsiActivo.TabIndex = 7;
            this.radioBsiActivo.Text = "Si";
            this.radioBsiActivo.UseVisualStyleBackColor = true;
            this.radioBsiActivo.CheckedChanged += new System.EventHandler(this.radioBsiActivo_CheckedChanged);
            // 
            // radioBnoPagado
            // 
            this.radioBnoPagado.AutoSize = true;
            this.radioBnoPagado.Font = new System.Drawing.Font("Malgun Gothic", 12F);
            this.radioBnoPagado.ForeColor = System.Drawing.Color.White;
            this.radioBnoPagado.Location = new System.Drawing.Point(689, 50);
            this.radioBnoPagado.Name = "radioBnoPagado";
            this.radioBnoPagado.Size = new System.Drawing.Size(51, 25);
            this.radioBnoPagado.TabIndex = 6;
            this.radioBnoPagado.Text = "No";
            this.radioBnoPagado.UseVisualStyleBackColor = true;
            this.radioBnoPagado.CheckedChanged += new System.EventHandler(this.radioBnoPagado_CheckedChanged);
            // 
            // radioBsiPagado
            // 
            this.radioBsiPagado.AutoSize = true;
            this.radioBsiPagado.Font = new System.Drawing.Font("Malgun Gothic", 12F);
            this.radioBsiPagado.ForeColor = System.Drawing.Color.White;
            this.radioBsiPagado.Location = new System.Drawing.Point(641, 50);
            this.radioBsiPagado.Name = "radioBsiPagado";
            this.radioBsiPagado.Size = new System.Drawing.Size(42, 25);
            this.radioBsiPagado.TabIndex = 5;
            this.radioBsiPagado.Text = "Si";
            this.radioBsiPagado.UseVisualStyleBackColor = true;
            this.radioBsiPagado.CheckedChanged += new System.EventHandler(this.radioBsiPagado_CheckedChanged);
            // 
            // dgvEquiposD
            // 
            this.dgvEquiposD.AllowUserToAddRows = false;
            this.dgvEquiposD.AllowUserToDeleteRows = false;
            this.dgvEquiposD.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEquiposD.AutoGenerateColumns = false;
            this.dgvEquiposD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEquiposD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.check,
            this.idEquipoD,
            this.tipoD,
            this.descripcionD,
            this.activoD,
            this.montoD});
            this.dgvEquiposD.DataSource = this.equipoBindingSource;
            this.dgvEquiposD.Location = new System.Drawing.Point(20, 113);
            this.dgvEquiposD.MultiSelect = false;
            this.dgvEquiposD.Name = "dgvEquiposD";
            this.dgvEquiposD.RowHeadersVisible = false;
            this.dgvEquiposD.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEquiposD.Size = new System.Drawing.Size(364, 130);
            this.dgvEquiposD.TabIndex = 11;
            this.dgvEquiposD.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEquiposD_CellContentClick);
            this.dgvEquiposD.CurrentCellDirtyStateChanged += new System.EventHandler(this.dgvEquiposD_CurrentCellDirtyStateChanged);
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
            this.btnClear.Location = new System.Drawing.Point(404, 249);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(250, 40);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "Limpiar";
            this.btnClear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtFf
            // 
            this.txtFf.Location = new System.Drawing.Point(298, 50);
            this.txtFf.Mask = "00/00/0000";
            this.txtFf.Name = "txtFf";
            this.txtFf.Size = new System.Drawing.Size(76, 20);
            this.txtFf.TabIndex = 4;
            this.txtFf.ValidatingType = typeof(System.DateTime);
            // 
            // lblFF
            // 
            this.lblFF.AutoSize = true;
            this.lblFF.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFF.ForeColor = System.Drawing.Color.White;
            this.lblFF.Location = new System.Drawing.Point(200, 49);
            this.lblFF.Name = "lblFF";
            this.lblFF.Size = new System.Drawing.Size(92, 21);
            this.lblFF.TabIndex = 40;
            this.lblFF.Text = "Fecha final:";
            // 
            // txtFi
            // 
            this.txtFi.Location = new System.Drawing.Point(118, 50);
            this.txtFi.Mask = "00/00/0000";
            this.txtFi.Name = "txtFi";
            this.txtFi.Size = new System.Drawing.Size(76, 20);
            this.txtFi.TabIndex = 3;
            this.txtFi.ValidatingType = typeof(System.DateTime);
            // 
            // txtClientes
            // 
            this.txtClientes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtClientes.FormattingEnabled = true;
            this.txtClientes.Location = new System.Drawing.Point(104, 19);
            this.txtClientes.Name = "txtClientes";
            this.txtClientes.Size = new System.Drawing.Size(273, 21);
            this.txtClientes.TabIndex = 1;
            // 
            // lblActivo
            // 
            this.lblActivo.AutoSize = true;
            this.lblActivo.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActivo.ForeColor = System.Drawing.Color.White;
            this.lblActivo.Location = new System.Drawing.Point(386, 50);
            this.lblActivo.Name = "lblActivo";
            this.lblActivo.Size = new System.Drawing.Size(61, 21);
            this.lblActivo.TabIndex = 34;
            this.lblActivo.Text = "Activo:";
            // 
            // lblPagado
            // 
            this.lblPagado.AutoSize = true;
            this.lblPagado.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPagado.ForeColor = System.Drawing.Color.White;
            this.lblPagado.Location = new System.Drawing.Point(566, 50);
            this.lblPagado.Name = "lblPagado";
            this.lblPagado.Size = new System.Drawing.Size(69, 21);
            this.lblPagado.TabIndex = 31;
            this.lblPagado.Text = "Pagado:";
            // 
            // txtMonto
            // 
            this.txtMonto.Enabled = false;
            this.txtMonto.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMonto.Location = new System.Drawing.Point(479, 16);
            this.txtMonto.Multiline = true;
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(272, 28);
            this.txtMonto.TabIndex = 2;
            this.txtMonto.Text = "0";
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonto.ForeColor = System.Drawing.Color.White;
            this.lblMonto.Location = new System.Drawing.Point(383, 19);
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
            this.lblFI.Location = new System.Drawing.Point(9, 50);
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
            this.btnGuardarServicio.Location = new System.Drawing.Point(118, 249);
            this.btnGuardarServicio.Name = "btnGuardarServicio";
            this.btnGuardarServicio.Size = new System.Drawing.Size(250, 40);
            this.btnGuardarServicio.TabIndex = 9;
            this.btnGuardarServicio.Text = "Guardar";
            this.btnGuardarServicio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardarServicio.UseVisualStyleBackColor = false;
            this.btnGuardarServicio.Click += new System.EventHandler(this.btnGuardarServicio_Click);
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.ForeColor = System.Drawing.Color.White;
            this.lblCliente.Location = new System.Drawing.Point(9, 19);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(65, 21);
            this.lblCliente.TabIndex = 0;
            this.lblCliente.Text = "Cliente:";
            // 
            // dgvServicios
            // 
            this.dgvServicios.AllowUserToAddRows = false;
            this.dgvServicios.AllowUserToDeleteRows = false;
            this.dgvServicios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvServicios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvServicios.Location = new System.Drawing.Point(44, 350);
            this.dgvServicios.MultiSelect = false;
            this.dgvServicios.Name = "dgvServicios";
            this.dgvServicios.ReadOnly = true;
            this.dgvServicios.RowHeadersVisible = false;
            this.dgvServicios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvServicios.Size = new System.Drawing.Size(775, 213);
            this.dgvServicios.TabIndex = 12;
            this.dgvServicios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvServicios_CellContentClick);
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
            this.labelTexto.Location = new System.Drawing.Point(40, 326);
            this.labelTexto.Name = "labelTexto";
            this.labelTexto.Size = new System.Drawing.Size(139, 21);
            this.labelTexto.TabIndex = 13;
            this.labelTexto.Text = "Lista de Servicios";
            // 
            // comprobantesTableAdapter
            // 
            this.comprobantesTableAdapter.ClearBeforeFill = true;
            // 
            // equiposServDataSet
            // 
            this.equiposServDataSet.DataSetName = "EquiposServDataSet";
            this.equiposServDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // equipoBindingSource
            // 
            this.equipoBindingSource.DataMember = "Equipo";
            this.equipoBindingSource.DataSource = this.equiposServDataSet;
            // 
            // equipoTableAdapter
            // 
            this.equipoTableAdapter.ClearBeforeFill = true;
            // 
            // check
            // 
            this.check.FalseValue = "";
            this.check.HeaderText = "";
            this.check.Name = "check";
            this.check.ReadOnly = true;
            this.check.TrueValue = "";
            this.check.Width = 50;
            // 
            // idEquipoD
            // 
            this.idEquipoD.DataPropertyName = "idEquipo";
            this.idEquipoD.HeaderText = "idEquipo";
            this.idEquipoD.Name = "idEquipoD";
            this.idEquipoD.Visible = false;
            // 
            // tipoD
            // 
            this.tipoD.DataPropertyName = "tipo";
            this.tipoD.HeaderText = "tipo";
            this.tipoD.Name = "tipoD";
            // 
            // descripcionD
            // 
            this.descripcionD.DataPropertyName = "descripcion";
            this.descripcionD.HeaderText = "descripcion";
            this.descripcionD.Name = "descripcionD";
            // 
            // activoD
            // 
            this.activoD.DataPropertyName = "activo";
            this.activoD.HeaderText = "activo";
            this.activoD.Name = "activoD";
            this.activoD.Visible = false;
            // 
            // montoD
            // 
            this.montoD.DataPropertyName = "monto";
            this.montoD.HeaderText = "monto";
            this.montoD.Name = "montoD";
            // 
            // check2
            // 
            this.check2.HeaderText = "";
            this.check2.Name = "check2";
            this.check2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.check2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.check2.Width = 50;
            // 
            // idEquipoA
            // 
            this.idEquipoA.DataPropertyName = "idEquipo";
            this.idEquipoA.HeaderText = "idEquipo";
            this.idEquipoA.Name = "idEquipoA";
            this.idEquipoA.Visible = false;
            // 
            // tipoA
            // 
            this.tipoA.DataPropertyName = "tipo";
            this.tipoA.HeaderText = "tipo";
            this.tipoA.Name = "tipoA";
            // 
            // descripcionA
            // 
            this.descripcionA.DataPropertyName = "descripcion";
            this.descripcionA.HeaderText = "descripcion";
            this.descripcionA.Name = "descripcionA";
            // 
            // activoA
            // 
            this.activoA.DataPropertyName = "activo";
            this.activoA.HeaderText = "activo";
            this.activoA.Name = "activoA";
            this.activoA.Visible = false;
            // 
            // montoA
            // 
            this.montoA.DataPropertyName = "monto";
            this.montoA.HeaderText = "monto";
            this.montoA.Name = "montoA";
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquiposA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquiposD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServicios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comprobantesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviciosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.equiposServDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipoBindingSource)).EndInit();
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
        private System.Windows.Forms.Label lblPagado;
        private System.Windows.Forms.Label lblActivo;
        private System.Windows.Forms.Label lblFF;
        private System.Windows.Forms.MaskedTextBox txtFi;
        private System.Windows.Forms.ComboBox txtClientes;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.MaskedTextBox txtFf;
        private System.Windows.Forms.DataGridView dgvEquiposD;
        private System.Windows.Forms.Label labelTexto;
        private ServiciosDataSet serviciosDataSet;
        private System.Windows.Forms.BindingSource comprobantesBindingSource;
        private ServiciosDataSetTableAdapters.ComprobantesTableAdapter comprobantesTableAdapter;
        private System.Windows.Forms.CheckBox radioBnoActivo;
        private System.Windows.Forms.CheckBox radioBsiActivo;
        private System.Windows.Forms.CheckBox radioBnoPagado;
        private System.Windows.Forms.CheckBox radioBsiPagado;
        private System.Windows.Forms.Label lblActual;
        private System.Windows.Forms.Label lblDisponible;
        private System.Windows.Forms.DataGridView dgvEquiposA;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEquipoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn activoDataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn montoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEquipoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn activoDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn montoDataGridViewTextBoxColumn;
        private EquiposServDataSet equiposServDataSet;
        private System.Windows.Forms.BindingSource equipoBindingSource;
        private EquiposServDataSetTableAdapters.EquipoTableAdapter equipoTableAdapter;
        private System.Windows.Forms.DataGridViewCheckBoxColumn check2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEquipoA;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoA;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionA;
        private System.Windows.Forms.DataGridViewCheckBoxColumn activoA;
        private System.Windows.Forms.DataGridViewTextBoxColumn montoA;
        private System.Windows.Forms.DataGridViewCheckBoxColumn check;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEquipoD;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoD;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionD;
        private System.Windows.Forms.DataGridViewCheckBoxColumn activoD;
        private System.Windows.Forms.DataGridViewTextBoxColumn montoD;
    }
}