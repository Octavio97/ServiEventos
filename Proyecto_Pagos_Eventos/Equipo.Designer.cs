namespace Proyecto_Pagos_Eventos
{
    partial class Equipo
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
            this.btnGuardarEquipo = new System.Windows.Forms.Button();
            this.textBoxTel = new System.Windows.Forms.TextBox();
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.labelDescripcion = new System.Windows.Forms.Label();
            this.labelTipo = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Id_Equipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.buttonEliminarEquipo = new System.Windows.Forms.Button();
            this.buttonEditarEquipo = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.Controls.Add(this.btnGuardarEquipo);
            this.panel1.Controls.Add(this.textBoxTel);
            this.panel1.Controls.Add(this.textBoxNom);
            this.panel1.Controls.Add(this.labelDescripcion);
            this.panel1.Controls.Add(this.labelTipo);
            this.panel1.Location = new System.Drawing.Point(44, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(775, 259);
            this.panel1.TabIndex = 1;
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
            this.btnGuardarEquipo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardarEquipo.Location = new System.Drawing.Point(479, 26);
            this.btnGuardarEquipo.Name = "btnGuardarEquipo";
            this.btnGuardarEquipo.Size = new System.Drawing.Size(250, 40);
            this.btnGuardarEquipo.TabIndex = 22;
            this.btnGuardarEquipo.Text = "Guardar";
            this.btnGuardarEquipo.UseVisualStyleBackColor = false;
            // 
            // textBoxTel
            // 
            this.textBoxTel.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTel.Location = new System.Drawing.Point(127, 107);
            this.textBoxTel.Multiline = true;
            this.textBoxTel.Name = "textBoxTel";
            this.textBoxTel.Size = new System.Drawing.Size(602, 135);
            this.textBoxTel.TabIndex = 7;
            // 
            // textBoxNom
            // 
            this.textBoxNom.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNom.Location = new System.Drawing.Point(127, 32);
            this.textBoxNom.Multiline = true;
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(272, 28);
            this.textBoxNom.TabIndex = 5;
            // 
            // labelDescripcion
            // 
            this.labelDescripcion.AutoSize = true;
            this.labelDescripcion.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescripcion.ForeColor = System.Drawing.Color.White;
            this.labelDescripcion.Location = new System.Drawing.Point(31, 110);
            this.labelDescripcion.Name = "labelDescripcion";
            this.labelDescripcion.Size = new System.Drawing.Size(96, 21);
            this.labelDescripcion.TabIndex = 2;
            this.labelDescripcion.Text = "Descripcion";
            // 
            // labelTipo
            // 
            this.labelTipo.AutoSize = true;
            this.labelTipo.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTipo.ForeColor = System.Drawing.Color.White;
            this.labelTipo.Location = new System.Drawing.Point(31, 36);
            this.labelTipo.Name = "labelTipo";
            this.labelTipo.Size = new System.Drawing.Size(43, 21);
            this.labelTipo.TabIndex = 0;
            this.labelTipo.Text = "Tipo";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_Equipo,
            this.Tipo,
            this.Descripcion});
            this.dataGridView1.Location = new System.Drawing.Point(44, 320);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(775, 205);
            this.dataGridView1.TabIndex = 2;
            // 
            // Id_Equipo
            // 
            this.Id_Equipo.HeaderText = "Id_Equipo";
            this.Id_Equipo.Name = "Id_Equipo";
            this.Id_Equipo.ReadOnly = true;
            // 
            // Tipo
            // 
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            this.Tipo.ReadOnly = true;
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(802, 320);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(17, 205);
            this.vScrollBar1.TabIndex = 3;
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
            this.buttonEliminarEquipo.TabIndex = 26;
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
            this.buttonEditarEquipo.TabIndex = 25;
            this.buttonEditarEquipo.Text = "Editar";
            this.buttonEditarEquipo.UseVisualStyleBackColor = false;
            // 
            // Equipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(850, 575);
            this.Controls.Add(this.buttonEliminarEquipo);
            this.Controls.Add(this.buttonEditarEquipo);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Equipo";
            this.Text = "Equipo";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnGuardarEquipo;
        private System.Windows.Forms.TextBox textBoxTel;
        private System.Windows.Forms.TextBox textBoxNom;
        private System.Windows.Forms.Label labelDescripcion;
        private System.Windows.Forms.Label labelTipo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Equipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.Button buttonEliminarEquipo;
        private System.Windows.Forms.Button buttonEditarEquipo;
    }
}