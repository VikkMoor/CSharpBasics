int m = 5, n = 3; // Here we can change height and width of matrix;
int[,] matrix = new int[m, n];
int[] ar = new int [m];
FillMatrix(matrix);
PrintMatrix(matrix);
Console.WriteLine();
ar = SumRow(matrix);
PrintArray(ar); // Printing array with sums of each matrix row.
Console.WriteLine();
int min = 0, armin = ar[0];
for (int i = 0; i < ar.Length; i++)
    if (ar[i] < armin) {min = i; armin = ar[i];} 
Console.Write(min + 1); // Printing number of row  with min sum.

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
void PrintArray(int[] arr)
{
    int len2 = arr.Length;
    int pos2 = 0;
    while (pos2 < len2)
    {
        Console.Write($"{arr[pos2]} ");
        pos2++;
    }
}
int[] SumRow (int[,] matr) // output - array with each row's sums of matrix.
{
    int[] arr = new int [matr.GetLength(0)];
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matr.GetLength(1); j++)
        {
           sum += matr[i, j];
        }
        arr[i] = sum;
    }
    return arr;
}
