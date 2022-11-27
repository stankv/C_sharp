//Урок 2.

//Задача 1:
//Напишите программу, которая принимает на вход трёхзначное число
//и на выходе показывает вторую цифру этого числа.

int SecondNumber(int num)
    {
        return (num / 10) % 10;
    }

Console.Write("Input number: ");
int number = int.Parse(Console.ReadLine());
Console.WriteLine(SecondNumber(number));
