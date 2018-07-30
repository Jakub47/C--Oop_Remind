using System;

namespace Projekt.Zad2
{
    internal class Kasa
    {
        public int Numer { get; set; }

        public Kasa(int numer)
        {
            this.Numer = numer;
        }

        public void printBill(Koszyk k , Cennik c)
        {
            //string wynik = "";
            ////string wynik = k.Produkty.Whe(i => i.ToString() == c.ProduktyCeny[i.ToString()])
            foreach (var item in k.Produkty)
            {
                float cena = -1;
                for (int i = 0; i < c.ProduktyCeny.Count; i++)
                {
                    if(c.ProduktyCeny[item.ToString()] != null )
                    {
                        cena = Convert.ToInt64(c.ProduktyCeny[item.ToString()]);
                    }
                }

                if (cena == -1) continue;

                float g = item.Ilosc * cena;

                System.Console.WriteLine(item.ToString() + " " + item.Ilosc + " * " + cena + " zl/kg = " + g );
            }


        }
    }
}