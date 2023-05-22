// Сумма чисел от 1 до А

int Sum(int number)
{
    int sum = 0;
    for (int i = 1; i <= number; i++)
    {
        sum += i;
    }
    return sum;
}
System.Console.WriteLine("Введтите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int sum = Sum(num);
System.Console.WriteLine($"Сумма чисел от 1 до {num} = {sum}");