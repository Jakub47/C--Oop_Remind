using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt.Zad3
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

        public void ZakupyDemo(String osoba)
        {

            Koszyk koszyk = new Koszyk();
            Console.WriteLine(osoba + " bierze " + koszyk);


            koszyk.add(new Truskawki(1));
            koszyk.add(new Banany(0.5f));
            koszyk.add(new Agrest(0.25f));
            koszyk.add(new Mandarynki(2));
            koszyk.add(new Winogrona(0.5f));

            koszyk.ShowContent();
            _kasa.PrintBill(koszyk);

            var torba = new Torba();
            torba.LoadFrom(koszyk);

            Console.WriteLine("Zawartość torby");
            torba.ShowContent();

            Console.ReadKey();
        }
    }

    public class Test
    {
        public static void main(string[] args)
        {
            var s = new Sklep();
            s.ZakupyDemo("Janek");
        }
    }
}
