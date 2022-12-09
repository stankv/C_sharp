//Урок 6.

//Задача 2:
//Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 *x + b1, y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем.

void PointIntersectionLines(float k1, float b1, float k2, float b2)
{
    float x, y;
    if (k1 == k2 && b1 == b2) Console.WriteLine("Прямые совпадают");
    else if (k1 == k2) Console.WriteLine("Прямые параллельны");
    else
    {
        x = (b2 - b1) / (k1 - k2);
        y = k1 * x + b1;
        Console.WriteLine($"Точка пересечения: ({x};{y})");
    }
}

Console.Write("k1: ");
float k1 = float.Parse(Console.ReadLine());
Console.Write("b1: ");
float b1 = float.Parse(Console.ReadLine());
Console.Write("k2: ");
float k2 = float.Parse(Console.ReadLine());
Console.Write("b2: ");
float b2 = float.Parse(Console.ReadLine());
PointIntersectionLines(k1, b1, k2, b2);
