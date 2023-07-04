// написать программу, которая задает массив из 8 элементов случайными числами и выводит их на экран


void ArrayFillAndPrint (int length, int min, int max)
{
    if (length <= 0)
    {
        Console.WriteLine("Incorrect array length!");
        return;
    }

    int[] arr = new int[length];
    Console.Write($"Random array (from {min} to {max}) : [ ");
    Random rnd = new Random();
    for (int i = 0; i < length; i++)
    {
        arr[i] = rnd.Next(min, max+1);
        Console.Write($"{arr[i]} ");
    }
    Console.Write("]");
}


Console.WriteLine("Enter a new array length");
int arrLength = int.Parse(Console.ReadLine());
Console.WriteLine("Enter min array member");
int arrMin = int.Parse(Console.ReadLine());
Console.WriteLine("Enter max array member");
int arrMax = int.Parse(Console.ReadLine());

ArrayFillAndPrint(arrLength, arrMin, arrMax);



