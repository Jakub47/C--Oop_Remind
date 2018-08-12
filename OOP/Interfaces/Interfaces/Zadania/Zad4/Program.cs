using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Zadania.Zad4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IShowable> shows = new List<IShowable>();
            shows.Add(new Class1());
            shows.Add(new Class2());
            //shows.Add(new Class3());

            ShowAll(shows);
            Console.ReadKey();
        }

        private static void ShowAll(List<IShowable> show)
        {
            show.ForEach(i => i.Show());
        }
    }
}
