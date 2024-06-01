USE sistemaventas;

CREATE VIEW VistaUsuarios AS
SELECT 
    U.ID_Usuario, 
    U.Usuario, 
    U.Clave, 
    R.Rol AS Rol,
    CONCAT(E.Nombres, ' ', E.Apellidos) AS Empleado,
    ES.Descripcion AS Estado
FROM 
    Usuarios U
INNER JOIN 
    Empleados E ON U.ID_Empleado = E.ID_Empleado
INNER JOIN 
    Roles R ON U.ID_Rol = R.ID_Rol
INNER JOIN 
    Estados ES ON U.ID_Estado = ES.ID_Estado;
    
CREATE VIEW VistaProductosParaCompras AS
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
    P.Descripcion, 
    PR.Proveedor, 
    C.Categoria
FROM 
    Productos P
INNER JOIN 
    Proveedores PR ON P.ID_Proveedor = PR.ID_Proveedor
INNER JOIN 
    Categorias C ON P.ID_Categoria = C.ID_Categoria
ORDER BY 
    P.Producto ASC;

CREATE VIEW VistaProductosParaVentas AS
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
    (P.PrecioCompra * 1.2) as Precio,
    DATE_FORMAT(P.FechaFabricacion, '%d-%m-%Y') AS FechaFabricacion, 
    DATE_FORMAT(P.FechaVencimiento, '%d-%m-%Y') AS FechaVencimiento, 
    P.Descripcion, 
    PR.Proveedor, 
    C.Categoria
FROM 
    Productos P
INNER JOIN 
    Proveedores PR ON P.ID_Proveedor = PR.ID_Proveedor
INNER JOIN 
    Categorias C ON P.ID_Categoria = C.ID_Categoria
ORDER BY 
    P.Producto ASC;
    
    
CREATE VIEW VistaEmpleados AS
SELECT 
    e.ID_Empleado,
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
    
CREATE VIEW VistaProveedores AS
SELECT 
    p.ID_Proveedor,
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