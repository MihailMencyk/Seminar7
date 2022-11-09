// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

void FillMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = new Random().Next(0, 10);
        }
    
    }
}
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write($"{matrix[i,j]} ");
        }
        System.Console.WriteLine();
    }
}

void MeanColumn(int[,] matrix)
{
    System.Console.WriteLine();
    double Sum = 0;
    double SumAr = 0;
    double K = matrix.GetLength(1);
        for (int j = 0; j < matrix.GetLength(0); j++)
    {
        for (int i = 0; i < matrix.GetLength(1); i++)
        {
           Sum += matrix[i,j];
           SumAr = Sum/K;
        }
        System.Console.Write($"{Math.Round(SumAr, 2)} ");
        Sum = 0;
        SumAr = 0;
    }
    System.Console.WriteLine();
}

System.Console.WriteLine("Введите количество строк двумерного массива, m:");
int M = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите количество столбцов двумерного массива, n:");
int N = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[M,N];
FillMatrix(matrix);
PrintMatrix(matrix);
MeanColumn(matrix);

