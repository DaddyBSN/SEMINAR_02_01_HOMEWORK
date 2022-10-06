// По двум заданным числам проверять является ли первое квадратом второго
// a=20, b=25 -> no
// a=25, b=5 -> yes

Console.WriteLine("Enter number a: ");
int a = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine("Enter number b: ");
int b = int.Parse(Console.ReadLine() ?? "0");

if (b * b == a)
{
    Console.WriteLine("Yes, first nuber is second power of second number");
}

else
{
    Console.WriteLine("No, first nuber is not second power of second number");
}