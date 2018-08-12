using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter1
{
    public class Box
    {
        //public
        public float szerokosc { get; set; }
        public float wysokosc { get; set; }

        //staticsss
        private static float szerokoscLaczna = 0;
        private static float wysokoscLaczna = 0;

        private static float maxSzerokosc = 0;
        private static float maxWysokosc = 0;

        public Box(float szerokosc,float wysokosc)
        {
            this.szerokosc = szerokosc; szerokoscLaczna += szerokosc;
            this.wysokosc = wysokosc; wysokoscLaczna += wysokosc;

            if (maxWysokosc <= wysokosc) maxWysokosc = wysokosc;
            if (maxSzerokosc <= szerokosc) maxSzerokosc = szerokosc;

        }
        //Return all given values 
        public static string joinDiagnol() { return wysokoscLaczna.ToString() + ',' +  szerokoscLaczna.ToString(); }

        //Return all Values of vertival and max of Height
        public static string vertical() { return szerokoscLaczna.ToString() + ',' + maxWysokosc.ToString(); }

        //Return all values of height and max of vertical
        public static string horizontal() { return wysokoscLaczna.ToString() + ',' + maxSzerokosc.ToString(); }
    }
}
