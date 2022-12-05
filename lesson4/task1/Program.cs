//Урок 4.

//Задача 25:
//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

int DegreeOfNumber(int A, int B)
{
    if (B == 0) return 1;
    else if (B == 1) return A;
    int result = 1;
    for (int i = 1; i <= B; i++) result *= A;
    return result;
}


Console.Write("Input number: ");
int x = int.Parse(Console.ReadLine());
Console.Write("Input degree of number: ");
int y = int.Parse(Console.ReadLine());
Console.WriteLine($"{DegreeOfNumber(x, y)}");
