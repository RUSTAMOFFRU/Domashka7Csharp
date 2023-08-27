// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1,7 -> такого элемента в массиве нет


int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}


// bool ElemMatrix(int[,] matrix, int rows, int columns)
// {
//     return rows < matrix.GetLength(0) && columns < matrix.GetLength(1);
// }

bool ElemMatrix(int[,] matrix, int rows, int columns)
{
    return rows < matrix.GetLength(0)
    && columns < matrix.GetLength(1)
    && rows >= 0
    && columns >= 0;
}

void PrintMatrix(int[,] matrix)
{
    Console.WriteLine();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {

            Console.Write($"{matrix[i, j],5}");
        }
        Console.WriteLine();
    }
}



Console.WriteLine("А сейчас я выведу значение элемента массива, а ты ");

Console.WriteLine("введи номер строки: ");
int row = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("введи номер столбца: ");
int column = Convert.ToInt32(Console.ReadLine());

int[,] array2d = CreateMatrixRndInt(4, 5, -9, 9);


PrintMatrix(array2d);
if (ElemMatrix(array2d, row, column))

    Console.WriteLine($"Элемент с индексами {row}, {column} => {array2d[row, column]}");

else Console.WriteLine($"В массиве нет элемента с индексами {row}, {column}");

