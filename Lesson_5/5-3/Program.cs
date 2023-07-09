// задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве

int[] ArrayInitAndPrint(int length, int min, int max)
{
    int[] arr = new int[length];
    Console.Write($"{length}-digit length array (from {min} to {max}) : [ ");
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine("]");
    return arr;
}

bool NumCheck(int[] arr, int check)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == check) return true;
    }
    return false;
}

Console.WriteLine("Enter a new array length");
int arrLength = int.Parse(Console.ReadLine());
Console.WriteLine("Enter min array member");
int arrMin = int.Parse(Console.ReadLine());
Console.WriteLine("Enter max array member");
int arrMax = int.Parse(Console.ReadLine());

int[] arr = ArrayInitAndPrint(arrLength, arrMin, arrMax);

Console.WriteLine("Enter a number to check");
int check = int.Parse(Console.ReadLine());

if (NumCheck(arr, check)) Console.WriteLine($"Array contains number {check}");
else Console.WriteLine($"Array doesn't contains number {check}");