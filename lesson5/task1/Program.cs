//Урок 5.

//Задача 1:
//Задайте массив, заполненный случайными положительными трёхзначными числами. Напишите
//программу, которая покажет количество чётных чисел в массиве.

// генерируем массив
int[] DefArray(int size, int begin, int end)
{
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(begin, end);
    }
    return arr;
}

// выводим содержимое массива в консоль
void PrintArray(int[] array, int size)
{
    for (int i = 0; i < size; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

// подсчет кол-ва четных чисел в массиве
int CountEvenNumbers(int[] arr, int size)
{
    int count = 0;
    for (int i = 0; i < size; i++)
    {
        if (arr[i] % 2 == 0)
            count += 1;
    }
    return count;
}

int dim = 8;    // размер массива
int from = 101;    // диапазон (нижняя граница) генерации случайных чисел
int to = 1000;    // диапазон (верхняя граница) генерации случайных чисел

int[] array = DefArray(dim, from, to);
Console.Write("Содержимое массива: ");
PrintArray(array, dim);
Console.WriteLine($"Четных чисел: {CountEvenNumbers(array, dim)}");
