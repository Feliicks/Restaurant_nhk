using Negocios;
using System.Windows.Forms;

namespace AlmacenForms
{
    
    public partial class VerPedido : Form
    {
        ConexionSQLN cn = new ConexionSQLN();
        public VerPedido()
        {
            InitializeComponent();
        }

        private void VerPedido_Load(object sender, System.EventArgs e)
        {
            lblTotal.Text ="0.00";
            lblCliente.Text = "";
        }

        private void btnBuscar_Click(object sender, System.EventArgs e)
        {

            if (txtNOrden.Text!="")
            {
                var resultX = cn.consulta_nom_cliente(txtNOrden.Text);
                dgvDetalleOrden.DataSource = cn.ver_orden(int.Parse(txtNOrden.Text));
                if (dgvDetalleOrden.Rows.Count == 0)
                {
                    MessageBox.Show("La orden no existe!");
                    lblTotal.Text = "0.00";
                    lblCliente.Text = "";
                }
                else
                {
                    lblTotal.Text = cn.get_total_pedido(int.Parse(txtNOrden.Text)).ToString();
                    lblCliente.Text = resultX.Item1;
                }
            

            }
            else
                MessageBox.Show("Debe introducir un codigo!");

        }

        private void txtNOrden_KeyPress(object sender, KeyPressEventArgs e)
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
