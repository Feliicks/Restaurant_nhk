using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Datov1;
using System.Data.SqlClient;
using AlmacenForms;
using Entidades;
//using Restaurante;

namespace Negocios
{
    public class ConexionSQLN
    {
        ConexionSql cn = new ConexionSql();
        public DataTable consultaProductos()
        {
            return cn.consultaProductos();
        }
        public Tuple<string> consulta_id_Cliente(string codigo)
        {
            return cn.consulta_id_Cliente(codigo);
        }
        public Tuple<string> consulta_nom_cliente(string codigo)
        {

            return cn.consulta_nom_cliente(codigo);
        }
        public int get_id_cliente(int codCliente)
        {
            return cn.get_id_cliente(codCliente);
        }
        public DataTable get_detalle_insumo(int codigo)
        {
            return cn.get_detalle_insumo(codigo);
        }
        public int get_id_plat_ins(int cod)
        {
            return cn.get_id_plat_ins(cod);
        }
        public DataTable get_Detalle_pedido(int id_last_orden)
        {
            return cn.det_Detalle_pedido(id_last_orden);
        }
        public void cambiar_estado(int id_orden)
        {
            cn.cambiar_estado(id_orden);
        }
        public void modificar_proveedor(int id_proveedor, string nom_prov, int codigo_proveedor)
        {
            cn.modificar_proveedor(id_proveedor, nom_prov, codigo_proveedor);
        }
        public Tuple<string> consulta_nom_cliente2(int id_orden )
        {

            return cn.consulta_nom_cliente2(id_orden);
        }
        public void registrar_cliente(int cod_cliente, string nom_cliemte)
        {
            cn.registrar_cliente(cod_cliente,nom_cliemte);
        }
        public DataTable consultaInsumos()
        {
            return cn.consultaInsumos();
        }
        public Tuple<string> consulta_Cliente(string codigo)
        {
            return consulta_Cliente(codigo);
        }

        public int consulta_lat_orden_preparando()
        {
            return cn.consulta_lat_orden_preparando();


        }
        public DataTable consultaInsumos2()
        {
            return cn.consultaInsumos2();
        }
        public int getLastId()
        {
            return cn.getLastId();
        }
        public DataTable consulta_insumos_platillo()
        {
            return cn.consulta_insumos_platillo();
        }
        public void del_insumo(int id_tipo_insumo, string nombre_insumo)
        {
            cn.del_insumo(id_tipo_insumo, nombre_insumo);
        }
        public void del_producto(int id_producto, string nombre_producto) 
        {
            cn.del_producto(id_producto, nombre_producto);
        }
        public int get_last_id_insumo()
        {
            return cn.get_last_id_insumo();
        }
        public int get_last_Id_proveedor()
        {
            return cn.get_last_Id_proveedor();
        }
        public int RegistroPlatillo(string nombre, string descripcion, decimal precio, bool estado)
        {
            return cn.RegistroPlatillo(nombre, descripcion, precio, estado);
        }
        public int registrarInsumo(string nombre, int id)
        {
            return cn.registrarInsumo(nombre, id);
        }
        public void reg_prov(int nit, string nombre)
        {
            cn.reg_prov(nit,nombre);
        }
        public void del_prov(int id, string nombre)
        {
            cn.del_prov(id,nombre);
        }
        public DataTable get_categorias()
        {
            return cn.get_categorias();

        }
        public DataTable getAllProducts()
        {
            return cn.getAllProducts();
        }
        /*public void crearOrden(List<Detalle_Orden> O)
        {
            cn.crearOrden(O);
        }*/
        public DataTable get_proveedor()
        {
            return cn.get_proveedor();
        }
        public int getIdCat(string category)
        {
            return cn.getIdCat(category);
        }
        public int consulta_num_orden()
        {
            return cn.consulta_num_orden();
        }
        public DataTable ver_orden(int num_orden)
        {
            return cn.ver_orden(num_orden);
        }

        public DataTable getPlatillos()
        {
            return cn.getPlatillos();
        }
        public int get_total_pedido(int id_pedido)
        {
            return cn.get_total_pedido(id_pedido);

        }
        public DataTable getBebidas()
        {
            return cn.getBebidas();
        }
        public DataTable proveedor_cb()
        {
            return cn.proveedor_cb();
        }
        public int proveedor_nit(int id)
        {
            return cn.proveedor_nit(id);
        }
        public int getLastReg()
        {
            return cn.getLastReg();
        }
        public void reg_insumos(List<Registrar_Insumo> o)
        {
            cn.reg_insumos(o);
        }

        public void reg_producto(string nom, double precio)
        {
            cn.reg_producto(nom, precio);
        }

        public void upd_producto(Producto pr)
        {
            cn.upd_producto(pr);
        }
        public void upd_platillo(Platillo pt)
        {
            cn.upd_platillo(pt);
        }
        public void reg_platillo(int id_producto, string nombre)
        {
            cn.reg_platillo(id_producto, nombre);
        }

        public int get_last_id_platillo()
        {
            return cn.get_last_id_platillo();
        }
        public void reg_insumo_platillo(List<Insumo_Platillo> ins_plat)
            {
            cn.reg_insumo_platillo(ins_plat);
            }
        public DataTable consulta_insumos_de_platillo(int id_platillo)
        {
            return cn.consulta_insumos_de_platillo(id_platillo);
        }
        public void upd_insumo_platillo(List<Insumo_Platillo> ins_plat, int id_plat)
        {
            cn.upd_insumo_platillo(ins_plat, id_plat);
        }
        public void clean_id_producto ()
        {
            cn.clean_id_producto();
        }
        public void crear_pedido(List<Detalle_Orden> det_orden, Orden orden)
        {
            cn.crear_pedido(det_orden,orden);
        }
    }
}
