USE sistemaventas;

CREATE VIEW VistaUsuarios AS
SELECT 
<<<<<<< HEAD
    U.IDUsuario, 
=======
    U.ID_Usuario, 
>>>>>>> 2009d1e448be5357596773ea12ca16823d4aa77a
    U.Usuario, 
    U.Clave, 
    R.Rol AS Rol,
    CONCAT(E.Nombres, ' ', E.Apellidos) AS Empleado,
    ES.Descripcion AS Estado
FROM 
    Usuarios U
INNER JOIN 
<<<<<<< HEAD
    Empleados E ON U.IDEmpleado = E.IDEmpleado
INNER JOIN 
    Roles R ON U.IDRol = R.IDRol
INNER JOIN 
    Estados ES ON U.IDEstado = ES.IDEstado;
    
CREATE VIEW VistaProductos AS
SELECT 
    P.IDProducto, 
    P.Producto, 
    P.Stock, 
    P.Precio, 
    DATE_FORMAT(P.FechaFabricacion, '%d-%m-%Y' ) AS FechaFabricacion, 
    DATE_FORMAT(P.FechaVencimiento, '%d-%m-%Y' ) AS FechaVencimiento, 
=======
    Empleados E ON U.ID_Empleado = E.ID_Empleado
INNER JOIN 
    Roles R ON U.ID_Rol = R.ID_Rol
INNER JOIN 
    Estados ES ON U.ID_Estado = ES.ID_Estado;
    
CREATE VIEW VistaProductos AS
SELECT 
    P.ID_Producto, 
    P.Producto, 
    (SELECT
        Kr.Stock
    FROM
        Kardex Kr
    INNER JOIN
        Compras Com ON Kr.ID_Compra = Com.ID_Compra
    INNER JOIN
        Productos Prod ON Com.ID_Producto = Prod.ID_Producto) AS Stock,
    P.PrecioCompra, 
    DATE_FORMAT(P.FechaFabricacion, '%d-%m-%Y') AS FechaFabricacion, 
    DATE_FORMAT(P.FechaVencimiento, '%d-%m-%Y') AS FechaVencimiento, 
>>>>>>> 2009d1e448be5357596773ea12ca16823d4aa77a
    P.Descripcion, 
    PR.Proveedor, 
    C.Categoria
FROM 
    Productos P
INNER JOIN 
<<<<<<< HEAD
    Proveedores PR ON P.IDProveedor = PR.IDProveedor
INNER JOIN 
    Categorias C ON P.IDCategoria = C.IDCategoria
ORDER BY 
    P.Producto ASC;
    
CREATE VIEW VistaVentas AS
SELECT 
    V.IDVenta,
=======
    Proveedores PR ON P.ID_Proveedor = PR.ID_Proveedor
INNER JOIN 
    Categorias C ON P.ID_Categoria = C.ID_Categoria
ORDER BY 
    P.Producto ASC;


    
CREATE VIEW VistaVentas AS
SELECT 
    V.ID_Venta,
>>>>>>> 2009d1e448be5357596773ea12ca16823d4aa77a
    DATE_FORMAT(V.FechaVenta, '%d-%m-%Y' ) AS FechaVenta, 
    U.Usuario AS Usuario, 
    CONCAT(C.Nombres, ' ', C.Apellidos) AS Cliente, 
    P.Producto AS Producto, 
<<<<<<< HEAD
    V.Precio,
    V.Cantidad, 
    V.Total
FROM 
    Ventas V
INNER JOIN 
    Usuarios U ON V.IDUsuario = U.IDUsuario
INNER JOIN 
    Clientes C ON V.IDCliente = C.IDCliente
INNER JOIN 
    Productos P ON V.IDProducto = P.IDProducto;
    
CREATE VIEW VistaEmpleados AS
SELECT 
    e.IDEmpleado,
=======
    (P.PrecioCompra * 1.2) as Precio,
    V.CantidadSaliente, 
    V.TotalCobrar
FROM 
    Ventas V
INNER JOIN 
    Usuarios U ON V.ID_Usuario = U.ID_Usuario
INNER JOIN 
    Clientes C ON V.ID_Cliente = C.ID_Cliente
INNER JOIN 
    Productos P ON V.ID_Producto = P.ID_Producto;
    
CREATE VIEW VistaClientes AS
SELECT 
    c.ID_Cliente,
    c.Nombres,
    c.Apellidos,
    c.Correo,
    c.Linea1,
    c.Linea2,
	c.CodigoPostal,
    d.Departamento AS Departamento,
    m.Municipio AS Municipio,
    dis.Distrito AS Distrito
FROM 
    Clientes c
LEFT JOIN 
    Municipios m ON c.ID_Municipio = m.ID_Municipio
LEFT JOIN 
    Departamentos d ON c.ID_Departamento = d.ID_Departamento
LEFT JOIN 
    Distritos dis ON c.ID_Distrito = dis.ID_Distrito;
    
CREATE VIEW VistaEmpleados AS
SELECT 
    e.ID_Empleado,
>>>>>>> 2009d1e448be5357596773ea12ca16823d4aa77a
    e.Nombres,
    e.Apellidos,
    e.DUI,
    e.Telefono,
    e.Correo,
    e.Linea1,
    e.Linea2,
	e.CodigoPostal,
    d.Departamento AS Departamento,
    m.Municipio AS Municipio,
    dis.Distrito AS Distrito
FROM 
    Empleados e
LEFT JOIN 
    Departamentos d ON e.ID_Departamento = d.ID_Departamento
LEFT JOIN 
    Municipios m ON e.ID_Municipio = m.ID_Municipio
LEFT JOIN 
    Distritos dis ON e.ID_Distrito = dis.ID_Distrito;
    
<<<<<<< HEAD
CREATE VIEW VistaClientes AS
SELECT 
    c.IDCliente,
    c.Nombres,
    c.Apellidos,
    c.Correo,
    c.Linea1,
    c.Linea2,
	c.CodigoPostal,
    d.Departamento AS Departamento,
    m.Municipio AS Municipio,
    dis.Distrito AS Distrito
FROM 
    Clientes c
LEFT JOIN 
    Municipios m ON c.ID_Municipio = m.ID_Municipio
LEFT JOIN 
    Departamentos d ON c.ID_Departamento = d.ID_Departamento
LEFT JOIN 
    Distritos dis ON c.ID_Distrito = dis.ID_Distrito;
    
CREATE VIEW VistaProveedores AS
SELECT 
    p.IDProveedor,
=======
CREATE VIEW VistaProveedores AS
SELECT 
    p.ID_Proveedor,
>>>>>>> 2009d1e448be5357596773ea12ca16823d4aa77a
    p.Proveedor,
    p.Contacto,
    p.Correo,
    p.Linea1,
    p.Linea2,
	p.CodigoPostal,
    d.Departamento AS Departamento,
    m.Municipio AS Municipio,
    dis.Distrito AS Distrito
FROM 
    Proveedores p
LEFT JOIN 
    Municipios m ON p.ID_Municipio = m.ID_Municipio
LEFT JOIN 
    Departamentos d ON p.ID_Departamento = d.ID_Departamento
LEFT JOIN 
    Distritos dis ON p.ID_Distrito = dis.ID_Distrito;
<<<<<<< HEAD





=======
>>>>>>> 2009d1e448be5357596773ea12ca16823d4aa77a
