// написать программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом

void PalindromeCheck (int num)
{
    if (num.ToString().Length == 5)
    {
        if (num.ToString()[0] == num.ToString()[4] & num.ToString()[1] == num.ToString()[3])
        {
            Console.WriteLine($"{num} is a palindrome");
            return;
        }
        Console.WriteLine($"{num} is not a palindrome");
        return;
    }
    Console.WriteLine("Entered number is not 5-digit positive number");
}

Console.WriteLine("Enter a 5-digit positive number");
int num = int.Parse(Console.ReadLine());
PalindromeCheck(num);
