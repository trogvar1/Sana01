Console.WriteLine("Enter value of a: ");
double a = double.Parse(Console.ReadLine());
Console.WriteLine("Enter value of b: ");
double b = double.Parse(Console.ReadLine());
Console.WriteLine("Enter value of c: ");
double c = double.Parse(Console.ReadLine());
Console.WriteLine("Enter value of d: ");
double d = double.Parse(Console.ReadLine());

double x = (a + 2 * b - c + d) / (c * d) + (a + b) / (c - d) - Math.Pow(a, 2) / Math.Pow(b, 2);
double y = 5 * (a + b) * (c - d) / (1 / 2 * c) + Math.Pow(d, 2) * ((Math.Pow(a, 2) - Math.Pow(b, 2)) / (b - a));
double z = (Math.Pow(Math.Pow(x, 2) - 2 * x, 3) - 4 * (Math.Pow(x, 4) + 1) * (1 - b)) / (5 * a + 3 * b);
double r = ((1 / 2) * a - 3 / 4 * b - 7 / 5) / (3 * c + 1) + 1 / (a - c);

Console.WriteLine($" x = {x:F10}, y = {y:F10}, z = {z:F10}, r = {r:F10}");