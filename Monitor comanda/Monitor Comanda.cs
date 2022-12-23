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

namespace Monitor_comanda
{
    public partial class Form1 : Form
    {
        ConexionSQLN cn = new ConexionSQLN();
        public Form1()
        {
            InitializeComponent();

           // dgv1.Columns.Add(dgc2);
            //dgv1.Columns.Add(dgc3);
            //dgv1.Columns[0].Width = 60;
            //dgv1.Columns[1].Width = 150;
            //dgv1.Columns[2].Width = 60;





        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int last_orden = cn.consulta_lat_orden_preparando();
            DataGridViewColumn dgc1 = new DataGridViewColumn();
            dgc1.HeaderText = "cantidad";
            dgc1.Name = "cantidad";
            DataGridViewColumn dgc2 = new DataGridViewColumn();
            dgc2.HeaderText = "nombre";
            dgc2.Name = "nombre";
            DataGridViewColumn dgc3 = new DataGridViewColumn();
            dgc3.HeaderText = "subtotal";
            dgc3.Name = "subtotal";
      

            if (last_orden == -1)
            {
                MessageBox.Show("No hay ningun pedido en espera!");
                nOrden.Text = "";
                dgv1.Columns.Add(dgc1);
                dgv1.Columns.Add(dgc2);
                dgv1.Columns.Add(dgc3);
                btnTerminado.Visible = false;
            }
            else
            {
                dgv1.DataSource = cn.get_Detalle_pedido(last_orden);
                nomCliente.Text = cn.consulta_nom_cliente2(last_orden).Item1;
                if (nomCliente.Text=="NULL")
                {
                    nomCliente.Text = "";
                }
                nOrden.Text = last_orden.ToString();
            }
        }

        private void btnTerminado_Click(object sender, EventArgs e)
        {
            cn.cambiar_estado(int.Parse(nOrden.Text));
            int last_orden = cn.consulta_lat_orden_preparando();
            DataGridViewColumn dgc1 = new DataGridViewColumn();
            dgc1.HeaderText = "cantidad";
            dgc1.Name = "cantidad";
            DataGridViewColumn dgc2 = new DataGridViewColumn();
            dgc2.HeaderText = "nombre";
            dgc2.Name = "nombre";
            DataGridViewColumn dgc3 = new DataGridViewColumn();
            dgc3.HeaderText = "subtotal";
            dgc3.Name = "subtotal";
            //dgv1.DataSource = cn.get_Detalle_pedido(last_orden);
            if (last_orden == -1)
            {
                MessageBox.Show("No hay ningun pedido en espera!");
                nOrden.Text = "";
                dgv1.Columns.Add(dgc1);
                dgv1.Columns.Add(dgc2);
                dgv1.Columns.Add(dgc3);
            }
            dgv1.DataSource = cn.get_Detalle_pedido(last_orden);
          if (dgv1.Rows.Count == 0)
            {
                nOrden.Text = "";
                nomCliente.Text = "";
                MessageBox.Show("No hay ningun pedido en espera!");
            }

        }
    }
}
