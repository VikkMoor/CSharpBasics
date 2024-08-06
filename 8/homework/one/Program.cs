int[,] matrix = new int[4, 7];
FillArray(matrix);
PrintArray(matrix);
Console.WriteLine();
SortRows(matrix);
PrintArray(matrix);

void FillArray(int[,] matr)
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
void SortRows(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            int jmax = j;
            for (int k = j + 1; k < matr.GetLength(1); k++)
            {
                if (matr[i, k] > matr[i, jmax]) jmax = k;
            }
            int temporary = matr[i, j];
            matr[i, j] = matr[i, jmax];
            matr[i, jmax] = temporary;
        }
    }
}
