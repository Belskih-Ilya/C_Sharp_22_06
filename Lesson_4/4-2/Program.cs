// написать программу, которая принимает на вход число и выдает количество цифр в числе

int DigitsCounter(double num)
{
    int result = 1;
    while (num/10 > 1)
    {
        num /= 10;
        result++;
    }
    return result;
}


Console.WriteLine("Enter a number");
int num = int.Parse(Console.ReadLine());
Console.WriteLine($"Number {num} contains {DigitsCounter(num)} digits");