// задать одномерный массив, заполненный случайными числами. Найти сумму элементов, стоящих на нечетных позициях

int[] RandomNumsArr()
{
    Random rnd = new Random();
    int[] arr = new int[rnd.Next(1, 21)]; 
    /* количество и диапазон элементов ограничим, чтобы в результате не выдавалось неадекватно больших чисел*/
    Console.Write($"{arr.Length}-nums length array of random nums : [ ");
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(-100, 101);
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine("]");
    return arr;
}

int OddElmntsSum(int[] arr)
{
    int result = 0;
    for(int i = 0; i < arr.Length; i++)
    {
        if (i % 2 == 0) result += arr[i];
    }
    return result;
}

int[] arr = RandomNumsArr();
Console.WriteLine($"Sum of odd array elements: {OddElmntsSum(arr)}");