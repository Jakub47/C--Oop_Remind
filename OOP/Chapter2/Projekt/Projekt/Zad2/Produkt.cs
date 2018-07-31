using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt.Zad2
{
    abstract public class Produkt
    {

        public float Ilosc { get; set; }
        public float Cena { get; set; }

        public Produkt(float ilosc,float cena = 0 )
        {
            this.Ilosc = ilosc; this.Cena = cena;
        }

        public override string ToString()
        {
            return this.GetType().Name;
        }

    }
}
