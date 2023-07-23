// задать двумерный массив. Написать программу, которая упорядочит по убыванию элементы каждой строки массива

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

int[,] RowsRegulator(int[,] incomingArr)
{
    // построчная шейкерная сортировка
    for (int i = 0;i < incomingArr.GetLength(0); i++)
    {
        int left = 0;
        int right = incomingArr.GetLength(1)-1;
        while (left < right)
        {
            for (int j = right; j > left; --j)
            {
                if (incomingArr[i, j-1] < incomingArr[i, j])
                {
                    int a = incomingArr[i, j-1];
                    incomingArr[i, j-1] = incomingArr[i, j];
                    incomingArr[i, j] = a;
                }
            }
        ++left;
        for (int j = left; j < right; ++j)
        {
            if (incomingArr[i,j] < incomingArr[i,j+1]) {
                int a = incomingArr[i, j];
                incomingArr[i, j] = incomingArr[i, j+1];
                incomingArr[i, j+1] = a;
            }
        }
            --right;
        }
    }
    return incomingArr;
}

Console.WriteLine("Enter array rows count");
int rows = int.Parse(Console.ReadLine());
Console.WriteLine("Enter array columns count");
int columns = int.Parse(Console.ReadLine());
Console.WriteLine("Enter array min member");
int arrMin = int.Parse(Console.ReadLine());
Console.WriteLine("Enter array max member");
int arrMax = int.Parse(Console.ReadLine());

int[,] arr = NewArray(rows, columns,arrMin, arrMax);
Console.WriteLine("");
Array2dPrint(arr);
Console.WriteLine("");
Array2dPrint(RowsRegulator(arr));