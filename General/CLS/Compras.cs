using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General.CLS
{
    internal class Compras
    {
        MySqlDataReader resultado;
        DataTable tabla = new DataTable();
        MySqlConnection sqlConexion = new MySqlConnection();

        Int32 _ID_Compra;
        DateTime _FechaCompra;
        Int32 _ID_Usuario;
        Int32 _ID_Proveedor;
        Int32 _ID_Producto;
        Int32 _CantidadEntrante;
        Decimal _TotalPagar;

        public int ID_Compra { get => _ID_Compra; set => _ID_Compra = value; }
        public DateTime FechaCompra { get => _FechaCompra; set => _FechaCompra = value; }
        public int ID_Usuario { get => _ID_Usuario; set => _ID_Usuario = value; }
        public int ID_Proveedor { get => _ID_Proveedor; set => _ID_Proveedor = value; }
        public int ID_Producto { get => _ID_Producto; set => _ID_Producto = value; }
        public int CantidadEntrante { get => _CantidadEntrante; set => _CantidadEntrante = value; }
        public decimal TotalPagar { get => _TotalPagar; set => _TotalPagar = value; }

        public Boolean Insertar()
        {
            Boolean Resultado = false;
            DataLayer.DBOperacion Operacion = new DataLayer.DBOperacion();

            StringBuilder Sentencia = new StringBuilder();

            Sentencia.Append("INSERT INTO Compras (FechaCompra, ID_Usuario, ID_Proveedor, ID_Producto, CantidadEntrante, TotalPagar) VALUES (");
            Sentencia.Append("'" + _FechaCompra.ToString("yyyy-MM-dd HH:mm:ss") + "', ");
            Sentencia.Append(_ID_Usuario + ", ");
            Sentencia.Append(_ID_Proveedor + ", ");
            Sentencia.Append(_ID_Producto + ", ");
            Sentencia.Append(_CantidadEntrante + ", ");
            Sentencia.Append(_TotalPagar.ToString());
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
            Sentencia.Append("UPDATE Compras SET ");
            Sentencia.Append("FechaCompra = '" + _FechaCompra.ToString("yyyy-MM-dd HH:mm:ss") + "', ");
            Sentencia.Append("ID_Usuario = " + _ID_Usuario + ", ");
            Sentencia.Append("ID_Proveedor = " + _ID_Proveedor + ", ");
            Sentencia.Append("ID_Producto = " + _ID_Producto + ", ");
            Sentencia.Append("CantidadEntrante = " + _CantidadEntrante + ", ");
            Sentencia.Append("TotalPagar = " + _TotalPagar.ToString());
            Sentencia.Append(" WHERE ID_Compra = " + _ID_Compra + ";");

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
            Sentencia.Append("DELETE FROM Compras ");
            Sentencia.Append("WHERE ID_Compra=" + _ID_Compra + ";");

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

        public List<Proveedores> ObtenerProveedores()
        {
            List<Proveedores> listaProveedores = new List<Proveedores>();

            try
            {
                sqlConexion.ConnectionString = "Server=localhost;Port=3306;Database=sistemaventas;Uid=sistema-user;Pwd=root;SslMode=None;";
                MySqlCommand comando = new MySqlCommand("ObtenerProveedores", sqlConexion);
                comando.CommandType = CommandType.StoredProcedure;
                sqlConexion.Open();
                resultado = comando.ExecuteReader();

                while (resultado.Read())
                {
                    listaProveedores.Add(new Proveedores(
                        resultado.GetInt32(0),
                        resultado.GetString(1)
                        )
                     );
                }

                return listaProveedores;
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
                        resultado.GetDouble(2),
                        resultado.GetInt32(3)
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
