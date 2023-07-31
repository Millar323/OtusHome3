using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessANumber
{
    internal class Reader
    {
        public string GetInput(string text) 
        {
            Console.WriteLine(text);//необходима валидация
            var res = Console.ReadLine();
            return res;
        }
    }
}
