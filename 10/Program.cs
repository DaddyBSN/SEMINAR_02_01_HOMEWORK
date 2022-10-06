// Удалить вторую цифру трёхзначного числа
// Ввод; проверка на 3х значное; ч1 = /100, ч2 = %10; ч = ч1*10+ч2; вывод

Console.WriteLine("Enter three-digit number");
int num = int.Parse(Console.ReadLine() ?? "0");

if (num / 100 < 1 || num / 100 >= 10)
{
    Console.WriteLine("The number is not three-digit");
}

else
{
    int dig1 = num / 100;
    int dig2 = num % 10;
    int dig = dig1 * 10 + dig2;
    Console.WriteLine("The number is: " + dig);
}