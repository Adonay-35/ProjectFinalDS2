using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General.CLS
{
    internal class Distritos
    {
        string _ID_Distrio;
        string _Distrito;
        Int32 _ID_Municipio;



        public string ID_Distrito { get => _ID_Distrio; set => _ID_Distrio = value; }
        public string Distrito { get => _Distrito; set => _Distrito = value; }
        public int ID_Municipio { get => _ID_Municipio; set => _ID_Municipio = value; }


        public Distritos(string iddistriro, string distrito, int idmunicipio)
        {
            this._ID_Distrio = iddistriro;
            this._Distrito = distrito;
            this._ID_Municipio = idmunicipio;
        }

        public Distritos()
        {
        }
    }
}
