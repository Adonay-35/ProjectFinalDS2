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
    DATE_FORMAT(V.FechaVenta, '%d-%m-%Y' ) AS FechaVenta, 
    U.Usuario AS Usuario, 
    CONCAT(C.Nombres, ' ', C.Apellidos) AS Cliente, 
    P.Producto AS Producto, 
    (P.PrecioCompra * 1.2) as Precio,
    V.CantidadSaliente, 
    (V.CantidadSaliente * (P.PrecioCompra * 1.2)) as Total
FROM 
    Ventas V
INNER JOIN 
    Usuarios U ON V.ID_Usuario = U.ID_Usuario
INNER JOIN 
    Clientes C ON V.ID_Cliente = C.ID_Cliente
INNER JOIN 
    Productos P ON V.ID_Producto = P.ID_Producto;
