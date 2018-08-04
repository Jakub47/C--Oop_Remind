using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    public class S
    {
        public static void ay(string s) => Console.WriteLine(s);
    }

    //public class A
    //{
    //    public A()
    //    {
    //        S.ay("Konstruktor A");
    //    }
    //    public A(string s) => S.ay("Konstruktor A z parametrem String = " + s);
    //}

    //public class B : A
    //{
    //    public B() => S.ay("Konstruktor B");
    //    public B(int c) => S.ay("Konstruktor B z parametrem int = " + c);
    //    public B(string t) : base(t) => S.ay("Konstruktor B z parametrem sting = " + t);
    //}

    //public class C : B { }

    public class Test
    {
        //static void Main(string[] args)
        //{
        //    S.ay("Tworzenie obiektu b - B():"); new B();
        //    S.ay("Tworzenie obiektu b - B(int):"); new B(1);
        //    S.ay("Tworzenie obiektu b - B(string):"); new B("Ala");
        //    S.ay("Tworzenie obiektu c:"); new C();
        //    Console.ReadKey();
        //}
    }
}
