// написать программу, которая принимает на вход число N и выдает таблицу кубов чисел от 1 до N

void Pows3toNum(int num)
{
    Console.WriteLine("Table of pow's_3 up to " + num + ":");
    for (int i = 1; i <= num; i++)
    {
        Console.Write(Math.Pow(i, 3) + " ");
    }
    Console.WriteLine("");
}

Console.WriteLine("Enter a number");
int num = int.Parse(Console.ReadLine());
Pows3toNum(num);
