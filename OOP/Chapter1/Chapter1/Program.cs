using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter1
{
    class Program
    {
        static void Main(string[] args)
        {
            //var box1 = new Box(10,15); var box2 = new Box(20, 30); var box3 = new Box(10, 10); var box4 = new Box(25, 100);
            //Console.WriteLine(Box.joinDiagnol() + "\n");
            //Console.WriteLine(Box.vertical() + "\n");
            //Console.WriteLine(Box.horizontal());

            SortedWordsFromFiles x = new SortedWordsFromFiles("Ala ma kota");
            x.getWords();
            Console.ReadLine();

        }
    }
}
