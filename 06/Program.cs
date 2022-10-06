// Показать четные числа от 1 до N
// Ввод; пока меньше Н если %2 ==0 то вывод

Console.WriteLine("Enter number");
int N = int.Parse(Console.ReadLine() ?? "0");
int N1 = 1;

while (N1<N)
{
    if (N1%2 ==0)
    {
        Console.WriteLine(N1);
    }

    N1++;
}