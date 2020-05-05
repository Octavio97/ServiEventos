using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Proyecto_Pagos_Eventos
{
    public partial class WFormsMenu : Form
    {
        private bool screen = true;
        public WFormsMenu()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea cerrar la Aplicación?", "Cerrar Aplicacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        int lx, ly;

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            if (screen.Equals(true))
            {
                this.WindowState = FormWindowState.Maximized;
                screen = false;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                screen = true;
            }
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Menu_Load(object sender, EventArgs e)
        {
           // Para comenzar con la interfaz con la opcion de inicio //
            button1_Click(null, e);
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Cliente());
        }

        private void btnServicio_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Servicios());
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelHora.Text = DateTime.Now.ToLongTimeString();
            labelFecha.Text = DateTime.Now.ToLongDateString();
        }

        private void labelFecha_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Inicio());
        }

        private void panel_Inicio_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void PanelTitulo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("¿Desea cerrar la sesion?", "Cerrar sesion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();
                Login Login = new Login();
                Login.Show();
            }
           
        }

        private void btnComprobante_Click(object sender, EventArgs e)
        {

        }

        private void btnEquipo_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Equipos());
        }

        // Metodo para llamar windowsform a panel contenedor //
        private void AbrirFormEnPanel(object Formhijo)
        { if (this.panel_Contenedor.Controls.Count > 0)
             this.panel_Contenedor.Controls.RemoveAt(0);
             Form fh = Formhijo as Form; fh.TopLevel = false;
             fh.Dock = DockStyle.Fill; this.panel_Contenedor.Controls.Add(fh);
             this.panel_Contenedor.Tag = fh; fh.Show(); 
        }

    }
}
