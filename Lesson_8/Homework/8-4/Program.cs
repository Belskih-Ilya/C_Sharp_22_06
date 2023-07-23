// задать двумерный массив целых чисел. Написать программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива

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

void WithoutMin (int[,] incomingArr)
{
    int min = incomingArr[0, 0];
    int row = 0; int col = 0;
    for (int i = 0; i < incomingArr.GetLength(0);i++)
    {
        for (int j = 0; j < incomingArr.GetLength(1); j++)
        {
            if (incomingArr[i, j] < min)
            {
                min = incomingArr[i, j];
                row = i;
                col = j;
            }
        }
    }

    for (int i = 0; i < incomingArr.GetLength(0); i++)
    {
        for (int j = 0; j < incomingArr.GetLength(1); j++)
        {
            if (i != row) 
            { 
                if (j != col) Console.Write($"{incomingArr[i, j]} "); 
            }
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

int[,] arr = NewArray(rows, columns, arrMin, arrMax);
Console.WriteLine("");
Array2dPrint(arr);
Console.WriteLine("");

WithoutMin(arr);