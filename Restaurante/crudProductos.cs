using Entidades;
using MySqlX.XDevAPI.Relational;
using Negocios;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;


namespace AlmacenForms
{
    public partial class crudProductos : Form
    {
        ConexionSQLN cn = new ConexionSQLN();
        private DataTable dt;
        private DataTable dt_insum_plat;
        public crudProductos()
        {
            InitializeComponent();
        }

        private void crudProductos_Load(object sender, EventArgs e)
        {
            lblInsDis.Visible = false;
            dgvInsProd.Visible = false;
            dgvProdIns.Visible = false;
            dgvInsumAvai.Visible = false;
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
            DataGridViewButtonColumn agregar = new DataGridViewButtonColumn();
            agregar.HeaderText = "Agregar";
            agregar.Name = "btnAgregar";
            agregar.UseColumnTextForButtonValue = true;
            agregar.Text = "Agregar";
            agregar.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;

            dgvInsumAvai.DataSource = cn.consultaInsumos2();
            dgvInsumAvai.Columns.Add(agregar);
            dgvInsumAvai.Columns["id_tipo_insumo"].Visible = false;

            dtgLista.DataSource = cn.consultaProductos();
            dgvInsumAvai.Columns[0].AutoSizeMode= DataGridViewAutoSizeColumnMode.AllCells; 
            dgvInsumAvai.Columns[1].AutoSizeMode= DataGridViewAutoSizeColumnMode.AllCells;
            dgvInsumAvai.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            //dtgLista.Columns[0].Visible = false;
            //txtCategoriaProducto.Text = "";
            txtNombreProducto.Text = "";
            txtPrecioProducto.Text = "";
            //cbCategoria.DataSource = cn.get_categorias();
   
            dt = new DataTable();

            DataGridViewButtonColumn eliminar = new DataGridViewButtonColumn();
            eliminar.HeaderText = "Eliminar";
            eliminar.Name = "btnEliminar";
            eliminar.UseColumnTextForButtonValue = true;
            eliminar.Text = "Eliminar";
            eliminar.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvProdIns.Columns.Add(eliminar);
            dgvProdIns.Columns["btnEliminar"].Visible = false;
            dt.Columns.Add("insumo");
            dt.Columns.Add("id_tipo_insumo");
            dgvProdIns.DataSource = dt;
            dgvProdIns.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells; ;
            dgvProdIns.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells; ;
            if (txtId.Text=="")
                MessageBox.Show("No hay productos registrados!");
            else
                dgvDetProd.DataSource = cn.consulta_insumos_de_platillo(int.Parse(txtId.Text));//VALIDAR  DGV NO TIEN INUSMOS
            //lblId.Size = CreateGraphics().MeasureString("Ejemplo", label2.Font).ToSize();
            //lblId.Text = "Id";
            //lblDetalleProducto.Text = "Detalle producto:";
            //lblRegistrando.Text = "Detalle Producto";

            lblInsDis.Visible = false;
            dgvInsProd.Visible = false;
            dgvProdIns.Visible = false;
            dgvInsumAvai.Visible = false;

            dt_insum_plat = new DataTable ();
            dt_insum_plat.Columns.Add("id_tipo_insumo");
            dt_insum_plat.Columns.Add("id_platillo");

            //ocular id de la columna para agregar insumo a plato
            dgvProdIns.Columns["id_tipo_insumo"].Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)

