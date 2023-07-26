// задать значения M и N. Написать программу, которая рекурсивно выведет все натуральные числа в промежутке от M до N.

string PrintMUpToN(int m, int n)
{
    if (m == n) return $"{m}";
    return $"{m}, {PrintMUpToN((m + 1), n)}";
}


Console.WriteLine("Enter a min number");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Enter a max number");
int n = int.Parse(Console.ReadLine());
Console.WriteLine(PrintMUpToN(m, n));
