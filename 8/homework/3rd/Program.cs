// columns A should be = rows B.
int mA = 3, nA = 2, mB = 2, nB = 2;
int[,] matrixA = new int[mA, nA];
int[,] matrixB = new int[mB, nB];
int[,] matrix = new int[mA, nB];
FillMatrix(matrixA);
PrintMatrix(matrixA);
Console.WriteLine();
FillMatrix(matrixB);
PrintMatrix(matrixB);
Console.WriteLine();
if (nA != mB) Console.WriteLine("Impossible for multiplicate");
else 
{
    matrix = Multiplication(matrixA, matrixB);
    PrintMatrix(matrix);
}

void FillMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(0, 10);
        }
    }
}
void PrintMatrix(int[,] matr)
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
int[,] Multiplication(int[,] a, int[,] b)
{
    int[,] r = new int[a.GetLength(0), b.GetLength(1)];
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < b.GetLength(1); j++)
        {
            for (int k = 0; k < b.GetLength(0); k++)
            {
                r[i,j] += a[i,k] * b[k,j];
            }
        }
    }
    return r;
}
