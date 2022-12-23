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
    public partial class formPago : Form
    {
        public formPago(decimal monto_total)
        {
            InitializeComponent();
            txtTotal.Text = monto_total.ToString();
        }

        private void formPago_Load(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtMoneda.Text))
            {
                txtCambio.Text = (Decimal.Parse(txtMoneda.Text) - Decimal.Parse(txtTotal.Text)).ToString();
                if (Decimal.Parse(txtMoneda.Text) < Decimal.Parse(txtTotal.Text))
                {
                    txtCambio.Text = "";
                }
                
            }


            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtMoneda.Text != "")
            {

            if (decimal.Parse(txtTotal.Text)>decimal.Parse(txtMoneda.Text))
            {
                MessageBox.Show("No es posible realizar eso");
            }
            else if (Decimal.Parse(txtMoneda.Text) < Decimal.Parse(txtTotal.Text))
            {
                MessageBox.Show("Debe introducir un monto valido");
            }

            else
            {
                AlmacenForms.AlimentosForm.payStatus = true;
                MessageBox.Show("Pago realizado!");
                this.Close();
            }

            }

        }

        private void txtMoneda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                //MessageBox.Show("No es válido", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
    }
}
