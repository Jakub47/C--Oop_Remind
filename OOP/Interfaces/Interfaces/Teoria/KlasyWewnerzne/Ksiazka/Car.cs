using System;
using System.Timers;

namespace Interfaces.Teoria.KlasyWewnerzne
{
	public class Car : Vehicle
    {
		public string NrRej { get; set; }
		public int TankCapacity { get; set; }
		public int Fuel { get; set; }
		public Timer fuelTimer = new Timer(1000);

        /// <summary>
        /// Prywatna klasa wewnętrzna. Nie można jej używać poza klasą Car.
		/// Dostarcza definicji metody ActionPerformed()
		/// wywoływanej przez Timer.
        /// </summary>
		private class FuelConsume
		{
			private readonly Car _car;

            public FuelConsume()
			{

			}

            public FuelConsume(Car car)
			{
				this._car = car;
			}

			public void ActionPerformed()
			{
				if(_car.state != MyConst.MOVED)
				{
					_car.fuelTimer.Stop();
				}
				else
				{
					_car.fuelTimer.Interval -= 1;
					if (_car.fuelTimer.Interval == 0) Stop();
				}
			}
		}

        public Car()
        {
        }
    }
}
