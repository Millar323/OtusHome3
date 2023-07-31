using GuessANumber;

var inputValue = new Reader();
var findNumber = new Number();
var helpUser = new HelpUser();
Console.WriteLine("Приветсвую в игре 'Угадай число!'");

Console.WriteLine("Выбирем несколько настроек: ");
/*
1)Выделено 3 класса, выполняющих каждый свою задачу (1 прицип)
2)Класс Reader должен выводить определенное сообщение пользователю, он сделан с учетом 2 принципа, что позволяет нам выводить лббое необходимое сообщение, не меняюю и не добавляя в класс что то лишнее.
*/
var start = inputValue.GetInput("Введите начало диапозона чисел: ");
var end = inputValue.GetInput("Введите конец диапозона чисел: ");
var maxTries = inputValue.GetInput("Введите максимальное количетсво попыток: ");
var number =  findNumber.GuessThis(Int32.Parse(start), Int32.Parse(end));
var tries = 0;

Console.WriteLine("Число загадано, начианем игру...");

do
{

    var userNumber = inputValue.GetInput("Ваше число - ");
    
    tries++;
                                                                                                                                                                                                                                        
    helpUser.Check(number, Int32.Parse(userNumber));

    Console.WriteLine("Неверно, попробуйте еще...");
    Console.WriteLine("Номер попытки - " + tries + ". Осталось попыток - " + (Int32.Parse(maxTries) - tries));
}
while (tries != Int32.Parse(maxTries));

Console.WriteLine("К сожалению, вы проиграли, может быть в другой раз...");


