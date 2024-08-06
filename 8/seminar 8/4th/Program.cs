﻿void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(0, 100);
        }
    }
}
void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]}" + "\t");
        }
        Console.WriteLine();
    }
}

int[,] matrix1 = new int[4, 5];
FillArray(matrix1);
PrintArray(matrix1);
Console.WriteLine();
int min = 100, imin = 0, jmin = 0;

for (int i = 0; i < matrix1.GetLength(0); i++)
{
    for (int j = 0; j < matrix1.GetLength(1); j++)
    {
        if (matrix1[i, j] < min)
        {
            min = matrix1[i, j];
            imin = i; jmin = j;
        }
    }
}
int[,] matrix2 = new int[matrix1.GetLength(0) - 1, matrix1.GetLength(1) - 1];
for (int i = 0; i < matrix1.GetLength(0); i++)
{
    if (i == imin) continue;
    for (int j = 0; j < matrix1.GetLength(1); j++)
    {
        if (j == jmin) continue;
        if (i > imin)
            if (j > jmin) matrix2[i - 1, j - 1] = matrix1[i, j];
            else matrix2[i - 1, j] = matrix1[i, j];
        else
            if (j > jmin) matrix2[i, j - 1] = matrix1[i, j];
            else matrix2[i,j] = matrix1[i,j];
    }
}
PrintArray(matrix2);