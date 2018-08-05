using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Teoria
{
    /// <summary>
    /// All classes due to inheritance will also become obligaory to implement this interface!
    /// </summary>
    public class Vehicle : IMoveable
    {
        public int Numer { get; set; }
        public Vehicle(int numer)
        {
            Numer = numer;
        }

        public void Start()
        {
            Console.WriteLine("Samochod nr " + Numer  + " - JEDZIE");
        }

        public void Stop()
        {
            throw new NotImplementedException();
        }
    }
}
