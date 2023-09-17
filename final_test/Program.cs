// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.


using System.Runtime.Serialization.Formatters;

String[] StringsArr()
{
    Random rnd = new Random();
    String[] arr = new String[rnd.Next(1, 10)];
    Console.WriteLine($"Array contains {arr.Length} string elements");
    Console.WriteLine("");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine($"Please enter array member #{i+1}");
        arr[i] = Console.ReadLine();
    }
    Console.WriteLine();
    return arr;
}

void ArrayPrint(String[] incomingArr)
{
    for (int i = 0; i < incomingArr.Length; i++)
    {
            Console.Write($"{incomingArr[i]} ");
    }
    Console.WriteLine("");
}

String[] Under3CharsArr(String[] incomingArr)
{
    int n = 0;
    for (int i = 0;i < incomingArr.Length;i++)
    {
        if (incomingArr[i].Length < 4) n += 1;
    }
    String[] resultArr = new String[n];
    n = 0;
    for (int i = 0; i < incomingArr.Length; i++)
    {
        if (incomingArr[i].Length < 4)
        {
            resultArr[n] = incomingArr[i];
            n++;
        }
    }
    return resultArr;
}

String[] arr = StringsArr();
Console.WriteLine("Source array of strings:");
ArrayPrint(arr);
Console.WriteLine();
Console.WriteLine("Array of under 3 chars strings:");
ArrayPrint(Under3CharsArr(arr));