// Не используя рекурсию, вывести первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1


void Fibonacci (int n)
{
    int a = 0;
    int b = 1;
    int c = a + b;
    if (n == 1)
    {
        Console.WriteLine(a);
        return;
    }
    if (n == 2)
    {
        Console.WriteLine($"{a} {b}");
        return;
    }

    Console.Write($"{a} {b} ");

    for (int i = 0; i < n-2; i++)
    {
        Console.Write($"{c} ");
        int temp = c;
        c = c + b;
        a = b;
        b = temp;
    }
    Console.WriteLine("");
}

void FibonacciClasswork (int n)
{
    int temp = 0;
    int temp2 = 1;

    for (int i = 0;i < n; i++)
    {
        Console.Write($"{temp} ");
        (temp, temp2) = (temp2, temp + temp2);
    }
}


Console.WriteLine("Enter position of fibonacci's number");
int n = int.Parse(Console.ReadLine());
Console.WriteLine($"Fibonacci for {n} members: ");
Fibonacci(n);
//FibonacciClasswork(n);
