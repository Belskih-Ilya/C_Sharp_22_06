// Написать программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3Д пространстве

double VectorLenght(int x1, int y1, int z1, int x2, int y2, int z2)
{
    return Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2) + Math.Pow(z1 - z2, 2));
}


Console.WriteLine("Enter Х for dot#1");
int x1 = int.Parse(Console.ReadLine());
Console.WriteLine("Enter Y for dot#1");
int y1 = int.Parse(Console.ReadLine());
Console.WriteLine("Enter Z for dot#1");
int z1 = int.Parse(Console.ReadLine());

Console.WriteLine("Enter Х for dot#2");
int x2 = int.Parse(Console.ReadLine());
Console.WriteLine("Enter Y for dot#2");
int y2 = int.Parse(Console.ReadLine());
Console.WriteLine("Enter Z for dot#2");
int z2 = int.Parse(Console.ReadLine());


Console.WriteLine("Lenght of dot#1 - dot#2 vector is: " + VectorLenght(x1, y1, z1, x2, y2, z2));
