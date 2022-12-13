// Задача 64: Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Write("Введите натурально число  ");
int number = Convert.ToInt32(Console.ReadLine());

void Integers(int num)
{

    if (num > 1)
    {
        Console.Write($"{num}, ");
        Integers(num - 1);
    }

    else Console.Write($"{num}");
}



if (number > 0) Integers(number);
else Console.Write("Введите наруральное число");