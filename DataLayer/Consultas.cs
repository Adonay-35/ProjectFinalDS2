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
        public static DataTable ROLES()
        {
            DataTable Resultado = new DataTable();
            string Consulta = @"SELECT IDRol, Rol FROM roles ORDER BY IDRol ASC;";
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
            string Consulta = @"SELECT IDEmpleado, Nombres, Apellidos, DUI, Direccion, Telefono, Correo FROM empleados ORDER BY IDEmpleado ASC;";
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
            string Consulta = @"SELECT IDProveedor, Proveedor, Contacto, Direccion, Correo FROM proveedores ORDER BY IDProveedor ASC;";
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
            string Consulta = @"SELECT IDCliente, Nombres, Apellidos, Correo FROM clientes ORDER BY IDCliente ASC;";
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
            string Consulta = @"SELECT *  FROM VistaProductos";
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
    }

 }