            {
            //dgvProdIns.datasource=nothing;
            //dgvProdIns.Rows.Clear();
            dgvProdIns.DataSource = null;
            lblTitulo.Text = "Registro de producto";
            txtId.Text = (cn.getLastId()+1).ToString() ;
            //lblTEXTO.Text = cn.getLastId().ToString();
            btnEnviarProducto.Visible = true;
            lblDetalleProducto.Visible = false;
            lblRegistrando.Visible = true;
            txtNombreProducto.Enabled = true;
            txtPrecioProducto.Enabled = true;
            //txtCategoriaProducto.Enabled = true;
            //int selectionIndex = dtgLista.CurrentRow.Index;
            //lblTEXTO.Text.;
            txtNombreProducto.Text = string.Empty;
            txtPrecioProducto.Text = string.Empty;
            //txtCategoriaProducto.Text = "Mantenimiento";

            lblDetInsumProd.Visible = false;
            dgvDetProd.Visible = false;
            txtPrecioProducto.Enabled = true;

            lblInsDis.Visible = true;
            dgvInsProd.Visible = true;
            dgvProdIns.Visible = true;
            dgvInsumAvai.Visible = true;
            if (dgvInsumAvai.Rows.Count==0)
                MessageBox.Show("No hay insumos disponibles. Debes registrar insumos");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            lblDetalleProducto.Visible = true;
            lblRegistrando.Visible = false;


            txtNombreProducto.Enabled = false;
            lblInsDis.Visible = false;
            dgvInsProd.Visible = false;
            dgvProdIns.Visible = false;
            dgvInsumAvai.Visible = false;
            txtPrecioProducto.Enabled=false; ;
            btnEnviarProducto.Visible = false;



            dgvDetProd.Visible = true;
            lblDetInsumProd.Visible = true;

            dtgLista.DataSource = cn.consultaProductos();

            dt.Clear();
        }

        private void button9_Click(object sender, EventArgs e)
        {

            //cn.RegistroPlatillo(txtNombreProducto.Text, txtDescripcionProducto.Text, decimal.Parse(txtPrecioProducto.Text), true);
            //dgvProdIns
            if (dgvProdIns.Rows.Count == 0 || txtNombreProducto.Text == "" || txtPrecioProducto.Text=="")
                MessageBox.Show("Tienes campos sin llenar");
            else
            {
                //List<Producto> prod = new List<Producto>();
                //List
                //List<Platillo> plat = new List<Platillo>();
                cn.reg_producto(txtNombreProducto.Text, double.Parse(txtPrecioProducto.Text));
                //validar para enviar solo nuemros double
                cn.reg_platillo(int.Parse(txtId.Text), txtNombreProducto.Text);
                List<Insumo_Platillo> ins_pla = new List<Insumo_Platillo>();
                foreach (DataRow row in dt.Rows)
                {
                    Insumo_Platillo ins_platillo = new Insumo_Platillo();
                    //row["id_tipo_insumo"] = dgvInsProd.
                    //row["tipo_insumo"] =
                    ins_platillo.Id_tipo_insumo = Int32.Parse(row["id_tipo_insumo"].ToString()); 
                    ins_platillo.Id_platilo = cn.get_last_id_platillo();
                    //ins_platillo.Id_tipo_insumo = Int32.Parse(txtId.Text);
                    //ins_platillo.Id_platilo = row["tipo_insumo"];
                    //ins_platillo.Id_platilo = row[]
                    ins_pla.Add(ins_platillo); 
                }
                cn.reg_insumo_platillo(ins_pla);
                dtgLista.DataSource = cn.consultaProductos();
                MessageBox.Show("Se ha registrado el producto!");
                dgvDetProd.Visible = true;
                lblDetInsumProd.Visible = true;

                lblInsDis.Visible = false;
                dgvInsumAvai.Visible = false;

                dgvInsProd.Visible = false;
                dgvProdIns.Visible = false;

                btnEnviarProducto.Visible = false;
            }




            //ejecutar registor a BD

            //intancair clases de producto, platiloo e insumo platillo respectivamte

            //intancair clases de platillo, producto e insumo platillo respectivamte


            //validar que no se envei un registor vacio
            //if (dgvInsProd.count)

        }

        private void dtgLista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void dtgLista_SelectionChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(dtgLista.CurrentCell.ColumnIndex.ToString());

