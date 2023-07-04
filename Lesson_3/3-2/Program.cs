// написать программу, которая по заданному номеру четверти показывает позможный диапазон координат точек в этой четверти (х и у)

void XYrange (int q)
{
    if (q == 1)
    {
        Console.WriteLine("X in 0+ range & Y in 0+ range");
        return;
    } else if (q == 2)
    {
        Console.WriteLine("X in 0- range & Y in 0+ range");
        return;
    } else if (q == 3)
    {
        Console.WriteLine("X in 0- range & Y in 0- range");
        return;
    } else if (q == 4)
    {
        Console.WriteLine("X in 0+ range & Y in 0- range");
        return;
    }
    Console.WriteLine("incorrect quarter nunber");
    return;
}




Console.WriteLine("Enter quarter number");
int num = int.Parse(Console.ReadLine());

XYrange (num);