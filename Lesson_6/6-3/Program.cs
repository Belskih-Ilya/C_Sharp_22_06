// написать программу, которая будет преобразовывать десятичное число в двоичное

int ToBinary (int num)
{
    string resultText = "";
    while (num >= 1)
    {
        resultText += num % 2;
        num /= 2;
    }
    char[] resultChar = resultText.ToCharArray();
    Array.Reverse(resultChar);
    return int.Parse(new string(resultChar));
}

Console.WriteLine("Enter a number to transfer");
int num = int.Parse(Console.ReadLine());

Console.WriteLine($"{num} in binary: {ToBinary(num)}");