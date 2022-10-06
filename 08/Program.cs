// Показать вторую цифру трёхзначного числа
// 7 задание + разделить число на 10

Console.WriteLine("Enter three digit number: ");
int number = int.Parse(Console.ReadLine() ?? "0");

if (number>=100 && number<1000)
{
    int num1 = number / 10;
    int num2 = num1 % 10;
    Console.WriteLine("The second figure of three-digit number is: " +num2);
}

else
{
    Console.WriteLine("The number is not three-digit");
}
