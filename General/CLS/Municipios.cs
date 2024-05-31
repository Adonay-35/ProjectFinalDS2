using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General.CLS
{
    internal class Municipios
    {
        Int32 _ID_Municipio;
        string _Municipio;
        Int32 _ID_Departamento;



        public int ID_Municipio { get => _ID_Municipio; set => _ID_Municipio = value; }
        public string Municipio { get => _Municipio; set => _Municipio = value; }
        public int ID_Departamento { get => _ID_Departamento; set => _ID_Departamento = value; }


        public Municipios(int idmunicipio, string municipio)
        {
            this._ID_Municipio = idmunicipio;
            this._Municipio = municipio;
        }

        public Municipios()
        {
        }
    }
}
