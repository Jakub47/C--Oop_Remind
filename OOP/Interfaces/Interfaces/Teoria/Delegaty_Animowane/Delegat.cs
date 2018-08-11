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
        private delegate void Writer(string message);


        public class Logger
        {
            private readonly Delegat _delegat;

            public Logger(Delegat delegat)
            {
                this._delegat = delegat;
            }

            public void WriteMessage(string message)
            {
                Console.WriteLine(message + "Cs 1.6\n");
            }

            public void WriteMessage2(string message2)
            {
                Console.WriteLine(message2 + "CS Global");
            }
        }


        public static void main(string[] args)
        {
            var a = new TypDelekacji(Kwadrat);
            var writer = new Writer(new Logger(new Delegat()).WriteMessage);

            //TypDelekacji obiektDelegacj = delegate (int x)
            //{
            //    Console.WriteLine("Wywa;mp metodę anonimową");
            //    return x * x;
            //};

            //===
            TypDelekacji obiektDelegacj = (int x) =>
            {
                Console.WriteLine("Wyrazenie lamda");
                return x * x;
            };

            TypDelekacji obiektDelegacji = x => x * x;
            Console.WriteLine("5*5=" + obiektDelegacji(5));

            //obiektDelegacj += Kwadrat;

            Console.WriteLine(obiektDelegacj(2));

            //a += InnaMetoda;
            //writer += new Logger(new Delegat()).WriteMessage2;

            //writer("Kaboom2");
            //Zostaną wywołane wszystkie metody zarejestrowane w delegacie a!
            //Console.WriteLine(a(10));
            
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
