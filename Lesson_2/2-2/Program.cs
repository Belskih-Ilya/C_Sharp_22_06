// Напишите программу, которая будет принимать на вход два числа и выводить,
// является ли второе число кратным первому. Если число 2 не кратно числу 1, то
// программа выводит остаток от деление.

void AAA(int a, int b) {
    if (b % a == 0) Console.WriteLine("второе число кратно первому");
    else Console.WriteLine("второе число не кратно первому, остаток от деления равен " + b % a);
}

int first_num = new Random().Next(1, 10);
int second_num = new Random().Next(1, 100);

Console.WriteLine($"Первое число равно {first_num}, второе число равно {second_num}");
AAA(first_num, second_num);