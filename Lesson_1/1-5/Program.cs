//написать программу, которая на вход принимает одно число, а на выходе показывает все целые числа в промежутке от -N до N

Console.WriteLine("Введите число");

int num = int.Parse(Console.ReadLine());

if (num < 0) {
    num = -1 * num;
}

int i = -1*num;

while (i <= num) {
    Console.WriteLine("" + i);
    i += 1;
}
