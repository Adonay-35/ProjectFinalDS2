﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace General.CLS
{
    internal class Empleados
    {
        MySqlDataReader resultado;
        DataTable tabla = new DataTable();
        MySqlConnection sqlConexion = new MySqlConnection();

        Int32 _IDEmpleado;
        string _Nombres;
        string _Apellidos;
        string _DUI;
        string _Telefono;
        string _Correo;
        string _Linea1;
        string _Linea2;
        Int32 _CodigoPostal;
        Int32 _ID_Departamento;
        Int32 _ID_Distrito;
        Int32 _ID_Municipio;

        public Empleados(int idEmpleado, string nombres, string apellidos)
        {
            this._IDEmpleado = idEmpleado;
            this._Nombres = nombres;
            this._Apellidos = apellidos;
        }

        public Empleados()
        {
        }


        public Int32 IDEmpleado { get => _IDEmpleado; set => _IDEmpleado = value; }
        public string Nombres { get => _Nombres; set => _Nombres = value; }
        public string Apellidos { get => _Apellidos; set => _Apellidos = value; }
        public string Dui { get => _DUI; set => _DUI = value; }
        public string Telefono { get => _Telefono; set => _Telefono = value; }
        public string Correo { get => _Correo; set => _Correo = value; }
        public string Linea1 { get => _Linea1; set => _Linea1 = value; }
        public string Linea2 { get => _Linea2; set => _Linea2 = value; }
        public int CodigoPostal { get => _CodigoPostal; set => _CodigoPostal = value; }
        public int IDDepartamento { get => _ID_Departamento; set => _ID_Departamento = value; }
        public int IDDistrito { get => _ID_Distrito; set => _ID_Distrito = value; }
        public int IDMunicipio { get => _ID_Municipio; set => _ID_Municipio = value; }



        public Boolean Insertar()
        {
            Boolean Resultado = false;
            DataLayer.DBOperacion Operacion = new DataLayer.DBOperacion();

            StringBuilder Sentencia = new StringBuilder();
            Sentencia.Append("INSERT INTO Empleados(Nombres, Apellidos, Dui, Telefono, Correo, Linea1, Linea2, CodigoPostal, ID_Departamento, ID_Distrito, ID_Municipio) VALUES(");
            Sentencia.Append("'" + _Nombres + "',");
            Sentencia.Append("'" + _Apellidos + "',");
            Sentencia.Append("'" + _DUI + "',");
            Sentencia.Append("'" + _Telefono + "',");
            Sentencia.Append("'" + _Correo + "',");
            Sentencia.Append("'" + _Linea1 + "',");
            Sentencia.Append("'" + _Linea2 + "',");
            Sentencia.Append(_CodigoPostal + ",");
            Sentencia.Append(_ID_Departamento + ",");
            Sentencia.Append(_ID_Distrito + ",");
            Sentencia.Append(_ID_Municipio + ");");
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
            Sentencia.Append("UPDATE Empleados SET ");
            Sentencia.Append("Nombres ='" + _Nombres + "',");
            Sentencia.Append("Apellidos ='" + _Apellidos + "',");
            Sentencia.Append("Dui ='" + _DUI + "',");
            Sentencia.Append("Telefono ='" + _Telefono + "',");
            Sentencia.Append("Correo ='" + _Correo + "',");
            Sentencia.Append("Linea1 ='" + _Linea1 + "',");
            Sentencia.Append("Linea2 ='" + _Linea2 + "',");
            Sentencia.Append("CodigoPostal =" + _CodigoPostal + ",");
            Sentencia.Append("ID_Departamento =" + _ID_Departamento + ",");
            Sentencia.Append("ID_Distrito =" + _ID_Distrito + ",");
            Sentencia.Append("ID_Municipio =" + _ID_Municipio);
            Sentencia.Append(" WHERE IDEmpleado ='" + _IDEmpleado + "';");
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
            Sentencia.Append("DELETE FROM Empleados");
            Sentencia.Append(" WHERE IDEmpleado ='" + _IDEmpleado + "';");
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
