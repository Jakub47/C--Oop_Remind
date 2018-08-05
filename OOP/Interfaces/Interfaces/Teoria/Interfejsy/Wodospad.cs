using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Teoria
{
    class Wodospad : ISpeakable
    {
        public string GetVoice(int voice)
        {
            if (voice == MyContansts.Loud) return "SZSZSZSZSZSZSZSZ";
            else if (voice == MyContansts.Quiet) return "szszszszszszsz";
            else return "?";
        }
    }
}
