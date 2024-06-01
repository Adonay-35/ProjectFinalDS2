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
    ID_Compra int not null,
    ID_Venta int not null,
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


-- INSERCIONES 
-- DIRECCIONES
-- Departamentos
INSERT INTO Departamentos(Departamento, Pais ) VALUES
	('Ahuachapán', 'El Salvador'),
	('Cabañas', 'El Salvador'),
	('Chalatenango', 'El Salvador'),
	('Cuscatlán', 'El Salvador'),
	('La Libertad', 'El Salvador'),
	('La Paz', 'El Salvador'),
	('La Unión', 'El Salvador'),
	('Morazán', 'El Salvador'),
	('Santa Ana', 'El Salvador'),
	('San Miguel', 'El Salvador'),
	('San Salvador', 'El Salvador'),
	('San Vicente', 'El Salvador'),
	('Sonsonate', 'El Salvador'),
	('Usulután', 'El Salvador');

-- Municipios
INSERT INTO Municipios (Municipio, ID_Departamento) VALUES
('Ahuachapán Norte', 1),
('Ahuachapán Centro', 1),
('Ahuachapán Sur', 1),
('Cabañas Este', 2),
('Cabañas Oeste', 2),
('Chalatenango Norte', 3),
('Chalatenango Centro', 3),
('Chalatenango Sur', 3),
('Cuscatlán Norte', 4),
('Cuscatlán Sur', 4),
('La Libertad Norte', 5),
('La Libertad Centro', 5),
('La Libertad Oeste', 5),
('La Libertad Este', 5),
('La Libertad Sur', 5),
('La Libertad Costa', 5),
('La Paz Oeste', 6),
('La Paz Centro', 6),
('La Paz Este', 6),
('La Unión Norte', 7),
('La Unión Sur', 7),
('Morazán Norte', 8),
('Morazán Sur', 8),
('Santa Ana Norte', 9),
('Santa Ana Centro', 9),
('Santa Ana Este', 9),
('Santa Ana Oeste', 9),
('San Miguel Norte', 10),
('San Miguel Centro', 10),
('San Miguel Oeste', 10),
('San Salvador Norte', 11),
('San Salvador Oeste', 11),
('San Salvador Este', 11),
('San Salvador Centro', 11),
('San Salvador Sur', 11),
('San Vicente Norte', 12),
('San Vicente Sur', 12),
('Sonsonate Norte', 13),
('Sonsonate Centro', 13),
('Sonsonate Este', 13),
('Sonsonate Oeste', 13),
('Usulután Norte', 14),
('Usulután Este', 14),
('Usulután Oeste', 14);

