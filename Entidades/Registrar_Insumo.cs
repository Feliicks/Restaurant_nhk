using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Registrar_Insumo
    {/*
      *     id_insumo           int auto_increment
        primary key,
    id_proveedor_insumo int           null,
    id_tipo_insumo      int           null,
    nombre_insumo       varchar(100)  null,
    unidad_de_medida    varchar(50)   null,
    medida_individual   decimal(5, 3) null,
    cantidad            int           null,
    total               double        null,
      */
        private int id_proveedor;
        private int proveedor_insumo;
        private decimal total;
        private string fecha;
        private int id_tipo_consumo;
        private string nombre_insumo;
        private string unidad_medida;
        private decimal medida_individual;
        private int cantidad;
        private decimal precio_individual;
        private decimal subtotal;
        private int num_prov_insumo;
        private decimal total_subtotal;

        public int Proveedor_insumo { get => proveedor_insumo; set => proveedor_insumo = value; }
        public decimal Total { get => total; set => total = value; }
        public string Fecha { get => fecha; set => fecha = value; }
        public int Id_tipo_consumo { get => id_tipo_consumo; set => id_tipo_consumo = value; }
        public string Nombre_insumo { get => nombre_insumo; set => nombre_insumo = value; }
        public string Unidad_medida { get => unidad_medida; set => unidad_medida = value; }
        public decimal Medida_individual { get => medida_individual; set => medida_individual = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public int Id_proveedor { get => id_proveedor; set => id_proveedor = value; }
        public int Num_prov_insumo { get => Num_prov_insumo1; set => Num_prov_insumo1 = value; }
        public decimal Subtotal { get => subtotal; set => subtotal = value; }
        public int Num_prov_insumo1 { get => num_prov_insumo; set => num_prov_insumo = value; }
        public decimal Precio_individual { get => precio_individual; set => precio_individual = value; }
        public decimal Total_subtotal { get => total_subtotal; set => total_subtotal = value; }
    }
}
