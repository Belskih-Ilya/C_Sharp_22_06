// написать программу, которая принимает на вход число N и выдает произведение чисел от 1 до N

int MultiplyUpToNum(int num)
{
    int result = 1;
    for (int i = 2; i <= num; i++)
    {
        result *= i;
    }
    return result;
}


Console.WriteLine("Enter a number");
int num = int.Parse(Console.ReadLine());
Console.WriteLine($"Sum of num's from 1 to {num} = {MultiplyUpToNum(num)}");
