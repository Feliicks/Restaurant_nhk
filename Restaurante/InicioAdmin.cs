using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace AlmacenForms
{
    public partial class InicioAdmin : Form
    {

        public InicioAdmin()
        {
            InitializeComponent();
        }

        private void InicioAdmin_Load(object sender, EventArgs e)
        {
            /*string conexion = "server=localhost;port=3306;uid=root;pwd='';database=RESTAURANTE2";
            MySqlConnection conn = new MySqlConnection(conexion);
            try
            {
                conn.Open();
                MessageBox.Show("Conectado Correctamente");
                conn.Close();
            }
            catch
            {
                MessageBox.Show("Error de conecion");
            }*/

            //this.panelContenedor.Location = new System.Drawing.Point(0, 80);

        }
        private void abrirFormHija(object formHija)
        {
            if (this.z.Controls.Count > 0)
            {
                this.z.Controls.RemoveAt(0);
            }
            Form fh = formHija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.z.Controls.Add(fh);
            this.z.Tag = fh;
            fh.Show();

        }
        private void button9_Click(object sender, EventArgs e)
        {
            abrirFormHija(new crudProductos());
            //this.Hide();
            //crudProductos.Show();

        }

        private void button13_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();

        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {

            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Minimized;
            else if (WindowState == FormWindowState.Maximized)
                WindowState = FormWindowState.Minimized;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else if (WindowState == FormWindowState.Maximized)
                WindowState = FormWindowState.Normal;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            abrirFormHija(new AlimentosForm());
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form Forminicio = new mainForm();
            this.Hide();
            Forminicio.Show();
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

        private void btnInsumos_Click(object sender, EventArgs e)
        {
            abrirFormHija(new crudInsumos());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            abrirFormHija(new VerPedido());
        }
    }
}
