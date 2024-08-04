﻿// Input - 3D coordinates a, b; output - distance between.
double Dist(int coord1, int coord2, int coord3, int coord4, int coord5, int coord6)
{
    double result = Math.Sqrt((Math.Pow(coord4 - coord1, 2) + Math.Pow(coord5 - coord2, 2) + Math.Pow(coord6 - coord3, 2)));
    return result;
}

Console.Write("Enter ax: ");
int ax = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter ay: ");
int ay = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter az: ");
int az = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter bx: ");
int bx = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter by: ");
int by = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter bz: ");
int bz = Convert.ToInt32(Console.ReadLine());

double result = Dist(ax, ay, az, bx, by, bz);
Console.Write($"Distance between dots = {Math.Round(result,2)}");