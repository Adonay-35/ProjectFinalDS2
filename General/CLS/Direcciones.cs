using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General.CLS
{

    internal class Direcciones
    {
        MySqlDataReader resultado;
        DataTable tabla = new DataTable();
        MySqlConnection sqlConexion = new MySqlConnection();

        Int32 _ID_Direccion;
        string _Linea1;
        string _Linea2;
        Int32 _CodigoPostal;
        Int32 _ID_Distrito;
        string _Distrito;
        Int32 _ID_Municipio;
        string _Municipio;
        Int32 _ID_Departamento;
        string _Departamento;
        string _Pais;



        public int ID_Direccion { get => _ID_Direccion; set => _ID_Direccion = value; }
        public string Linea1 { get => _Linea1; set => _Linea1 = value; }
        public string Linea2 { get => _Linea2; set => _Linea2 = value; }
        public int ID_Distrito { get => _ID_Distrito; set => _ID_Distrito = value; }
        public int CodigoPostal { get => _CodigoPostal; set => _CodigoPostal = value; }
        public string Distrito { get => _Distrito; set => _Distrito = value; }
        public int ID_Municipio { get => _ID_Municipio; set => _ID_Municipio = value; }
        public string Municipio { get => _Municipio; set => _Municipio = value; }
        public int ID_Departamento { get => _ID_Departamento; set => _ID_Departamento = value; }
        public string Departamento { get => _Departamento; set => _Departamento = value; }
        public string Pais { get => _Pais; set => _Pais = value; }

        public Direcciones(int iddireccion)
        {
            this.ID_Direccion = iddireccion;

        }

        public Direcciones()
        {
        }

        public Boolean Insertar()
        {
            Boolean Resultado = false;
            DataLayer.DBOperacion Operacion = new DataLayer.DBOperacion();

            StringBuilder Sentencia = new StringBuilder();
            Sentencia.Append("INSERT INTO Direcciones(Linea1, Linea2, ID_Distrito, CodigoPostal, ID_Municipio, ID_Departamento) VALUES(");
            Sentencia.Append("'" + _Linea1 + "',");
            Sentencia.Append("'" + _Linea2 + "',");
            Sentencia.Append("'" + _ID_Distrito + "',");
            Sentencia.Append(_CodigoPostal + ",");
            Sentencia.Append("'" + _ID_Municipio + "',");
            Sentencia.Append("'" + _ID_Departamento + "');");

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
            Sentencia.Append("UPDATE Direcciones SET ");
            Sentencia.Append("Linea1 ='" + _Linea1 + "', ");
            Sentencia.Append("Linea2 ='" + _Linea2 + "', ");
            Sentencia.Append("ID_Distrito ='" + _ID_Distrito + "', ");
            Sentencia.Append("CodigoPostal =" + _CodigoPostal + ", ");
            Sentencia.Append("ID_Municipio ='" + _ID_Municipio + "', ");
            Sentencia.Append("ID_Departamento ='" + _ID_Departamento + "' ");
            Sentencia.Append("WHERE ID_Direccion =" + _ID_Direccion + ";");

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



        public List<Municipios> ObtenerMunicipios()
        {
            List<Municipios> listaMunicipios = new List<Municipios>();

            try
            {
                sqlConexion.ConnectionString = "Server=localhost;Port=3307;Database=sistemaventas;Uid=sistema-user;Pwd=root;SslMode=None;";
                MySqlCommand comando = new MySqlCommand("ObtenerMunicipios", sqlConexion);
                comando.CommandType = CommandType.StoredProcedure;
                sqlConexion.Open();
                resultado = comando.ExecuteReader();

                while (resultado.Read())
                {
                    listaMunicipios.Add(new Municipios(
                        resultado.GetInt32(0),
                        resultado.GetString(1)
                        )
                     );
                }

                return listaMunicipios;
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

        public List<Distritos> ObtenerDistritos()
        {
            List<Distritos> listaDistritos = new List<Distritos>();
            try
            {
                sqlConexion.ConnectionString = "Server=localhost;Port=3307;Database=sistemaventas;Uid=sistema-user;Pwd=root;SslMode=None;";
                MySqlCommand comando = new MySqlCommand("ObtenerDistritos", sqlConexion);
                comando.CommandType = CommandType.StoredProcedure;
                sqlConexion.Open();
                resultado = comando.ExecuteReader();

                while (resultado.Read())
                {
                    listaDistritos.Add(new Distritos(
                        resultado.GetInt32(0),
                        resultado.GetString(1)
                    ));
                }

                return listaDistritos;
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

        public List<Departamentos> ObtenerDepartamentos()
        {
            List<Departamentos> listaDepartamentos = new List<Departamentos>();
            try
            {
                sqlConexion.ConnectionString = "Server=localhost;Port=3307;Database=sistemaventas;Uid=sistema-user;Pwd=root;SslMode=None;";
                MySqlCommand comando = new MySqlCommand("ObtenerDepartamentos", sqlConexion);
                comando.CommandType = CommandType.StoredProcedure;
                sqlConexion.Open();
                resultado = comando.ExecuteReader();

                while (resultado.Read())
                {
                    listaDepartamentos.Add(new Departamentos(
                        resultado.GetInt32(0),
                        resultado.GetString(1),
                        resultado.GetString(1)
                    ));
                }

                return listaDepartamentos;
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
