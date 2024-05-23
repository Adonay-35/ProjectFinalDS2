using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General.CLS
{
    internal class Categorias
    {
        Int32 _IDCategoria;
        String _Categoria;

        public Categorias(int idCategoria, string categoria)
        {
            this._IDCategoria = idCategoria;
            this._Categoria = categoria;
        }

        public Categorias()
        { 
        }

        public Int32 IDCategoria { get => _IDCategoria; set => _IDCategoria = value; }
        public string Categoria { get => _Categoria; set => _Categoria = value; }

        public Boolean InsertarCategoria()
        {
            Boolean Resultado = false;
            DataLayer.DBOperacion Operacion = new DataLayer.DBOperacion();

            StringBuilder Sentencia = new StringBuilder();
            Sentencia.Append("INSERT INTO categorias(IDCategoria, Categoria) VALUES (");
            Sentencia.Append(_IDCategoria + ", '" + _Categoria + "');");

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

        public Boolean ActualizarCategoria()
        {
            Boolean Resultado = false;
            DataLayer.DBOperacion Operacion = new DataLayer.DBOperacion();

            StringBuilder Sentencia = new StringBuilder();
            Sentencia.Append("UPDATE categorias SET ");
            Sentencia.Append("Categoria='" + _Categoria + "' ");
            Sentencia.Append("WHERE IDCategoria=" + _IDCategoria + ";");

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

        public Boolean EliminarCategoria()
        {
            Boolean Resultado = false;
            DataLayer.DBOperacion Operacion = new DataLayer.DBOperacion();

            StringBuilder Sentencia = new StringBuilder();
            Sentencia.Append("DELETE FROM categorias ");
            Sentencia.Append("WHERE IDCategoria=" + _IDCategoria + ";");

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

    }
}

