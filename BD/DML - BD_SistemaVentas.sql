-- CREACION BASE DE DATOS
CREATE DATABASE SistemaVentas;
USE SistemaVentas;

-- CREACION TABLAS DEL SISTEMA
create table Departamentos(
	ID_Departamento int auto_increment primary key,
	Departamento varchar(60) not null,
	Pais varchar(60)
);

create table Municipios(
	ID_Municipio int auto_increment primary key,
	Municipio varchar(60) not null,
	ID_Departamento int not null
);

create table Distritos(
	ID_Distrito int auto_increment primary key,
	Distrito varchar(60) not null,
	ID_Municipio int not null
);

CREATE TABLE Roles(
	ID_Rol int auto_increment primary key,
	Rol varchar(50) not null
);

CREATE TABLE Estados(
	ID_Estado int auto_increment primary key,
	Estado boolean not null,
	Descripcion varchar(10) not null
);

CREATE TABLE Empleados (
	ID_Empleado int auto_increment primary key,
    Nombres varchar(50) not null,
    Apellidos varchar(50) not null,
    FechaNac date not null,
    DUI varchar(10) not null,
    Telefono varchar(9) not null,
    Correo varchar(50) not null,
    Linea1 varchar(100) not null,
	Linea2 varchar(100) not null,
	ID_Distrito int not null,
	CodigoPostal int not null,
	ID_Departamento int not null,
	ID_Municipio int not null
);

CREATE TABLE Clientes (
	ID_Cliente int auto_increment primary key,
    Nombres varchar(50) not null,
    Apellidos varchar(50) not null,
    Correo varchar(50) not null,
    Linea1 varchar(100) not null,
	Linea2 varchar(100) not null,
	ID_Distrito int not null,
	CodigoPostal int not null,
	ID_Departamento int not null,
	ID_Municipio int not null
);

CREATE TABLE Proveedores(
	ID_Proveedor int auto_increment primary key,
	Proveedor varchar(100) not null,
	Contacto double not null,
	Correo varchar(80) not null,
	Linea1 varchar(100) not null,
	Linea2 varchar(100) not null,
	ID_Distrito int not null,
	CodigoPostal int not null,
	ID_Departamento int not null,
	ID_Municipio int not null
);

CREATE TABLE Categorias(
	ID_Categoria int auto_increment primary key,
    Categoria varchar(50) not null
);

CREATE TABLE Usuarios(
	ID_Usuario int auto_increment primary key,
	Usuario varchar(50) not null,
	Clave varchar(200) not null,
	ID_Rol int not null,
	ID_Empleado int not null,
    ID_Estado int not null
);

CREATE TABLE Productos (
    ID_Producto int auto_increment primary key,
    Producto varchar(200) not null,
    FechaFabricacion datetime not null,
    FechaVencimiento datetime not null,
    Descripcion varchar(100) not null,
    PrecioCompra double not null,
    ID_Proveedor int not null,
    ID_Categoria int not null
);

CREATE TABLE Compras (
    ID_Compra int auto_increment primary key,
    FechaCompra date not null,
    ID_Usuario int not null,
    ID_Proveedor int not null,
    ID_Producto  int not null,
    CantidadEntrante int not null,
    TotalPagar decimal(18, 2) not null
);

CREATE TABLE Ventas (
    ID_Venta int auto_increment primary key,
    FechaVenta date not null,
    ID_Usuario int not null,
    ID_Cliente int not null,
    ID_Producto  int not null,
    PrecioVenta decimal(18, 2) not null, 
    CantidadSaliente int not null,
    TotalCobrar decimal(18, 2) not null
);

CREATE TABLE Kardex(
	ID_Kardex int auto_increment primary key,
    ID_Compra int null,
    ID_Venta int null,
    Stock int not null
);

