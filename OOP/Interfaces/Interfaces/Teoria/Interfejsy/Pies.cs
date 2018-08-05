using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Teoria
{
    /// <summary>
    /// Pies potrafi:
    /// -Jest Zwierzeciem
    /// -Potrafi mowic
    /// -Moze sie poruszac
    /// </summary>
    class Pies : Zwierz , ISpeakable , IMoveable
    {
        public Pies() { }
        public Pies(string s) : base(s) { }

        public string GetVoice(int voice)
        {
            if (voice == MyContansts.Loud) return "HAU...HAU...HAU..";
            else return "hau... hau...";
        }

        public void Start()
        {
            Console.WriteLine("Pies " + name + " biegnie");
        }

        public void Stop()
        {
            Console.WriteLine("Pies " + name + " stanął");
        }
    }
}
