// Программа, которая выведет все натуральные числа в промежутке от M до N.
void RoadToN(int n, int m)
{
if (n < m)
{
return;
}
RoadToN(n - 1, m);
System.Console.Write($"{n} ");
}

System.Console.WriteLine("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

RoadToN(n, m);