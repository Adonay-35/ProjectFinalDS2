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