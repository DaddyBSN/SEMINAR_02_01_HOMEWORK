// Выяснить, кратно ли число заданному, если нет, вывести остаток.
// Ввод ч1; ввод ч2; ч2 % ч1 == 0 "кратно"; иначе ч2 % ч1 вывод

Console.WriteLine("Enter first number: ");
int num1 = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Enter second number: ");
int num2 = int.Parse(Console.ReadLine() ?? "0");

if (num1 % num2 == 0)
{
    Console.WriteLine("The first number is a multiple of second number");
}
else
{
    int surplus = num1 % num2;
    Console.WriteLine("The first number is not multiple of second number. Surplus is: " +surplus);
}
