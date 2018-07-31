using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt.Zad2
{
    /// <summary>
    /// If the inheritance is public, everything that is aware of Base and Child is also aware that Child inherits from Base.
    ///If the inheritance is protected, only Child, and its children, are aware that they inherit from Base.
    ///If the inheritance is private, no one other than Child is aware of the inheritance.
    /// </summary>
    abstract public  class Items
    {
        internal List<Produkt> Produkty { get; set; }

        public Items()
        {
            Produkty = new List<Produkt>();
        }

        internal void add(Produkt produkt)
        {
            Produkty.Add(produkt);
        }

        internal void ShowContent()
        {
            foreach (var item in Produkty)
            {
                Console.WriteLine(item.ToString() + " " + item.Ilosc + " kg");
            }
        }
    }
}
