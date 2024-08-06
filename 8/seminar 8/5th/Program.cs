﻿float Factorial(int n)
{
    float i, x = 1;
    for (i = 1; i <= n; i++) x *= i;
    return x;
}

Console.Write("Enter count of rows of triangle: ");
int n = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i < n; i++)
{
    // printing spaces for symmetry:
    for (int c = 0; c < n - i; c++) Console.Write("  ");
    for (int c = 0; c <= i; c++)
    {
        /* Console.Write("{index,alignment}", value) - example for alignment output;
        Number "alignment" sets the minimum width of the field for displaying the value.
        A positive value (for example, 4) aligns the value to the right, adding spaces to 
        the left (if the number of characters in the number is less than 4).
        A negative value (such as -4) aligns to the left, adding spaces to the right. 
        We will set the width of the field for the value as 5: */
        Console.Write("{0,5} ", Factorial(i) / (Factorial(c) * Factorial(i - c)));
    }
    Console.WriteLine();
}