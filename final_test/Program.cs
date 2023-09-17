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
    Console.WriteLine("Result string array: ");
    for (int i = 0; i < incomingArr.Length; i++)
    {
            Console.Write($"{incomingArr[i]} ");
    }
    Console.WriteLine("");
}

ArrayPrint(StringsArr());