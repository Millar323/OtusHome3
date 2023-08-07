using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessANumber
{
    public class Game : IReader, IHelpUser, INumber
    {
        public string GetInput(string text) 
        {
            Console.WriteLine(text);//необходима валидация
            var res = Console.ReadLine();
            return res;
        }

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

        public int Number(int start, int end)
        {
            var rnd = new Random();
            var number = rnd.Next(start, end);
            return number;
        }
        public void Play() 
        {
            Console.WriteLine("Приветсвую в игре 'Угадай число!'");

            Console.WriteLine("Выбирем несколько настроек: ");
            var maxTries = GetInput("Введите максимальное количетсво попыток: ");
            var start = Int32.Parse(GetInput("Введите начало диапозона чисел: "));
            var end = Int32.Parse(GetInput("Введите конец диапозона чисел: "));
            var number = Number(start, end);
            var tries = 0;

            Console.WriteLine("Число загадано, начианем игру...");

            do
            {

                var userNumber = GetInput("Ваше число - ");

                tries++;

                Check(number, Int32.Parse(userNumber));

                Console.WriteLine("Неверно, попробуйте еще...");
                Console.WriteLine("Номер попытки - " + tries + ". Осталось попыток - " + (Int32.Parse(maxTries) - tries));
            }
            while (tries != Int32.Parse(maxTries));

            Console.WriteLine("К сожалению, вы проиграли, может быть в другой раз...");

        }

    }
}
