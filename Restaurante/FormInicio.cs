using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace AlmacenForms
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            abrirFormHija(new AlimentosForm());
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
        private void abrirFormHija(object formHija)
        {
            if (this.sonPanelContenedor.Controls.Count > 0)
            {
                this.sonPanelContenedor.Controls.RemoveAt(0);
            }
            Form fh = formHija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.sonPanelContenedor.Controls.Add(fh);
            this.sonPanelContenedor.Tag = fh;
            fh.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {

            Form inicioAdmin = new InicioAdmin();
            this.Hide();
            inicioAdmin.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            abrirFormHija(new AlimentosForm());
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Minimized;
            else if (WindowState == FormWindowState.Maximized)
                WindowState = FormWindowState.Minimized;
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else if (WindowState == FormWindowState.Maximized)
                WindowState = FormWindowState.Normal;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void sonPanelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            abrirFormHija(new VerPedido());
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnRegProv_Click(object sender, EventArgs e)
        {
            
        }
    }
}
