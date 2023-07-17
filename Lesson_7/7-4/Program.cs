// задать двумерный массив. Ввести элемент и найти первое его вхождение, вывести позицию. Либо вывести, что такого элемента нет

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

void ElementSearch(int[,] incomingArr, int element)
{
    for ( int i = 0;i < incomingArr.GetLength(0);i++)
    {
        for( int j = 0;j < incomingArr.GetLength(1); j++)
        {
            if (element == incomingArr[i,j])
            {
                Console.WriteLine($"First {element} num in position [{i+1}, {j+1}] of array");
                return;
            }
        }
    }
    Console.WriteLine($"There is no {element} num in the array =(");
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
Console.WriteLine("Original 2d array: ");
Array2dPrint(arr);

Console.WriteLine("Enter num to search");
int searchNum = int.Parse(Console.ReadLine());
ElementSearch(arr, searchNum);


