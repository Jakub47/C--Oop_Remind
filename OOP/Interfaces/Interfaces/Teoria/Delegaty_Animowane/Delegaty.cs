using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Teoria.Delegaty_Animowane
{
    public class Delegaty
    {
        protected delegate int Delegat1(int arg1, int arg2);
    }

    class Program : Delegaty
    { 
        public static void main(string[] args)
        {
            Delegat1 dodawanie1 = delegate (int arg1, int arg2)
            {
                return arg1 + arg2;
            };
            Console.WriteLine("Wynik dodwania " + dodawanie1(4,2));

            Delegat1 odejmowanie = (int c, int d) => { return c - d; };

            Console.WriteLine("Wynik dodwania " + odejmowanie(15,5));
        }

    }
}
