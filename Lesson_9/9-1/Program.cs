// задать значение N. Написать программу, которая выведет все натуральные числа в промежутке от 1 до N при помощи рекурсии.

string PrintUpToNReverse (int n)
{
    if (n == 1) return $"{n}";
    return $"{n}, {PrintUpToNReverse(n-1)}";
}

string PrintUpToN(int m,int n)
{
    if (m == n) return $"{m}";
    return $"{m}, {PrintUpToN((m + 1), n)}";
}


Console.WriteLine("Enter a number");
int n = int.Parse(Console.ReadLine());
Console.WriteLine(PrintUpToN (1, n));
Console.WriteLine(PrintUpToNReverse(n));