using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace GuessANumber
{
    interface INumber
    {
        public int Number(int start, int end);
    }
}
