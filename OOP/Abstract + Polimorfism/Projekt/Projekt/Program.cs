using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    abstract class Zwierz
    {
        string name = "nieznany";
        public Zwierz() { }
        public Zwierz(string s) { name = s; }

        public abstract string getTyp();

        public virtual string getName() { return name; }

        public abstract string getVoice();

        public void Speak()
        {
            Console.WriteLine(getTyp() + " " + getName() + " mówi " + getVoice());
        }
    }

    class Pies : Zwierz
    {
        public Pies() { }
        public Pies(string s) : base(s) { }

        public override string getTyp() { return "Pies"; }
        public override string getVoice() { return "Hau Hau!"; }
    }

    class Kot : Zwierz
    {
        public Kot() { }
        public Kot(string s) : base(s) { }

        public override string getTyp() { return "Kot"; }
        public override string getVoice() { return "Miau..."; }
    }

    class Program
    {
        //static void Main(string[] args)
        //{
        //    //Zwierz z1 = new Zwierz(); Zwierz z2 = new Zwierz();
        //    Pies pies = new Pies(); Pies kuba = new Pies("Kuba"); Pies reksio = new Pies("reksio");
        //    Kot kot = new Kot();

        //    //animalDialog(z1, z2);
        //    animalDialog(kuba, reksio);
        //    animalDialog(kuba, kot);
        //    animalDialog(reksio, pies);

        //    Console.ReadKey();
        //}

        static void animalDialog(Zwierz z1, Zwierz z2)
        {
            z1.Speak();
            z2.Speak();
            Console.WriteLine("---------------------------------------------------------------------");
        }
    }
}
