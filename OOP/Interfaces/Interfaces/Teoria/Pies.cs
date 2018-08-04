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
            throw new NotImplementedException();
        }

        public void Start()
        {
            throw new NotImplementedException();
        }

        public void Stop()
        {
            throw new NotImplementedException();
        }
    }
}
