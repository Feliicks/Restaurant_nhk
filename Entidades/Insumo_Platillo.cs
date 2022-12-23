using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Insumo_Platillo
    {
        private int id_tipo_insumo;
        private int id_platilo;

        public int Id_tipo_insumo { get => id_tipo_insumo; set => id_tipo_insumo = value; }
        public int Id_platilo { get => id_platilo; set => id_platilo = value; }
    }
}
