//Урок 4.

//Задача 2:
//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.


int SumOfNumbers(string s_num)
{
    if (s_num == "" || s_num == " ") return 0;
    
    int length = s_num.Length;
    if (length == 0) return 0;
    else if (length == 1) return int.Parse(s_num);

    int num = int.Parse(s_num);
    int sum = 0;
    int ost = 0;
    for (int i = 0; i < length; i++)
    {
        sum += (num % 10);
        num /= 10;
    }
    return sum;
}


Console.Write("Input number: ");
string s_number = Console.ReadLine();
Console.WriteLine(SumOfNumbers(s_number));
