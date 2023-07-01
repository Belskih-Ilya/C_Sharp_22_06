// Напишите программу которая принимает на вход координаты точки (X и У), не равные нулю, и выдает номер плоскости, в
// которой находится эта точка.

Console.WriteLine("Enter Х");
int x = int.Parse(Console.ReadLine());
Console.WriteLine("Enter Y");
int y = int.Parse(Console.ReadLine());

if (x == 0 || y == 0)
{
    Console.WriteLine("X & Y souldn't be 0");
} else {
        if (x * y > 0)
    {
        if (x > 0) Console.WriteLine("Dot is in 1st plane");
        else Console.WriteLine("Dot is in 3rd plane");
    } else
    {
        if (x > 0) Console.WriteLine("Dot is in 4th plane");
        else Console.WriteLine("Dot is in 2nd plane");
    }
}