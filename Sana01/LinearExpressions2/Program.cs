﻿Console.WriteLine("Enter value of m: ");
double m = double.Parse(Console.ReadLine());
Console.WriteLine("Enter value of n: ");
double n = double.Parse(Console.ReadLine());
Console.WriteLine("Enter value of m: ");
double a = double.Parse(Console.ReadLine());
Console.WriteLine("Enter value of b: ");
double b = double.Parse(Console.ReadLine());
Console.WriteLine("Enter value of x: ");
double x = double.Parse(Console.ReadLine());

double z1 = ((m - 1) * Math.Sqrt(m) - (n - 1) * Math.Sqrt(n)) / (Math.Sqrt(Math.Pow(m, 3) * n) + n * m + Math.Pow(m, 2) - m);
double z2 = (Math.Sqrt(m) - Math.Sqrt(n)) / m;
double y = 2.4 * Math.Abs((Math.Pow(x, 2) + b) / a) + (a - b) * Math.Pow(Math.Sin(a - b), 2) + Math.Pow(10, -2) * (x - b);

Console.WriteLine($" z1 = {z1:F10}, z2 = {z2:F10}, y = {y:F10}");