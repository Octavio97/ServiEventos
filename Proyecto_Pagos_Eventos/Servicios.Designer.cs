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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnGuardarServicio = new System.Windows.Forms.Button();
            this.textBoxServ = new System.Windows.Forms.TextBox();
            this.labelServicio = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonEliminarEquipo = new System.Windows.Forms.Button();
            this.buttonEditarEquipo = new System.Windows.Forms.Button();
            this.Id_Equipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Servicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.Controls.Add(this.btnGuardarServicio);
            this.panel1.Controls.Add(this.textBoxServ);
            this.panel1.Controls.Add(this.labelServicio);
            this.panel1.Location = new System.Drawing.Point(44, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(775, 259);
            this.panel1.TabIndex = 2;
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
            this.btnGuardarServicio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardarServicio.Location = new System.Drawing.Point(479, 26);
            this.btnGuardarServicio.Name = "btnGuardarServicio";
            this.btnGuardarServicio.Size = new System.Drawing.Size(250, 40);
            this.btnGuardarServicio.TabIndex = 22;
            this.btnGuardarServicio.Text = "Guardar";
            this.btnGuardarServicio.UseVisualStyleBackColor = false;
            // 
            // textBoxServ
            // 
            this.textBoxServ.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxServ.Location = new System.Drawing.Point(134, 26);
            this.textBoxServ.Multiline = true;
            this.textBoxServ.Name = "textBoxServ";
            this.textBoxServ.Size = new System.Drawing.Size(272, 28);
            this.textBoxServ.TabIndex = 5;
            // 
            // labelServicio
            // 
            this.labelServicio.AutoSize = true;
            this.labelServicio.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelServicio.ForeColor = System.Drawing.Color.White;
            this.labelServicio.Location = new System.Drawing.Point(38, 30);
            this.labelServicio.Name = "labelServicio";
            this.labelServicio.Size = new System.Drawing.Size(68, 21);
            this.labelServicio.TabIndex = 0;
            this.labelServicio.Text = "Servicio";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_Equipo,
            this.Servicio});
            this.dataGridView1.Location = new System.Drawing.Point(44, 320);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(775, 205);
            this.dataGridView1.TabIndex = 4;
            // 
            // buttonEliminarEquipo
            // 
            this.buttonEliminarEquipo.BackColor = System.Drawing.Color.OrangeRed;
            this.buttonEliminarEquipo.FlatAppearance.BorderSize = 0;
            this.buttonEliminarEquipo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OrangeRed;
            this.buttonEliminarEquipo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSalmon;
            this.buttonEliminarEquipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEliminarEquipo.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEliminarEquipo.ForeColor = System.Drawing.Color.White;
            this.buttonEliminarEquipo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEliminarEquipo.Location = new System.Drawing.Point(178, 531);
            this.buttonEliminarEquipo.Name = "buttonEliminarEquipo";
            this.buttonEliminarEquipo.Size = new System.Drawing.Size(128, 32);
            this.buttonEliminarEquipo.TabIndex = 30;
            this.buttonEliminarEquipo.Text = "Eliminar";
            this.buttonEliminarEquipo.UseVisualStyleBackColor = false;
            // 
            // buttonEditarEquipo
            // 
            this.buttonEditarEquipo.BackColor = System.Drawing.Color.OrangeRed;
            this.buttonEditarEquipo.FlatAppearance.BorderSize = 0;
            this.buttonEditarEquipo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OrangeRed;
            this.buttonEditarEquipo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSalmon;
            this.buttonEditarEquipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEditarEquipo.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditarEquipo.ForeColor = System.Drawing.Color.White;
            this.buttonEditarEquipo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEditarEquipo.Location = new System.Drawing.Point(44, 531);
            this.buttonEditarEquipo.Name = "buttonEditarEquipo";
            this.buttonEditarEquipo.Size = new System.Drawing.Size(128, 32);
            this.buttonEditarEquipo.TabIndex = 29;
            this.buttonEditarEquipo.Text = "Editar";
            this.buttonEditarEquipo.UseVisualStyleBackColor = false;
            // 
            // Id_Equipo
            // 
            this.Id_Equipo.HeaderText = "Id_Equipo";
            this.Id_Equipo.Name = "Id_Equipo";
            this.Id_Equipo.ReadOnly = true;
            // 
            // Servicio
            // 
            this.Servicio.HeaderText = "Servicio";
            this.Servicio.Name = "Servicio";
            this.Servicio.ReadOnly = true;
            // 
            // Servicios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(850, 575);
            this.Controls.Add(this.buttonEliminarEquipo);
            this.Controls.Add(this.buttonEditarEquipo);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Servicios";
            this.Text = "Servicios";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnGuardarServicio;
        private System.Windows.Forms.TextBox textBoxServ;
        private System.Windows.Forms.Label labelServicio;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonEliminarEquipo;
        private System.Windows.Forms.Button buttonEditarEquipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Equipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Servicio;
    }
}