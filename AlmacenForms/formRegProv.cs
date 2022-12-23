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

namespace AlmacenForms
{
    
    public partial class formRegProv : Form
    {
        ConexionSQLN cn = new ConexionSQLN();
        public formRegProv()
        {
            InitializeComponent();
        }

        private void formRegProv_Load(object sender, EventArgs e)
        {
            dgvProveedor.DataSource = cn.get_proveedor();
            //dgvProveedor.AutoGenerateColumns = true;
        }

        private void dgvProveedor_SelectionChanged(object sender, EventArgs e)
        {
            int selectionIndex = dgvProveedor .CurrentRow.Index;

            txtIdPro.Enabled = false;
            txtNom.Enabled = false;
            txtNit.Enabled = false;
            txtIdPro.Text = dgvProveedor.Rows[selectionIndex].Cells[0].Value.ToString();
            txtNom .Text = dgvProveedor.Rows[selectionIndex].Cells[2].Value.ToString();
            txtNit.Text = dgvProveedor.Rows[selectionIndex].Cells[1].Value.ToString();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtIdPro.Enabled = false;
            txtNom.Enabled = false;
            txtNit.Enabled = false;
            btnGuardarEdit.Visible = false;
            btnRegProv.Visible = false;
            txtNom.Text = "";
            txtNit.Text = "";
            txtIdPro.Text = "";
        }

        private void btnCrearNuevo_Click(object sender, EventArgs e)
        {
            txtIdPro.Enabled = false;
            txtNom.Enabled = true;
            txtNit.Enabled = true;
            txtIdPro.Text = (cn.get_last_Id_proveedor() + 1).ToString();
            txtNom.Text = "";
            txtNit.Text = "";
            btnRegProv.Visible = true;

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            btnGuardarEdit.Visible = true;
            btnRegProv.Visible = false;
            txtNit.Enabled = true;
            txtNom.Enabled = true;
        }

        private void btnRegProv_Click(object sender, EventArgs e)
        {
            if (txtNit.Text == "" && txtNom.Text == "")
                MessageBox.Show("Debes llenarlos campos");
            else
            {
                MessageBox.Show("Proveedor registrado correctamente");
                cn.reg_prov(int.Parse(txtNit.Text), txtNom.Text);
                dgvProveedor.DataSource = cn.get_proveedor();
                txtNom.Text = "";
                txtNit.Text = "";
                btnRegProv.Visible = false;
            }
                

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txtNit.Text != "" && txtNom.Text != "")
            {
                MessageBox.Show("Se ha eliminado el proveedor");
                cn.del_prov(int.Parse(txtIdPro.Text), txtNom.Text);
                dgvProveedor.DataSource = cn.get_proveedor();
                txtNom.Text = "";
                txtNit.Text = "";
            }
            else
            {
                MessageBox.Show("Debes seleccionar un proveedor");
            }

        }

        private void btnGuardarEdit_Click(object sender, EventArgs e)
        {
            //cn.modificar_proveedor(int.Parse(txtNit.Text), txtNom.Text,  int.Parse(txtIdPro.Text));
            if (txtIdPro.Text =="" || txtNit.Text=="" || txtNom.Text=="")
            {
                MessageBox.Show("Debe seleccionar un proveedor");
            }
            else
            {
                cn.modificar_proveedor(int.Parse(txtIdPro.Text), txtNom.Text, int.Parse(txtNit.Text));
                MessageBox.Show("Se ha modificado el proveedor");
                dgvProveedor.DataSource = cn.get_proveedor();
                txtNom.Text = "";
                txtNit.Text = "";
                btnGuardarEdit.Visible = false;
            }

        }

        private void txtNit_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNit_KeyPress(object sender, KeyPressEventArgs e)
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
