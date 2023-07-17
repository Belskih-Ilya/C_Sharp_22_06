// задать двумерный массив из целых чисел. Найти среднее арифметическое элементов в каждом столбце

int[,] NewArray(int rows, int columns, int min, int max)
{
    Random rnd = new Random();
    int[,] result = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            result[i, j] = rnd.Next(min, max + 1);
        }
    }
    return result;
}

void Array2dPrint(int[,] incomingArr)
{
    for (int i = 0; i < incomingArr.GetLength(0); i++)
    {
        for (int j = 0; j < incomingArr.GetLength(1); j++)
        {
            Console.Write($"{incomingArr[i, j]} ");
        }
        Console.WriteLine("");
    }
}

void AvgCol(int[,] arr)
{
    for (int i =0;  i < arr.GetLength(0); i++)
    {
        double avg = 0;
        Console.Write($"Average of {i + 1} column :");
        for (int j = 0;j < arr.GetLength(1); j++)
        {
            avg += arr[j,i];
        }
        avg /= arr.GetLength(0);
        Console.WriteLine(Math.Round(avg, 1).ToString() );
    }
}

Console.WriteLine("Enter array rows count");
int rows = int.Parse(Console.ReadLine());
Console.WriteLine("Enter array columns count");
int columns = int.Parse(Console.ReadLine());
Console.WriteLine("Enter array min member");
int arrMin = int.Parse(Console.ReadLine());
Console.WriteLine("Enter array max member");
int arrMax = int.Parse(Console.ReadLine());

int[,] arr = NewArray(rows, columns, arrMin, arrMax);
Array2dPrint(arr);
AvgCol(arr);