// написать программу которая выводит третью цифру заданного числа или сообщает что третьей цифры нет

void ThirdDigit (int num)
{
    if (num < 100 && num > -100)
    {
        Console.WriteLine("Число меньше 100 по модулю, третья цифра отсутствует");
        return;
    }
    if (num > 0)
    {
        Console.WriteLine("Третья цифра в числе :" + num.ToString()[2]);
    } else
    {
        Console.WriteLine("Третья цифра в числе :" + num.ToString()[3]);
    }
}

Console.WriteLine("Введите положительное число");
int num = int.Parse(Console.ReadLine());
ThirdDigit (num);
