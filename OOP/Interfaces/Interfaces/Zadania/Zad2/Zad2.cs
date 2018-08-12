using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Zadania.Zad2
{
    class Zad2 : IMoveable
    {
        public bool IsMoveable { get; set; }

        public Zad2()
        {
            IsMoveable = false;
        }

        public void Start()
        {
            IsMoveable = true;
        }

        public void Stop()
        {
            IsMoveable = false;
        }
    }
}
