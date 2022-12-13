//Урок 7.

//Задача 3:
//Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.


int[,] DefArray(int m, int n, int begin, int end)
{
    int[,] arr = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++) arr[i, j] = new Random().Next(begin, end);
    }
    return arr;
}


void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++) Console.Write($" {array[i, j],3}  ");
        Console.WriteLine();
    }
}


void ArithmeticAverageOfColumns(int[,] array)
{
    double sum = 0;
    Console.WriteLine("Среднее арифметическое столбцов: ");
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int i = 0; i < array.GetLength(0); i++) sum += array[i, j];
        Console.Write($" {Math.Round(sum / array.GetLength(0), 2),3} ");
        sum = 0;
    }
    Console.WriteLine();
}


Console.Write("Число строк: ");
int row = int.Parse(Console.ReadLine());
Console.Write("Число столбцов: ");
int columns = int.Parse(Console.ReadLine());
Console.Write("Диапазон значений, от: ");
int from = int.Parse(Console.ReadLine());
Console.Write("Диапазон значений, до: ");
int to = int.Parse(Console.ReadLine());

int[,] work_array = DefArray(row, columns, from, to);
PrintArray(work_array);
ArithmeticAverageOfColumns(work_array);
