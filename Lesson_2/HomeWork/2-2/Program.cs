// написать программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа

int SecDigitDel (int num)
{
    int first = num / 100;
    int third = num % 10;
    return first*10 + third;
}


int num = new Random().Next(100, 1000);
Console.WriteLine("Случайное трехзначное число: " + num);
Console.WriteLine("Число без второй цифры: " + SecDigitDel(num));


