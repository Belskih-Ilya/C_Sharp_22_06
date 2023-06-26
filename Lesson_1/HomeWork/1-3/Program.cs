// написать программу, которая на вход принимает число и выдает, является ли оно четным

Console.WriteLine("Введите число");

int a = int.Parse(Console.ReadLine());

if (a%2 == 0) {
    Console.WriteLine("Введенное число является четным");
} else {
    Console.WriteLine("Введенное число является нечетным");
}