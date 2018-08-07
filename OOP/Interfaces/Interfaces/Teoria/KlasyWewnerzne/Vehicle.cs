using System;
namespace Interfaces.Teoria.KlasyWewnerzne
{
	public class Vehicle : IMoveable
    {
		public Person Owner { get; set; }
		public int w { get; set; }
		public int h { get; set; }
		public int l { get; set; }
		public int weight { get; set; }
		public int state { get; set; }

        public Vehicle(Person ownwer,int w,int h, int l, int weight, int state)
        {
			this.Owner = ownwer; this.w = w; this.h = h;
			this.l = l; this.weight = weight; this.state = state;
        }

		public void Stop()
		{
			throw new NotImplementedException();
		}

		public void Start()
		{
			throw new NotImplementedException();
		}
	}

	public class Person
	{
		
	}
}