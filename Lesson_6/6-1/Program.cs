// написать программу, которая перевернет одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.

int[] ArrayFillAndPrint(int length, int min, int max)
{
    int[] arr = new int[length];
    Console.Write($"Random array (from {min} to {max}) : [ ");
    Random rnd = new Random();
    for (int i = 0; i < length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
        Console.Write($"{arr[i]} ");
    }
    Console.Write("]");
    return arr;
}

int[] ArrayTurnAndPrint(int[] arr)
{
    int[] result = new int[arr.Length];
    for (int i = 0;i < arr.Length; i++)
    {
        int resultPos = result.Length - 1 - i;
        result[resultPos] = arr[i];
    }
    Console.Write($"Turned array: [ ");
    for (int i = 0; i < result.Length; i++)
    {
        Console.Write($"{result[i]} ");
    }
    Console.Write("]");
    return result;
}

Console.WriteLine("Enter a new array length");
int arrLength = int.Parse(Console.ReadLine());
Console.WriteLine("Enter min array member");
int arrMin = int.Parse(Console.ReadLine());
Console.WriteLine("Enter max array member");
int arrMax = int.Parse(Console.ReadLine());

if (arrLength <= 0) { 
    Console.WriteLine("Incorrect array length!");
    return;
}

int[] arr = ArrayFillAndPrint(arrLength, arrMin, arrMax);

Console.WriteLine("");
int[] turnedArr = ArrayTurnAndPrint(arr);



