//Урок 4.

//Задача 3:
//Напишите программу, которая задаёт массив из 8 элементов случайными числами и выводит их на экран.

int[] DefArray(int n, int r)    // генерируем массив
{
    int[] arr = new int[n];
    for (int i = 0; i < n; i++)
    {
        arr[i] = new Random().Next(0, r);
    }
    return arr;
}

void PrintArray(int[] array, int n)    // выводим элементы массива в консоль
{
    for (int i = 0; i < n; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

int size = 8;    // размер массива
int range = 100;    // диапазон (верхняя граница) генерации случайных чисел
PrintArray(DefArray(size, range), size);
