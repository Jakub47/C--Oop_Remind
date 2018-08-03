using System;
using System.Collections.Generic;

namespace Projekt.Zad4
{
    public class Koszyk : Items
    {
        public static int Numer { get; set; }
        public int NumerKoszyk { get; set; }

        static Koszyk()
        {
            Numer = 0;
        }

        public Koszyk() : base()
        {
            this.NumerKoszyk = Numer;
        }

        internal void add(Produkt produkt)
        {
            Produkty.Add(produkt);
        }
    }
}