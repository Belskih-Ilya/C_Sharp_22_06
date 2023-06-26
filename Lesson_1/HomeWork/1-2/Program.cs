//написать программу, которая на вход принимает три числа и выдает максимальное из них

Console.WriteLine("Введите первое число");

int max = int.Parse(Console.ReadLine());

Console.WriteLine("Введите второе число");

int a = int.Parse(Console.ReadLine());

if (a > max) {
    max = a;
}

Console.WriteLine("Введите третье число");

int b = int.Parse(Console.ReadLine());

if (b > max) {
    max = b;
}

Console.WriteLine("Максимальное введенное число: " + max);

