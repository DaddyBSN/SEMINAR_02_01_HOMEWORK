// Дано число из отрезка [10, 99]. Показать наибольшую цифру числа
// Ввод числа (мин 10, макс 99); num1 = %10, num2 = /10; if num1>num2 print num1, else print num2

Console.WriteLine("enter a number from 10 to 99");
int num = int.Parse(Console.ReadLine() ?? "0");

if (num < 10 || num > 99)
{
    Console.WriteLine("This is not a number from 10 to 99");
}

else
{
    int num1 = num % 10;
    int num2 = num / 10;

    if (num1>num2)
    {
        Console.WriteLine("the largest digit of the number: " +num1);
    }

    else
    {
        Console.WriteLine("the largest digit of the number: " +num2);
    }
}