using System;
namespace Interfaces.Teoria.KlasyWewnerzne
{
    public class Start
    {
        public Start()
        {
        }

		static void main(string[] args)
        {
            //var c = new Car();
            var cos = new { Name = "Adam" };
            Console.WriteLine(cos.Name);
            Console.ReadKey();
        }
    }
}
