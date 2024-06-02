using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General.CLS
{
    internal class Kardex
    {
        Int32 _ID_Kardex;
        Int32 _Stock;


        public Kardex(int idkardex, int stock)
        {
            this._ID_Kardex = idkardex;
            this._Stock = stock;
        }

        Kardex()
        {

        }

        public int ID_Kardex { get => _ID_Kardex; set => _ID_Kardex = value; }
        public int Stock { get => _Stock; set => _Stock = value; }

    }
}

