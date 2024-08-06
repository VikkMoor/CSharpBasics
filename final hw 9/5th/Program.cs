﻿Console.Write("Enter A: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter B: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write(Step(a, b));

int Step(int A, int B)
{
    if (B == 0) return 1;
    return A * Step(A, B - 1);
}
