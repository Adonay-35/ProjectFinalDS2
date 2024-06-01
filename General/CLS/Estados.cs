using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General.CLS
{
    internal class Estados
    {
        Int32 _ID_Estado;
        Int32 _Estado;
        String _Descripcion;

        public Estados(int idEstado, int estado, string descripcion)
        {
            this._ID_Estado = idEstado;
            this._Estado = estado;
            this._Descripcion = descripcion;
        }

        public int ID_Estado { get => _ID_Estado; set => _ID_Estado = value; }
        public int Estado { get => _Estado; set => _Estado = value; }
        public string Descripcion { get => _Descripcion; set => _Descripcion = value; }

    }
}
