// задайте две матрицы. Нпишите программу, которая будет находить произведение двух матриц

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

int[,] ArrMultiple(int[,] incomingArr1, int[,] incomingArr2)
{
    int[,] result = new int[incomingArr1.GetLength(0), incomingArr2.GetLength(1)];
    for (int i = 0; i < incomingArr1.GetLength(0);  i++)
    {
        for (int j = 0;j < incomingArr2.GetLength(1); j++)
        {
            for (int k = 0; k < incomingArr2.GetLength(0); k++)
            {
                result[i, j] += incomingArr1[i, k] * incomingArr2[k, j];
            }
        }
    }
    return result;
}


Console.WriteLine("Enter 1st array rows count");
int rows1 = int.Parse(Console.ReadLine());
Console.WriteLine("Enter 1st array columns count");
int columns1 = int.Parse(Console.ReadLine());
Console.WriteLine("Enter 1st array min member");
int arrMin1 = int.Parse(Console.ReadLine());
Console.WriteLine("Enter 1st array max member");
int arrMax1 = int.Parse(Console.ReadLine());

int[,] arr = NewArray(rows1, columns1, arrMin1, arrMax1);
Console.WriteLine("");
Array2dPrint(arr);
Console.WriteLine("");

Console.WriteLine("Enter 2d array rows count");
int rows2 = int.Parse(Console.ReadLine());
Console.WriteLine("Enter 2d array columns count");
int columns2 = int.Parse(Console.ReadLine());
Console.WriteLine("Enter 2d array min member");
int arrMin2 = int.Parse(Console.ReadLine());
Console.WriteLine("Enter 2d array max member");
int arrMax2 = int.Parse(Console.ReadLine());

int[,] arr2 = NewArray(rows2, columns2, arrMin2, arrMax2);
Console.WriteLine("");
Array2dPrint(arr2);
Console.WriteLine("");
Console.WriteLine("Multiplied matrix: ");
Console.WriteLine("");
Array2dPrint(ArrMultiple(arr, arr2));