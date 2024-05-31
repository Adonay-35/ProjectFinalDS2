using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
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

        Int32 _IDVenta;
        DateTime _FechaVenta;
        Int32 _IDUsuario;
        Int32 _IDCliente;
        Int32 _IDProducto;
        double _Precio;
        Int32 _Cantidad;
        double _Total;

        public Ventas(int idVenta)
        {
            this._IDVenta = idVenta;
        }

        public Ventas()
        { 
        }

        public int IDVenta { get => _IDVenta; set => _IDVenta = value; }
        public DateTime FechaVenta { get => _FechaVenta; set => _FechaVenta = value; }
        public int IDUsuario { get => _IDUsuario; set => _IDUsuario = value; }
        public int IDCliente { get => _IDCliente; set => _IDCliente = value; }
        public int IDProducto { get => _IDProducto; set => _IDProducto = value; }
        public double Precio { get => _Precio; set => _Precio = value; }
        public int Cantidad { get => _Cantidad; set => _Cantidad = value; }
        public double Total { get => _Total; set => _Total = value; }



        public Boolean Insertar()
        {
            Boolean Resultado = false;
            DataLayer.DBOperacion Operacion = new DataLayer.DBOperacion();

            StringBuilder Sentencia = new StringBuilder();

            Sentencia.Append("INSERT INTO ventas (FechaVenta, IDUsuario, IDCliente, IDProducto, Precio, Cantidad, Total) VALUES (");
            Sentencia.Append("'" + _FechaVenta.ToString("yyyy-MM-dd HH:mm:ss") + "', ");
            Sentencia.Append(_IDUsuario + ", ");  
            Sentencia.Append(_IDCliente + ", ");  
            Sentencia.Append(_IDProducto + ", ");
            Sentencia.Append(_Precio + ", ");
            Sentencia.Append(_Cantidad + ", "); 
            Sentencia.Append(_Total + ");"); 

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


        public Boolean Actualizar()
        {
            Boolean Resultado = false;
            DataLayer.DBOperacion Operacion = new DataLayer.DBOperacion();

            StringBuilder Sentencia = new StringBuilder();
            Sentencia.Append("UPDATE Ventas SET ");
            Sentencia.Append("FechaVenta = '" + _FechaVenta.ToString("yyyy-MM-dd HH:mm:ss") + "', ");
            Sentencia.Append("IDUsuario = " + _IDUsuario + ", ");
            Sentencia.Append("IDCliente = " + _IDCliente + ", ");
            Sentencia.Append("IDProducto = '" + _IDProducto + "', ");
            Sentencia.Append("Precio = " + _Precio + ", ");
            Sentencia.Append("Cantidad = " + _Cantidad + ", "); 
            Sentencia.Append("Total = " + _Total);
            Sentencia.Append(" WHERE IDVenta = '" + _IDVenta + "';");

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


        public bool Eliminar()
        {
            bool Resultado = false;
            DataLayer.DBOperacion Operacion = new DataLayer.DBOperacion();

            StringBuilder Sentencia = new StringBuilder();
            Sentencia.Append("DELETE FROM ventas ");
            Sentencia.Append("WHERE IDVenta='" + _IDVenta + "';");

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
<<<<<<< HEAD
                sqlConexion.ConnectionString = "Server=localhost;Port=3007;Database=sistemaventas;Uid=sistema-user;Pwd=root;SslMode=None;";
=======
                sqlConexion.ConnectionString = "Server=localhost;Port=3006;Database=sistemaventas;Uid=sistema-user;Pwd=root;SslMode=None;";
>>>>>>> 2009d1e448be5357596773ea12ca16823d4aa77a
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
<<<<<<< HEAD
                sqlConexion.ConnectionString = "Server=localhost;Port=3007;Database=sistemaventas;Uid=sistema-user;Pwd=root;SslMode=None;";
=======
                sqlConexion.ConnectionString = "Server=localhost;Port=3006;Database=sistemaventas;Uid=sistema-user;Pwd=root;SslMode=None;";
>>>>>>> 2009d1e448be5357596773ea12ca16823d4aa77a
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
<<<<<<< HEAD
                sqlConexion.ConnectionString = "Server=localhost;Port=3007;Database=sistemaventas;Uid=sistema-user;Pwd=root;SslMode=None;";
=======
                sqlConexion.ConnectionString = "Server=localhost;Port=3006;Database=sistemaventas;Uid=sistema-user;Pwd=root;SslMode=None;";
>>>>>>> 2009d1e448be5357596773ea12ca16823d4aa77a
                MySqlCommand comando = new MySqlCommand("ObtenerProductos", sqlConexion);
                comando.CommandType = CommandType.StoredProcedure;
                sqlConexion.Open();
                resultado = comando.ExecuteReader();

                while (resultado.Read())
                {
                    listaProductos.Add(new Productos(
                        resultado.GetInt32(0),
                        resultado.GetString(1)
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

    


