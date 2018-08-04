using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter1
{
    class MyWater
    {
        private static List<int> _largeBottles;
        private static List<int> _mediumBottles;
        private static List<int> _smallBottles;

        static MyWater()
        {
            _largeBottles = new List<int>(); _mediumBottles = new List<int>(); _smallBottles = new List<int>();
        }

        public static List<int> LargeBottles
        {
            get
            {
                return _largeBottles;
            }

            set
            {
                _largeBottles = value;
            }
        }

        public static List<int> MediumBottles
        {
            get
            {
                return _mediumBottles;
            }

            set
            {
                _mediumBottles = value;
            }
        }

        public static List<int> SmallBottles
        {
            get
            {
                return _smallBottles;
            }

            set
            {
                _smallBottles = value;
            }
        }

        public void addLarge(int bottles) => _largeBottles.Add(bottles);
        public void addMedium(int bottles) => _mediumBottles.Add(bottles);
        public void addSmall(int bottles) => _smallBottles.Add(bottles);

        public override string ToString()
        {
            return "Mam teraz " + (_largeBottles.Sum() * 2 + _mediumBottles.Sum() + _smallBottles.Sum() * 0.5) + "litrów wody" +  "\n" +
                "dużych butelek: " + _largeBottles.Sum() + "\n" + 
                "średnich butelek: " + _mediumBottles.Sum() + "\n" +
                "małych butelek: " + _smallBottles.Sum();
        }
    }
}
