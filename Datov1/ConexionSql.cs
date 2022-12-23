using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using AlmacenForms;
using MySqlX.XDevAPI.Common;
using Org.BouncyCastle.Asn1.X500;
using Entidades;
using System.Data.SqlClient;
//using System.Data.SqlClient;

namespace Datov1
{
    public class ConexionSql
    {
        static string conexion = "server=localhost;port=3306;uid=root;pwd='';database=restaurante_nhk";
        MySqlConnection conn = new MySqlConnection(conexion);
        public int consultaLogin()
        {
            return 0;
        }
        /*
         * public Tuple<string> query_cliente(string cod_cliente)
        {
            int count;
            conn.Open();
            string query = "select Count(*) from cliente where id_cliente="+ cod_cliente + ";";
            string resul = "NULL";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader reg = cmd.ExecuteReader();
            count = Convert.ToInt32(cmd.ExecuteScalar());
            if (reg.Read())
            {
                resul = reg["nombre_cliente"].ToString();
            }
            con.Close();
            return Tuple.Create(resul);
        }
        */
        public Tuple<string> consulta_id_Cliente(string codigo)
        {
            conn.Open();
            string query = "select nombre_cliente from cliente where cod_cliente="+codigo+";";
            string resul = "NULL";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader reg = cmd.ExecuteReader();
            if (reg.Read())
            {
                resul = reg["nombre_cliente"].ToString();
            }
            conn.Close();
            return Tuple.Create(resul);
        }
        public Tuple<string> consulta_nom_cliente(string codigo)
        {
            conn.Open();
            string query = "select nombre_cliente from cliente join orden o on cliente.id_cliente = o.id_cliente where o.id_orden="+codigo+";;";
            string resul = "NULL";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader reg = cmd.ExecuteReader();
            if (reg.Read())
            {
                resul = reg["nombre_cliente"].ToString();
            }
            conn.Close();
            return Tuple.Create(resul);
        }
        public Tuple<string> consulta_nom_cliente2(int id_orden)
        {
            conn.Open();
            string query = "select nombre_cliente from cliente join orden o on cliente.id_cliente = o.id_cliente where o.id_orden="+id_orden+";";
            string resul = "NULL";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader reg = cmd.ExecuteReader();
            if (reg.Read())
            {
                resul = reg["nombre_cliente"].ToString();
            }
            conn.Close();
            return Tuple.Create(resul);
        }
        public int consulta_num_orden()
        {
            string query = "SELECT (select distinct  id_orden from orden order by id_orden desc LIMIT 1)+1 as num_orden;";
            int  resul = 0;
            conn.Open();
            //validacion para comprar si la bbdd está envendid
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader reg = cmd.ExecuteReader();
            if (reg.Read())
            {
                if (reg["num_orden"] == DBNull.Value)
                    resul = 1;
                else
                    resul = Convert.ToInt32(reg["num_orden"]);
            }

            conn.Close();
            return resul;

        }
        public int consulta_lat_orden_preparando()
        {
            string query = "select id_orden as num_orden from orden join estado_pedido ep on ep.id_estado_pedido = orden.id_estado_pedido where orden.id_estado_pedido=1;";
            int resul = 0;
            conn.Open();
            //validacion para comprar si la bbdd está envendid
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader reg = cmd.ExecuteReader();
            if (reg.Read())
            {
                if (reg["num_orden"] == DBNull.Value || reg["num_orden"] == "")
                    resul = -1;
                else
                    resul = Convert.ToInt32(reg["num_orden"]);
            }

            conn.Close();
            return resul;

        }

        public int get_total_pedido(int id_pedido)
        {
            string query = "select total from orden where id_orden="+ id_pedido + ";";
            int resul = 0;
            conn.Open();
            //validacion para comprar si la bbdd está envendid
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader reg = cmd.ExecuteReader();
            if (reg.Read())
            {
                if (reg["total"] == DBNull.Value)
                    resul = 1;
                else
                    resul = Convert.ToInt32(reg["total"]);
            }

            conn.Close();
            return resul;

        }
        public int getLastId()
        {
            string query = "select max(id_producto) as id_producto from producto;";
            int resul=0;
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(query,conn);
            //response= (cmd.ExecuteScalar());
            MySqlDataReader reg = cmd.ExecuteReader();
            if (reg.Read())
            {
                if (reg["id_producto"] == DBNull.Value)
                    resul = 0;
                else
                    resul = Convert.ToInt32(reg["id_producto"]);
            }
            conn.Close();
            return resul;
        }

