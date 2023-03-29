// Задача 2. Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N с помощью рекурсии.

Console.Clear();
Console.Write("Введите числа M и N: ");

int EvenSum(int M, int N)
{
    while (M < 1) M++;
    if (M > N) return 0;
    return EvenSum(M+1, N) + M;
}

int num = int.Parse(Console.ReadLine()!);
int num2 = int.Parse(Console.ReadLine()!);
Console.WriteLine(EvenSum(num, num2));