-- Distritos
INSERT INTO Distritos (Distrito, ID_Municipio) VALUES
-- Ahuachapan
('Atiquizaya', 1),
('El Refugio', 1),
('San Lorenzo', 1),
('Turín', 1),
('Ahuachapán', 2),
('Apaneca', 2),
('Concepción de Ataco', 2),
('Tacuba', 2),
('Guaymango', 3),
('Jujutla', 3),
('San Francisco Menéndez', 3),
('San Pedro Puxtla', 3),
-- Cabañas
('Sensuntepeque', 4),
('Victoria', 4),
('Dolores', 4),
('Guacotecti', 4),
('San Isidro', 4),
('Ilobasco', 5),
('Tejutepeque', 5),
('Jutiapa', 5),
('Cinquera', 5),
-- Chalatenango
('La Palma', 6),
('Citalá', 6),
('San Ignacio', 6),
('Nueva Concepción', 7),
('Tejutla', 7),
('La Reina', 7),
('Agua Caliente', 7),
('Dulce Nombre de María', 7),
('El Paraíso', 7),
('San Fernando', 7),
('San Francisco Morazán', 7),
('San Rafael', 7),
('Santa Rita', 7),
('Chalatenango', 8),
('Arcatao', 8),
('Azacualpa', 8),
('Comalapa', 8),
('Concepción Quezaltepeque', 8),
('El Carrizal', 8),
('La Laguna', 8),
('Las Vueltas', 8),
('Nombre de Jesús', 8),
('Nueva Trinidad', 8),
('Ojos de Agua', 8),
('Potonico', 8),
('San Antonio de La Cruz', 8),
('San Antonio Los Ranchos', 8),
('San Francisco Lempa', 8),
('San Isidro Labrador', 8),
('San José Cancasque', 8),
('San Miguel de Mercedes', 8),
('San José Las Flores', 8),
('San Luis del Carmen', 8),
-- Cuscatlán
('Suchitoto', 9),
('San José Guayabal', 9),
('Oratorio de Concepción', 9),
('San Bartolomé Perulapía', 9),
('San Pedro Perulapán', 9),
('Cojutepeque', 10),
('San Rafael Cedros', 10),
('Candelaria', 10),
('Monte San Juan', 10),
('El Carmen', 10),
('San Cristobal', 10),
('Santa Cruz Michapa', 10),
('San Ramón', 10),
('El Rosario', 10),
('Santa Cruz Analquito', 10),
('Tenancingo', 10),
-- La Libertad
('Quezaltepeque', 11),
('San Matías', 11),
('San Pablo Tacachico', 11),
('San Juan Opico', 12),
('Ciudad Arce', 12),
('Colón', 13),
('Jayaque', 13),
('Sacacoyo', 13),
('Tepecoyo', 13),
('Talnique', 13),
('Antiguo Cuscatlán', 14),
('Huizúcar', 14),
('Nuevo Cuscatlán', 14),
('San José Villanueva', 14),
('Zaragoza', 14),
('Comasagua', 15),
('Santa Tecla', 15),
('Chiltiupán', 16),
('Jicalapa', 16),
('La Libertad', 16),
('Tamanique', 16),
('Teotepeque', 16),
-- La Paz
('Cuyultitan', 17),
('Olocuilta', 17),
('San Juan Talpa', 17),
('San Luis Talpa', 17),
('San Pedro Masahuat', 17),
('Tapalhuaca', 17),
('San Francisco Chinameca', 17),
('El Rosario', 18),
('Jerusalén', 18),
('Mercedes La Ceiba', 18),
('Paraíso de Osorio', 18),
('San Antonio Masahuat', 18),
('San Emigdio', 18),
('San Juan Tepezontes', 18),
('San Luís La Herradura', 18),
('San Miguel Tepezontes', 18),
('San Pedro Nonualco', 18),
('Santa María Ostuma', 18),
('Santiago Nonualco', 18),
('San Juan Nonualco', 19),
('San Rafael Obrajuelo', 19),
('Zacatecoluca', 19),
-- La Unión
('Anamorós', 20),
('Bolivar', 20),
('Concepción de Oriente', 20),
('El Sauce', 20),
('Lislique', 20),
('Nueva Esparta', 20),
('Pasaquina', 20),
('Polorós', 20),
('San José La Fuente', 20),
('Santa Rosa de Lima', 20),
('Conchagua', 21),
('El Carmen', 21),
('Intipucá', 21),
('La Unión', 21),
('Meanguera del Golfo', 21),
('San Alejo', 21),
('Yayantique', 21),
('Yucuaiquín', 21),
-- Morazán
('Arambala', 22),
('Cacaopera', 22),
('Corinto', 22),
('El Rosario', 22),
('Joateca', 22),
('Jocoaitique', 22),
('Meanguera', 22),
('Perquín', 22),
('San Fernando', 22),
('San Isidro', 22),
('Torola', 22),
('Chilanga', 23),
('Delicias de Concepción', 23),
('El Divisadero', 23),
('Gualococti', 23),
('Guatajiagua', 23),
('Jocoro', 23),
('Lolotiquillo', 23),
('Osicala', 23),
('San Carlos', 23),
('San Francisco Gotera', 23),
('San Simón', 23),
('Sensembra', 23),
('Sociedad', 23),
('Yamabal', 23),
('Yoloaiquín', 23),
-- Santa Ana
('Masahuat', 24),
('Metapán', 24),
('Santa Rosa Guachipilín', 24),
('Texistepeque', 24),
('Santa Ana', 25),
('Coatepeque', 26),
('El Congo', 26),
('Candelaria de la Frontera', 27),
('Chalchuapa', 27),
('El Porvenir', 27),
('San Antonio Pajonal', 27),
('San Sebastián Salitrillo', 27),
('Santiago de La Frontera', 27),
-- San Miguel
('Ciudad Barrios', 28),
('Sesori', 28),
('Nuevo Edén de San Juan', 28),
('San Gerardo', 28),
('San Luis de La Reina', 28),
('Carolina', 28),
('San Antonio del Mosco', 28),
('Chapeltique', 28),
('San Miguel', 29),
('Comacarán', 29),
('Uluazapa', 29),
('Moncagua', 29),
('Quelepa', 29),
('Chirilagua', 29),
('Chinameca', 30),
('Nueva Guadalupe', 30),
('Lolotique', 30),
('San Jorge', 30),
('San Rafael Oriente', 30),
('El Tránsito', 30),
-- San Salvador
('Aguilares', 31),
('El Paisnal', 31),
('Guazapa', 31),
('Apopa', 32),
('Nejapa', 32),
('Ilopango', 33),
('San Martín', 33),
('Soyapango', 33),
('Tonacatepeque', 33),
('Ayutuxtepeque', 34),
('Mejicanos', 34),
('San Salvador', 34),
('Cuscatancingo', 34),
('Ciudad Delgado', 34),
('Panchimalco', 34),
('Rosario de Mora', 34),
('San Marcos', 34),
('Santiago Texacuangos', 34),
('Santo Tomás', 34),
-- San Vicente
('Apastepeque', 35),
('San Ildefonso', 35),
('San Esteban Catarina', 35),
('San Lorenzo', 35),
('San Sebastián', 35),
('Tecoluca', 35),
('San Vicente', 36),
('Guadalupe', 36),
('Tepetitán', 36),
('Santo Domingo', 36),
('Verapaz', 36),
-- Sonsonate
('Izalco', 37),
('Caluco', 37),
('Nahuizalco', 37),
('Armenia', 37),
('Juayúa', 37),
('Salcoatitán', 37),
('Sonsonate', 38),
('Acajutla', 38),
('San Julián', 38),
('Santo Domingo de Guzmán', 38),
('Sonzacate', 38),
('Cuisnahuat', 39),
('San Antonio del Monte', 39),
('Santa Catarina Masahuat', 39),
('Santo Domingo', 39),
('Nahulingo', 39),
-- Usulután
('Santa Elena', 40),
('Jucuapa', 40),
('Jiquilisco', 41),
('Puerto El Triunfo', 41),
('San Agustín', 41),
('Berlín', 42),
('Mercedes Umaña', 42),
('San Buenaventura', 42),
('California', 43),
('Ereguayquín', 43),
('Santa María', 43),
('Ozatlán', 43),
('San Francisco Javier', 43),
('Tecapán', 43),
('Concepción Batres', 43),
('San Dionisio', 43),
('Usulután', 43),
('Alegría', 44),
('Santiago de María', 44);

