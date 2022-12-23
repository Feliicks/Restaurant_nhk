using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Producto
    {
        private string nombre_producto;
        private decimal precio_producto;
        private int id_producto;

        public string Nombre_producto { get => nombre_producto; set => nombre_producto = value; }
        public decimal Precio_producto { get => precio_producto; set => precio_producto = value; }
        public int Id_producto { get => id_producto; set => id_producto = value; }
    }
}
