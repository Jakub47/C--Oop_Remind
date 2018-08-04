using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt.Zad4
{
    class Torba : Items
    {
        public string Osoba { get; set; }

        public Torba(string osoba) : base()
        {
            this.Osoba = osoba;
        }

        public void LoadFrom(Koszyk k)
        {
            k.Produkty.ForEach(i => this.Produkty.Add(i)); 
        }
    }
}
