using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General.CLS
{
    internal class Empleados
    {
         Int32 _IDEmpleado;
         string _Nombres;
         string _Apellidos;
         string _DUI;
         string _Direccion;
         string _Telefono;
         string _Correo;

        public Empleados(int idEmpleado, string empleado, string apellidos)
        {
            this._IDEmpleado = idEmpleado;
            this._Nombres = empleado;
            this._Apellidos = apellidos;
        }

        public Empleados()
        {
        }


    public Int32 IDEmpleado { get => _IDEmpleado; set => _IDEmpleado = value; }
        public string Nombres { get => _Nombres; set => _Nombres = value; }
        public string Apellidos { get => _Apellidos; set => _Apellidos = value; }
        public string Dui { get => _DUI; set => _DUI = value; }
        public string Direccion { get => _Direccion; set => _Direccion = value; }
        public string Telefono { get => _Telefono; set => _Telefono = value; }
        public string Correo { get => _Correo; set => _Correo = value; }


        public Boolean Insertar()
        {
            Boolean Resultado = false;
            DataLayer.DBOperacion Operacion = new DataLayer.DBOperacion();

            StringBuilder Sentencia = new StringBuilder();
            Sentencia.Append("INSERT INTO empleados(IDEmpleado, Nombres, Apellidos, DUI, Direccion, Telefono, Correo) VALUES (");
            Sentencia.Append(_IDEmpleado + ", '" + _Nombres + "', '" + _Apellidos + "', '" + _DUI + "', '" + _Direccion + "', '" + _Telefono + "', '" + _Correo + "');");

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
            Sentencia.Append("UPDATE empleados SET ");
            Sentencia.Append("Nombres='" + _Nombres + "', ");
            Sentencia.Append("Apellidos='" + _Apellidos + "', ");
            Sentencia.Append("DUI='" + _DUI + "', ");
            Sentencia.Append("Direccion='" + _Direccion + "', ");
            Sentencia.Append("Telefono='" + _Telefono + "', ");
            Sentencia.Append("Correo='" + _Correo + "' ");
            Sentencia.Append("WHERE IDEmpleado=" + _IDEmpleado + ";");

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
            Sentencia.Append("DELETE FROM empleados ");
            Sentencia.Append("WHERE IDEmpleado =" + _IDEmpleado + ";");

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
