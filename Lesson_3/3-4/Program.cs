// написать программу, которая принимает на вход число N и выдает таблицу квадратов чисел от 1 до N


void PowstoNum (int num)
{
    Console.WriteLine("Table of pow's up to " + num + ":");
    for (int i = 1; i <= num; i++)
    {
        Console.Write(Math.Pow(i, 2) + " ");
    }
    Console.WriteLine ("");
}

Console.WriteLine("Enter a number");
int num = int.Parse(Console.ReadLine());
PowstoNum(num);
