using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt.Zad3
{
    class Cennik
    {
        public Hashtable ProduktyCeny = new Hashtable();

        internal void Set(string v1, float v2)
        {
            ProduktyCeny.Add(v1, v2);
        }
    }
}
