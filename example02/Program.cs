// Задача 66: Задайте значения M и N. Напишите программу,
//  которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Введите натурально число M  ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите натурально число N  ");
int numberN = Convert.ToInt32(Console.ReadLine());


int IntervalNatural(int num1, int num2)
{
    if (num1 < num2) return num1 + IntervalNatural(num1 + 1, num2);
    else if (num1 > num2) return num1 + IntervalNatural(num1 - 1, num2);
    else return num2;
}


int res = IntervalNatural(numberM, numberN);

Console.Write($"M = {numberM}; N = {numberN} -> {res}");