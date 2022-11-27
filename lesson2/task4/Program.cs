//Урок 2.

//Задача 4:
//Напишите программу, которая принимает на вход цифру,
//обозначающую день недели, и проверяет, является ли этот день выходным.

void CheckDayOfWeek(int num)
    {
        if (num > 5) Console.WriteLine("Да");
        else
            Console.WriteLine("Нет");
    }

Console.Write("Введите номер дня недели: ");
int number = int.Parse(Console.ReadLine());
CheckDayOfWeek(number);
