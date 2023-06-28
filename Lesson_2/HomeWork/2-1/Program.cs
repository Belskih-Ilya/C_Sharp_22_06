// написать программу, которая принимает на вход трехзначное число и на выходе показывает вторую цифру этого числа

int SecDigit (int num)
{
    return (num / 10) % 10;
}

Console.WriteLine("Введите трехзначное число");
int num = int.Parse(Console.ReadLine());
Console.WriteLine("Вторая цифра введенного трехначного числа: " + SecDigit(num));
