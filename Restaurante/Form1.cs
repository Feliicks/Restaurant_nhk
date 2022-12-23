using System;
using System.Windows.Forms;

namespace AlmacenForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OrdenForm ventana = new OrdenForm();
            ventana.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 ventana = new Form2();
            ventana.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            VerPedido ventana = new VerPedido();
            ventana.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 ventana = new Form4();
            ventana.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }
}

