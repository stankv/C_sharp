//Урок 8.

//Задача 3:
//Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.


int[,] DefMatrix(int row, int column, int begin, int end)
{
    int[,] matrix = new int[row, column];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++) matrix[i, j] = new Random().Next(begin, end);
    }
    return matrix;
}


void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++) Console.Write($" {matrix[i, j],3}  ");
        Console.WriteLine();
    }
}


int[,] InputParameterMatrix()
{
    while (true)
    {
        Console.Write("Число строк: ");
        int row = int.Parse(Console.ReadLine());
        if (row <= 0) continue;
        Console.Write("Число столбцов: ");
        int columns = int.Parse(Console.ReadLine());
        if (columns <= 0) continue;
        Console.Write("Диапазон значений, от: ");
        int from = int.Parse(Console.ReadLine());
        Console.Write("Диапазон значений, до: ");
        int to = int.Parse(Console.ReadLine());
        if (to < from) continue;
        return DefMatrix(row, columns, from, to);
    }
}

int[,] MultiplicationMatrices(int[,] arr1, int[,] arr2)    //универсально для любых матриц
{
    int[,] result = new int[arr1.GetLength(0), arr2.GetLength(1)];
    for (int i = 0; i < arr1.GetLength(0); i++)
    {
        for (int j = 0; j < arr2.GetLength(1); j++)
        {
            result[i, j] = 0;
            for (int k = 0; k < arr1.GetLength(1); k++) result[i, j] += (arr1[i, k] * arr2[k, j]);
        }
    }
    return result;
}

Console.WriteLine("Ввод параметров первой матрицы");
int[,] matrix1 = InputParameterMatrix();
Console.WriteLine();
Console.WriteLine("Ввод параметров второй матрицы");
int[,] matrix2 = InputParameterMatrix();
PrintMatrix(matrix1);
Console.WriteLine("---------------------------------");
PrintMatrix(matrix2);
Console.WriteLine("==================================");

if (matrix1.GetLength(1) == matrix2.GetLength(0)) PrintMatrix(MultiplicationMatrices(matrix1, matrix2));
else Console.WriteLine("Матрицы не совместимы!");
