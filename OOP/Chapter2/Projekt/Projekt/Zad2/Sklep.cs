using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt.Zad2
{
    class Sklep
    {
        public static void Main(string[] args)
        {
            
            Cennik.Instance.Set("Truskawki", 5);
            Cennik.Instance.Set("Banany", 6);
            Cennik.Instance.Set("Agrest", 7);
            Cennik.Instance.Set("Winogrona", 7);

            Koszyk koszyk = new Koszyk();

            koszyk.add(new Truskawki(1));
            koszyk.add(new Banany(0.5f));
            koszyk.add(new Agrest(0.25f));
            koszyk.add(new Mandarynki(2));
            koszyk.add(new Winogrona(0.5f));

            Kasa kasa = new Kasa(1);
            koszyk.ShowContent();
            kasa.PrintBill(koszyk);


            Console.ReadKey();
        }
    }
}
