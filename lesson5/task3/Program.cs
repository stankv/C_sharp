//Урок 5.

//Задача 3:
//Задайте массив вещественных чисел. Найдите разницу между максимальным и 
//минимальным элементами массива.

// генерируем массив
double[] DefRealArray(int size, int begin, int end)
{
    double[] arr = new double[size];
    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().NextDouble() * (end - begin) + begin;
    }
    return arr;
}

// выводим содержимое массива в консоль
void PrintArray(double[] arr, int size)
{
    for (int i = 0; i < size; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

// Вычисление разницы максимального и минимального значений массива
void DiffMaxMin(double[] arr, int size)
{
    double max = arr[0];
    double min = arr[0];
    for (int i = 1; i < size; i++)
    {
        if (max <= arr[i]) max = arr[i];
        if (min >= arr[i]) min = arr[i];
    }
    Console.WriteLine($"Максимальное: {max}");
    Console.WriteLine($"Минимальное: {min}");
    Console.WriteLine($"Разница: {max - min}");
}

int dim = 8;    // размер массива
int from = 0;    // диапазон (нижняя граница) генерации случайных чисел
int to = 100;    // диапазон (верхняя граница) генерации случайных чисел

double[] array = DefRealArray(dim, from, to);
Console.WriteLine("Содержимое массива: ");
PrintArray(array, dim);
DiffMaxMin(array, dim);
