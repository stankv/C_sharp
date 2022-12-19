// Урок 9.

// Задача 2. Задайте значения M и N. Напишите программу, которая найдёт сумму
//натуральных элементов в промежутке от M до N с помощью рекурсии.


int SumNumbers(int begin, int end, int sum)
{
    sum += begin;
    if (begin == end) return sum;
    return SumNumbers(begin + 1, end, sum);
}


Console.Write("Введите начальное значение: ");
int M = int.Parse(Console.ReadLine());
Console.Write("Введите конечное значение: ");
int N = int.Parse(Console.ReadLine());

if (M > N) Console.WriteLine("Конечное значение должно быть больше начального!");
else if (M == N) Console.WriteLine(0);
else Console.WriteLine($" {SumNumbers(M, N, 0)} ");