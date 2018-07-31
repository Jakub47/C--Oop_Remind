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

        public void PrintBill(Koszyk k)
        {
            //string wynik = "";
            ////string wynik = k.Produkty.Whe(i => i.ToString() == c.ProduktyCeny[i.ToString()])
            foreach (var item in k.Produkty)
            {
                float cena = -1;
                for (int i = 0; i < Cennik.Instance.ProduktyCeny.Count; i++)
                {
                    if(Cennik.Instance.ProduktyCeny[item.ToString()] != null )
                    {
                        cena = Convert.ToInt64(Cennik.Instance.ProduktyCeny[item.ToString()]);
                    }
                }

                if (cena == -1) continue;

                float g = item.Ilosc * cena;

                System.Console.WriteLine(item.ToString() + " " + item.Ilosc + " * " + cena + " zl/kg = " + g );
            }


        }
    }
}