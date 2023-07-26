// написать программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии

int Pow(int a, int b)
{
    if (b == 0) return 1;
    return a*(Pow(a, b-1));
}

Console.WriteLine("Enter A number");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Enter B number");
int b = int.Parse(Console.ReadLine());

Console.WriteLine($"{a} in pow of {b} = {Pow(a, b)}");