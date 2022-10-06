// Выяснить является ли число чётным
// Ввод числа; если %2 == 0, то "четное", иначе "не является"

Console.WriteLine("Enter number");
int number = int.Parse(Console.ReadLine() ?? "0");

if (number%2 == 0)
{
    Console.WriteLine("Тhe number is even");
}

else
{
    Console.WriteLine("Тhe number is not even");
}