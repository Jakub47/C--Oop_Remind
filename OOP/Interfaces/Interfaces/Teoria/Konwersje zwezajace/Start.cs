using System;
namespace Interfaces.Teoria.Konwersjezwezajace
{
    public class Start
    {
        public Start()
        {
			
        }


        /// <summary>
        /// Pies pochodzi od Zwierza, wiec możemy z Psa uzyskać Zwierza, a pozniej
		/// z tego Zwierza z powrotem Psa
        /// </summary>
        /// <param name="args">The command-line arguments.</param>
		static void Main(string[] args)
        {
			var pies = new Pies();
			Zwierz z = new Zwierz();
			Pies p1 = (Pies)z;

			Kot mruczek = new Kot();
			info(mruczek);

            Console.ReadKey();         
        }

		static void info(Zwierz z)
        {
            say(z.GetType() + z.name);

            if (z is ISpeakable)
            {
                ISpeakable zs = (ISpeakable)z;
                say(zs.GetVoice(Teoria.MyContansts.Loud));
            }

            if (z is Pies)
            {
				(z as Pies).Merda();
            }
        }

        static void say(string s)
        {
            Console.WriteLine(s);
        }
    }
}
