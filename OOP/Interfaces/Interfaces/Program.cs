using Interfaces.Teoria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Testing with MonoDevelop
*/
namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            //var kuba = new Pies("Kuba");
            //kuba.Start();
            //Console.WriteLine(kuba.GetVoice(MyContansts.Loud));
            //kuba.Stop();

            wyscig(new IMoveable[] { new Pies(),new Car(4311)});

            Console.ReadKey();

        }

        static void wyscig(IMoveable[] objects)
        {
            for (int i = 0; i < objects.Length; i++)
            {
                objects[i].Start();
                if(objects[i] is Vehicle)
                    Console.WriteLine(""+objects[i]);
            }
        }
    }
}
