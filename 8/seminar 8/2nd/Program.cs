﻿void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(0, 10);
        }
    }
}
void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}
void ReverseRowsColumns(int[,] matr1, int[,] matr2)
{
    for (int i = 0; i < matr1.GetLength(0); i++)
    {
        for (int j = i; j < matr1.GetLength(1); j++)
        {
            matr2[i, j] = matr1[j,i];
            matr2[j, i] = matr1[i,j];
        }
    }
}
Console.Write("Enter matrix height: ");
int height = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter matrix width: ");
int width = Convert.ToInt32(Console.ReadLine());
if (height != width) Console.Write("Impossible to change rows and columns");
else 
{
    int[,] matrix1 = new int[height, width];
    FillArray(matrix1);
    PrintArray(matrix1);
    Console.WriteLine();
    int[,] matrix2 = new int[height, width];
    ReverseRowsColumns(matrix1, matrix2);
    PrintArray(matrix2);
}