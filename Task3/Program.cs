/*
Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19] 
6, 1, 33 -> [6, 1, 33]
*/

void FillRandArray(int[] massive)                   // Метод заполнения массива случайными числами от 0 до 99
{
    Random randomiser = new Random();
    for (int i = 0; i < massive.Length; i++)
    {
        massive[i] = randomiser.Next(0, 100);
    }
}

void PrintArray(int[] array)                        // Метод вывода массива на печать
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.WriteLine();
}

int[] array = new int[8];                           //int[] array = { 1, 2, 3, 4, 5, 6, 7, 8 };
FillRandArray(array);
PrintArray(array);
