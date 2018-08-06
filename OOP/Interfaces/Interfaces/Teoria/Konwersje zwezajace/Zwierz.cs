using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Teoria.Konwersjezwezajace
{
	public class Zwierz : ISpeakable, IMoveable
    {
        public string  name { get; set; }
        public Zwierz()
        {

        }
        public Zwierz(string imie)
        {
            this.name = imie;
        }

		public string GetVoice(int voice, string s)
		{
			if (voice == Teoria.MyContansts.Loud)
				return s.ToUpper();
			else
				return s.ToLower();
		}

		public virtual void Start(){}

		public virtual void Stop(){}

		public string GetVoice(int voice)
		{
			return "Test";
		}
	}
}
