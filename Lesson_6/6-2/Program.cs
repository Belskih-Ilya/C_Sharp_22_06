// написать программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник со сторонами такой длины


bool TrianglePossibikityCheck (int firstSide, int secondSide, int thirdSide)
{
    if (firstSide + secondSide > thirdSide && firstSide + thirdSide > secondSide && secondSide + thirdSide > firstSide) return true;
    return false;
}   

Console.WriteLine("Enter first triangle side length");
int firstTrnglSide = int.Parse(Console.ReadLine());
Console.WriteLine("Enter second triangle side length");
int secTrnglSide = int.Parse(Console.ReadLine());
Console.WriteLine("Enter third triangle side length");
int thirdTrnglSide = int.Parse(Console.ReadLine());

if (TrianglePossibikityCheck(firstTrnglSide, secTrnglSide, thirdTrnglSide)) Console.WriteLine("Triangle with entered sides exists");
else Console.WriteLine("Triangle with entered sides not exists");