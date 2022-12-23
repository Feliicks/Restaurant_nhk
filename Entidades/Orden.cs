using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Orden
    {
        private int id_cliente;
        private string descripcion;
        private string fecha;
        private decimal total;
        private int estado_pedido;

        public int Id_cliente { get => id_cliente; set => id_cliente = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public string Fecha { get => fecha; set => fecha = value; }
        public decimal Total { get => total; set => total = value; }
        public int Estado_pedido { get => estado_pedido; set => estado_pedido = value; }
    }
}
