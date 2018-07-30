using System;
using System.Collections.Generic;

namespace Projekt.Zad2
{
    public class Koszyk
    {
        public List<Produkt> Produkty { get; set; }

        public Koszyk()
        {
            Produkty = new List<Produkt>();
        }

        public void add(Produkt produkt)
        {
            Produkty.Add(produkt);
        }

        public void ShowContent()
        {
            foreach (var item in Produkty)
            {
                Console.WriteLine(item.ToString() +  " " + item.Ilosc + " kg" );
            }
        }
    }
}