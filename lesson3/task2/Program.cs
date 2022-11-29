//Урок 3.

//Задача 21:
//Напишите программу, которая принимает на вход координаты двух точек 
//и находит расстояние между ними в 3D пространстве.

double Distance(double x1, double y1, double z1, double x2, double y2, double z2)
{
    return Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2));
}

Console.WriteLine("Введите координаты 2 точек");
Console.Write("X1: ");
double x1 = double.Parse(Console.ReadLine());
Console.Write("Y1: ");
double y1 = double.Parse(Console.ReadLine());
Console.Write("Z1: ");
double z1 = double.Parse(Console.ReadLine());
Console.Write("X2: ");
double x2 = double.Parse(Console.ReadLine());
Console.Write("Y2: ");
double y2 = double.Parse(Console.ReadLine());
Console.Write("Z2: ");
double z2 = double.Parse(Console.ReadLine());

Console.WriteLine(Distance(x1, y1, z1, x2, y2, z2));
