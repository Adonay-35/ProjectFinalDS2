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
    P.FechaFabricacion, 
    P.FechaVencimiento, 
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
    V.FechaVenta, 
    U.Usuario AS Usuario, 
    CONCAT(C.Nombres, ' ', C.Apellidos) AS Cliente, 
    P.Producto AS Producto, 
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

