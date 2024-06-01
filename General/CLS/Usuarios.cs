using DataLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace General.CLS
{
    internal class Usuarios
    {
        MySqlDataReader resultado;
        DataTable tabla = new DataTable();
        MySqlConnection sqlConexion = new MySqlConnection();

        Int32 _ID_Usuario;
        String _Usuario;
        String _Clave;
        Int32 _ID_Rol;
        Int32 _ID_Empleado;
        Int32 _ID_Estado;

        public Usuarios(int idUsuario, string usuario)
        {
            this._ID_Usuario = idUsuario;
            this._Usuario = usuario;
        }

        public Usuarios()
        {
        }

        public int ID_Usuario { get => _ID_Usuario; set => _ID_Usuario = value; }
        public string Usuario { get => _Usuario; set => _Usuario = value; }
        public string Clave { get => _Clave; set => _Clave = value; }
        public int ID_Rol { get => _ID_Rol; set => _ID_Rol = value; }
        public int ID_Empleado { get => _ID_Empleado; set => _ID_Empleado = value; }
        public int ID_Estado { get => _ID_Estado; set => _ID_Estado = value; }

        public Boolean Insertar()
        {
            Boolean Resultado = false;
            DataLayer.DBOperacion Operacion = new DataLayer.DBOperacion();

            string claveEncriptada = Encryptar.GetSHA256(_Clave);

            StringBuilder Sentencia = new StringBuilder();
            Sentencia.Append("INSERT INTO usuarios(Usuario,Clave,ID_Rol,ID_Empleado,ID_Estado) VALUES(");
            Sentencia.Append("'" + _Usuario + "',");
            Sentencia.Append("'" + claveEncriptada + "',");
            Sentencia.Append(_ID_Rol + ",");
            Sentencia.Append(_ID_Empleado + ",");
            Sentencia.Append(_ID_Estado + ");");
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

            string claveEncriptada = Encryptar.GetSHA256(_Clave);

            StringBuilder Sentencia = new StringBuilder();
            Sentencia.Append("UPDATE usuarios  SET ");
            Sentencia.Append("Usuario ='" + _Usuario + "',");
            Sentencia.Append("Clave = ('" + claveEncriptada + "'),");
            Sentencia.Append("ID_Rol =" + _ID_Rol + ",");
            Sentencia.Append("ID_Empleado =" + _ID_Empleado + ",");
            Sentencia.Append("ID_Estado =" + _ID_Estado);
            Sentencia.Append(" WHERE ID_Usuario =" + _ID_Usuario + ";");
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

        public Boolean Elminar()
        {
            Boolean Resultado = false;
            DataLayer.DBOperacion Operacion = new DataLayer.DBOperacion();

            StringBuilder Sentencia = new StringBuilder();
            Sentencia.Append("DELETE FROM  usuarios");
            Sentencia.Append(" WHERE ID_Usuario =" + _ID_Usuario + ";");
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

        public List<Roles> ObtenerRoles()
        {
            List<Roles> listaRoles = new List<Roles>();

            try
            {
                sqlConexion.ConnectionString = "Server=localhost;Port=3306;Database=sistemaventas;Uid=sistema-user;Pwd=root;SslMode=None;";
                MySqlCommand comando = new MySqlCommand("ObtenerRoles", sqlConexion);
                comando.CommandType = CommandType.StoredProcedure;
                sqlConexion.Open();
                resultado = comando.ExecuteReader();

                while (resultado.Read())
                {
                    listaRoles.Add(
                        new Roles(
                            resultado.GetInt32(0),
                            resultado.GetString(1)
                            )
                        );
                }

                return listaRoles;
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

        public List<Estados> ObtenerEstados()
        {
            List<Estados> listaEstados = new List<Estados>();

            try
            {
                sqlConexion.ConnectionString = "Server=localhost;Port=3306;Database=sistemaventas;Uid=sistema-user;Pwd=root;SslMode=None;";
                MySqlCommand comando = new MySqlCommand("ObtenerEstados", sqlConexion);
                comando.CommandType = CommandType.StoredProcedure;
                sqlConexion.Open();
                resultado = comando.ExecuteReader();

                while (resultado.Read())
                {
                    listaEstados.Add(
                        new Estados(
                            resultado.GetInt32(0),
                            resultado.GetInt32(1),
                            resultado.GetString(2)
                            )
                        );
                }

                return listaEstados;
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

        public List<Empleados> ObtenerEmpleados()
        {
            List<Empleados> listaEmpleados = new List<Empleados>();

            try
            {
                sqlConexion.ConnectionString = "Server=localhost;Port=3306;Database=sistemaventas;Uid=sistema-user;Pwd=root;SslMode=None;";
                MySqlCommand comando = new MySqlCommand("ObtenerEmpleados", sqlConexion);
                comando.CommandType = CommandType.StoredProcedure;
                sqlConexion.Open();
                resultado = comando.ExecuteReader();

                while (resultado.Read())
                {
                    listaEmpleados.Add(new Empleados(
                            resultado.GetInt32(0),
                            resultado.GetString(1),
                            resultado.GetString(2)
                            )
                        );
                }

                return listaEmpleados;
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
