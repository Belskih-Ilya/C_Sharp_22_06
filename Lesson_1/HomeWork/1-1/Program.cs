﻿//напишите программу, которая на вход принимает два числа и выдает какое число меньгее а какое большее


Console.WriteLine("Введите первое число");

int num1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите второе число");

int num2 = int.Parse(Console.ReadLine());

if (num1 == num2) {
    Console.WriteLine("Введенные числа равны");
} else if (num1 > num2) {
    Console.WriteLine("Первое число больше второго");
} else {
    Console.WriteLine("Второе число больше первого");
}
