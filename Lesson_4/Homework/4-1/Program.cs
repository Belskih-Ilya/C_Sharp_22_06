// написать цикл, который принимает на вход два числа (А и В) и возводит число А в натуральную степень В.

double Pow(int a, int b)
{
    if (a == 0) return 0;
    if (b == 0) return 1;

    double result = 1;
    if (b > 0)
    {
        for (int i = 0; i < b; i++)
        {
            result *= a;
        }
    } else
    {
        for (int i = 0; i > b; i--)
        {
            result /= a;
        }
    }
    return result;
}


Console.WriteLine("Enter a number");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Enter a pow to number");
int b = int.Parse(Console.ReadLine());
Console.WriteLine($"{a} in pow of {b} is {Pow(a,b)}");

