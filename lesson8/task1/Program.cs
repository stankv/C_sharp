//Урок 8.

//Задача 1:
//Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.


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


int[,] SortRowArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1) - 1; j++)
        {
            for (int k = j + 1; k < array.GetLength(1); k++)
            {
                if (array[i, j] < array[i, k]) (array[i, j], array[i, k]) = (array[i, k], array[i, j]);
            }
        }
    }
    return array;
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
Console.WriteLine("-----------------");
PrintArray(SortRowArray(work_array));
