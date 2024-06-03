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
        Int32 _ID_Categoria;

        String _Categoria;

        public Categorias(int idCategoria, string categoria)
        {
            this._ID_Categoria = idCategoria;
            this._Categoria = categoria;
        }

        public Categorias()
        { 
        }

        public Int32 ID_Categoria { get => _ID_Categoria; set => _ID_Categoria = value; }
        public string Categoria { get => _Categoria; set => _Categoria = value; }

        public Boolean InsertarCategoria()
        {
            Boolean Resultado = false;
            DataLayer.DBOperacion Operacion = new DataLayer.DBOperacion();

            StringBuilder Sentencia = new StringBuilder();
            Sentencia.Append("INSERT INTO categorias(ID_Categoria, Categoria) VALUES (");
            Sentencia.Append(_ID_Categoria + ", '" + _Categoria + "');");

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
            Sentencia.Append("WHERE ID_Categoria=" + _ID_Categoria + ";");

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
            Sentencia.Append("WHERE ID_Categoria=" + _ID_Categoria + ";");

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

