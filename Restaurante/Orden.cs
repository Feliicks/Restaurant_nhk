using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurante
{
    public class Orden
    {
        /*
         * row["id"] = dgvListaProductos.Rows[e.RowIndex].Cells[1].Value.ToString();
                row["Producto"] = dgvListaProductos.Rows[e.RowIndex].Cells[2].Value.ToString();
                row["Categoria"] = dgvListaProductos.Rows[e.RowIndex].Cells[3].Value.ToString();
                row["Cantidad"] = 1;
                row["Precio"] = dgvListaProductos.Rows[e.RowIndex].Cells[4].Value.ToString();
                row["Subtotal"] = dgvListaProductos.Rows[e.RowIndex].Cells[4].Value.ToString();
         */
        private int id = 0;
        private string producto = "";
        private string categoria = "";
        private int cantidad = 0;
        private decimal precio = 0;
        private decimal subtotal = 0;

        public int Id { get => id; set => id = value; }
        public string Producto { get => producto; set => producto = value; }
        public string Categoria { get => categoria; set => categoria = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public decimal Precio { get => precio; set => precio = value; }
        public decimal Subtotal { get => subtotal; set => subtotal = value; }
    }
}
