//Возведение в квадрат чисел от 1 до N

Console.WriteLine("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= N; i++)
{
    System.Console.WriteLine(Math.Pow(i, 2));
}

/*Console.WriteLine("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int count = 1;
while (count <= N)
{
    System.Console.WriteLine(count * count);
    count++;
}
*/