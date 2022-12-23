using System;
using System.Drawing;
using System.Windows.Forms;
using Negocios;
using System.Data;
using System.Collections.Generic;
using MySqlX.XDevAPI.Relational;
using Restaurante;
using System.Reflection;
using System.Drawing.Printing;
//using Entidades;

namespace AlmacenForms
{

    
    public partial class AlimentosForm : Form
    {
        public static bool payStatus = false;
        private decimal total = 0;
        public List<MidWay> lista = new List<MidWay>();
        private DataGridView _DtProducto;
        private DataTable dt;
        public DateTime now = DateTime.Now;
        public void DT_PRODUCTO()
        {
            _DtProducto = dgvListaProductos;
        }
        ConexionSQLN conn = new ConexionSQLN();
        public AlimentosForm()
        { 
            InitializeComponent();
            //lblnOrden.Text = conn.consulta_num_orden()+1.ToString();
            lblnOrden.Text = "0";
            lblNomCliente.Text = "";
            lblFecha.Visible = false;
            //dataGridView1.Rows[rowIndexYouWant].Cells["Agregar"].Value = 1;
        }

        private void abrirFormHija(object formHija)
        {
            /*if (this.panel1.Controls.Count > 0)
            {
                this.panel1.Controls.RemoveAt(0);
            }
            Form fh = formHija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panel1.Controls.Add(fh);
            this.panel1.Tag = fh;
            fh.Show();
            */
        }
        private void AlimentosForm_Load(object sender, EventArgs e)
        {
            
            lblFecha.Text = now.ToString("d");
            lblnOrden.Text = conn.consulta_num_orden().ToString();
            DataGridViewComboBoxColumn dgvCmb = new DataGridViewComboBoxColumn();
            
            dgvCmb.HeaderText = "cantidad";
            /*dgvCmb.Items.Add("1");
            dgvCmb.Items.Add("2");
            dgvCmb.Items.Add("3");
            dgvCmb.Items.Add("4");
            dgvCmb.Items.Add("5");*/
            var datasourceXAMP = new List<Restaurante.Num>();
            datasourceXAMP.Add(new Restaurante.Num() { Cantidad_name=1,Cantidad_value=1});
            datasourceXAMP.Add(new Restaurante.Num() { Cantidad_name = 2, Cantidad_value = 2 });
            datasourceXAMP.Add(new Restaurante.Num() { Cantidad_name = 3, Cantidad_value = 3 });
            datasourceXAMP.Add(new Restaurante.Num() { Cantidad_name = 4, Cantidad_value = 4 });
            datasourceXAMP.Add(new Restaurante.Num() { Cantidad_name = 5, Cantidad_value = 5 });
            dgvCmb.DataSource = datasourceXAMP;
            //datasource.Add(new Restaurante.Num() { Cantidad_name = 1, Cantidad_value = 1 });

            //dgvCmb.ValueType;
            //dgvCmb.DisplayStyle.

            
            dgvCmb.DisplayMember = "Cantidad_name";
            dgvCmb.ValueMember = "Cantidad_value";


            dgvCmb.DisplayIndex = -1;
            //dgvCmb.DisplayMember = "Texto";
            //dgvCmb.Selected = true;
            dgvCmb.Name = "cmbCantidad";
            


            //dgvCmb.DefaultCellStyle= { Index = 8, Make = "Ford" }

            DataGridViewButtonColumn agregar = new DataGridViewButtonColumn();
            agregar.HeaderText = "Agregar";
            agregar.Name = "btnAgregar";
            
            dgvListaProductos.DataSource = conn.getAllProducts();
            dgvListaProductos.Columns.Add(agregar);
            dgvListaProductos.Columns.Add(dgvCmb);
            //dgvListaFinal.Columns("cmbCantidad").Dea














            //dgvListaProductos.Columns["cmbName"].DisplayIndex = 3;
            dgvListaProductos.Columns["id_producto"].DisplayIndex = 0;
            dgvListaProductos.Columns["nombre"].DisplayIndex = 1;
            dgvListaProductos.Columns["precio"].DisplayIndex = 2;
            dgvListaProductos.Columns["btnAgregar"].DisplayIndex = 4;
            dgvListaProductos.Columns["cmbCantidad"].DisplayIndex = 3;



            //dgvListaProductos["cmbCantidad", 3].Value = 1;//item id value


            DataGridViewButtonColumn btnclm = new DataGridViewButtonColumn();
            btnclm.Name = "Agregar";
            btnclm.UseColumnTextForButtonValue = true;
   
            //dgvListaProductos.Columns.Add(btnclm);
            abrirFormHija(new OrdenForm());
            dt = new DataTable();
            //Tabla detalle pedido
            dt.Columns.Add("Id");
            dt.Columns.Add("Producto");
            //dt.Columns.Add("Categoria");
            dt.Columns.Add("Cantidad");
            dt.Columns.Add("Precio");
            dt.Columns.Add("Subtotal");
            dgvListaFinal.DataSource =  dt;
            
            //dtgListaProductos=d
            //lblCurrent.Text = conn.getIdCat("Plato Tradicional").ToString();
            /*int i = 3;
            if (dgvListaProductos.Rows.Count > 0) //Una fila al menos para proceder
            {
                if (dgvListaProductos.Rows[i].Cells[i].Value != null) //Valor columna no es null?
                {
                    //OK, no es null, podemos trabajar con la fila
                    string sValor = dgvListaProductos.Rows[i].Cells[i].Value.ToString(); ;
                    MessageBox.Show("00 no es nulo");
                    MessageBox.Show(dgvListaProductos.Rows[i].Cells[i].Value.ToString());
                    //.....más código
                }
            }*/
            if (dgvListaProductos.Rows.Count == 0)
                MessageBox.Show("No hay productos registrados. El administrador debe registrar productos");
        }
        private DataTable ToDataTable(DataGridView dataGridView)
        {
            var dt = new DataTable();
            int columnCount = 0;
            List<int> columnNumbers = new List<int>();

            foreach (DataGridViewColumn dataGridViewColumn in dataGridView.Columns)
            {
                if (dataGridViewColumn.Visible)
                {
                    dt.Columns.Add(dataGridViewColumn.Name);
                    columnNumbers.Add(columnCount);
                }
                columnCount++;
            }

            var cell = new object[columnNumbers.Count];
            foreach (DataGridViewRow dataGridViewRow in dataGridView.Rows)
            {
                int i = 0;
                foreach (int a in columnNumbers)
                {
                    cell[i] = dataGridViewRow.Cells[a].Value;
                    i++;
                }
                dt.Rows.Add(cell);
            }
            return dt;
        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            dgvListaProductos.DataSource = conn.getAllProducts();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dgvListaProductos.DataSource = conn.getBebidas();
        }

