using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Teoria.Konwersjezwezajace
{
    /// <summary>
    /// Pies potrafi:
    /// -Jest Zwierzeciem
    /// -Potrafi mowic
    /// -Moze sie poruszac
    /// </summary>
    public class Pies  : Zwierz
	{
       public Pies() { }
        public Pies(string s) : base(s) { }
       
		public override void Start()
        {
            Console.WriteLine("Pies " + name + " biegnie");
        }

		public override void Stop()
        {
            Console.WriteLine("Pies " + name + " stanął");
        }

		public void Merda() 
		{
			Console.WriteLine("Merda ogonem!"); 
		}
    }
}