INSERT INTO Roles (Rol) VALUES
("Administrador"),
("Almacenista"),
("Vendedor");

INSERT INTO Estados (Estado, Descripcion) VALUES
('0', "Inactivo"),
('1', "Activo");

INSERT INTO Clientes (Nombres, Apellidos, Correo, Linea1, Linea2, ID_Distrito, CodigoPostal, ID_Departamento, ID_Municipio) VALUES
("Juan Daniel", "López Pérez", "cliente1@correo.com", "Col Madera, Calle 1, #1N", "Frente al parque", 1, 1001, 1, 1),
("Pedro Armando", "Escamoso Barrientos", "cliente2@correo.com", "Col Madera, Calle 1, #1N", "Frente al parque", 2, 1002, 2, 2),
("José María", "Zotelo Bran", "cliente3@correo.com", "Col Madera, Calle 1, #1N", "Frente al parque", 3, 1003, 3, 3),
("María José", "Pérez Zosa", "cliente4@correo.com", "Col Madera, Calle 1, #1N", "Frente al parque", 4, 1004, 4, 4),
("Flor Del Carmen", "Najarro Hernádez", "cliente5@correo.com", "Col Madera, Calle 1, #1N", "Frente al parque", 5, 1005, 5, 5);


INSERT INTO Empleados (Nombres, Apellidos, DUI, Telefono, Correo, Linea1, Linea2, ID_Distrito, CodigoPostal, ID_Departamento, ID_Municipio) VALUES
("Juan José", "López Pérez", "11111111-1", "1234-5678", "empleado1@correo.com", "Col La Paz, Calle 1, #101", "Cerca del mercado", 1, 1001, 1, 1),
("María Elena", "García Martínez", "22222222-2", "2234-5678", "empleado2@correo.com", "Col La Esperanza, Calle 2, #202", "Frente a la iglesia", 2, 1002, 2, 2),
("Pedro Antonio", "Martínez López", "33333333-3", "3234-5678", "empleado3@correo.com", "Col Las Flores, Calle 3, #303", "Junto a la escuela", 3, 1003, 3, 3),
("Laura Isabel", "Pérez Rodríguez", "44444444-4", "4234-5678", "empleado4@correo.com", "Col Los Almendros, Calle 4, #404", "Cerca del parque central", 4, 1004, 4, 4),
("Carlos Andrés", "Hernández Bonilla", "55555555-5", "5234-5678", "empleado5@correo.com", "Col Los Pinos, Calle 5, #505", "A la par del supermercado", 5, 1005, 5, 5);


