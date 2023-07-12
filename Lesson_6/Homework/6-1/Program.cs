// напишите программу, которая будет создавать копию заданного двумерного массива с помощью поэлементного копирования

int[,] NewArray (int rows, int columns, int min, int max)
{
    Random rnd = new Random ();
    int[,] result = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            result[i, j] = rnd.Next (min, max+1);
        }
    }
    return result;
}

int[,] Array2dCopy (int[,] incomingArr)
{
    int[,] result = new int[incomingArr.GetLength(0), incomingArr.GetLength(1)];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i, j] = incomingArr[i, j];
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
            Console.Write($"{ incomingArr[i, j]} ");
        }
        Console.WriteLine("");
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
// задавать двумерный массив долго и бессмысленно, создадим случайный заданного размера
int[,] arr = NewArray (rows, columns, arrMin, arrMax);
Console.WriteLine($"New array with {rows} rows & {columns} columns:");
Array2dPrint (arr);
int[,] copiedArr = Array2dCopy (arr);
Console.WriteLine($"Copied array:");
Array2dPrint(copiedArr);