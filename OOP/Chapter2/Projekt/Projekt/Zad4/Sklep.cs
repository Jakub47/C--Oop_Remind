using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt.Zad4
{
    class Sklep
    {
        private Kasa _kasa;

        public Sklep()
        {
            Cennik cennik = Cennik.Instance;

            //      Create new variable that will store that Instance
            cennik.Set("Truskawki", 5);
            cennik.Set("Banany", 6);
            cennik.Set("Agrest", 7);
            cennik.Set("Winogrona", 7);
            _kasa = new Kasa();
        }

        internal void Zakupy(string osoba, Produkt[] produkty)
        {
            Koszyk koszyk = new Koszyk();
            Console.WriteLine(osoba + " bierze koszyk sklepowy nr " + Koszyk.Numer);

            produkty.ToList().ForEach(i => koszyk.add(i));

            //koszyk.add(new Truskawki(1));
            //koszyk.add(new Banany(0.5f));
            //koszyk.add(new Agrest(0.25f));
            //koszyk.add(new Mandarynki(2));
            //koszyk.add(new Winogrona(0.5f));

            Console.WriteLine("Zawartość pojemnika koszyk \" Koszyk sklepowy nr " + Koszyk.Numer + "\"" );
            koszyk.ShowContent();

            Console.WriteLine("Kasa - rachunek za {koszyk sklepowy nr " + Koszyk.Numer + " } ");
            _kasa.PrintBill(koszyk);

            var torba = new Torba(osoba);
            torba.LoadFrom(koszyk);

            Console.WriteLine("Zawartość pojemnika \"torba [Wlasciciel: " + torba.Osoba + " ] : ");
            torba.ShowContent();

            Console.ReadKey();
            Console.WriteLine("---------------------------------------------------------");
        }
    }

    public class Test
    {
        public static void Main(string[] args)
        {
            var s = new Sklep();
            s.Zakupy("Janek",
                new Produkt[] { new Truskawki(2), new Banany(0.5f), new Agrest(0.25f), new Mandarynki(1)});

            s.Zakupy("Małgosia",
                new Produkt[] { new Truskawki(5), new Banany(3) });
        }
    }
}