            //MessageBox.Show("Fila numero" + dtgLista.CurrentRow.Index);
            if (dtgLista.CurrentRow!=null)
            {
                int selectionIndex = dtgLista.CurrentRow.Index;
                lblTitulo.Text = "Detalles";
                //lblTEXTO.Text = selectionIndex.ToString();
                txtId.Enabled = false;
                txtNombreProducto.Enabled = false;
                txtPrecioProducto.Enabled = false;
                //txtCategoriaProducto.Enabled = false;
                //txtNombreProducto.ReadOnly = true;

                txtId.Text = dtgLista.Rows[selectionIndex].Cells[0].Value.ToString();
                txtNombreProducto.Text = dtgLista.Rows[selectionIndex].Cells[1].Value.ToString();
                //txtDescripcionProducto.Text = dtgLista.Rows[selectionIndex].Cells[2].Value.ToString();
                txtPrecioProducto.Text = dtgLista.Rows[selectionIndex].Cells[2].Value.ToString();
                //txtCategoriaProducto.Text = "Mantenimiento"
                dgvDetProd.DataSource = cn.consulta_insumos_de_platillo(int.Parse(txtId.Text));//vlidar que no sea vacio
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

        private void dgvInsumAvai_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dgvInsumAvai.Columns[e.ColumnIndex].Name == "btnAgregar")
            {///
                //
                DataRow row = dt.NewRow();
                row["insumo"] = dgvInsumAvai.Rows[e.RowIndex].Cells["insumo"].Value.ToString();
                row["id_tipo_insumo"] = dgvInsumAvai.Rows[e.RowIndex].Cells["id_tipo_insumo"].Value.ToString();
                dt.Rows.Add(row); 
                //dgvProdIns.Rows.Add(row);
                dgvProdIns.DataSource = dt;
                dgvProdIns.Columns["btnEliminar"].Visible = true;
            }

        }

        private void lblDetInsumProd_Click(object sender, EventArgs e)
        {

        }

