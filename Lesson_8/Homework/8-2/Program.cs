// задать прямоугольный двумерный массив. Написать программу, которая будет находить строку с наимешьшей суммой элементов

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

int[] RowSums(int[,] incomingArr)
{
    int[] result = new int[incomingArr.GetLength(0)];
    for (int i = 0;i < incomingArr.GetLength(0); i++) { 
        int sum = 0;
        for (int j = 0;j < incomingArr.GetLength(1);j++)
        {
            sum += incomingArr[i,j];
        }
        result[i] = sum;
    }
    return result;
}

void MaxSum(int[] incomingArr)
{
    int min = incomingArr[0];
    int minRow = 0;
    for (int i = 0;  i < incomingArr.Length; i++) {
        if (incomingArr[i] < min) {
            min = incomingArr[i];
            minRow = i+1;
        }
    }
    Console.WriteLine($"Min sum = {min} is in {minRow} row");
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
Console.WriteLine("");
Array2dPrint(arr);
Console.WriteLine("");
MaxSum(RowSums(arr));