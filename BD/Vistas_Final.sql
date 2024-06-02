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
    
CREATE VIEW VistaVentas AS
SELECT 
    V.ID_Venta,
    V.FechaVenta, 
    U.Usuario AS Usuario, 
    CONCAT(C.Nombres, ' ', C.Apellidos) AS Cliente, 
    P.Producto AS Producto, 
    V.PrecioVenta,
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
    
CREATE VIEW VistaCompras AS
SELECT 
    C.ID_Compra,
    C.FechaCompra, 
    U.Usuario AS Usuario, 
    PR.Proveedor, 
    P.Producto AS Producto, 
    C.CantidadEntrante, 
    C.TotalPagar
FROM 
    Compras C
INNER JOIN 
    Usuarios U ON C.ID_Usuario = U.ID_Usuario
INNER JOIN 
    Proveedores PR ON C.ID_Proveedor = PR.ID_Proveedor
INNER JOIN 
    Productos P ON C.ID_Producto = P.ID_Producto;
    
    
-- ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
-- VISTAS PARA REPORTES
-- Vista para clientes frecuentes
CREATE VIEW ClientesFrecuentes AS
SELECT 
    c.ID_Cliente,
    c.Nombres,
    c.Apellidos,
    COUNT(v.ID_Venta) AS NumeroDeCompras
FROM 
    Clientes c
JOIN 
    Ventas v ON c.ID_Cliente = v.ID_Cliente
GROUP BY 
    c.ID_Cliente, c.Nombres, c.Apellidos
HAVING COUNT(v.ID_Venta) BETWEEN 1 AND 10
ORDER BY 
    NumeroDeCompras DESC;

-- Vista para clientes por zona
CREATE VIEW ClientesPorZona AS
SELECT 
    d.Departamento,
    m.Municipio,
    COUNT(c.ID_Cliente) AS NumeroDeClientes
FROM 
    Clientes c
JOIN 
    Departamentos d ON c.ID_Departamento = d.ID_Departamento
JOIN 
    Municipios m ON c.ID_Municipio = m.ID_Municipio
GROUP BY 
    d.Departamento, m.Municipio
HAVING COUNT(c.ID_Cliente) BETWEEN 1 AND 10
ORDER BY 
    NumeroDeClientes DESC;

-- Vista para ventas por categoría
CREATE VIEW VentasPorCategoria AS
SELECT 
    cat.Categoria,
    SUM(v.TotalCobrar) AS TotalVendido
FROM 
    Ventas v
JOIN 
    Productos p ON v.ID_Producto = p.ID_Producto
JOIN 
    Categorias cat ON p.ID_Categoria = cat.ID_Categoria
GROUP BY 
    cat.Categoria
HAVING SUM(v.TotalCobrar) BETWEEN 5 AND 30
ORDER BY 
    TotalVendido DESC;

-- Vista para facturas
CREATE VIEW Facturas AS
SELECT 
    v.ID_Venta,
    v.FechaVenta,
    u.Usuario AS Vendedor,
    CONCAT(c.Nombres, ' ', c.Apellidos) AS Cliente,
    p.Producto,
    v.PrecioVenta,
    v.CantidadSaliente,
    v.TotalCobrar
FROM 
    Ventas v
JOIN 
    Usuarios u ON v.ID_Usuario = u.ID_Usuario
JOIN 
    Clientes c ON v.ID_Cliente = c.ID_Cliente
JOIN 
    Productos p ON v.ID_Producto = p.ID_Producto
WHERE CAST(V.FechaVenta AS DATE) BETWEEN '2024-05-13' AND '2024-05-14'
GROUP BY v.ID_Venta;
