using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessANumber
{
    interface IHelpUser
    {
        public void Check(int number, int userNumber);
    }
}
