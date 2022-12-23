using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using Negocios;
using Entidades;

namespace AlmacenForms
{
    public partial class formInsumos : Form
    {
        ConexionSQLN cn = new ConexionSQLN();
        private DataTable dt;
        public formInsumos()
        {
            InitializeComponent();
            dt = new DataTable();
            DateTime now = DateTime.Now;
            lblFecha.Text = now.ToString("d");
            txtNumReg.Text = cn.getLastReg().ToString();
            lblNumReg.Text= cn.getLastReg().ToString();
            //DataTable dt = new DataTable();
            //DataRow row= dt.
        }

        private void btnRuta_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Selecciona el archivo";
            ofd.Filter = "Hoja de Excel (*.xls)|*.xls|All Files (*.*)| *.*";
            ofd.FilterIndex = 1;
            ofd.FileName = txtRuta.Text;
            ofd.RestoreDirectory = true;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                txtRuta.Text = ofd.FileName;
            }
        }
        DataView ImportarDatos(string nombreArchivo)
        {
            string conexion = string.Format("Provider = Microsoft.ACE.OLEDB.16.0; Data Source = {0}; Extended Properties = 'Excel 12.0;'", nombreArchivo);
            OleDbConnection conector = new OleDbConnection(conexion);
            //conector.Open();//TRY CATCH para excepcion cuando el archivos esta abierto y para cuando no hay ningun archi cargado
            try
            {
                conector.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Debes cargar algun archivo"+ex);

            }
            
            OleDbCommand consulta = new OleDbCommand("select * from [Hoja1$]", conector);
            OleDbDataAdapter adaptador = new OleDbDataAdapter("select * from [Hoja1$]", conector);
            DataSet ds = new DataSet();
            adaptador.Fill(ds);
            conector.Close();
            return ds.Tables[0].DefaultView;
        }
        private void formAlmacen_Load(object sender, EventArgs e)
        {
            
            cbProveedor.DisplayMember = "nombre_proveedor";
            cbProveedor.ValueMember = "id_proveedor";
            cbProveedor.DataSource = cn.proveedor_cb();

            /*dt.Columns.Add("id_insumo");
            dt.Columns.Add("nombre_insumo");
            dt.Columns.Add("unidaded_de_medida");
            dt.Columns.Add("tipo_de_insumo");
            dt.Columns.Add("medidia_individual");
            dt.Columns.Add("cantidad");
            dt.Columns.Add("total");
            dgvTest.DataSource = dt;*/
        }

        private void btnImportar_Click(object sender, EventArgs e)
        {
            dgvDatos.DataSource = ImportarDatos(txtRuta.Text);
        }
         private DataTable ToDataTable(DataGridView dataGridView)
         {
        var dt = new DataTable();
        int columnCount = 0;
        List<int> columnNumbers= new List<int>();

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

        private DataTable RemoveEmptyRows(DataTable dt)
        {
            for (int i = dt.Rows.Count - 1; i >= 0; i--)
            {
                if (dt.Rows[i]["col1"] == DBNull.Value && dt.Rows[i]["col2"] == DBNull.Value)
                {
                    dt.Rows[i].Delete();
                }
            }
            dt.AcceptChanges();
            return dt;
        }
        public DataTable DeleteEmptyRows(DataTable dt)
        {
            DataTable formattedTable = dt.Copy();
            List<DataRow> drList = new List<DataRow>();
            foreach (DataRow dr in formattedTable.Rows)
            {
                int count = dr.ItemArray.Length;
                int nullcounter = 0;
                for (int i = 0; i < dr.ItemArray.Length; i++)
                {
                    if (dr.ItemArray[i] == null || string.IsNullOrEmpty(Convert.ToString(dr.ItemArray[i])))
                    {
                        nullcounter++;
                    }
                }

                if (nullcounter == count)
                {
                    drList.Add(dr);
                }
            }

            for (int i = 0; i < drList.Count; i++)
            {
                formattedTable.Rows.Remove(drList[i]);
            }
            formattedTable.AcceptChanges();

            return formattedTable;

        }
        public void Clear_DataTableEmptyRows(DataTable dataTableControl)
        {

            for (int i = dataTableControl.Rows.Count - 1; i >= 0; i--)
            {
                DataRow currentRow = dataTableControl.Rows[i];

                foreach (var colValue in currentRow.ItemArray)
                {
                    if (!string.IsNullOrEmpty(colValue.ToString()))
                        break;

                    dataTableControl.Rows[i].Delete();
                    break;
                }
            }

        }
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            txtNumReg.Text = cn.getLastReg().ToString();
            //dt = dgvDatos.DataSource as DataTable;
            //BindingSource bs = (BindingSource)dgvDatos.DataSource;
            //dt = (DataTable)dgvDatos.DataSource;
            //dgvTest.DataSource = dt;
            List<Registrar_Insumo> regIns = new List<Registrar_Insumo>();
            dt = ToDataTable(dgvDatos);
            DeleteEmptyRows(dt);
            Clear_DataTableEmptyRows(dt);
            dgvTest.DataSource = dt;
            foreach (DataRow row in dt.Rows)
            {
                /*MessageBox.Show(row["cantidad"].ToString());
                MessageBox.Show(row["medida_individual"].ToString());
                MessageBox.Show(row["id_tipo_de_insumo"].ToString());
                MessageBox.Show(row["nombre_insumo"].ToString());
                MessageBox.Show(row["unidad_de_medida"].ToString());*/
                int cant = Int32.Parse(row["cantidad"].ToString());
                //lblTest.Text = row["nombre_insumo"].ToString();
                //lblTest.Text = dgvDatos.Rows[0].Cells[0].Value.ToString();
                decimal med_ind = (int)Convert.ToDouble(row["medida_individual"].ToString());
                Registrar_Insumo reg = new Registrar_Insumo();
                reg.Id_proveedor = (int)cbProveedor.SelectedValue;//para id proveedor //nit
                reg.Proveedor_insumo = int.Parse(txtNumReg.Text);//para numde proveedor insumo desde la variable text
                reg.Total=cant * med_ind;
                reg.Fecha = lblFecha.Text;
                reg.Id_tipo_consumo = Int32.Parse(row["id_tipo_de_insumo"].ToString());
                reg.Nombre_insumo = row["nombre_insumo"].ToString();
                reg.Unidad_medida =row["unidad_de_medida"].ToString();
                reg.Medida_individual =med_ind;
                reg.Cantidad = cant;
                reg.Num_prov_insumo = int.Parse(txtNumReg.Text);
                regIns.Add(reg);
            }
            MessageBox.Show("¡Se han registrados los datos!");
            
            cn.reg_insumos(regIns);
            lblNumReg.Text= cn.getLastReg().ToString(); 
            this.Refresh();

            //DataTable otro = (DataTable)dgvDatos.DataSource;
            //otro.Clear();
            //lblTest.Text = regIns[0].Id_proveedor.ToString();
            //dgvDatos.DataSource = null;
            //this.dgvDatos.Rows.Clear();

        }

        private void cbProveedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            //cbProveedor;
            //cbProveedor.DataSourceChanged -= cbProveedor_SelectedIndexChanged;  
            int id = (int)cbProveedor.SelectedValue;
            txtNit.Text = cn.proveedor_nit(id).ToString();
            //lblTest.Text = cbProveedor.SelectedValue.ToString();
            
        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }
    }
}
