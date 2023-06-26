// написать программу, которая на вход принимает число N, а на выходе показывает все четные числа от 1 до N

Console.WriteLine("Введите положительное число");

int a = int.Parse(Console.ReadLine());

if (a%2 > 0) {
    a--;
}

int i = 2;

Console.WriteLine("Четные числа от 0 до " + a + ":");

while (i <= a) {
    Console.WriteLine(i);
    i+=2;
}
