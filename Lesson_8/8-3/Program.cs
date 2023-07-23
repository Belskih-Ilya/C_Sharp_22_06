// составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том,
// сколько раз встречается элемент входных данных

int[,] NewArray(int rows, int columns, int max)
{
    Random rnd = new Random();
    int[,] result = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            result[i, j] = rnd.Next(0, max + 1);
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

void ElementsCouter (int[,] incomingArr, int max)
{
    int[] elementsCounter = new int[max+1];
    for (int i = 0;i < incomingArr.GetLength(0);i++)
    {
        for (int j = 0;j < incomingArr.GetLength(1);j++)
        {
            elementsCounter[incomingArr[i,j]]++;
        }
    }
    for (int i = 0; i<elementsCounter.Length;i++)
    {
        if (elementsCounter[i] != 0) Console.WriteLine($"{i} is in array {elementsCounter[i]} times");
    }
}


Console.WriteLine("Enter array rows count");
int rows = int.Parse(Console.ReadLine());
Console.WriteLine("Enter array columns count");
int columns = int.Parse(Console.ReadLine());
Console.WriteLine("Enter array max member");
int arrMax = int.Parse(Console.ReadLine());

int[,] arr = NewArray(rows, columns, arrMax);
Console.WriteLine("");
Array2dPrint(arr);
Console.WriteLine("");
ElementsCouter(arr, arrMax);