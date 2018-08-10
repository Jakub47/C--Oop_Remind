using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// The main feature of nested classes is that they can access private members of the outer class while having the full power
/// of a class itself. Also they can be private which allows for some preety powerful encapsulation.
/// </summary>
namespace Interfaces.Teoria.KlasyWewnerzne.Forum
{
    public interface IFoo
    {
        int Foo { get; }
    }

    class Factory
    {
        private class MyFoo : IFoo
        {
            public int Foo { get; set; }
        }
        public IFoo CreateFoo(int value) => new MyFoo { Foo = value };
    }

    /// <summary>
    /// If we were to provide an instance of some interfaces to some other objects but we don't want our main class to 
    /// implement it we could let an inner class implement it.
    /// </summary>
    /// 

    public interface ISomeInterface
    {
        int DoStuff();
    }

    public class Outer
    {
        private int _example;
        private class Inner : ISomeInterface
        {
            Outer _outer;
            public Inner(Outer outer) => _outer = outer;

            public int DoStuff()
            {
                return _outer._example;
            }
        }

        public void DoStuff() { }
    }
}
