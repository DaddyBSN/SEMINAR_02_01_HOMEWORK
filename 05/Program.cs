// Показать числа от -N до N
// Ввести число; x = N*-1; если x<N вывод, ++

Console.WriteLine("Enter N");
int N = int.Parse(Console.ReadLine() ?? "0");
int N1 = (N)*(-1);

while (N1<=N)
{
    int x = N1++;
    Console.WriteLine(x);
}
