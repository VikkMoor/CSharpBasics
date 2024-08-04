﻿// Input N, output - cube number table 1..N;
void FillArray(int[] fortable)
{
    int length = fortable.Length;
    int index = 0;
    while (index < length)
    {
        fortable[index] = index;
        index++;
    }
}

Console.Write("Enter positive N: ");
int N = Convert.ToInt32(Console.ReadLine());
int[] array = new int[Math.Abs(N)];
if (N > 0)
{
    FillArray(array);
    foreach (int i in array) Console.WriteLine($"{i + 1} | {Math.Pow(i + 1, 3)}");
}
else Console.Write("Enter correct number");