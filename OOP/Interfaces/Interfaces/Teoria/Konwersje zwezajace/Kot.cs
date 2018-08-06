using System;
namespace Interfaces.Teoria.Konwersjezwezajace
{
	public class Kot : Zwierz
    {
		public Kot() 
        {
			
        }

		public override void Start()
		{
			Console.WriteLine("Kot biegnie");
		}

		public override void Stop()
		{
			Console.WriteLine("Kot Stoi");
		}
	}
}
