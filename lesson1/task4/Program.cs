//Задача 4: Напишите программу, которая на вход принимает число (N), а на выходе показывает 
//все чётные числа от 1 до N.

// Считаем, что работаем только с целыми числами. Если от 1 до N, то речь только о 
//положительных числах

Console.Write("Введите любое число, не меньше 1: ");
int N = int.Parse(Console.ReadLine());

if (N < 1) Console.WriteLine("Некорректный ввод");
else if (N == 1) Console.WriteLine("Четных чисел нет");
else {
	int count = 1;
	while(count <= N) {
		count++;
		if (count % 2 == 0) Console.Write($"{count} ");
	}
    Console.WriteLine();
}

// Более простое и БЫСТРОЕ решение:
/*
Console.Write("Введите любое число, не меньше 1: ");
int N = int.Parse(Console.ReadLine());

if (N < 1) Console.WriteLine("Некорректный ввод");
else if (N == 1) Console.WriteLine("Четных чисел нет");
else {
	int count = 2;
	while(count <= N) {
		Console.Write($"{count} ");
        count += 2;
	}
    Console.WriteLine();
}
*/