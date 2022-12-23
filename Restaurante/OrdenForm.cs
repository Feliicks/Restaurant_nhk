using System.Collections.Generic;
using System.Windows.Forms;


namespace AlmacenForms
{
    public partial class OrdenForm : Form
    {
        public List<MidWay> lista = new List<MidWay>();
        public OrdenForm()
        {
            InitializeComponent();
        }
        private DataGridView _DtProducto;

        public DataGridView DtProducto { get => _DtProducto; set => _DtProducto = value; }
        public void DT_PRODUCTO()
        {
            _DtProducto = dtglistaFinal;
        }
        private void OrdenForm_Load(object sender, System.EventArgs e)
        {
            DT_PRODUCTO();
            foreach(var dato in lista)
            {
                dtglistaFinal.Rows.Add(dato.nombre, dato.cantidad, dato.precio, 5);
            }
             
        }

        private void groupBox1_Enter(object sender, System.EventArgs e)
        {

        }


    }
}
