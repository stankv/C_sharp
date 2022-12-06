//Урок 5.

//Задача 2:
//Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, 
//стоящих на нечётных позициях.

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

// сумма элементов, стоящих на нечетных позициях в массиве
int SumOfOddPositionNumbers(int[] arr, int size)
{
    int sum = 0;
    for (int i = 0; i < size; i += 2)
    {
        sum += arr[i];
    }
    return sum;
}

int dim = 8;    // размер массива
int from = 0;    // диапазон (нижняя граница) генерации случайных чисел
int to = 100;    // диапазон (верхняя граница) генерации случайных чисел

int[] array = DefArray(dim, from, to);
Console.Write("Содержимое массива: ");
PrintArray(array, dim);
Console.WriteLine($"Сумма чисел, стоящих на нечетных позициях: {SumOfOddPositionNumbers(array, dim)}");
