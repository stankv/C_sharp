//Урок 8.

//Задача 2:
//Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.


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


int FindRowWithMinSum(int[,] array)
{
    int position = 1, sum, buffer = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        sum = 0;
        for (int j = 0; j < array.GetLength(1); j++) sum += array[i,j];
        if (i == 0)
        {
            buffer = sum;
            continue;
        }
        if (sum < buffer)
        {
            buffer = sum;
            position = i + 1;
        }
    }
    return position;
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
Console.WriteLine("---------------------------------");
Console.WriteLine($"Строка с минимальной суммой эл-тов: {FindRowWithMinSum(work_array)}");
