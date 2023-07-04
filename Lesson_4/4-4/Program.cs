// написать программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке

int[] arr = new int[8];
Console.Write("Random 0 & 1 array: [ ");
Random rnd = new Random();
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = rnd.Next(0,2);
    Console.Write($"{arr[i]} ");
}
Console.Write("]");
