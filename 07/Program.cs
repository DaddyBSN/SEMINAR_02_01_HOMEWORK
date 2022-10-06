//Показать последнюю цифру трёхзначного числа
//Ввод; если /100>=10 или <1 вывод "не трехзначное"; иначе число %10 = цифра

Console.WriteLine("Enter three digit number: ");
int number = int.Parse(Console.ReadLine() ?? "0");

if (number>=100 && number<1000)
{
    Console.WriteLine("The last figure of three-digit number is: " +number%10);
}

else
{
    Console.WriteLine("The number is not three-digit");
}