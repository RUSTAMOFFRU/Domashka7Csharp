// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

double[,] CreateMatrixRndDouble(int rows, int columns, int min, int max)
{
    double[,] matrix = new double[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.NextDouble() * (max - min) + min;
        }
    }
    return matrix;
}

void PrintMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            double matrixRound = Math.Round(matrix[i, j], 1);
            Console.Write($"{matrixRound,6}");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Ну что,  случайно зададим двумерный массив вещественных чисел?");

Console.Write("Введи количество строк массива: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введи количество столбцов массива: ");
int n = Convert.ToInt32(Console.ReadLine());

double[,] array2d = CreateMatrixRndDouble(m, n, -9, 10);
Console.WriteLine();
Console.WriteLine($"   m = {m};  n = {n}");
PrintMatrix(array2d);

