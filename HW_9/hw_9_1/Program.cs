// Задачаь 1. Задайте значения M и N. Напишите программу, которая выведет все чётные натуральные числа в промежутке от M до N с помощью рекурсии.

Console.Write("Введите n: ");
int n = Convert.ToInt16(Console.ReadLine());
Console.Write("Введите m: ");
int m = Convert.ToInt16(Console.ReadLine());
Console.WriteLine($"n={n}, m={m}");
if (m > n)
    for (int i = n; i <= m; i++)
        Console.Write($" {i}");
else
    for (int i = m; i <= n; i++)
        Console.Write($" {i}");