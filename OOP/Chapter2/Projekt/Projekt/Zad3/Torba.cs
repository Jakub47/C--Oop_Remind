using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt.Zad3
{
    class Torba : Items
    {
        public Torba() : base()
        {

        }

        public void LoadFrom(Koszyk k)
        {
            k.Produkty.ForEach(i => this.Produkty.Add(i)); 
        }
    }
}
