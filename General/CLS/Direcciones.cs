using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General.CLS
{
    internal class Direcciones
    {
        Int32 _ID_Direccion;
        string _Linea1;
        string _Linea2;
        Int32 _ID_Distrito;
        Int32 _CodigoPostal;



        public Int32 ID_Direccion { get => _ID_Direccion; set => _ID_Direccion = value; }
        public string Linea1 { get => _Linea1; set => _Linea1 = value; }
        public string Linea2 { get => _Linea2; set => _Linea2 = value; }
        public int ID_Distrito { get => _ID_Distrito; set => _ID_Distrito = value; }
        public int CodigoPostal { get => _CodigoPostal; set => _CodigoPostal = value; }

        public Boolean Insertar()
        {
            Boolean Resultado = false;
            DataLayer.DBOperacion Operacion = new DataLayer.DBOperacion();

            StringBuilder Sentencia = new StringBuilder();
            Sentencia.Append("INSERT INTO Direcciones(IDDireccion, Linea1, Linea2, CodigoPostal) VALUES(");
            Sentencia.Append("'" + _Linea1 + "', '" + _Linea2 + "', " + _CodigoPostal + ");");

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
            Sentencia.Append("Linea1='" + _Linea1 + "', ");
            Sentencia.Append("Linea2='" + _Linea2 + "', ");
            Sentencia.Append("CodigoPostal=" + _CodigoPostal + " ");
            Sentencia.Append("WHERE IDDireccion=" + _ID_Direccion + ";");

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
            Sentencia.Append("DELETE FROM Direcciones ");
            Sentencia.Append("WHERE IDDireccion =" + _ID_Direccion + ";");

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