-- LLAVES FORANEAS
ALTER TABLE Municipios ADD CONSTRAINT fk_municipio_departamento FOREIGN KEY (ID_Departamento) REFERENCES Departamentos(ID_Departamento);
ALTER TABLE Distritos ADD CONSTRAINT fk_distrito_muncipio FOREIGN KEY (ID_Municipio) REFERENCES Municipios(ID_Municipio);
ALTER TABLE Empleados ADD CONSTRAINT fk_empleado_departamento FOREIGN KEY (ID_Departamento) REFERENCES Departamentos(ID_Departamento);
ALTER TABLE Empleados ADD CONSTRAINT fk_empleado_distrito FOREIGN KEY (ID_Distrito) REFERENCES Distritos(ID_Distrito);
ALTER TABLE Empleados ADD CONSTRAINT fk_empleado_municipio FOREIGN KEY (ID_Municipio) REFERENCES Municipios(ID_Municipio);
ALTER TABLE Clientes ADD CONSTRAINT fk_cliente_departamento FOREIGN KEY (ID_Departamento) REFERENCES Departamentos(ID_Departamento);
ALTER TABLE Clientes ADD CONSTRAINT fk_cliente_distrito FOREIGN KEY (ID_Distrito) REFERENCES Distritos(ID_Distrito);
ALTER TABLE Clientes ADD CONSTRAINT fk_cliente_municipio FOREIGN KEY (ID_Municipio) REFERENCES Municipios(ID_Municipio);
ALTER TABLE Proveedores ADD CONSTRAINT fk_proveedor_distrito FOREIGN KEY (ID_Distrito) REFERENCES Distritos(ID_Distrito);
ALTER TABLE Proveedores ADD CONSTRAINT fk_proveedor_departamento FOREIGN KEY (ID_Departamento) REFERENCES Departamentos(ID_Departamento);
ALTER TABLE Proveedores ADD CONSTRAINT fk_proveedor_municipio FOREIGN KEY (ID_Municipio) REFERENCES Municipios(ID_Municipio);
ALTER TABLE Usuarios ADD CONSTRAINT fk_usuario_rol FOREIGN KEY (ID_Rol) REFERENCES Roles(ID_Rol);
ALTER TABLE Usuarios ADD CONSTRAINT fk_usuario_empleado FOREIGN KEY (ID_Empleado) REFERENCES Empleados(ID_Empleado);
ALTER TABLE Usuarios ADD CONSTRAINT fk_usuario_estado FOREIGN KEY (ID_Estado) REFERENCES Estados(ID_Estado);
ALTER TABLE Productos ADD CONSTRAINT fk_producto_proveedor FOREIGN KEY (ID_Proveedor) REFERENCES Proveedores(ID_Proveedor);
ALTER TABLE Productos ADD CONSTRAINT fk_producto_categoria FOREIGN KEY (ID_Categoria) REFERENCES Categorias(ID_Categoria);
ALTER TABLE Compras ADD CONSTRAINT fk_compra_usuario FOREIGN KEY (ID_Usuario) REFERENCES Usuarios(ID_Usuario);
ALTER TABLE Compras ADD CONSTRAINT fk_compra_proveedor FOREIGN KEY (ID_Proveedor) REFERENCES Proveedores(ID_Proveedor);
ALTER TABLE Compras ADD CONSTRAINT fk_compra_producto FOREIGN KEY (ID_Producto) REFERENCES Productos(ID_Producto);
ALTER TABLE Ventas ADD CONSTRAINT fk_venta_usuario FOREIGN KEY (ID_Usuario) REFERENCES Usuarios(ID_Usuario);
ALTER TABLE Ventas ADD CONSTRAINT fk_venta_cliente FOREIGN KEY (ID_Cliente) REFERENCES Clientes(ID_Cliente);
ALTER TABLE Ventas ADD CONSTRAINT fk_venta_producto FOREIGN KEY (ID_Producto) REFERENCES Productos(ID_Producto);
ALTER TABLE Kardex ADD CONSTRAINT fk_kardex_compra FOREIGN KEY (ID_Compra) REFERENCES Compras(ID_Compra);
ALTER TABLE Kardex ADD CONSTRAINT fk_kardex_venta FOREIGN KEY (ID_Venta) REFERENCES Ventas(ID_Venta);

/* PROCEDIMIENTOS ALMACENADOS */

/* ESTADOS */
DELIMITER $$
CREATE PROCEDURE ObtenerEstados()
BEGIN
SELECT * 
FROM estados;
END $$

/* PERMISOS */
DELIMITER $$
CREATE PROCEDURE ObtenerRoles()
BEGIN
SELECT *
FROM roles;
END $$

/* PERMISOS */
DELIMITER $$
CREATE PROCEDURE ObtenerPermisos()
BEGIN
SELECT *
FROM permisos;
END $$

/* USUARIOS */
DELIMITER $$
CREATE PROCEDURE ObtenerUsuarios()
BEGIN
SELECT *
FROM usuarios;
END $$

DELIMITER $$
CREATE PROCEDURE ObtenerClientes()
BEGIN
SELECT *
FROM clientes;
END $$

DELIMITER $$
CREATE PROCEDURE ObtenerEmpleados()
BEGIN
SELECT ID_Empleado, Nombres,Apellidos
FROM empleados;
END $$

DELIMITER $$
CREATE PROCEDURE ObtenerDepartamentos()
BEGIN
SELECT ID_Departamento, Departamento
FROM departamentos;
END $$

DELIMITER $$
CREATE PROCEDURE ObtenerMunicipios()
BEGIN
SELECT ID_Municipio, Municipio
FROM municipios;
END $$

DELIMITER $$
CREATE PROCEDURE ObtenerDistritos()
BEGIN
SELECT ID_Distrito, Distrito
FROM distritos;
END $$

DELIMITER $$
CREATE PROCEDURE ObtenerDirecciones()
BEGIN
SELECT ID_Direccion, Linea
FROM direcciones;
END $$

DELIMITER //
CREATE PROCEDURE ObtenerProductos()
BEGIN
    SELECT 
        P.ID_Producto, 
        P.Producto, 
        P.PrecioCompra,
        (SELECT 
            SUM(Kr.Stock)
         FROM 
            Kardex Kr 
         INNER JOIN 
            Compras Com ON Kr.ID_Compra = Com.ID_Compra 
         WHERE 
            Com.ID_Producto = P.ID_Producto 
        ) AS Stock
    FROM 
        Productos P;
END //
DELIMITER ;

/* PROVEEDORES */
DELIMITER $$
CREATE PROCEDURE ObtenerProveedores()
BEGIN
SELECT *
FROM proveedores;
END $$

/* PROVEEDORES */
DELIMITER $$
CREATE PROCEDURE ObtenerCategorias()
BEGIN
SELECT *
FROM categorias;
END $$
