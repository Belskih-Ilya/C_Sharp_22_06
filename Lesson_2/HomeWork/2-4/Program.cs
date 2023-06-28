// написать программу, которая принимает на вход циру, обозначающую день недели, и проверяет, является ли этот день выходным

void WeekendCheck (int num)
{
    if (num == 6 || num == 7)
    {
        Console.WriteLine("День является выходным");
        return;
    }
    switch (num)
    {
        case 1:
            Console.WriteLine("Понедельник");
            return;
        case 2:
            Console.WriteLine("Вторник");
            return;
        case 3:
            Console.WriteLine("Среда");
            return;
        case 4:
            Console.WriteLine("Четверг");
            return;
        case 5:
            Console.WriteLine("Пятница");
            return;
    }
    Console.WriteLine("Введенное значение не соответствует дню недели");
}

Console.WriteLine("Введите номер дня недели");
int num = int.Parse(Console.ReadLine());
WeekendCheck(num);
