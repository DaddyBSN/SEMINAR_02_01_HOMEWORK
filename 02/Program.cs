// По заданному номеру дня недели вывести его название
// 1=monday, 2=Tuesday... если другой ввод, то "Это не день недели"

Console.WriteLine ("Enter number of the day of the week");
int day = int.Parse(Console.ReadLine() ?? "0");

if (day > 7 || day < 1)
{
    Console.WriteLine("This is not a number of the day of the week");
}

if (day == 1)
{
    Console.WriteLine("Monday");
}

if (day == 2)
{
    Console.WriteLine("Tuesday");
}

if (day == 3)
{
    Console.WriteLine("Wednesday");
}

if (day == 4)
{
    Console.WriteLine("Thursday");
}

if (day == 5)
{
    Console.WriteLine("Friday");
}

if (day == 6)
{
    Console.WriteLine("Saturday");
}

if (day == 7)
{
    Console.WriteLine("Sunday");
}