        public int get_last_Id_proveedor()
        {
            string query = "select max(id_proveedor) as id_proveedor from proveedor;;";
            int resul = 0;
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(query, conn);
            //response= (cmd.ExecuteScalar());
            MySqlDataReader reg = cmd.ExecuteReader();
            if (reg.Read())
            {
                if (reg["id_proveedor"] == DBNull.Value)
                    resul = 0;
                else
                    resul = Convert.ToInt32(reg["id_proveedor"]);
            }
            conn.Close();
            return resul;
        }

        public int get_last_id_platillo()
        {
            string query = "select max(id_platillo) as id_platillo from platillo;";
            int resul = 0;
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(query, conn);
            //response= (cmd.ExecuteScalar());
            MySqlDataReader reg = cmd.ExecuteReader();
            if (reg.Read())
            {
                if (reg["id_platillo"] == DBNull.Value)
                    resul = 0;
                else
                    resul = Convert.ToInt32(reg["id_platillo"]);
            }
            conn.Close();
            return resul;
        }
        public int get_last_id_insumo()
        {
            string query = "select max(id_tipo_insumo) as id_tipo_insumo from tipo_insumo;";
            int resul = 0;
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader reg = cmd.ExecuteReader();
            if (reg.Read())
            {
                if (reg["id_tipo_insumo"]==DBNull.Value)
                    resul = 0;
                else
                    resul = Convert.ToInt32(reg["id_tipo_insumo"]);
            }
            conn.Close();
            return resul;
        }
        
