//Урок 7.

//Задача 2:
//Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.


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


void FindNumInArray(int[,] array, int posX, int posY)
{
    if (posX < 1 || posX > array.GetLength(0) || posY < 1 || posY > array.GetLength(1))
    {
        Console.WriteLine("Такого элемента нет");
        return;
    }
    Console.WriteLine($"Значение элемента позиции ({posX},{posY}): {array[posX - 1, posY - 1]}");

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

Console.Write("Позиция элемента в строке №: ");
int x = int.Parse(Console.ReadLine());
Console.Write("Позиция элемента в столбце №: ");
int y = int.Parse(Console.ReadLine());

FindNumInArray(work_array, x, y);
