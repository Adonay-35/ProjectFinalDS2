using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General.CLS
{
    internal class Productos
    {

        MySqlDataReader resultado;
        DataTable tabla = new DataTable();
        MySqlConnection sqlConexion = new MySqlConnection();

        Int32 _ID_Producto;
        string _Producto;
        DateTime _FechaFabricacion;
        DateTime _FechaVencimiento;
        string _Descripcion;
        double _PrecioCompra;
        Int32 _ID_Proveedor;
        Int32 _ID_Categoria;

        public Productos(int idproducto, string producto, double preciocompra)
        {
            this._ID_Producto = idproducto;
            this._Producto = producto;
            this._PrecioCompra = preciocompra;
        }

        public Productos()
        {
        }

        public int ID_Producto { get => _ID_Producto; set => _ID_Producto = value; }
        public string Producto { get => _Producto; set => _Producto = value; }
        public DateTime FechaFabricacion { get => _FechaFabricacion; set => _FechaFabricacion = value; }
        public DateTime FechaVencimiento { get => _FechaVencimiento; set => _FechaVencimiento = value; }
        public string Descripcion { get => _Descripcion; set => _Descripcion = value; }
        public double PrecioCompra { get => _PrecioCompra; set => _PrecioCompra = value; }
        public int ID_Proveedor { get => _ID_Proveedor; set => _ID_Proveedor = value; }
        public int ID_Categoria { get => _ID_Categoria; set => _ID_Categoria = value; }

        public Boolean Insertar()
        {
            Boolean Resultado = false;
            DataLayer.DBOperacion Operacion = new DataLayer.DBOperacion();

            StringBuilder Sentencia = new StringBuilder();
            Sentencia.Append("INSERT INTO Productos(Producto, FechaFabricacion, FechaVencimiento, Descripcion, PrecioCompra, ID_Proveedor, ID_Categoria) VALUES(");
            Sentencia.Append("'" + _Producto + "',");
            Sentencia.Append("'" + _FechaFabricacion.ToString("yyyy-MM-dd") + "',");
            Sentencia.Append("'" + _FechaVencimiento.ToString("yyyy-MM-dd") + "',");
            Sentencia.Append("'" + _Descripcion + "',");
            Sentencia.Append(_PrecioCompra + ",");
            Sentencia.Append(_ID_Proveedor + ",");
            Sentencia.Append(_ID_Categoria + ");");
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
            Sentencia.Append("UPDATE productos SET ");
            Sentencia.Append("Producto ='" + _Producto + "',");
            Sentencia.Append("FechaFabricacion ='" + _FechaFabricacion.ToString("yyyy-MM-dd") + "',");
            Sentencia.Append("FechaVencimiento ='" + _FechaVencimiento.ToString("yyyy-MM-dd") + "',");
            Sentencia.Append("Descripcion ='" + _Descripcion + "',");
            Sentencia.Append("PrecioCompra =" + _PrecioCompra + ",");
            Sentencia.Append("ID_Proveedor =" + _ID_Proveedor + ",");
            Sentencia.Append("ID_Categoria =" + _ID_Categoria);
            Sentencia.Append(" WHERE ID_Producto ='" + _ID_Producto + "';");
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

        public Boolean Eliminar()
        {
            Boolean Resultado = false;
            DataLayer.DBOperacion Operacion = new DataLayer.DBOperacion();

            StringBuilder Sentencia = new StringBuilder();
            Sentencia.Append("DELETE FROM Productos");
            Sentencia.Append(" WHERE ID_Producto ='" + _ID_Producto + "';");
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

        public List<Categorias> ObtenerCategorias()
        {
            List<Categorias> listaCategorias = new List<Categorias>();
            try 
            {
                sqlConexion.ConnectionString = "Server=localhost;Port=3306;Database=sistemaventas;Uid=sistema-user;Pwd=root;SslMode=None;";
                MySqlCommand comando = new MySqlCommand("ObtenerCategorias", sqlConexion);
                comando.CommandType = CommandType.StoredProcedure;
                sqlConexion.Open();
                resultado = comando.ExecuteReader();

                while (resultado.Read())
                {
                    listaCategorias.Add(new Categorias(
                        resultado.GetInt32(0),
                        resultado.GetString(1)
                    ));
                }

                return listaCategorias;
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


