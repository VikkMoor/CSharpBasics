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
Console.Write("Enter matrix height: ");
int height = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter matrix width: ");
int width = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[height, width];
FillArray(matrix);
PrintArray(matrix);
Console.WriteLine();
int[] counts = new int[10];
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        counts[matrix[i, j]]++;
    }
}
for (int i = 0; i < counts.Length; i++)
{
    if (counts[i] != 0) Console.WriteLine($"The number {i} occurs in matrix {counts[i]} times");
}