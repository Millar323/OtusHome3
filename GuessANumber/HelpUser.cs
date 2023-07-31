using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessANumber
{
    internal class HelpUser
    {
        public virtual void Check(int number, int userNumber)
        {
            if (userNumber == number)
            {
                Console.Write("Поздравляем! Вы угадали!");
                Environment.Exit(0);
            }
            else if (userNumber > number)
            {
                Console.WriteLine("Неверно, загаданное число меньше");
            }
            else
            {
                Console.WriteLine("Неверно, загаданное число больше");
            }
        }
    }
}
