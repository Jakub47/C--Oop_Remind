using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt.Zad4
{
    //Sealed == zabezpieczenie przed dziediczeniem
    public sealed class Cennik
    {
        //public
        public Hashtable ProduktyCeny = new Hashtable();


        //private
        private static Cennik m_oInstance = null;
        private static readonly object m_oPadLock = new object();
        
        public static Cennik Instance
        {
            get
            {
                lock (m_oPadLock)
                {
                    if(m_oInstance == null)
                    {
                        m_oInstance = new Cennik();
                    }
                    return m_oInstance;
                }
            }
        }

        public void Set(string v1, float v2)

        {
            ProduktyCeny.Add(v1, v2);
        }
    }
}
