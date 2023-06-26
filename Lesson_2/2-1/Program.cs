int sc_num = new Random().Next(10, 100);

Console.WriteLine(sc_num);

int a = sc_num/10;
int b = sc_num%10;

if (a>b) 
{
    Console.WriteLine("цифра " + a + " наибольшая в числе");
} else if (b>a) 
{
    Console.WriteLine("цифра " + b + " наибольшая в числе");
} else 
{
    Console.WriteLine("цифры в числе одинаковы (" + a + ")");
}
