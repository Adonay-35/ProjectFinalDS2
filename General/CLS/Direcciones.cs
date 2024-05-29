using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General.CLS
{
    internal class Direcciones
    {
        string _ID_Direccion;
        string _Linea1;
        string _Linea2;
        Int32 _ID_Distrito;
        Int32 _CodigoPostal;



        public string ID_Direccion { get => _ID_Direccion; set => _ID_Direccion = value; }
        public string Linea1 { get => _Linea1; set => _Linea1 = value; }
        public string Linea2 { get => _Linea2; set => _Linea2 = value; }
        public int ID_Distrito { get => _ID_Distrito; set => _ID_Distrito = value; }
        public int CodigoPostal { get => _CodigoPostal; set => _CodigoPostal = value; }

        public Direcciones(string iddireccion)
        {
            this._ID_Direccion = iddireccion;
        }

        public Direcciones()
        {
        }
    }
}
