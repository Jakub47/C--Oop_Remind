using System;
namespace Interfaces.Teoria.KlasyWewnerzne
{
	public class Car : Vehicle
    {
		public string NrRej { get; set; }
		public int TankCapacity { get; set; }
		public int Fuel { get; set; }
        

        /// <summary>
        /// Prywatna klasa wewnętrzna. Nie można jej używać poza klasą Car.
		/// Dostarcza definicji metody ActionPerformed()
		/// wywoływanej przez Timer.
        /// </summary>
		private class FuelConsume
		{
			public void ActionPerformed()
			{
				if(1==1)
				{
					
				}
			}
		}

        public Car()
        {
        }
    }
}
