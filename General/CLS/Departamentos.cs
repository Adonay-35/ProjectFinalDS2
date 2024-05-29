using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General.CLS
{
    internal class Departamentos
    {
        string _ID_Departamento;
        string _Departamento;
        string _Pais;


        public string ID_Departamento { get => _ID_Departamento; set => _ID_Departamento = value; }
        public string Departamento { get => _Departamento; set => _Departamento = value; }
        public string Pais { get => _Pais; set => _Pais = value; }

        public Departamentos(string iddepartamento, string departamento, string pais)
        {
            this._ID_Departamento = iddepartamento;
            this._Departamento = departamento;
            this._Pais = pais;
        }

        public Departamentos()
        {
        }
    }
}
