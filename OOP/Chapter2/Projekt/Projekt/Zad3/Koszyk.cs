using System;
using System.Collections.Generic;

namespace Projekt.Zad3
{
    public class Koszyk
    {
        public List<Produkt> Produkty { get; set; }

        public Koszyk()
        {
            Produkty = new List<Produkt>();
        }

        public void Add(Produkt produkt)
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