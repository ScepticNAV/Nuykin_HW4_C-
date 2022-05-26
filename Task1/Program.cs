/* Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

int GetNumber(string msg)                                                   // Метод проверки ввода пользователем числа
{
while(true)
{
Console.WriteLine(msg);
string valueFromConsole = Console.ReadLine();

    if(int.TryParse(valueFromConsole, out int number))
    {
        return number;
    }
    else
    {
        Console.WriteLine("Вы ввели не число. Нужно ввести число.");
    }
}
}

void GetDegree(int num1, int num2)                                               // Метод возведения в числа1 в степень, равную числу2
{
    Console.Write($"Число {num1} в степени {num2} = {Math.Pow(num1, num2)}");  
}

int number1 = GetNumber("Введите первое число");                                 // Код основной программы
int number2 = GetNumber("Введите второе число");
GetDegree(number1, number2);