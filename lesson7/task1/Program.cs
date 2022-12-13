//Урок 7.

//Задача 1:
//Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

double[,] DefArray(int m, int n, int begin, int end)
{
    double[,] arr = new double[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++) arr[i,j] = new Random().NextDouble() * (end - begin) + begin;
    }
    return arr;
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++) Console.Write($" {array[i,j], 6}  ");
        Console.WriteLine();
    }
}

Console.Write("Число строк: ");
int row = int.Parse(Console.ReadLine());
Console.Write("Число столбцов: ");
int columns = int.Parse(Console.ReadLine());
Console.Write("Диапазон значений, от: ");
int from = int.Parse(Console.ReadLine());
Console.Write("Диапазон значений, до: ");
int to = int.Parse(Console.ReadLine());

PrintArray(DefArray(row, columns, from, to));
