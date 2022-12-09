//Урок 6.

//Задача 1:
//Пользователь вводит с клавиатуры M чисел.
//Посчитайте, сколько чисел больше 0 ввёл пользователь.

void CountPosNumbers()
{
    string str_in, str_out = string.Empty;
    int count = 0;
    while(true)
    {
        Console.Write("Input number: ");
        str_in = Console.ReadLine();
        if (str_in == "" || str_in == " ")
        {
            Console.WriteLine("Numbers entered: " + str_out);
            Console.WriteLine($"Positive numbers: {count}");
            return;
        }
        if (int.Parse(str_in) > 0) count++;
        str_out = str_out + " " + str_in;
    }
}

CountPosNumbers();