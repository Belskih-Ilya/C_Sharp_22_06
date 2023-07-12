// написать программу, которая найдет точку пересечения двух прямых, заданных уравнениями y = k1x+b1 и y=k2x+b2. Значения k1, k2, b1, b2 задаются пользователем

void CrossCoordinates (double k1, double b1, double k2, double b2)
{
    double x = (b2 - b1)/(k1 - k2);
    double y = k1 * x + b1;
    Console.WriteLine($"Lines crosses in dot ({Math.Round(x, 2)}, {Math.Round(y,2)})");
}

Console.WriteLine("Lines are given by formulas y = k1x+b1 & y=k2x+b2");
Console.WriteLine("");
Console.WriteLine("Enter k1");
int k1 = int.Parse(Console.ReadLine());
Console.WriteLine("Enter b1");
int b1 = int.Parse(Console.ReadLine());
Console.WriteLine("Enter k2");
int k2 = int.Parse(Console.ReadLine());
Console.WriteLine("Enter b2");
int b2 = int.Parse(Console.ReadLine());
CrossCoordinates(k1, b1, k2, b2);