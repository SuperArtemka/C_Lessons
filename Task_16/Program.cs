// Произведение чисел от 1 до А

int Multi(int number)
{
    int mult = 1;
    for (int i = 1; i <= number; i++)
    {
        mult *= i;
    }
    return mult;
}
System.Console.WriteLine("Введтите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int mult = Multi(num);
System.Console.WriteLine($"Сумма чисел от 1 до {num} = {mult}");