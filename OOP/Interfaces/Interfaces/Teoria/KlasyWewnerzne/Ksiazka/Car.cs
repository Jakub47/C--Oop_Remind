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
					if (_car.fuelTimer.Interval == 0) _car.fuelTimer.Stop();
				} 
			}
		}

        public Car(Person ownwer, int w,int h,int l,int weight, int state,string nr,int tankCp)
            : base(ownwer,  w,  h,  l,  weight,  state)
        {
            this.NrRej = nr;
            this.TankCapacity = tankCp;
        }

        public void fill(int amount)
        {
            if (this.state == MyConst.MOVING)
                Console.WriteLine("Nie moge tankowac w ruchu");
            else
            {
                Fuel += amount;
                if (Fuel > TankCapacity) Fuel = TankCapacity;
            }
        }

        public override void Start()
        {
           if(Fuel > 0)
            {
                base.Start();
                fuelTimer.Start();
            }
            else Console.WriteLine("Brak bezyny");
        }

        public override void Stop()
        {
            base.Stop();
            fuelTimer.Stop();
        }

        public override string ToString()
        {
            return "Samochód nr rej " + NrRej + " - " + state;
        }
    }
}
