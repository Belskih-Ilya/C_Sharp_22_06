// написать программу, которая принимает на вход число (А) и выдает сумму чисел от 1 до А

int SumUpToNum (int num)
{
    int result = 0;
    for (int i = 1; i <= num; i++)
    {
        result += i;
    }
    return result;
}


Console.WriteLine("Enter a number");
int num = int.Parse(Console.ReadLine());
Console.WriteLine($"Sum of num's from 0 to {num} = {SumUpToNum(num)}");