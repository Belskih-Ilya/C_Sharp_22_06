// задать массив вещественных чисел. Найти разницу между максимальным и минимальным элементом массива

double[] RandomNumsArr()
{
    Random rnd = new Random();
    double[] arr = new double[rnd.Next(1, 21)];
    Console.Write($"{arr.Length}-nums length array of random nums : [ ");
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.NextDouble()*(100+100)-100;
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine("]");
    return arr;
}

double MinMaxDifference(double[] arr)
{
    double min = arr[0];
    double max = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] > max) max = arr[i];
        if (arr[i] < min) min = arr[i];
    }
    Console.WriteLine($"Min array member: {min}, max array member: {max}");
    return max-min;
}

double[] arr = RandomNumsArr();
Console.WriteLine($"Difference between max & min: {MinMaxDifference(arr)}");