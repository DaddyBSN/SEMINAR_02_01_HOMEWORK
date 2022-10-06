// Найти третью цифру числа или сообщить, что её нет
// Ввод числа, проверка на 3 знака+, проверка на разрядность, если 4+, то /10, потом %10; вывод

Console.WriteLine("Enter number: ");
int num = int.Parse(Console.ReadLine() ?? "0");

if (num < 0)
{
    num = -num;
}

if (num > 100)
{
    while (num >= 1000)
    {
        num = num / 10;
    }
    int res = num % 10;
    Console.WriteLine("Thrid digit is: " + res );
}
else
{
    Console.WriteLine($"There is no third digit in the number {num}");
}