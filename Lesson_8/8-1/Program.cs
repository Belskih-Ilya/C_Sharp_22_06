// задать двумерный массив. Написать программу, которая поменяет местами первую и последнюю строку массива

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

int[,] SwitchArray(int[,] incomingArr)
{
    int[,] result = new int[incomingArr.GetLength(0), incomingArr.GetLength(1)];
    for (int i = 0;i < incomingArr.GetLength(0);i++) { 
        for (int j = 0;j < incomingArr.GetLength(1);j++)
        {
            if (i == 0)
            {
                result[incomingArr.GetLength(0)-1, j] = incomingArr[i,j];
            } else if (i == incomingArr.GetLength(0) - 1) {
                result[0, j] = incomingArr[i, j];
            } else result[i, j] = incomingArr[i, j];
        }
    }
    return result;
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
int[,] switchedArr = SwitchArray(arr);
Console.WriteLine("");
Array2dPrint(switchedArr);