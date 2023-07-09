// задать массив из 12 элементов, заполненный случацными числами из промежутка [-9 , 9]. Найти сумму
// отрицательных и положительных элементов массива


int[] TwelveDigitArr ()
{
    int[] arr = new int[12];
    Console.Write($"12-digit length array (from -9 to 9) : [ ");
    Random rnd = new Random();
    for (int i = 0; i < 12; i++)
    {
        arr[i] = rnd.Next(-9, 10);
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine("]");
    return arr;
}

int PositivesSum(int[] arr)
{
    int result = 0;
    for (int i = 0; i <arr.Length; i++)
    {
        if (arr[i] > 0) result += arr[i];
    }
    return result;
}

int NegativesSum(int[] arr)
{
    int result = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < 0) result += arr[i];
    }
    return result;
}

int[] arr = TwelveDigitArr ();
Console.WriteLine($"Sum of positives from array: {PositivesSum(arr)}");
Console.WriteLine($"Sum of negatives from array: {NegativesSum(arr)}");
