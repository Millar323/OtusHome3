using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessANumber
{
    internal class Number
    {
        public int GuessThis(int start, int end) 
        {
            var rnd = new Random();
            var number = rnd.Next(start, end);
            return number;
        }

    }
}