INSERT INTO Proveedores (Proveedor, Contacto, Correo, Linea1, Linea2, ID_Distrito, CodigoPostal, ID_Departamento, ID_Municipio) VALUES
('Refrescos Delicia', '12345678', 'ventas@refrescosdelicia.com', 'Col Central, Calle A, #101', 'Cerca de la plaza', 1, 1101, 1, 1),
('Distribuidora de Golosinas', '98765432', 'ventas@golosinasdistribuidora.com', 'Col Las Delicias, Calle B, #202', 'Frente al estadio', 2, 1102, 2, 2),
('Suministros Industriales Hermanos Pérez', '32178904', 'ventas@suministroshermanosperez.com', 'Col Industrial, Calle C, #303', 'A un costado del hospital', 3, 1103, 3, 3),
('Electrodomésticos Vargas', '56789012', 'ventas@electrodomesticosvargas.com', 'Col Los Robles, Calle D, #404', 'Al lado del centro comercial', 4, 1104, 4, 4),
('Distribuidora de Juguetes Felices', '67890123', 'ventas@juguetesfelices.com', 'Col Los Laureles, Calle E, #505', 'Cerca del parque infantil', 5, 1105, 5, 5);


INSERT INTO Categorias (Categoria) VALUES
('Lácteos'),
('Carnes'), -- /(pollo, res, cerdo)/
('Mariscos'), -- /(pescado, camarón, etc.)/
('Alimentos enlatados'),
('Bebidas embotelladas'), -- /(plastico y vidrio)/
('Bebidas enlatadas'),
('Bebidas para preparar'), -- /(cafe en polvo, Tang, Yus, etc.)/
('Cereales'), -- /(maiz, frijol, arroz, etc)/
('Frutas'),
('Pastas'), -- /(spaggeti, lasagña, etc.)/
('Hortalizas'), -- /(incluye verduras y legumbres)/
('Desechables'),
('Cocina'), -- /(utensilios)/
('Postres'),
('Golosinas'),
('Deporte'),
('Belleza'),
('Electrodomésticos'),
('Limpieza'),
('Escolares'),
('Juguetes'),
('Mascotas'); -- /(Comida y accesorios para mascotas)/

INSERT INTO Usuarios(Usuario, Clave, ID_Rol, ID_Empleado, ID_Estado) VALUES
("Admin",  SHA2('adm', 256), 1, 1, 1),
("Almacen",  SHA2('alm', 256), 2, 2, 2),
("Ventas",  SHA2('vnt', 256), 1, 3, 1),
("Laura",  SHA2('lau', 256), 3, 4, 2),
("Carlos",  SHA2('car', 256), 2, 5, 1);

