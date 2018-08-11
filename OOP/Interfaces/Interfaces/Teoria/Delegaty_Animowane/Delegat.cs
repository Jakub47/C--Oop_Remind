using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Teoria.Delegaty_Animowane
{
    class Delegat
    {
        private delegate int TypDelekacji(int a);

        public static void Main(string[] args)
        {
            var a = new TypDelekacji(Kwadrat);

            Console.WriteLine("-------------------------------");
            a += InnaMetoda;
            //Zostaną wywołane wszystkie metody zarejestrowane w delegacie a!
            Console.WriteLine(a(10));
            
            Console.ReadKey();
        }

        private static int Kwadrat(int a)
        {
            Console.WriteLine("Wywołano Metodę kwadrat");
            return a * a;
        }

        private static int InnaMetoda(int b)
        {
            Console.WriteLine("Wywołano metode InnaMetoda");
            return b * 2;
        }
    }
}
