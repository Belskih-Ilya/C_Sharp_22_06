// Задать массив, заполненный случайными положительными трехзначными числами. Написать программу,
// которая покажет количество четных чисел в массиве

int[] ThreeDigitNumsArr()
{
    Random rnd = new Random();
    int[] arr = new int[rnd.Next(1, 21)];
    Console.Write($"{arr.Length}-nums length array (from 100 to 999) : [ ");
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(100, 999);
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine("]");
    return arr;
}

int EvensCheck(int[] arr)
{
    int result = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i]%2 == 0) result++;
    }
    return result;
}

int[] arr = ThreeDigitNumsArr();
Console.WriteLine($"Array contains {EvensCheck(arr)} even 3-digit nums");