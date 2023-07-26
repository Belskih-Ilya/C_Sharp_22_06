// задать значения M и N. Написать программу, которая выведет все четные натуральные числа в промежутке от M до N с помощью рекурсии

string PrintMUpToN(int m, int n)
{
    if (m % 2 != 0) m++;
    if (m == n || (m-n) == -1) return $"{m}";
    return $"{m}, {PrintMUpToN((m + 2), n)}";
}


Console.WriteLine("Enter a min number");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Enter a max number");
int n = int.Parse(Console.ReadLine());
Console.WriteLine(PrintMUpToN(m, n));