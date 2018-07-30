//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Projekt
//{
//    public enum TypBenzyny : byte {BENZYNA,GAZ,DIESEL};

//    public class EngineVehicle

//    {
//        public TypBenzyny typBenzyny;
//        public string numerRejestracyjny { get; set; }
//        public int bak { get; set; }
//        public int paliwoWBaku { get; set; }

//        public EngineVehicle(TypBenzyny typBenzyny,string nr,int bk,int pal)
//        {
//            this.typBenzyny = typBenzyny; numerRejestracyjny = nr; bak = bk;
//        }

//        void fill(int paliwo)
//        {
//            if (paliwoWBaku + paliwo < bak)
//                paliwoWBaku += paliwo;
//            else
//                paliwoWBaku = bak;
//        }
//    }

//    public class Vehicle : EngineVehicle
//    {
//        public Person person { get; set; }
//        public int szerokosc { get; set; }
//        public int height { get; set; }
//        public int length { get; set; }
//        public int weight { get; set; }

//        public Vehicle(Person owner,int szerokosc,int height,int length,int weight,TypBenzyny typ,string nr,int bak,int pal)
//            :base(typ,nr,bak,pal)
//        {
//            person = owner; this.szerokosc = szerokosc;
//            this.height = height; this.length = length; this.weight = weight;
//        }
//    }

//    public class Car : Vehicle
//    {
//        public Car(string nr,Person owner,int w,int h, int l,int weight,int tankCap,TypBenzyny bn,string numer,int bak,int pal) 
//            : base(owner,w,h,l,weight,bn,numer,bak,pal)
//        {

//        }
//    }

//    public class Bus : Vehicle
//    {
//        public int LiczbaMiejsc { get; set; }
//        public int LiczbaWolnychMiejsc { get; set; }

//        public Bus(int liczbaMiejsc,int liczbaWolnychMiejsc,string nr, Person owner, int w, int h, int l, int weight, int tankCap, TypBenzyny bn, string numer, int bak, int pal) 
//            : base(owner,w,h,l,weight,bn,numer,bak,pal)
//        {
//            this.LiczbaMiejsc = liczbaMiejsc;
//            this.LiczbaWolnychMiejsc = liczbaWolnychMiejsc;
//        }
//    }

//    public class Person
//    {
//        private string _imie;
//        private string _nazwisko;

//        public Person()
//        {

//        }

//        public Person(string imie, string nazwisko)
//        {
//            _imie = imie; _nazwisko = nazwisko;
//        }
//    }

//    public class Veh1
//    {
//        public static void reportState(EngineVehicle[] v)
//        {

//        }

//        public static void startEngineVehicles(EngineVehicle[] v)
//        {
//            foreach (var item in v)
//            {
//                item.
//            }
//        }

//        public static void main(string[] args)
//        {
//            Bus a = new Bus()
//        }
//    }
//}
