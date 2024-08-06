﻿Console.Write("Enter number M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter number N: ");
int n = Convert.ToInt32(Console.ReadLine());

 int Sum(int a, int b)
{
    if (a > b) return 0;
    else return a + Sum(a + 1, b);
}
Console.Write(Sum(m, n));