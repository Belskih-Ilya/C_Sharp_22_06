// задать одномерный массив из 123 случайных чисел. Найти количество элементов массива, значения которых лежат в отрезке [10, 99]

int[] ArrayOf123Nums(int min, int max)
{
    int[] arr = new int[123];
    Console.Write($"123-digit length array (from {min} to {max}) : [ ");
    Random rnd = new Random();
    for (int i = 0; i < 123; i++)
    {
        arr[i] = rnd.Next(min, max+1);
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine("]");
    return arr;
}

int CheckFrom10To99(int[] arr)
{
    int result = 0;
    for (int i = 0;i < arr.Length;i++)
    {
        if (arr[i] >= 10 && arr[i] <= 99) result++;
    }
    return result;
}

Console.WriteLine("Enter min array member");
int arrMin = int.Parse(Console.ReadLine());
Console.WriteLine("Enter max array member");
int arrMax = int.Parse(Console.ReadLine());

int[] arr = ArrayOf123Nums(arrMin, arrMax);
Console.WriteLine($"Array contains {CheckFrom10To99(arr)} nums from 10 to 99");