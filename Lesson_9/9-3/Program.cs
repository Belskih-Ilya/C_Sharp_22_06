// написать программу, которая будет принимать на вход число и возвращать его сумму цифр. Использовать рекурсию

int DigitsSum(int n)
{
    if (n % 10 == 0) return n;
    return (n%10) + DigitsSum(n/10);
}

Console.WriteLine("Enter a number");
int n = int.Parse(Console.ReadLine());
Console.WriteLine($"Numbers's {n} sum of digits = {DigitsSum(n)}");
