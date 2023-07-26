// задать значения M и N. Написать программу которая дает сумму натуральных элементов в промежутке от M до N с помощью рекурсии.

int SumFromMToN(int m, int n)
{
    if (m == n) return m;
    return m + SumFromMToN(m+1, n);
}


Console.WriteLine("Enter a min number");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Enter a max number");
int n = int.Parse(Console.ReadLine());
Console.WriteLine($"Sum of numbers from {m} to {n} = {SumFromMToN(m,n)}");