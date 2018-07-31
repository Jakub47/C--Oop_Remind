using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt.Zad3
{
    /// <summary>
    /// Napisac aplikacje ktora symuluje zakupy w sklepie.
    /// Nalezy uzyc abstrakcji i polimorfizmu.
    /// Nalezy zminimalizowac kod Koszyk i Torba.
    /// Zdefinowac trak klase cennik aby istnial tylko jeden obiekt tej klasay (singleton). Tylko jeden cennik.
    /// 
    /// Z treści wynika,że potrzeba jeszcze 2 klas o których nie wspomniano. Sądzę,że chodzi o klase abstrakcyjną Dla
    /// -Wszystkich produktów
    /// -Torba i Koszyk
    /// 
    /// The C# equivalent for vector in java, is ArrayList. It is in System.Collection namespace.
    /// For Key/ Value pair, you can use Hashtables, Dictionary or even a KeyValuePair object.
    /// 
    /// 
    /// </summary>
    public class Sklep
    {
        private Kasa kasa;
        private Cennik cennik;
        public Sklep()
        {
            cennik = new Cennik();
            cennik.Set("Truskawki",5);
            cennik.Set("Truskawki",6);
            cennik.Set("Truskawki",7);
            kasa = new Kasa();
        }

        public void zakupyDemo(string osoba)
        {
            Koszyk koszyk = new Koszyk();
            Console.WriteLine(osoba + " bierze " + koszyk);

            koszyk.Add(new Truskawki(1));
            koszyk.Add(new Banany(0.5f));
            koszyk.Add(new Agrest(0.25f));
            koszyk.Add(new Mandarynki(2));

            koszyk.ShowContent();
            kasa.PrintBill(koszyk,cennik);

            //Torba torba = new Torba();
            //torba.LoadFrom(koszyk);

            //torba.ShowContent();
        }
    }

    public class Test
    {
        public static void main(string[] args)
        {
            Sklep s = new Sklep();
            s.zakupyDemo("Janek");
        }
    }
}
