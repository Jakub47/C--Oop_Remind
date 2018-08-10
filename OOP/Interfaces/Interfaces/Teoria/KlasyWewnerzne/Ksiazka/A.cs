using System;
namespace Interfaces.Teoria.KlasyWewnerzne
{
	/// <summary>
    /// -Klasy wewnetrzne moga bycc ukryte przed innymi klasami pakietu
	/// -Pozwalaja unikac kolizji nazw
	/// -Lepsza strukturyzacja kodu. Poniewaz mozna sie odwolac do skladowych, klay
	/// Otaczajacej, a przy tm zlokalizowac pewne dzialana
    /// </summary>
    public class A
    {
        public A()
        {
			
        }

		class B
		{
			public B()
			{

			}
		}
	}
}
