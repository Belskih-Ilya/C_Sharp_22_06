// найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.
// Результат записать в новый массив

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

int[] MultiplyArr(int[] arr)
{
    int[] result = new int[arr.Length/2];
    for (int i = 0; i < arr.Length/2; i++)
    {
        result[i] = arr[i]*arr[arr.Length-1-i];
    }
    return result;
}

void ArrPrint(int[] arr)
{
    Console.Write("[ ");
    for (int i = 0; i < arr.Length; i++)
    {
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

int[] arr = ArrayInitAndPrint(arrLength, arrMin, arrMax);
Console.Write("New array with multiplied opposites: ");
ArrPrint(MultiplyArr(arr));