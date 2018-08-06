using System;
namespace Interfaces.Teoria.KlasyWewnerzne
{
    public class Start
    {
        public Start()
        {
        }

		static void Main(string[] args)
        {
            var pies = new Pies();
            Zwierz z = new Zwierz();
            Pies p1 = (Pies)z;

            Kot mruczek = new Kot();
            info(mruczek);

            Console.ReadKey();
        }
    }
}
