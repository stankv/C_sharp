//Урок 3.

//Задача 19:
//Напишите программу, которая принимает на вход пятизначное число и 
//проверяет, является ли оно палиндромом.

// Универсальное решение (число на входе любой длины)


// перевод строки в целое число
int ConvertStrToInt()
{
    Console.Write("Введите целое число: ");
    var line = Console.ReadLine();
    if (line == "" || line == " " || line == null) return 0;
    else return int.Parse(line);
}


// подсчет количества цифр в числе
int CountLength(int number)
{
    int length = 0;
    while (number != 0)
    {
        number /= 10;
        length++;
    }
    return length;
}


// проверка целого числа на палиндром
void isPalindrome()
{
    int number = ConvertStrToInt();
    int length = CountLength(number);
    if (length == 0 || length == 1) 
    {
        Console.WriteLine("Нет");
        return;
    }

    int divisor = (int)Math.Pow(10, (length - 1));    //тут пришлось почитать на stackoverflow
    int count = 1;
    int num1, num2;
    while(count <= length / 2)
    {
        num1 = number / divisor;
        num2 = number % 10;
        if (num1 != num2)
        {
            Console.WriteLine("Нет");
            return;
        }
        number = (number % divisor) / 10;    //убираем первую и последнюю цифры из числа
        divisor /= 100;    //потому что убрали 2 цифры
        count++;
    }
    Console.WriteLine("Да");
}


isPalindrome();
