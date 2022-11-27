//Урок 2.

//Задача 3:
//Напишите программу, которая выводит третью цифру
//заданного числа или сообщает, что третьей цифры нет.


int CountLength(int num)    // подсчет количества цифр в числе
    {
        int number = num;
        int length = 0;
        while(number != 0) {
            number /= 10;
            length++;
        }
        return length;
    }

string ThirdNumber(int num)    // нахождение 3-й цифры числа и ее вывод
    {
        int length = CountLength(num);
        if (length < 3 ) return "Третьей цифры нет!";
        else
            {
            int divisor = 1;
            int i = 1;
            while(i <= length - 3) {
                divisor *= 10;
                i += 1;
            }
            int z = ((num / divisor) % 10);
            return $"{z}";
            }
    }

Console.Write("Введите целое число: ");
int number = int.Parse(Console.ReadLine());
Console.WriteLine(ThirdNumber(number));
