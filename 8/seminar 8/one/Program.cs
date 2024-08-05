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
void StringChange(int[,] matr)
{
    int height = matr.GetLength(0);
    int[] arr = new int [matr.GetLength(1)];
    for (int j = 0; j < matr.GetLength(1); j++)
    {
        arr[j] = matr[0, j];
        matr [0, j] = matr[height-1, j];
        matr[height-1, j] = arr[j];
    }
}
int[,] matrix = new int[5, 6];
FillArray(matrix);
PrintArray(matrix);
Console.WriteLine();
StringChange(matrix);
PrintArray(matrix);