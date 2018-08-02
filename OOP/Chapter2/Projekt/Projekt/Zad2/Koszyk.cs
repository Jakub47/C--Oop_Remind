using System;
using System.Collections.Generic;

namespace Projekt.Zad2
{
    public class Koszyk : Items
    {
        //public List<Produkt> Produkty { get; set; }

        public Koszyk() : base()
        {
            
        }

        internal void add(Produkt produkt)
        {
            Produkty.Add(produkt);
        }
    }
}