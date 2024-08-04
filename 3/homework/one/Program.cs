﻿// Input: 5-digit number, output: palindrome or not.
Console.Write("Enter 5-digit number: ");
int N = Convert.ToInt32(Console.ReadLine());
if (N < 10000 || N > 99999) Console.WriteLine("Please, enter correct number ;P");
else
{
    int[] digit = new int[5];
    int divisor = 10000;
    for (int i = 0; i < 5; i++)
    {
        digit[i] = (N / divisor) % 10;
        divisor = divisor / 10;
    }
    if (digit[0] == digit[4] && digit[1] == digit[3]) Console.Write("Palindrome");
    else Console.Write("Not palindrome");
}