// задать двумерный массив размером mxn, заполненный случайными вещественными числами

double[,] NewArray(int rows, int columns)
{
    Random rnd = new Random();
    double[,] result = new double[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            result[i, j] = Math.Round(rnd.NextDouble(), 1);
        }
    }
    return result;
}

void Array2dPrint(double[,] incomingArr)
{
    for (int i = 0; i < incomingArr.GetLength(0); i++)
    {
        for (int j = 0; j < incomingArr.GetLength(1); j++)
        {
            Console.Write($" {incomingArr[i, j]} ");
            if (incomingArr[i, j] == 0 || incomingArr[i, j] == 1) {
                Console.Write("  ");
            }
            Console.Write("|");
        }
        Console.WriteLine("");
    }
}


Console.WriteLine("Enter array rows count");
int rows = int.Parse(Console.ReadLine());
Console.WriteLine("Enter array columns count");
int columns = int.Parse(Console.ReadLine());

double[,] arr = NewArray(rows, columns);
Console.WriteLine("Random double num's array: ");
Array2dPrint(arr);
