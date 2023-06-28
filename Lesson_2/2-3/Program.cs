// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

string AAA(int a) {
    if (a % 7 == 0 && a % 23 == 0) return "Число кратно одновременно 7 и 23";
    else return "Число не кратно одновременно 7 и 23";
}

int num = new Random().Next(100, 1000);

Console.WriteLine($"Рандомное число = {num}");
Console.WriteLine(AAA(num));

