//Урок 2.

//Задача 2:
//Напишите программу, которая выводит случайное
//трёхзначное число и удаляет вторую цифру этого числа.

string DelSecondNumber(int num)
    {
        return $"{num / 100}{num % 10}";
    }

int number = new Random().Next(100, 999);
Console.WriteLine($"{number}");
Console.WriteLine(DelSecondNumber(number));
