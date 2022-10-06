// Найти максимальное из трех чисел
// ввести 3 числа; мах = первое число; сравнение - если больше, то мах =; следующее число.

Console.WriteLine("Enter first number");
int first = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Enter second number");
int second = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Enter thrid number");
int thrid = int.Parse(Console.ReadLine() ?? "0");

int max = first;

if (first>max) max=first;
if (second>max) max=second;

Console.WriteLine("The biggest number is " + max);