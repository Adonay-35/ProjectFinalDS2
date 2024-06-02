using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class Consultas
    {
        public static DataTable CATEGORIAS()
        {
            DataTable Resultado = new DataTable();
            string Consulta = @"SELECT ID_Categoria, Categoria FROM categorias ORDER BY ID_Categoria ASC;";
            DBOperacion operacion = new DBOperacion();
            try
            {
                Resultado = operacion.Consultar(Consulta);
            }
            catch (Exception)
            {

            }
            return Resultado;
        }

        public static DataTable ROLES()
        {
            DataTable Resultado = new DataTable();
            string Consulta = @"SELECT ID_Rol, Rol FROM roles ORDER BY ID_Rol ASC;";
            DBOperacion operacion = new DBOperacion();
            try
            {
                Resultado = operacion.Consultar(Consulta);
            }
            catch (Exception)
            {

            }
            return Resultado;
        }

        public static DataTable EMPLEADOS()
        {
            DataTable Resultado = new DataTable();
            string Consulta = @"SELECT * FROM VistaEmpleados";
            DBOperacion operacion = new DBOperacion();
            try
            {
                Resultado = operacion.Consultar(Consulta);
            }
            catch (Exception)
            {

            }
            return Resultado;
        }

        public static DataTable PROVEEDORES()
        {
            DataTable Resultado = new DataTable();
            string Consulta = @"SELECT * FROM VistaProveedores";
            DBOperacion operacion = new DBOperacion();
            try
            {
                Resultado = operacion.Consultar(Consulta);
            }
            catch (Exception)
            {

            }
            return Resultado;
        }

        public static DataTable CLIENTES()
        {
            DataTable Resultado = new DataTable();
            string Consulta = @"SELECT * FROM VistaClientes";
            DBOperacion operacion = new DBOperacion();
            try
            {
                Resultado = operacion.Consultar(Consulta);
            }
            catch (Exception)
            {

            }
            return Resultado;
        }

        public static DataTable USUARIOS()
        {
            DataTable Resultado = new DataTable();
            string Consulta = @"SELECT * FROM VistaUsuarios;";
            DBOperacion operacion = new DBOperacion();
            try
            {
                Resultado = operacion.Consultar(Consulta);
            }
            catch (Exception)
            {

            }
            return Resultado;
        }

        public static DataTable PRODUCTOS()
        {
            DataTable Resultado = new DataTable();
            string Consulta = @"SELECT *  FROM VistaProductosParaCompras";
            DBOperacion operacion = new DBOperacion();
            try
            {
                Resultado = operacion.Consultar(Consulta);
            }
            catch (Exception)
            {

            }
            return Resultado;
        }

        public static DataTable VENTAS()
        {
            DataTable resultado = new DataTable();
            string consulta = @"SELECT *  FROM VistaVentas";
            DBOperacion operacion = new DBOperacion();
            try
            {
                resultado = operacion.Consultar(consulta);
            }
            catch (Exception)
            {

            }
            return resultado;
        }

        public static DataTable COMPRAS()
        {
            DataTable resultado = new DataTable();
            string consulta = @"SELECT *  FROM VistaCompras";
            DBOperacion operacion = new DBOperacion();
            try
            {
                resultado = operacion.Consultar(consulta);
            }
            catch (Exception)
            {

            }
            return resultado;
        }

        public static DataTable CLIENTES_FRECUENTES(string CantidadMinima, string CantidadMaxima)
        {
            DataTable Resultado = new DataTable();
            string Consulta = @"SELECT 
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
                HAVING 
                    COUNT(v.ID_Venta) BETWEEN '" + CantidadMinima + "' AND '" + CantidadMaxima + @"'
                ORDER BY 
                    NumeroDeCompras DESC";
            DBOperacion operacion = new DBOperacion();
            try
            {
                Resultado = operacion.Consultar(Consulta);
            }
            catch (Exception)
            {

            }
            return Resultado;
        }

        public static DataTable CLIENTES_ZONAS(string pCantidadMinima, string pCantidadMaxima)
        {
            DataTable Resultado = new DataTable();
            string Consulta = @"SELECT 
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
                HAVING COUNT(c.ID_Cliente) BETWEEN '" + pCantidadMinima + "' AND '" + pCantidadMaxima + @"' 
                ORDER BY 
                    NumeroDeClientes DESC;";
            DBOperacion operacion = new DBOperacion();
            try
            {
                Resultado = operacion.Consultar(Consulta);
            }
            catch (Exception)
            {

            }
            return Resultado;
        }

        public static DataTable FACTURAS(string pFechaInicio, string pFechaFinal)
        {
            DataTable Resultado = new DataTable();
            string Consulta = @"SELECT 
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
                WHERE CAST(V.FechaVenta AS DATE) BETWEEN '" + pFechaInicio + "' AND '" + pFechaFinal + @"'
                GROUP BY v.ID_Venta;";
            DBOperacion operacion = new DBOperacion();
            try
            {
                Resultado = operacion.Consultar(Consulta);
            }
            catch (Exception)
            {

            }
            return Resultado;
        }

        public static DataTable VENTAS_CATEGORIAS(string pMinimoVendido, string pMaximoVendido)
        {
            DataTable Resultado = new DataTable();
            string Consulta = @"SELECT 
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
                HAVING SUM(v.TotalCobrar) BETWEEN '" + pMinimoVendido + "' AND '" + pMaximoVendido + @"'
                ORDER BY 
                    TotalVendido DESC;";
            DBOperacion operacion = new DBOperacion();
            try
            {
                Resultado = operacion.Consultar(Consulta);
            }
            catch (Exception)
            {

            }
            return Resultado;
        }
    }

 }


