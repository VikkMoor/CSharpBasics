﻿// Input - array; output - (max-min);

void FillArray(int[] arr1)
{
    int len1 = arr1.Length;
    int pos1 = 0;
    while (pos1 < len1)
    {
        arr1[pos1] = new Random().Next(-100, 101);
        pos1++;
    }
}
void PrintArray(int[] arr2)
{
    int len2 = arr2.Length;
    int pos2 = 0;
    while (pos2 < len2)
    {
        Console.Write($"{arr2[pos2]} ");
        pos2++;
    }
}
int DifMaxMin(int[] arr3)
{
    int min = arr3[0], max = arr3[0];
    for (int i = 0; i < arr3.Length; i++)
    {
        if (arr3[i] < min) min = arr3[i];
        if (arr3[i] > max) max = arr3[i];
    }
    int difference = max - min;
    return difference;
}
Console.Write("Enter array size: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];
FillArray(array);
PrintArray(array);
Console.WriteLine();
int dif = DifMaxMin(array);
Console.Write(dif);