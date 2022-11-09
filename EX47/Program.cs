// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

void PrintMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = Convert.ToDouble(new Random().Next(-100, 100)/10.0);
            System.Console.Write($"{matrix[i,j]} ");
        }
        System.Console.WriteLine();
    }
}

System.Console.WriteLine("Введите количество строк двумерного массива, m:");
int M = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите количество столбцов двумерного массива, n:");
int N = Convert.ToInt32(Console.ReadLine());

double[,] matrix = new double[M,N];
PrintMatrix(matrix);