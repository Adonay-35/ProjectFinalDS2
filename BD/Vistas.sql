USE sistemaventas;

CREATE VIEW VistaUsuarios AS
SELECT 
    U.IDUsuario, 
    U.Usuario, 
    U.Clave, 
    R.Rol AS Rol,
    CONCAT(E.Nombres, ' ', E.Apellidos) AS Empleado,
    ES.Descripcion AS Estado
FROM 
    Usuarios U
INNER JOIN 
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
    P.Descripcion, 
    PR.Proveedor, 
    C.Categoria
FROM 
    Productos P
INNER JOIN 
    Proveedores PR ON P.IDProveedor = PR.IDProveedor
INNER JOIN 
    Categorias C ON P.IDCategoria = C.IDCategoria
ORDER BY 
    P.Producto ASC;
    
CREATE VIEW VistaVentas AS
SELECT 
    V.IDVenta,
    DATE_FORMAT(V.FechaVenta, '%d-%m-%Y' ) AS FechaVenta, 
    U.Usuario AS Usuario, 
    CONCAT(C.Nombres, ' ', C.Apellidos) AS Cliente, 
    P.Producto AS Producto, 
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





