using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Teoria.KlasyWewnerzne.Forum
{
    /// <summary>
    /// Typically a nested class N is created inside of class whenever C needs to use something internally
    /// Which should be never be used outside of C. and for whatever reason that something needs to be a new type of
    /// object rather that some existing type.
    /// </summary>
    class BlobOfBusinessData : IEnumerable<BusinessDatum>
    {
        public IEnumerator<BusinessDatum> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
