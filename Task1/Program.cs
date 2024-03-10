﻿// Задайте значения M и N. Напишите
// программу, которая выведет все натуральные числа
// в промежутке от M до N. Использовать рекурсию, не
// использовать циклы.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"


static void ShowNumbersInInterval(int m, int n)
{
    if(m==n)
    {
        Console.Write(n);
    }
    if(m<n)
    {
        Console.Write($"{m}, ");
        ShowNumbersInInterval(m+1,n);
    }
    else if(m>n)
    {
        Console.Write($"{m}, ");
        ShowNumbersInInterval(m-1,n);
    }
    
}


Console.WriteLine("Введите натуральное значение M");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите натуральное значение N");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write($"M = {m}; N = {n} -> ");
ShowNumbersInInterval(m,n);
Console.WriteLine();