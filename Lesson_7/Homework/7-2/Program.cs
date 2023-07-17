// написать программу, которая на вход принимает позицию элемента в двумерном массиве и возвращает
// значение этого элемента или же указание, что такого элемента нет

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

int ElementSearch(int[,] arr, int row, int col)
{
    return arr[row-1, col-1];
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

Console.WriteLine("Enter searching element's row");
int rowSearch = int.Parse(Console.ReadLine());
Console.WriteLine("Enter searching element's column");
int colSearch = int.Parse(Console.ReadLine());

if (rowSearch > 0 && rowSearch <= rows && colSearch > 0 && colSearch <= columns) Console.WriteLine($"[{rowSearch}, {colSearch}] element: {ElementSearch(arr, rowSearch, colSearch)}");
else Console.WriteLine("There is no element in array with entered position!");