/*A los productos que no venzan se les pondrá como año de vencimiento "2100-01-01" y a los productos tales como frutas u hortalizas
que no tengan fechas especificadas se les dará un aproximado de vida de 10 días a partir de
su ingreso al sistema (se debe verificar su estado de manera física)*/
INSERT INTO Productos (Producto, FechaFabricacion, FechaVencimiento,Descripcion, PrecioCompra, ID_Proveedor, ID_Categoria) VALUES
('Refresco de cola', '2024-01-01 13:00:00', '2025-01-01 13:00:00', 'Refresco de cola en lata de 355ml', 1.99, 1, 6),
('Bolsa de papas fritas', '2024-01-01 14:00:00', '2024-01-02 14:00:00', 'Bolsa de papas fritas de 100g', 2.49, 2, 15),
('Jabón de manos', '2023-01-01 15:00:00', '2026-01-01 15:00:00', 'Jabón líquido para manos con aroma a manzana', 5.99, 3, 19),
('Caja de dulces surtidos', '2024-01-01 16:00:00', '2024-05-01 16:00:00', 'Caja de dulces surtidos, ideal para regalo', 1.99, 4, 15),
('Lápiz de colores', '2022-01-01 17:00:00', '2100-01-01 17:00:00', 'Paquete de 12 lápices de colores surtidos', 0.99, 5, 21);

INSERT INTO Compras (FechaCompra, ID_Usuario, ID_Proveedor, ID_Producto, CantidadEntrante, TotalPagar) VALUES
('2024-01-01 08:30:00', 4, 1, 1, 4, 7.96),
('2024-01-02 10:15:00', 4, 2, 3, 3, 7.47),
('2024-01-03 13:45:00', 5, 3, 4, 5, 29.95),
('2024-01-04 15:20:00', 3, 4, 5, 4, 7.96),
('2024-01-05 17:00:00', 5, 5, 2, 7, 6.93);

INSERT INTO Ventas (FechaVenta, ID_Usuario, ID_Cliente, ID_Producto, PrecioVenta, CantidadSaliente, TotalCobrar) VALUES
('2024-05-01 08:30:00', 4, 1, 1, 1.99, 4, 7.96),
('2024-05-02 10:15:00', 4, 2, 3, 2.49, 3, 7.47),
('2024-05-03 13:45:00', 5, 3, 4, 5.99, 5, 29.95),
('2024-05-04 15:20:00', 3, 4, 5, 1.99, 4, 7.96),
('2024-05-05 17:00:00', 5, 5, 2, 0.99, 7, 6.93);

INSERT INTO Kardex (ID_Compra, ID_Venta, Stock) VALUES
(1, 1, 0),
(2, 2, 0),
(3, 3, 0),
(4, 4, 0),
(5, 5, 0)

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
    SELECT ID_Producto, Producto FROM Productos;
END //
DELIMITER ;


DELIMITER $$
CREATE PROCEDURE BuscarUsuario(IN usuario varchar(200))
BEGIN
SELECT *
FROM usuarios
WHERE nomUsuario LIKE CONCAT(usuario,'%');
END

DELIMITER $$
CREATE PROCEDURE InsertarUsuario(IN nomUsuario varchar(200), usuario varchar(50), contrasena varchar(10), idPermiso int, idEstado int)
BEGIN
INSERT INTO usuarios (nomUsuario, usuario, contrasena, idPermiso, idEstado)
VALUES (nomUsuario, usuario, contrasena, idPermiso, idEstado);
END

DELIMITER $$
CREATE PROCEDURE ActualizarUsuario(IN id int, nomUsuario varchar(200), usuario varchar(50), contrasena varchar(10), idPermiso int, idEstado int)
BEGIN
UPDATE usuarios 
SET nomUsuario=nomUsuario, usuario=usuario, contrasena=contrasena, idPermiso=idPermiso, idEstado=idEstado
WHERE idUsuario=id;
END

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

