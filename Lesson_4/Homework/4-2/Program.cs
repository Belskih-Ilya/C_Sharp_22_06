// написать программу, которая принимает на вход число и выдает сумму цифр в числе

int DigitsSum(int num)
{
    int result = 0;
    int numLength = num.ToString().Length;
    for (int i = 0; i < numLength; i++)
    {
        result += num % 10;
        num /= 10;
    }
    return result + num;
}


Console.WriteLine("Enter a number");
int num = int.Parse(Console.ReadLine());
Console.WriteLine($"Sum of {num} digits is {DigitsSum(num)}");
