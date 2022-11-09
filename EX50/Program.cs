// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и 
// возвращает значение этого элемента или же указание, что такого элемента нет.
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = new Random().Next(0, 20);
            System.Console.Write($"{matrix[i,j]} ");
        }
        System.Console.WriteLine();
    }
}

void SearchElement(int[,] matrix, int X, int Y)
{
    int Element = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
           if (X == i && Y == j) Element = matrix[i,j];
        }
    }
    if (Element == 0) System.Console.WriteLine("Элемента с заданными индексами НЕТ");
    else System.Console.WriteLine(Element);
}

System.Console.WriteLine("Введите количество строк двумерного массива, m:");
int M = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите количество столбцов двумерного массива, n:");
int N = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[M,N];
PrintMatrix(matrix);

System.Console.WriteLine("Помните! Нумирация массива начинается с 0!!!");
System.Console.WriteLine("Введите позицию элемента (строка), x:");
int X = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите позицию элемента (столбец), y:");
int Y = Convert.ToInt32(Console.ReadLine());
SearchElement(matrix, X, Y);