        private void dgvInsumAvai_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(this.dgvInsumAvai.Columns[e.ColumnIndex].Name == "Agregar")
            {
                //DataRow row = dt.NewRow();
                //row["id_tipo_insumo"]

            }
        }

        private void dgvProdIns_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dgvProdIns.Columns[e.ColumnIndex].Name == "btnEliminar")
            {
                //dt.Rows[]
                //MessageBox.Show((dgvProdIns.Rows[e.RowIndex].Cells["insumo"].Value.ToString())); 
                //dgvProdIns.Rows.Remove(dgvProdIns.CurrentRow);//quitar posiblida de crear mas rows
                //dt.Rows.Remove()

                //DataRow[] result = dt2.Select("CtryCode = 'mm'");
                //MessageBox.Show(dt.Rows[e.RowIndex]["insumo"].ToString());
                /*foreach (DataRow row in dt.Rows)
                {
                    if (row[0].ToString() == dt.Rows[e.RowIndex]["insumo"].ToString())
                        dt.Rows.Remove(row);
                }*/
                
                for (int i = 0; i< dt.Rows.Count; i++)
                {
                    //datatable.Rows.Remove(advRow[i]);
                    //if (row[].ToString().Contains(dgvProdIns.Rows[e.RowIndex].Cells["insumo"].Value.ToString()))
                    //dt.Rows.Remove(row);
                    
                    if (dt.Rows[i]["insumo"].ToString() == dt.Rows[e.RowIndex]["insumo"].ToString())// no pertenece a la tabla
                    {
                        //MessageBox.Show("vot a eliminar este valor "+ dt.Rows[i]["insumo"].ToString());
                        dt.Rows.RemoveAt(i);
                        
                    }
                }
                
                dgvProdIns.DataSource = dt;
                dgvProdIns.Columns["id_tipo_insumo"].Visible = false;
                //dgvProdIns.Columns["btnEliminar"].Visible = true;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void del_producto_Click(object sender, EventArgs e)
        {
            cn.del_producto(int.Parse(txtId.Text),txtNombreProducto.Text);
            MessageBox.Show("Se ha eliminado el producto!");
            dtgLista.DataSource = cn.consultaProductos();
            if (dtgLista.Rows.Count==0)
            {
                cn.clean_id_producto();
            }

        }

        private void txtPrecioProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                //MessageBox.Show("No es válido", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            /*
            DataGridViewButtonColumn eliminar = new DataGridViewButtonColumn();
            eliminar.HeaderText = "Eliminar";
            eliminar.Name = "btnEliminar";
            eliminar.UseColumnTextForButtonValue = true;
            eliminar.Text = "Eliminar";
            //eliminar.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            eliminar.Width = 50;
            dgvProdIns.Columns.Add(eliminar);
            */
            btnActualizarProd.Visible = true;
            lblTitulo.Text = "Editar producto";

            //lblTEXTO.Text = cn.getLastId().ToString();
            dgvProdIns.Columns["btnEliminar"].Visible = true;
            btnEnviarProducto.Visible = false;
            btnActualizarProd.Visible = true;
            lblDetalleProducto.Visible = false;
            lblRegistrando.Visible = true;
            txtNombreProducto.Enabled = true;
            txtPrecioProducto.Enabled = true;
            //txtCategoriaProducto.Enabled = true;
            //int selectionIndex = dtgLista.CurrentRow.Index;
            //lblTEXTO.Text.;
            //txtCategoriaProducto.Text = "Mantenimiento";

            lblDetInsumProd.Visible = false;
            dgvDetProd.Visible = false;
            txtPrecioProducto.Enabled = true;

            lblInsDis.Visible = true;
            dgvInsProd.Visible = true;
            dgvProdIns.Visible = true;
            dgvProdIns.DataSource = cn.get_detalle_insumo(int.Parse(txtId.Text));
            dt = cn.get_detalle_insumo(int.Parse(txtId.Text));
            dgvInsumAvai.Visible = true;
        }

        private void dgvProdIns_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnActualizarProd_Click(object sender, EventArgs e)
        {
            //codigo para actualizar insumo de producto o proyuecto
            if (dgvProdIns.Rows.Count == 0 || txtNombreProducto.Text == "" || txtPrecioProducto.Text == "")
                MessageBox.Show("Tienes campos sin llenar");
            else
            {
                Producto pr = new Producto();
                pr.Id_producto = int.Parse(txtId.Text);
                pr.Nombre_producto = txtNombreProducto.Text;
                pr.Precio_producto = decimal.Parse(txtPrecioProducto.Text);
                //List<Producto> prod = new List<Producto>();
                //List
                //List<Platillo> plat = new List<Platillo>();
                Platillo pt = new Platillo();
                pt.Nombre_platillo = txtNombreProducto.Text;
                pt.Id_producto= cn.get_id_plat_ins(int.Parse(txtId.Text));
                /////
                cn.upd_producto(pr);//a ctuazlairt
                //validar para enviar solo nuemros double
                cn.upd_platillo(pt); //actrualizar
               // insumos
              

                List<Insumo_Platillo> ins_pla = new List<Insumo_Platillo>();
                foreach (DataRow row in dt.Rows)
                {
                    Insumo_Platillo ins_platillo = new Insumo_Platillo();
                    //row["id_tipo_insumo"] = dgvInsProd.
                    //row["tipo_insumo"] =
                    ins_platillo.Id_tipo_insumo = Int32.Parse(row["id_tipo_insumo"].ToString());
                    ins_platillo.Id_platilo = cn.get_id_plat_ins(int.Parse(txtId.Text));
                    //ins_platillo.Id_tipo_insumo = Int32.Parse(txtId.Text);
                    //ins_platillo.Id_platilo = row["tipo_insumo"];
                    //ins_platillo.Id_platilo = row[]
                    ins_pla.Add(ins_platillo);
                }

                cn.upd_insumo_platillo(ins_pla, cn.get_id_plat_ins(int.Parse(txtId.Text)));//Actualizar
                dtgLista.DataSource = cn.consultaProductos();
                MessageBox.Show("Se ha registrado el producto!");
                dgvDetProd.Visible = true;
                lblDetInsumProd.Visible = true;

                lblInsDis.Visible = false;
                dgvInsumAvai.Visible = false;

                dgvInsProd.Visible = false;
                dgvProdIns.Visible = false;

                btnEnviarProducto.Visible = false;
            }
        }
    }
}
