//Урок 3.

//Задача 23:
//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.


void TableCubingNumber(int number)    //с учетом отрицательного числа на входе
{
    if (number == 0) Console.WriteLine(number);
    else if (number == 1 || number == -1) Console.WriteLine(number);
    else
    {
        int degree = 3;    // нет магическим числам))
        int count = 1;
        while (count <= Math.Abs(number))
        {
            if (number < 0) Console.Write($"{Math.Pow(-count, degree)} ");
            else Console.Write($"{Math.Pow(count, degree)} ");
            count++;
        }
        Console.WriteLine();
    }
}


Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine());
TableCubingNumber(N);
