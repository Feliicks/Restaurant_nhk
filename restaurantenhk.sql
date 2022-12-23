DROP DATABASE  IF EXISTS restaurante_nhk;
CREATE DATABASE restaurante_nhk;
use restaurante_nhk;

CREATE  TABLE proveedor
(
  id_proveedor int primary key auto_increment,
  nit_provedor int,
  nombre_proveedor varchar(50)
);
create  table proveedor_insumo
(
    id_proveedor_insumo int primary key  auto_increment,
    id_proveedor int,
    ##id_insumo int,
    precio_total decimal(6,2),
    fecha_compra varchar(12),
    foreign key (id_proveedor) references proveedor(id_proveedor)
    ##foreign key (id_insumo) references insumo (id_insumo)

);
## simple
/*create table insumo
(
    id_insumo int primary key  auto_increment,
    nombre_insumo varchar(100),
    unidad_de_medida varchar(50),
    medida_individual decimal(5,3),
    cantidad int,
    total decimal(6,2)
);*/
create table tipo_insumo
(
    id_tipo_insumo int primary key  auto_increment,
    nombre_insumo varchar (50)
);
create table insumo
(
    id_insumo int primary key  auto_increment,
    id_proveedor_insumo int,
    id_tipo_insumo int,
    nombre_insumo varchar(100),
    unidad_de_medida varchar(50),
    medida_individual decimal(5,2),
    cantidad int,
    precio_individual decimal(6,2),
    subtotal decimal (10,3),
    total decimal(7,2),
    foreign key (id_tipo_insumo) references tipo_insumo(id_tipo_insumo),
    foreign key (id_proveedor_insumo) references proveedor_insumo (id_proveedor_insumo)
);

CREATE TABLE  producto
(
    id_producto INT PRIMARY KEY auto_increment,
    nombre VARCHAR (30),
    precio DECIMAL(5,2)
);
CREATE TABLE bebida
(
    id_bebida INT PRIMARY KEY AUTO_INCREMENT,
    id_insumo INT,
    id_producto INT,
    FOREIGN KEY (id_insumo) REFERENCES  insumo (id_insumo),
    fOREIGN KEY (id_producto) REFERENCES producto (id_producto)
);


CREATE TABLE platillo
(
  id_platillo INT AUTO_INCREMENT PRIMARY KEY ,
  id_producto INT,
  nombre_platillo VARCHAR (30),
  descripcion TEXT,
    FOREIGN KEY (id_producto) REFERENCES producto (id_producto)
);
CREATE TABLE insumo_platillo
(
    id_insumo_platillo INT PRIMARY KEY  AUTO_INCREMENT,
    id_tipo_insumo INT,
    id_platillo INT,
    FOREIGN KEY (id_tipo_insumo) REFERENCES  tipo_insumo (id_tipo_insumo),
    foreign key (id_platillo) REFERENCES  platillo (id_platillo)
);
CREATE TABLE cliente
(
    id_cliente INT PRIMARY KEY AUTO_INCREMENT,
    cod_cliente INT NOT NULL UNIQUE ,
    nombre_cliente VARCHAR (30)
);
create  table estado_pedido
(
  id_estado_pedido int primary key  auto_increment,
  estado varchar (10)
);
INSERT INTO estado_pedido (estado) values ('PREPARANDO'),( 'FINALIZADO');
create table orden
(
    id_orden INT PRIMARY KEY AUTO_INCREMENT,
    id_cliente int,
    id_estado_pedido int,
    descripcion text,
    fecha VARCHAR(14),
    total decimal (6,2),
    foreign key (id_cliente) references  cliente (id_cliente),
    foreign key (id_estado_pedido) references estado_pedido (id_estado_pedido)
);

CREATE TABLE detalle_orden
(
    id_detalle_orden INT PRIMARY KEY AUTO_INCREMENT,
    id_orden INT,
    id_producto int,
    cantidad int,
    precio decimal (6,2),
    subtotal decimal (6,2),
    foreign key (id_producto) references  producto(id_producto),
    foreign key (id_orden) references  orden(id_orden)
);
create procedure sp_get_products ()
BEGIN
    select * from producto;
end;
CREATE OR REPLACE procedure sp_get_last_num_pedido ()
    begin
        SELECT (select distinct  id_orden from orden order by id_orden desc LIMIT 1)+1 as num_orden;
    end;

create or replace procedure sp_proveedor_cb ()
begin
    select * from proveedor;
end;
CREATE OR REPLACE PROCEDURE reg_proveedor_insumo (id_prov int,precio_tot decimal (6,2),fecha_comp varchar(12))
    begin
        insert into proveedor_insumo (id_proveedor, precio_total, fecha_compra)
        values (id_prov,precio_tot,fecha_comp);
    end;

CREATE OR REPLACE PROCEDURE sp_reg_insumo (id_prov INT,id_tip INT ,nomb_ins VARCHAR(50),unid_med VARCHAR(10),med_ind INT,can INT,total decimal(6,2),prec_indivi DECIMAL(6,2),sub_total DECIMAL(9,2))
BEGIN
    insert into insumo (id_proveedor_insumo, id_tipo_insumo, nombre_insumo, unidad_de_medida, medida_individual, cantidad, total,precio_individual,subtotal)
    values (id_prov, id_tip, nomb_ins, unid_med, med_ind,can,(cantidad*medida_individual),prec_indivi,sub_total);
END;
INSERT INTO tipo_insumo (nombre_insumo) values ('papa'),('arroz'),('lechuga'),('bebida'),('zanahoria');
##SELECT @@foreign_key_checks;