DELIMITER $$
CREATE PROCEDURE BuscarProveedor(IN proveedor varchar(100))
BEGIN
SELECT *
FROM proveedores
WHERE nomProveedor LIKE CONCAT(proveedor,'%');
END

DELIMITER $$
CREATE PROCEDURE InsertarProveedor(IN nomProveedor varchar(100), numContacto double, direccion varchar(200), email varchar(80))
BEGIN
INSERT INTO proveedores (nomProveedor, numContacto, direccion, email)
VALUES (nomProveedor, numContacto, direccion, email);
END

DELIMITER $$
CREATE PROCEDURE ActualizarProveedor(IN id int, nomProveedor varchar(100), numContacto double, direccion varchar(200), email varchar(80))
BEGIN
UPDATE proveedores 
SET nomProveedor=nomProveedor, numContacto=numContacto, direccion=direccion, email=email
WHERE idProveedor=id;
END

DELIMITER $$
CREATE PROCEDURE InsertarProducto(IN idProducto int, nomProducto varchar(200), stock int, precio double, descripcion text, idProveedor int)
BEGIN
INSERT INTO productos (idProducto, nomProducto, stock, precio, descripcion, idProveedor)
VALUES (idProducto, nomProducto, stock, precio, descripcion, idProveedor);
END

DELIMITER $$
CREATE PROCEDURE ActualizarProducto(IN id int, nomProducto varchar(200), stock int, precio double, descripcion text, idProveedor int)
BEGIN
UPDATE productos 
SET nomProducto=nomProducto, stock=stock, precio=precio, descripcion=descripcion, idProveedor=idProveedor
WHERE idProducto=id;
END

DELIMITER $$
CREATE PROCEDURE BuscarProducto(IN producto varchar(200))
BEGIN
SELECT prod.*, prov.nomProveedor
FROM productos prod
INNER JOIN proveedores prov ON prod.idProveedor=prov.idProveedor
WHERE idProducto LIKE CONCAT(producto,'%') OR nomProducto LIKE CONCAT(producto, '%');
END

DELIMITER $$
CREATE PROCEDURE BuscarProductoVenta(IN codigo varchar(200))
BEGIN
SELECT idProducto, nomProducto, stock, precio, descripcion
FROM productos
WHERE idProducto LIKE CONCAT(codigo,'%');
END

DELIMITER $$
CREATE PROCEDURE ObtenerNombreProducto(IN codigo varchar(200))
BEGIN
SELECT idProducto, nomProducto, descripcion
FROM productos
WHERE idProducto LIKE CONCAT(codigo,'%');
END

/* VENTAS */
DELIMITER $$
CREATE PROCEDURE InsertarVenta(IN idVenta varchar(20), fechaVenta datetime, idUsuario int, idProductos mediumtext, total double)
BEGIN
INSERT INTO ventas(idVenta, fechaVenta, idUsuario, idProductos, total)
VALUES (idVenta, fechaVenta, idUsuario, idProductos, total);
END

DELIMITER $$
CREATE PROCEDURE ActualizarStock(IN codigo varchar(100), cantidad int)
BEGIN
UPDATE productos
SET stock=stock-cantidad
WHERE idProducto=codigo;
END

/* REPORTES */
DELIMITER $$
CREATE PROCEDURE ObtenerVentas(IN fechaInicial varchar(20), fechaFinal varchar(20))
BEGIN
SELECT ventas.*, usuarios.nomUsuario 
FROM ventas 
INNER JOIN usuarios ON ventas.idUsuario=usuarios.idUsuario
WHERE idVenta BETWEEN (fechaInicial) AND (fechaFinal);
END

/* PROCEDIMIENTO ALMACENADO LOGIN */
DELIMITER $$
CREATE PROCEDURE LoginUsuario(IN Usuario varchar(50), Clave varchar(32))
BEGIN
SELECT *
FROM Usuarios
WHERE Usuarios.Usuario=Usuario AND Usuarios.Clave=Clave;
END