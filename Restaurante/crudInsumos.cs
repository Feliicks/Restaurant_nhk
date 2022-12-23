using Negocios;
using System;
using System.Windows.Forms;


namespace AlmacenForms
{
    public partial class crudInsumos : Form
    {
        ConexionSQLN cn = new ConexionSQLN();

        public crudInsumos()
        {
            InitializeComponent();
        }

        private void crudProductos_Load(object sender, EventArgs e)
        {
            dtgLista.DataSource = cn.consultaInsumos();
            /*cn.consultaPlatillos
            string conexion = "server=localhost;port=3306;uid=root;pwd='';database=restauranttest";
            MySqlConnection conn = new MySqlConnection(conexion);
            btnEnviarProducto.Visible = false;
            string query = "select * from platillo";
            MySqlCommand command = new MySqlCommand(query, conn);
            MySqlDataAdapter data = new MySqlDataAdapter(command); ;
            DataTable tabla = new DataTable();
            data.Fill(tabla);
            */
            /*
            //dtgLista.Columns[0].Visible = false;
            txtDescripcionProducto.Text = "";
            //txtCategoriaProducto.Text = "";
            txtNombreProducto.Text = "";
            txtPrecioProducto.Text = "";
            //cbCategoria.DataSource = cn.get_categorias();
            cbCategoria.Items.Add("Platillo");
            cbCategoria.Items.Add("Bebida");
            cbCategoria.DisplayMember = "nombre_categoria";
            cbCategoria.ValueMember = "id_categoria";
            //lblId.Size = CreateGraphics().MeasureString("Ejemplo", label2.Font).ToSize();
            //lblId.Text = "Id";
            //lblDetalleProducto.Text = "Detalle producto:";
            //lblRegistrando.Text = "Detalle Producto";

            */
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtId.Text = (cn.get_last_id_insumo()+1).ToString();//(Int32.Parse( cn.get_last_id_insumo())+1).ToString();//cadea no tien formato coorecto
            lblTitulo.Text = "Registro de insumos";
            btnEmviar.Visible = true;
            lblDetalleProducto.Visible = false;
            lblRegistrando.Visible = true;
            txtNombreInsumo.Enabled = true;
            txtNombreInsumo.Text = string.Empty;
            //txtCategoriaProducto.Text = "Mantenimiento";

        }

        private void button10_Click(object sender, EventArgs e)
        {
            lblDetalleProducto.Visible = true;
            lblRegistrando.Visible = false;
            dtgLista.DataSource = cn.consultaInsumos();
            //txtNombreInsumo.ReadOnly=true;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //cn.RegistroPlatillo(txtNombreProducto.Text, txtDescripcionProducto.Text, decimal.Parse(txtPrecioProducto.Text), true);
            cn.registrarInsumo(txtNombreInsumo.Text,int.Parse(txtId.Text)) ;
            dtgLista.DataSource = cn.consultaInsumos();
            txtNombreInsumo.ReadOnly = false;
            lblTitulo.Text = "Detalle Insumo";
            btnEmviar.Visible = false;
            //lblDetalleProducto.Visible = false;
            //lblRegistrando.Visible = true;
        }

        private void dtgLista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void dtgLista_SelectionChanged(object sender, EventArgs e)
        {
            /*
            int selectionIndex = dtgLista.CurrentRow.Index;
            lblTitulo.Text = "Detalles";
            //lblTEXTO.Text = selectionIndex.ToString();
            txtId.Enabled = false;
            txtNombreProducto.Enabled = false;
            txtDescripcionProducto.Enabled = false;
            txtPrecioProducto.Enabled = false;
            //txtCategoriaProducto.Enabled = false;
            cbCategoria.Enabled = false;

            txtId.Text = dtgLista.Rows[selectionIndex].Cells[0].Value.ToString();
            txtNombreProducto.Text = dtgLista.Rows[selectionIndex].Cells[1].Value.ToString();
            txtDescripcionProducto.Text = dtgLista.Rows[selectionIndex].Cells[2].Value.ToString();
            txtPrecioProducto.Text = dtgLista.Rows[selectionIndex].Cells[3].Value.ToString();
            */
            if (dtgLista.CurrentRow != null)
            {

            //txtCategoriaProducto.Text = "Mantenimiento"
            int selectionIndex = dtgLista.CurrentRow.Index;
            /*if (dtgLista.CurrentRow==null )
            {

            }*/
            selectionIndex = dtgLista.CurrentRow.Index;
            txtId.Text = dtgLista.Rows[selectionIndex].Cells[0].Value.ToString();
            txtNombreInsumo.Text = dtgLista.Rows[selectionIndex].Cells[1].Value.ToString();
            txtNombreInsumo.Enabled = false;

            }


        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblTEXTO_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            btnSaveEdit.Visible = true;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            
            if (txtId.Text == "" && txtNombreInsumo.Text=="")
                MessageBox.Show("No hay datos vacios");
            else
                try
                {
                    cn.del_insumo(int.Parse(txtId.Text), txtNombreInsumo.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    throw;
                }
                
            //validar para no enviar datos vacios
            dtgLista.DataSource = cn.consultaInsumos();
            txtId.Text = String.Empty;
            txtNombreInsumo.Text = String.Empty;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }

        private void btnSaveEdit_Click(object sender, EventArgs e)
        {
            btnSaveEdit.Visible = false;
        }
    }
}