        public DataTable consultaProductos()
        {   
            string query = "CALL sp_get_products();";
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataAdapter data=new MySqlDataAdapter();
            data.SelectCommand=cmd;
            DataTable tabla = new DataTable();
            data.Fill(tabla);
            conn.Close();
            return tabla;
        }
        public DataTable consulta_insumos_platillo()
        {
            string query = "select ti.nombre_insumo from producto join platillo p on producto.id_producto = p.id_producto join insumo_platillo ip on p.id_platillo = ip.id_platillo join tipo_insumo ti on ti.id_tipo_insumo = ip.id_tipo_insumo;";
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataAdapter data = new MySqlDataAdapter();
            data.SelectCommand = cmd;
            DataTable tabla = new DataTable();
            data.Fill(tabla);
            conn.Close();
            return tabla;
        }
        public DataTable consulta_insumos_de_platillo(int id_plat)
        {
            string query = "select ti.nombre_insumo from producto join platillo p on producto.id_producto = p.id_producto join insumo_platillo ip on p.id_platillo = ip.id_platillo join tipo_insumo ti on ti.id_tipo_insumo = ip.id_tipo_insumo\r\nwhere p.id_producto="+id_plat+";";
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataAdapter data = new MySqlDataAdapter();
            data.SelectCommand = cmd;
            DataTable tabla = new DataTable();
            data.Fill(tabla);
            conn.Close();
            return tabla;
        }
        public DataTable consultaInsumos()
        {
            string query = "select * from tipo_insumo;";
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataAdapter data = new MySqlDataAdapter();
            data.SelectCommand = cmd;
            DataTable tabla = new DataTable();
            data.Fill(tabla);
            conn.Close();
            return tabla;
        }
        public DataTable consultaInsumos2()
        {
            string query = "select id_tipo_insumo,nombre_insumo as insumo from tipo_insumo;";
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataAdapter data = new MySqlDataAdapter();
            data.SelectCommand = cmd;
            DataTable tabla = new DataTable();
            data.Fill(tabla);
            conn.Close();
            return tabla;
        }
        public int RegistroPlatillo(string nombre, string descripcion, decimal precio, bool estado)
        {
            int flag;
            string query = "INSERT INTO platillo (nombre,descripcion,precio,estado)  VALUES('"+ nombre + "','"+ descripcion + "',"+precio+","+estado+") ;";
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(query,conn);
            flag = cmd.ExecuteNonQuery();
            conn.Close();
            return flag;
        }
        public int registrarInsumo(string nombre,int id)
        {
            int flag;
            string query = "insert into tipo_insumo (id_tipo_insumo,nombre_insumo) values ("+id+",'"+nombre+"');";
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(query, conn);
            flag = cmd.ExecuteNonQuery();
            conn.Close();
            return flag;
        }
        public DataTable get_categorias()
        {
            MySqlCommand cmd = new MySqlCommand("Select * FROM categoria_producto",conn);
            conn.Open();
            MySqlDataAdapter data = new MySqlDataAdapter();
            data.SelectCommand = cmd;
            DataTable tabla = new DataTable();
            data.Fill(tabla);
            conn.Close();
            return tabla;
        }
        public DataTable getAllProducts()
        {
            //string query = "select id_platillo as id, nombre as Producto , nombre_categoria as Categoria, precio\r\nfrom platillo\r\njoin categoria_producto cp on cp.id_categoria = platillo.id_cateogoria\r\nunion\r\nselect id_bebida as id,nombre as Producto , nombre_categoria as Categoria, precio\r\nfrom bebida\r\njoin categoria_producto cp on bebida.id_categoria = cp.id_categoria";
            string query = "CALL sp_get_products();";
            MySqlCommand cmd = new MySqlCommand(query,conn);
            conn.Open();
            MySqlDataAdapter data = new MySqlDataAdapter();
            data.SelectCommand = cmd;
            DataTable tabla = new DataTable();
            data.Fill(tabla);
            conn.Close();
            return tabla;
        }
        public DataTable getPlatillos()
        {
            //string query = "select id_platillo, nombre as producto ,cp.nombre_categoria, precio\r\nfrom platillo\r\njoin categoria_producto cp on cp.id_categoria = platillo.id_cateogoria;";
            string query = "select p.id_producto,p.nombre,p.precio from platillo join producto p on p.id_producto = platillo.id_producto;";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            conn.Open();
            MySqlDataAdapter data = new MySqlDataAdapter();
            data.SelectCommand = cmd;
            DataTable tabla = new DataTable();
            data.Fill(tabla);
            conn.Close();
            return tabla;
        }
        public DataTable det_Detalle_pedido(int id_last_orden)
        {
            //string query = "select id_platillo, nombre as producto ,cp.nombre_categoria, precio\r\nfrom platillo\r\njoin categoria_producto cp on cp.id_categoria = platillo.id_cateogoria;";
            string query = "select det_or.cantidad , p.nombre, det_or.subtotal from detalle_orden as det_or join producto p on p.id_producto = det_or.id_producto join orden o on det_or.id_orden = o.id_orden join estado_pedido ep on o.id_estado_pedido = ep.id_estado_pedido where  o.id_orden="+id_last_orden+" and ep.id_estado_pedido=1;";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            conn.Open();
            MySqlDataAdapter data = new MySqlDataAdapter();
            data.SelectCommand = cmd;
            DataTable tabla = new DataTable();
            data.Fill(tabla);
            conn.Close();
            return tabla;
        }
        public DataTable getBebidas()
        {
            string query = "select p.id_producto,p.nombre,p.precio from bebida join producto p on p.id_producto = bebida.id_producto;";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            conn.Open();
            MySqlDataAdapter data = new MySqlDataAdapter();
            data.SelectCommand = cmd;
            DataTable tabla = new DataTable();
            data.Fill(tabla);
            conn.Close();
            return tabla;
        }
        public DataTable get_detalle_insumo(int codigo)
        {
            string query = "select ti.id_tipo_insumo,ti.nombre_insumo as insumo from tipo_insumo ti join insumo_platillo ip on ti.id_tipo_insumo = ip.id_tipo_insumo where id_platillo=" + codigo+";";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            conn.Open();
            MySqlDataAdapter data = new MySqlDataAdapter();
            data.SelectCommand = cmd;
            DataTable tabla = new DataTable();
            data.Fill(tabla);
            conn.Close();
            return tabla;
        }
        public void registrar_cliente(int cod_cliente, string nom_cliemte)
        {
            string query = "INSERT  INTO cliente (cod_cliente, nombre_cliente) VALUES ("+cod_cliente+",'"+nom_cliemte+"');";
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void modificar_proveedor(int id_proveedor, string nom_prov,int codigo_proveedor)
        {
            string query = "update proveedor set nombre_proveedor = '"+nom_prov+"', nit_provedor= "+codigo_proveedor+" where id_proveedor="+id_proveedor+" ";
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void update_producto(Producto pr)
        {
            string query = "update producto set nombre = '"+pr.Nombre_producto+"',precio="+ pr .Precio_producto+ " where id_producto="+ pr .Id_producto+ ";";
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void crear_orden(Orden orden)
        {   
            string query = "INSERT INTO orden (id_cliente, descripcion, fecha, total,id_estado_pedido) values (" + orden.Id_cliente + ",'" + orden.Descripcion + "','" + orden.Fecha + "'," + orden.Total + ", "+orden.Estado_pedido+");";
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void cambiar_estado(int id_orden)
        {
            string query = "update estado_pedido join orden o on estado_pedido.id_estado_pedido = o.id_estado_pedido  set o.id_estado_pedido =2   where id_orden="+ id_orden + ";";
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void crear_detalle_orden(List<Detalle_Orden> det_orden)
        {
            
            conn.Open();
            foreach(Detalle_Orden item in det_orden)
            {
                string query = "insert into detalle_orden (id_orden, id_producto, cantidad, precio, subtotal) VALUES ("+item.Id_orden+","+item.Id_producto+","+item.Cantidad+","+item.Precio+","+item.Subtotal+");";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.ExecuteNonQuery();

            }
            conn.Close();
        }
        public void crear_pedido(List<Detalle_Orden> det_orden, Orden orden)
        {
            crear_orden(orden);
            crear_detalle_orden(det_orden);
        }
        public int getIdCat (string category)
        {
            int value=1;
            string query = "select id_categoria from categoria_producto where nombre_categoria='"+category+"';";
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(query,conn);
            value = Convert.ToInt32(cmd.ExecuteScalar());
            conn.Close();
            return value;
        }
        public int get_id_plat_ins(int cod)
        {
            int value = 1;
            string query = "select id_platillo from platillo where id_producto="+ cod + ";";
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(query, conn);
            value = Convert.ToInt32(cmd.ExecuteScalar());
            conn.Close();
            return value;
        }

        public int get_id_cliente(int codCliente)
        {
            int value = 1;
            string query = "select id_cliente from cliente where  cod_cliente= '"+codCliente+"'";
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(query, conn);
            value = Convert.ToInt32(cmd.ExecuteScalar());
            conn.Close();
            return value;
        }

        public DataTable ver_orden(int num_orden)
        {
            string query = "select p.nombre, d.precio, d.cantidad, d.subtotal,orden.fecha  from orden join detalle_orden d on orden.id_orden = d.id_orden join producto p on p.id_producto = d.id_producto where d.id_orden="+num_orden+";";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            conn.Open();
            MySqlDataAdapter data = new MySqlDataAdapter();
            data.SelectCommand = cmd;
            DataTable tabla = new DataTable();
            data.Fill(tabla);
            conn.Close();
            return tabla;
        }

        public DataTable proveedor_cb1()
        {
            string query = "call  sp_proveedor_cb()";
            //MySqlCommand cmd = new MySqlCommand();
            //cmd.CommandType = CommandType.StoredProcedure;
            conn.Open();
            MySqlDataAdapter data = new MySqlDataAdapter(query, conn);
            data.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable tabla = new DataTable();
            data.Fill(tabla);
            conn.Close();
            return tabla;
        }
        public DataTable proveedor_cb()
        {
            string query = "call  sp_proveedor_cb()";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            conn.Open();
            MySqlDataAdapter data = new MySqlDataAdapter(cmd);
            DataTable tabla = new DataTable();
            data.Fill(tabla);
            conn.Close();
            return tabla;
        }
        public DataTable get_proveedor()
        {
            string query = "select * from proveedor;";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            conn.Open();
            MySqlDataAdapter data = new MySqlDataAdapter(cmd);
            DataTable tabla = new DataTable();
            data.Fill(tabla);
            conn.Close();
            return tabla;
        }
        public int proveedor_nit(int id)
        {
            //string query = "call  sp_proveedor_nit("+id+")";
            string query = "select nit_provedor\r\n    from proveedor\r\n        where id_proveedor=" + id + "";
            int value=1;
            MySqlCommand cmd = new MySqlCommand(query, conn);
            conn.Open();
            MySqlDataAdapter data = new MySqlDataAdapter(cmd);
            value = Convert.ToInt32(cmd.ExecuteScalar());
            conn.Close();
            return value;
        }
        public int getLastReg()
        {
            //string query = "call sp_last_prov_insumo()";.
            string query = "SELECT (select distinct  id_proveedor_insumo from proveedor_insumo order by id_proveedor_insumo desc LIMIT 1)+1 as num_prov_ins";
            int resul = 0;
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader reg = cmd.ExecuteReader();
            if (reg.Read())
            {
                if (reg["num_prov_ins"] == DBNull.Value)
                    resul = 1;
                else
                    resul = Convert.ToInt32(reg["num_prov_ins"]);
            }
           
            conn.Close();
            return resul;
        }
        public void del_insumo(int id_tipo_insumo, string nombre_insumo)
        {
            string query = "delete from tipo_insumo where  id_tipo_insumo="+id_tipo_insumo+" and nombre_insumo='"+nombre_insumo+"';";
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(query, conn);
            ;// no se puede linar por contraot
                cmd.ExecuteNonQuery();
            conn.Close();
        }
        public int get_id_plati_de_product(int id_producto)
        {
            //string query = "call sp_last_prov_insumo()";.
            string query = "select id_platillo from producto join platillo p on producto.id_producto = p.id_producto where p.id_producto="+id_producto+";";
            int resul = 0;
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader reg = cmd.ExecuteReader();
            if (reg.Read())
            {
                resul = int.Parse(reg["id_platillo"].ToString());
            }

            conn.Close();
            return resul;
        }
        public void del_platillo(int id_producto)
        {
            //eliminar platilo y eliannar insimo platilo en orden
            string query = "DELETE FROM platillo where  id_producto ="+ id_producto + ";";
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(query, conn);
            ;// no se puede linar por contraot
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void del_insumo_platillo(int id_platillo)
        {
            //eliminar platilo y eliannar insimo platilo en orden
            string query = "delete from insumo_platillo where id_platillo="+id_platillo+"";
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(query, conn);
            ;// no se puede linar por contraot
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void del_producto(int id_producto, string nombre_producto)
        {
            //eliminar platilo y eliannar insimo platilo en orden

            //Eliminar insumo_platillo
            int id_platillo = get_id_plati_de_product(id_producto);
           
            del_insumo_platillo(id_platillo);

            //Eliminar platillo
            del_platillo(id_producto);
          
            

            //Eliminar producto
            string query = "set foreign_key_checks =0;DELETE FROM producto where  id_producto =" + id_producto + " AND nombre='"+nombre_producto+ "';set foreign_key_checks =1;";
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(query, conn);
            ;// no se puede linar por contraot
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void reg_prov_insumo (int id_prov,decimal total, string fecha)
        {
            string query = "CALL reg_proveedor_insumo('"+ id_prov + "',"+total+",'"+fecha+"')";
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void reg_insumos(List<Registrar_Insumo> regIns)
        {
            reg_prov_insumo(Int32.Parse(regIns[0].Id_proveedor.ToString()), regIns[0].Total_subtotal, regIns[0].Fecha.ToString());

            conn.Open();
            foreach (Registrar_Insumo item in regIns)
            {
                string query = "CALL sp_reg_insumo("+item.Num_prov_insumo+","+item.Id_tipo_consumo+",'"+item.Nombre_insumo+"','"+item.Unidad_medida+"',"+item.Medida_individual+","+item.Cantidad+",("+ item.Cantidad + "*"+ item.Medida_individual + "),"+item.Precio_individual+","+item.Subtotal+")";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.ExecuteNonQuery();
            }
            conn.Close();
        }
        public void reg_prov(int nit, string nombre )
        {
            string query = "INSERT INTO proveedor (nit_provedor, nombre_proveedor) VALUES ("+nit+",'"+nombre+"');";
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void del_prov(int id, string nombre)
        {
            string query = "DELETE  FROM proveedor WHERE id_proveedor="+id+" and nombre_proveedor='"+nombre+"'";
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void reg_producto(string nom, double precio)
        {
            string query = "insert into producto (nombre, precio) VALUES ('"+nom+"',"+precio+")";
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void reg_platillo(int id_producto, string nombre)
        {
            string query = "insert into platillo (id_producto, nombre_platillo, descripcion) values ("+id_producto+",'"+nombre+"','Ejemplo desde c#');";
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void upd_producto(Producto pr)
        {
            string query = "update producto set nombre = '" + pr.Nombre_producto + "',precio=" +pr.Precio_producto+" where id_producto="+pr.Id_producto+";";
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void upd_platillo(Platillo pt)
        {
            string query = "update platillo set nombre_platillo = '"+pt.Nombre_platillo+"' where id_producto="+pt.Id_producto+";";
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void reg_insumo_platillo(List<Insumo_Platillo> ins_plat)
        {
            conn.Open();
            foreach (Insumo_Platillo item in ins_plat)
            {
                string query = "insert into insumo_platillo (id_tipo_insumo, id_platillo) values ("+item.Id_tipo_insumo+","+item.Id_platilo+")";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.ExecuteNonQuery();
            }
            conn.Close();
        }

        public void clean_insumo(int id_plat)
        {
            string query = "delete insumo_platillo from insumo_platillo where id_platillo="+ id_plat + ";";
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void upd_insumo_platillo(List<Insumo_Platillo> ins_plat,int id_plat)
        {
            clean_insumo(id_plat);
            conn.Open();
            foreach (Insumo_Platillo item in ins_plat)
            {
                string query = "insert into insumo_platillo (id_tipo_insumo, id_platillo) values (" + item.Id_tipo_insumo + "," + item.Id_platilo + ")";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.ExecuteNonQuery();
            }
            conn.Close();
        }
        public void clean_id_producto()
        {
            string query = "set foreign_key_checks =0; TRUNCATE producto;set foreign_key_checks =1;";
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }


    }
}
