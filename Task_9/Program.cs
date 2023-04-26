// Является ли одно число квадратом второго
Console.Write("Введите первое число: ");
int numberOne = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int numberTwo = Convert.ToInt32(Console.ReadLine());

if (numberOne == Math.Pow(numberTwo, 2) || numberTwo == Math.Pow(numberOne, 2))
{
    Console.Write("Да");
}
else
{
    Console.Write("Нет");
}

