// Урок 9.

// Задача 1. Задайте значения M и N. Напишите программу, которая выведет все
//чётные натуральные числа в промежутке от M до N с помощью рекурсии.


void EvenNumbers(int begin, int end)
{
    if ((begin % 2) == 0) Console.Write($" {begin} ");
    if (begin == end) return;
    EvenNumbers(begin + 1, end);
}


Console.Write("Введите начальное значение: ");
int M = int.Parse(Console.ReadLine());
Console.Write("Введите конечное значение: ");
int N = int.Parse(Console.ReadLine());

if (M > N) Console.WriteLine("Конечное значение должно быть больше начального!");
else if (M == N && (M % 2 == 0)) Console.WriteLine(M);
else if (M == N && (M % 2 != 0)) Console.WriteLine("Четных чисел нет!");
else 
{
    EvenNumbers(M, N);
    Console.WriteLine();
}