        private void dtgListaProductos_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex >= 0 && this.dgvListaProductos.Columns[e.ColumnIndex].Name == "Agregar" && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                DataGridViewButtonCell celBoton = this.dgvListaProductos.Rows[e.RowIndex].Cells["Agregar"] as DataGridViewButtonCell;
                Icon icoAtomico = new Icon(Environment.CurrentDirectory + @"\\icon15px.ico");/////Recuerden colocar su icono en la carpeta debug de su proyecto
                e.Graphics.DrawIcon(icoAtomico, e.CellBounds.Left + 3, e.CellBounds.Top + 3);

                this.dgvListaProductos.Rows[e.RowIndex].Height = icoAtomico.Height + 8;
                this.dgvListaProductos.Columns[e.ColumnIndex].Width = icoAtomico.Width + 8;

                e.Handled = true;
            }
        }

        public void dtgListaProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //accion al presionar boton eliminar
            // MidWay dt = new MidWay();
            //List data = new List;
            //MidWay dt = new MidWay();
            if (this.dgvListaProductos.Columns[e.ColumnIndex].Name == "btnAgregar" && e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {

                //OrdenForm form = new OrdenForm();
                /*form.DtProducto.Rows.Add(dtgListaProductos.CurrentRow.Cells["Producto"].Value,
                    dtgListaProductos.CurrentRow.Cells["Cant"].Value,
                    dtgListaProductos.CurrentRow.Cells["Precio"].Value,
                    dtgListaProductos.CurrentRow.Cells["Suntotal"].Value);*/
                //lblCurrent.Text = e.RowIndex.ToString();
                //lblCurrent.Text = dgvListaProductos.Rows[e.RowIndex].Cells[1].Value.ToString();
                DataRow row = dt.NewRow();


                /*row["id"] = dgvListaProductos.Rows[e.RowIndex].Cells[1].Value.ToString();
                row["Producto"] = dgvListaProductos.Rows[e.RowIndex].Cells[2].Value.ToString();
                row["Categoria"] = dgvListaProductos.Rows[e.RowIndex].Cells[3].Value.ToString();
                row["Cantidad"] = 1;
                row["Precio"] = dgvListaProductos.Rows[e.RowIndex].Cells[4].Value.ToString();
                row["Subtotal"] = dgvListaProductos.Rows[e.RowIndex].Cells[4].Value.ToString();//dgvListaProductos.Rows[e.RowIndex].Cells[6].Value.ToString();
                */

                //MessageBox.Show(dgvListaProductos.Rows[e.RowIndex].Cells["id_producto"].Value.ToString());
                // Para pasar de la tabla de producot a tabla detalle pedido
                decimal prec = Decimal.Parse(dgvListaProductos.Rows[e.RowIndex].Cells["precio"].Value.ToString());
                int cantidad = 1;
                if (dgvListaProductos.Rows[e.RowIndex].Cells["cmbCantidad"].Value == null)
                    cantidad = 1;
                else
                    cantidad = int.Parse(dgvListaProductos.Rows[e.RowIndex].Cells["cmbCantidad"].Value.ToString());

                row["id"] = dgvListaProductos.Rows[e.RowIndex].Cells["id_producto"].Value.ToString();
                row["Producto"] = dgvListaProductos.Rows[e.RowIndex].Cells["nombre"].Value.ToString();
                //row["Categoria"] = dgvListaProductos.Rows[e.RowIndex].Cells[3].Value.ToString();
                row["Cantidad"] = cantidad;
//MessageBox.Show(cantidad.ToString());
                row["Precio"] = prec;
                row["Subtotal"] = cantidad * prec;
                dt.Rows.Add(row);
                total = total + cantidad * Decimal.Parse(dgvListaProductos.Rows[e.RowIndex].Cells["precio"].Value.ToString());
                lblPrecioTotal.Text = total.ToString();
                

                //DataRow row = dgvListaProductos.newRow();

                //foreach(DataGridViewRow fila in dtgListaProductos.Rows) {


                //form.lista.Add(dt);

                //}
                //lblCurrent.Text = dgvListaProductos.CurrentRow.Cells[0].Value.ToString();
                //Data
            }
        }

        private void dtgListaProductos_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            //lblCurrent.Text = dgvListaProductos.Rows[e.RowIndex].Cells[0].Value.ToString();
        }
        decimal subtotal = 0;
        int cantidad = 0;
        decimal precio = 0;
        private void dgvListaProductos_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            //lblCurrent.Text = dgvListaFinal.Columns[e.ColumnIndex].ToString();

        }

        private void dgvListaFinal_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvListaFinal_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            //lblCurrent.Text = dgvListaFinal.Columns[e.ColumnIndex].HeaderText;
            if (dgvListaFinal.Columns[e.ColumnIndex].HeaderText == "Cantidad")
            {
                //lblCurrent.Text = dgvListaFinal.Rows[e.RowIndex].Cells[0].Value.ToString();
                cantidad = Int32.Parse(dgvListaFinal.Rows[e.RowIndex].Cells[2].Value.ToString());
                precio = decimal.Parse(dgvListaFinal.Rows[e.RowIndex].Cells[3].Value.ToString());
                total = total - subtotal;
                subtotal = cantidad * precio;
                dgvListaFinal.Rows[e.RowIndex].Cells["Subtotal"].Value = subtotal;
                //row["Cantidad"].
                //t.Rows.
                //total
                total =total+ cantidad * precio;
                lblPrecioTotal.Text = total.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (payStatus==false)
                MessageBox.Show("Debe realizar el pago primero!");
            else
            {
                //valida que el datagrid view no esté en 0
                total = 0;
                Entidades.Orden orden = new Entidades.Orden();
                orden.Total = Decimal.Parse(lblPrecioTotal.Text);// no tien fomrato crroecto
                orden.Descripcion = "";
                //orden.Id_cliente = int.Parse(txtCodCliente.Text);//El codigo de lciente es opcional Asdi que debe validrase o poenr un codigo vacio
                int codCliente = conn.get_id_cliente(int.Parse(txtCodCliente.Text));
                orden.Id_cliente = codCliente;
                orden.Fecha = now.ToString("d");
                orden.Estado_pedido = 1;
                // date
                /*
                MessageBox.Show(orden.Id_cliente.ToString());
                MessageBox.Show(orden.Descripcion.ToString());
                MessageBox.Show(orden.Fecha.ToString());
                MessageBox.Show(orden.Total.ToString());
                MessageBox.Show(orden.Estado_pedido.ToString());*/
                List<Detalle_Orden> listOrden = new List<Detalle_Orden>();
                foreach (DataRow row in dt.Rows)
                {
                    //string cat = row["Categoria"].ToString();

                    Detalle_Orden det_orden = new Detalle_Orden();
                    det_orden.Id_producto = int.Parse(row["id"].ToString());
                    det_orden.Id_orden = int.Parse(lblnOrden.Text);
                    det_orden.Cantidad = int.Parse(row["Cantidad"].ToString());
                    det_orden.Precio = decimal.Parse(row["Precio"].ToString());
                    det_orden.Subtotal = decimal.Parse(row["Subtotal"].ToString());
                    /*
                    MessageBox.Show(det_orden.Id_producto.ToString());
                    MessageBox.Show(det_orden.Id_orden.ToString());
                    MessageBox.Show(det_orden.Cantidad.ToString());
                    MessageBox.Show(det_orden.Precio.ToString());
                    MessageBox.Show(det_orden.Subtotal.ToString());
                    */
                    //det_orden.NumOrden = int.Parse(lblnOrden.Text);
                    listOrden.Add(det_orden);
                }
                conn.crear_pedido(listOrden, orden);
                txtCodCliente.Text = "";
                lblCodCLiente.Text = "";
                lblPrecioTotal.Text = "0";
                lblnOrden.Text = conn.consulta_num_orden().ToString();
                DataTable otro = (DataTable)dgvListaFinal.DataSource;
                otro.Clear();
                MessageBox.Show("Pedido creado con exito");
            }

        }
        private void Imprimir(object sender, PrintPageEventArgs e)
        {
            //Obetner nombre Cliente
            var resultadoX = conn.consulta_id_Cliente(txtCodCliente.Text);
            string Cliente = resultadoX.Item1;
            ///
            Font font = new Font("Arial", 10);
            Font fontGrande = new Font("Arial", 17);
            Font fontDescrip = new Font("Arial", 8);
            int ancho = 800;
            int y = 20;


            e.Graphics.DrawString("         Empresa XYZ", fontGrande, Brushes.Black, new RectangleF(0, y += 35, ancho, 30));
            e.Graphics.DrawString("    Venta de accesorios electronicos y otros.", font, Brushes.Black, new RectangleF(0, y += 30, ancho, 20));
            e.Graphics.DrawString("                El Alto, La Paz - Bolivia", font, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));

            e.Graphics.DrawString("-------------------------------------------------------------", font, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));
            e.Graphics.DrawString("                 ", font, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));

            e.Graphics.DrawString("   NIT      :  365395019  ", font, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));
            e.Graphics.DrawString("   FACTURA NRO    :      " + lblnOrden.Text, font, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));
            //e.Graphics.DrawString("   AUTORIZACION   :  54318743" , font, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));
            e.Graphics.DrawString("                 ", font, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));


            e.Graphics.DrawString("---------------------Venta----------------------------", font, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));
            e.Graphics.DrawString("  FECHA   :   " + DateTime.Now.ToShortDateString(), font, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));
            e.Graphics.DrawString("  CLIENTE   :  " + resultadoX.Item1, font, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));
            e.Graphics.DrawString("  NIT    :  " + txtCodCliente.Text, font, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));

            e.Graphics.DrawString("_________________________________________________", font, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));
            e.Graphics.DrawString(" Cant. |        Descripción               |   P .U     |  Total", font, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));
            e.Graphics.DrawString("_________________________________________________", font, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));


            foreach (DataRow row in dt.Rows)
            {
                e.Graphics.DrawString("  " + row["Cantidad"].ToString() + "      " + row["Producto"].ToString() + "           " + row["Precio"].ToString() + "             " + row["Subtotal"].ToString()
                    , font, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));


            }


            e.Graphics.DrawString("____________________________________________________", font, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));
            e.Graphics.DrawString("                  TOTAL A PAGAR Bs.    " + lblPrecioTotal, font, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));


            e.Graphics.DrawString("       -----Gracias por su visita!------", font, Brushes.Black, new RectangleF(0, y += 40, ancho, 20));

        }
        private void button1_Click(object sender, EventArgs e)
        {
            lblPrecioTotal.Text = "0";
            txtCodCliente.Text = "";
            lblNomCliente.Text = "";
            lblnOrden.Text = conn.consulta_num_orden().ToString();
            DataTable dt = (DataTable)dgvListaFinal.DataSource;
            dt.Clear();
            total = 0;
        }

        private void lblnOrden_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            dgvListaProductos.DataSource = conn.getPlatillos();
        }

        private void dgvListaProductos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //suppose column index of ComboBox is 0
            /*if (e.ColumnIndex == 5 && e.Value == null)
            {
                e.Value = "Default value";
            }*/
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            if (lblNomCliente.Text=="NULL" || lblNomCliente.Text==".")
                MessageBox.Show("Debe introducir el codigo del cliente");
            else if (dt.Rows.Count==0)
            {
                MessageBox.Show("Nm hay producot añadidos");
            }
            else
            {
                Restaurante.formPago nuevo = new Restaurante.formPago(Decimal.Parse(lblPrecioTotal.Text));
                nuevo.ShowDialog();
            }
        }

        private void txtCodCliente_TextChanged(object sender, EventArgs e)
        {
            //lnlNomCliente.Text = conn.consulta_id_Cliente(txtCodCliente.Text).ToString();
        }

        private void txtCodCliente_Leave(object sender, EventArgs e)
        {
            
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtCodCliente.Text=="")
            {
                MessageBox.Show("Debe introducir el codigo del cliente");
            }
            else
            {
                var resultadoX = conn.consulta_id_Cliente(txtCodCliente.Text);
                //string zxamp = conn.consulta_id_Cliente(txtCodCliente.Text);
                //lblNomCliente.Text = resultadoX.Item1;
                Restaurante.registrarCliente form = new registrarCliente(txtCodCliente.Text);
                if (resultadoX.Item1 == "NULL")
                {
                    MessageBox.Show("Cliente no encontrado. Se registrará un nuevo Cliente");
                    
                    form.ShowDialog();
                }
                resultadoX = conn.consulta_id_Cliente(txtCodCliente.Text);
                lblNomCliente.Text = resultadoX.Item1;
            }

        }

        private void dgvListaProductos_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            e.Row.Cells["btnclm"].Value = 1;
        }

        private void dgvListaFinal_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 3 && e.Value == null)
            {
                e.Value = 1;
            }
        }

        private void dgvListaFinal_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            e.Row.Cells["cmbCantidad"].Value = "0";//give combobox index value here
        }

        private void txtCodCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            //solo numeros
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                //MessageBox.Show("No es válido", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            PrintDocument printDocument1 = new PrintDocument();
            PrinterSettings ps = new PrinterSettings();
            printDocument1.PrinterSettings = ps;
            printDocument1.PrintPage += Imprimir;
            printDocument1.Print();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dgvListaProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
