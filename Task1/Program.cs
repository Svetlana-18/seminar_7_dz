// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
//  и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого элемента в массиве нет

Console.WriteLine("Введите номер строки:  ");
int line = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите номер столбца:  ");
int column = Convert.ToInt32(Console.ReadLine());
int[,] CreateMtrixRndInt(int row, int col, int min, int max)
{
    int[,] matrix = new int[row, col];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(min, max);
        }
    }

    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) System.Console.Write($"{matrix[i, j],4},");
            else Console.Write($"{matrix[i, j],4} ");
        }
        Console.WriteLine("]");
    }

}

void SearchElement(int[,] array1)

{
    if (line <= 0 && column <= 0 || line <= 0 || column <= 0) 
        Console.WriteLine($" Вы ввели неверное значение, введите положительные целые числа");
    else if (line <= array1.GetLength(0) && column <= array1.GetLength(1))
        Console.WriteLine($" Значение элемента на данной позиции = {array1[line - 1, column - 1]}");
    else Console.WriteLine($" Такого элемента в массиве нет");
}
Console.WriteLine();
int[,] array1 = CreateMtrixRndInt(7, 7, -99, 99);
PrintMatrix(array1);
Console.WriteLine();
SearchElement(array1);
