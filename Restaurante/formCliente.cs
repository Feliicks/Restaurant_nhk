using Negocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurante
{
    public partial class registrarCliente : Form
    {
        ConexionSQLN conn = new ConexionSQLN();
        public registrarCliente(string cod)
        {
            InitializeComponent();
            txtCodCliente.Text = cod;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //vlaida qyue los cmapos no esten vacios
            if (String.IsNullOrEmpty( txtNom.Text))
                MessageBox.Show("Debes llenar el nombre");
            else if (String.IsNullOrEmpty(txtCodCliente.Text))
                MessageBox.Show("Debes llenarl el codigo de cliente");
            else
            {
                conn.registrar_cliente(int.Parse(txtCodCliente.Text), txtNom.Text);
                MessageBox.Show("Se ha regisdtrado el cliente");
                this.Close();
            }
                
        }
    }
}
