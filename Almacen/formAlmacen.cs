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
namespace Almacen
{
    public partial class formAlmacen : Form
    {
        DataView ImportarDatos(string nombreArchivo)
        {
            string conexion = string.Format("\"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = {0}; Extended Properties = ‘Excel 12.0;°",nombreArchivo);
            OleDbConnection conector = new OleDbConnection(conexion);
            conector.Open();
            OleDbCommand consulta = new OleDbCommand("select * from [Hoja1]",conector);
            OleDbDataAdapter adaptador = new OleDbDataAdapter("select * from [Hoja1]", conector);
            DataSet ds = new DataSet();
            adaptador.Fill(ds);
            conector.Close();


            return ds.Tables[0].DefaultView;
        }
        public formAlmacen()
        {
            InitializeComponent();
        }

        private void btn_cargar_excel_Click(object sender, EventArgs e)
        {


        }

        private void btnCargarRuta_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Selecciona el archivo";
            ofd.Filter = "Excel Sheet (*.xls)|*.xls|All Files (*.*)| *.*";
            ofd.FilterIndex = 1;
            ofd.FileName = txtRuta.Text;
            ofd.RestoreDirectory = true;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                txtRuta.Text=ofd.FileName; 
            }
        }
    }
}
