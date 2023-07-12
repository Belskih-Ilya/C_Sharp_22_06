// пользователь вводит с клавиатуры М чисел. Посчитайте сколько чисел больше 0 ввел пользователь

Console.WriteLine("Choose amount of incoming numbers you want to enter");
int amount = int.Parse(Console.ReadLine());
int count = 0;

int[] ints = new int[amount];

for (int i = 0; i < amount; i++)
{
    Console.WriteLine($"Enter number #{i+1}:");
    ints[i] = int.Parse(Console.ReadLine());
    if (ints[i] > 0) count++;
}

Console.WriteLine($"You entered {count} positive numbers");
