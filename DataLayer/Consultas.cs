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
            string consulta = @"SELECT *  FROM VistaProductosParaVentas";
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
    }

 }


