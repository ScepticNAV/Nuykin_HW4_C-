/* Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

int GetNumber(string msg)                                                   // Метод проверки ввода пользователем числа
{
    while (true)
    {
        Console.WriteLine(msg);
        string valueFromConsole = Console.ReadLine();

        if (int.TryParse(valueFromConsole, out int number))
        {
            return number;
        }
        else
        {
            Console.WriteLine("Вы ввели не число. Нужно ввести число.");
        }
    }
}

int SumFiguresInNum(int num)
{
    if (num < 0)
    {
        num = num * (-1);
    }
    
    int sum = 0;
    while (num % 10 > 0)
        {
            sum = sum + num % 10;
            num = num / 10;
        }
    return sum;
}

int number = GetNumber("Введите число");
int result = SumFiguresInNum(number);
Console.Write($"Сумма цифр в числе {number} = {result}");


