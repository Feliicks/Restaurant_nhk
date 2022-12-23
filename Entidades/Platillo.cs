using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Platillo
    {
        private int id_producto;
        private string nombre_platillo;
        private string descripcion_platillo;

        public int Id_producto { get => id_producto; set => id_producto = value; }
        public string Nombre_platillo { get => nombre_platillo; set => nombre_platillo = value; }
        public string Descripcion_platillo { get => descripcion_platillo; set => descripcion_platillo = value; }
    }
}
