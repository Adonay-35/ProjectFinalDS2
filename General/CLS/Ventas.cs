using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General.CLS
{
    internal class Ventas
    {
        MySqlDataReader resultado;
        DataTable tabla = new DataTable();
        MySqlConnection sqlConexion = new MySqlConnection();

        Int32 _ID_Venta;
        DateTime _FechaVenta;
        Int32 _ID_Usuario;
        Int32 _ID_Cliente;
        Int32 _ID_Producto;
        Decimal _PrecioVenta;
        Int32 _CantidadSaliente;
        Decimal _TotalCobrar;

        public int ID_Venta { get => _ID_Venta; set => _ID_Venta = value; }
        public DateTime FechaVenta { get => _FechaVenta; set => _FechaVenta = value; }
        public int ID_Usuario { get => _ID_Usuario; set => _ID_Usuario = value; }
        public int ID_Cliente { get => _ID_Cliente; set => _ID_Cliente = value; }
        public int ID_Producto { get => _ID_Producto; set => _ID_Producto = value; }
        public decimal PrecioVenta { get => _PrecioVenta; set => _PrecioVenta = value; }
        public int CantidadSaliente { get => _CantidadSaliente; set => _CantidadSaliente = value; }
        public decimal TotalCobrar { get => _TotalCobrar; set => _TotalCobrar = value; }

        public Boolean Insertar()
        {
            Boolean Resultado = false;
            DataLayer.DBOperacion Operacion = new DataLayer.DBOperacion();

            StringBuilder Sentencia = new StringBuilder();
            Sentencia.Append("INSERT INTO ventas (FechaVenta, ID_Usuario, ID_Cliente, ID_Producto, PrecioVenta, CantidadSaliente, TotalCobrar) VALUES (");
            Sentencia.Append("'" + _FechaVenta.ToString("yyyy-MM-dd HH:mm:ss") + "', ");
            Sentencia.Append(_ID_Usuario + ", ");
            Sentencia.Append(_ID_Cliente + ", ");
            Sentencia.Append(_ID_Producto + ", ");
            Sentencia.Append(_PrecioVenta.ToString() + ", ");
            Sentencia.Append(_CantidadSaliente + ", ");
            Sentencia.Append(_TotalCobrar.ToString());
            Sentencia.Append(");");

            try
            {
                if (Operacion.EjecutarSentencia(Sentencia.ToString()) >= 0)
                {
                    Resultado = true;
                }
                else
                {
                    Resultado = false;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al insertar la venta: " + ex.Message);
            }
            return Resultado;
        }

        public Boolean Actualizar()
        {
            Boolean Resultado = false;
            DataLayer.DBOperacion Operacion = new DataLayer.DBOperacion();

            StringBuilder Sentencia = new StringBuilder();
            Sentencia.Append("UPDATE ventas SET ");
            Sentencia.Append("FechaVenta = '" + _FechaVenta.ToString("yyyy-MM-dd HH:mm:ss") + "', ");
            Sentencia.Append("ID_Usuario = " + _ID_Usuario + ", ");
            Sentencia.Append("ID_Cliente = " + _ID_Cliente + ", ");
            Sentencia.Append("ID_Producto = " + _ID_Producto + ", ");
            Sentencia.Append("PrecioVenta = " + _PrecioVenta.ToString() + ", ");
            Sentencia.Append("CantidadSaliente = " + _CantidadSaliente + ", ");
            Sentencia.Append("TotalCobrar = " + _TotalCobrar.ToString());
            Sentencia.Append(" WHERE ID_Venta = " + _ID_Venta + ";");

            try
            {
                if (Operacion.EjecutarSentencia(Sentencia.ToString()) >= 0)
                {
                    Resultado = true;
                }
                else
                {
                    Resultado = false;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar la venta: " + ex.Message);
            }
            return Resultado;
        }

        public bool Eliminar()
        {
            bool Resultado = false;
            DataLayer.DBOperacion Operacion = new DataLayer.DBOperacion();

            StringBuilder Sentencia = new StringBuilder();
            Sentencia.Append("DELETE FROM ventas ");
            Sentencia.Append("WHERE ID_Venta='" + _ID_Venta + "';");

            try
            {
                if (Operacion.EjecutarSentencia(Sentencia.ToString()) >= 0)
                {
                    Resultado = true;
                }
                else
                {
                    Resultado = false;
                }
            }
            catch (Exception)
            {
                Resultado = false;
            }
            return Resultado;
        }

        public List<Usuarios> ObtenerUsuarios()
        {
            List<Usuarios> listaUsuarios = new List<Usuarios>();

            try
            {
                sqlConexion.ConnectionString = "Server=localhost;Port=3306;Database=sistemaventas;Uid=sistema-user;Pwd=root;SslMode=None;";
                MySqlCommand comando = new MySqlCommand("ObtenerUsuarios", sqlConexion);
                comando.CommandType = CommandType.StoredProcedure;
                sqlConexion.Open();
                resultado = comando.ExecuteReader();

                while (resultado.Read())
                {
                    listaUsuarios.Add(new Usuarios(
                        resultado.GetInt32(0),
                        resultado.GetString(1)
                        ));
                }

                return listaUsuarios;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (sqlConexion.State == ConnectionState.Open)
                {
                    sqlConexion.Close();
                }
            }
        }

        public List<Clientes> ObtenerClientes()
        {
            List<Clientes> listaClientes = new List<Clientes>();

            try
            {
                sqlConexion.ConnectionString = "Server=localhost;Port=3306;Database=sistemaventas;Uid=sistema-user;Pwd=root;SslMode=None;";
                MySqlCommand comando = new MySqlCommand("ObtenerClientes", sqlConexion);
                comando.CommandType = CommandType.StoredProcedure;
                sqlConexion.Open();
                resultado = comando.ExecuteReader();

                while (resultado.Read())
                {
                    listaClientes.Add(new Clientes(
                        resultado.GetInt32(0),
                        resultado.GetString(1),
                        resultado.GetString(2)
                        ));
                }

                return listaClientes;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (sqlConexion.State == ConnectionState.Open)
                {
                    sqlConexion.Close();
                }
            }
        }

        public List<Productos> ObtenerProductos()
        {
            List<Productos> listaProductos = new List<Productos>();

            try
            {
                sqlConexion.ConnectionString = "Server=localhost;Port=3306;Database=sistemaventas;Uid=sistema-user;Pwd=root;SslMode=None;";
                MySqlCommand comando = new MySqlCommand("ObtenerProductos", sqlConexion);
                comando.CommandType = CommandType.StoredProcedure;
                sqlConexion.Open();
                resultado = comando.ExecuteReader();

                while (resultado.Read())
                {
                    listaProductos.Add(new Productos(
                        resultado.GetInt32(0),
                        resultado.GetString(1),
                        resultado.GetDouble(2)
                    ));
                }

                return listaProductos;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (sqlConexion.State == ConnectionState.Open)
                {
                    sqlConexion.Close();
                }
            }
        }
    }
}

    


