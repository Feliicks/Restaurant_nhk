using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlmacenForms
{
    public class Detalle_Orden
    {
        /*
         * row["id"] = dgvListaProductos.Rows[e.RowIndex].Cells[1].Value.ToString();
                row["Producto"] = dgvListaProductos.Rows[e.RowIndex].Cells[2].Value.ToString();
                row["Categoria"] = dgvListaProductos.Rows[e.RowIndex].Cells[3].Value.ToString();
                row["Cantidad"] = 1;
                row["Precio"] = dgvListaProductos.Rows[e.RowIndex].Cells[4].Value.ToString();
                row["Subtotal"] = dgvListaProductos.Rows[e.RowIndex].Cells[4].Value.ToString();
         */
        private int id_orden = 0;
        private int id_producto = 0;
        private int cantidad = 0;
        private decimal precio = 0;
        private decimal subtotal = 0;
        private int numOrden = 0;

        public int Id_orden { get => id_orden; set => id_orden = value; }
        public int Id_producto { get => id_producto; set => id_producto = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public decimal Precio { get => precio; set => precio = value; }
        public decimal Subtotal { get => subtotal; set => subtotal = value; }
        public int NumOrden { get => numOrden; set => numOrden = value; }
    }
}
